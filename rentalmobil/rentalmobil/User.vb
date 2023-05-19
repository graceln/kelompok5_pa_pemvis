Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class User
    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub KeluarAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarAkunToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Sub kosong()
        txtNama.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        ComboBoxType.ResetText()
        ComboBoxType.Items.Clear()
        txtCari.Clear()
    End Sub

    Sub isi()
        txtNama.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        ComboBoxType.ResetText()
        ComboBoxType.Items.Clear()
        txtCari.Clear()
        txtNama.Focus()
    End Sub

    Sub TampilUser()
        DA = New MySqlDataAdapter("SELECT * FROM user", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "user")
        DataGridView1.DataSource = DS.Tables("user")
        DataGridView1.Refresh()
    End Sub
    Sub AturGrid()
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Username"
        DataGridView1.Columns(3).HeaderText = "Password"
        DataGridView1.Columns(4).HeaderText = "Type"
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilUser()
        Call kosong()
        Call AturGrid()
    End Sub

    Private Sub ComboBoxType_Click(sender As Object, e As EventArgs) Handles ComboBoxType.Click
        ComboBoxType.Items.Add("Admin")
        ComboBoxType.Items.Add("Staff")
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtNama.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or ComboBoxType.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtNama.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * FROM user WHERE nama='" & txtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "Insert Into user values (NULL,'" & txtNama.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & ComboBoxType.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Terjadi kesalahan")
                RD.Close()
            End If
            Call TampilUser()
            Call kosong()
            txtNama.Focus()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtNama.Text = .Cells(1).Value
            Me.txtUsername.Text = .Cells(2).Value
            Me.txtPassword.Text = .Cells(3).Value
            Me.ComboBoxType.Text = .Cells(4).Value
        End With
    End Sub


    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If txtNama.Text = "" Then
            MsgBox("Nama belum diisi")
            txtNama.Focus()
        Else
            Dim Ubah As String = "Update user set nama = '" & txtNama.Text & "', username = '" & txtUsername.Text & "', password = '" & txtPassword.Text & "', type = '" & ComboBoxType.Text & "' WHERE nama = '" & txtNama.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilUser()
            Call kosong()
            txtNama.Focus()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If txtNama.Text = "" Then
            MsgBox("Nama belum diisi")
            txtNama.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data user " & txtNama.Text & " ?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From user WHERE nama = '" & txtNama.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kosong()
                Call TampilUser()
            Else
                Call kosong()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call kosong()
        Call TampilUser()
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        txtNama.MaxLength = 25
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM user WHERE nama='" & txtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtUsername.Text = RD.Item(2)
                txtPassword.Text = RD.Item(3)
                ComboBoxType.Text = RD.Item(4)
                txtUsername.Focus()
            Else
                Call isi()
                txtUsername.Focus()
            End If
            RD.Close()
        End If
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM user WHERE nama LIKE '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * FROM user WHERE nama LIKE '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DS.Clear()
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak dapat ditemukan")
            End If
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ' Biarkan karakter masuk ke TextBox
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Biarkan karakter kontrol (misalnya tombol backspace) masuk ke TextBox
            e.Handled = False
        Else
            ' Blokir karakter selain huruf kecil dan karakter kontrol
            e.Handled = True
        End If
    End Sub
End Class