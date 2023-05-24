Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Pengembalian
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Me.Hide()
        User.Show()
    End Sub

    Sub kosong()
        TxtNama.Clear()
        TxtKTP.Clear()
        TxtNope.Clear()
        ComboBoxJK.ResetText()
        txtCari.Clear()
        TxtKTP.Focus()
    End Sub
    Sub isi()
        TxtNama.Clear()
        TxtKTP.Clear()
        TxtNama.Clear()
        ComboBoxJK.ResetText()
        TxtNope.Clear()
        txtCari.Clear()
        TxtKTP.Focus()
    End Sub

    Sub AturGrid()
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(0).HeaderText = "No. KTP"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Jenis Kelamin"
        DataGridView1.Columns(3).HeaderText = "No. HP"
    End Sub

    Public Sub TampilPengembalian()

        DA = New MySqlDataAdapter("SELECT * FROM data_peminjam", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data_peminjam")
        DataGridView1.DataSource = DS.Tables("data_peminjam")
        DataGridView1.Refresh()

    End Sub
    Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim ktp As Integer
        Dim nama, jk, nope As String


        ktp = TxtKTP.Text
        nama = TxtNama.Text
        jk = ComboBoxJK.Text
        nope = TxtNope.Text


        If TxtNama.Text = "" Or TxtKTP.Text = "" Or TxtNope.Text = "" Or ComboBoxJK.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TxtKTP.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * FROM data_peminjam WHERE no_ktp='" & TxtKTP.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim query As String = "INSERT INTO data_peminjam VALUES (@TextData1, @TextData2, @TextData3, @TextData4, @TextData5, @ImageData)"
                Using MCD = New MySqlCommand(query, CONN)
                    MCD.Parameters.AddWithValue("@TextData1", ktp)
                    MCD.Parameters.AddWithValue("@TextData2", nama)
                    MCD.Parameters.AddWithValue("@TextData3", jk)
                    MCD.Parameters.AddWithValue("@TextData4", nope)
                    MCD.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
                End Using
            Else
                MsgBox("Terjadi kesalahan")
                RD.Close()
            End If
            Call TampilPengembalian()
            Call AturGrid()
            Call kosong()
            TxtNama.Focus()
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        TxtNama.MaxLength = 25
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM data_peminjam WHERE nama_p='" & TxtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                TxtKTP.Text = RD.Item(0)
                ComboBoxJK.Text = RD.Item(2)
                TxtNope.Text = RD.Item(3)
                TxtNama.Focus()
            Else
                Call isi()
                TxtNama.Focus()
            End If
            RD.Close()
            Me.SelectNextControl(ActiveControl, True, True, True, True) ' Berpindah ke kontrol inputan selanjutnya
        End If
    End Sub

    Private Sub TxtKTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKTP.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Membatalkan karakter yang bukan angka
        End If
    End Sub

    Private Sub TxtNope_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNope.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(ActiveControl, True, True, True, True) ' Berpindah ke kontrol inputan selanjutnya
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM data_peminjam WHERE nama_p LIKE '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * FROM data_peminjam WHERE nama_p LIKE '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DS.Clear()
                DA.Fill(DS, "Ditemukan")
                DataGridView1.DataSource = DS.Tables("Ditemukan")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak dapat ditemukan")
            End If
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class
