Imports MySql.Data.MySqlClient

Public Class Data_Mobil

    Sub kosong()
        txtmerek.Clear()
        txttype.Clear()
        txttahun.Clear()
        txtnopol.Clear()
        txtharga.Clear()
        txtstatus.Clear()
        txtcari.Clear()

    End Sub

    Sub isi()
        txtmerek.Clear()
        txttype.Clear()
        txttahun.Clear()
        txtnopol.Clear()
        txtharga.Clear()
        txtstatus.Clear()
        txtcari.Clear()

        txtmerek.Focus()
    End Sub


    Sub AturGrid1()
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 100

        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100


        DataGridView1.Columns(1).HeaderText = "Merek Mobil "
        DataGridView1.Columns(2).HeaderText = "Tipe Mobil"
        DataGridView1.Columns(3).HeaderText = "Tahun Produksi"
        DataGridView1.Columns(4).HeaderText = "No.Polisi"
        DataGridView1.Columns(5).HeaderText = "Harga Sewa "
        DataGridView1.Columns(6).HeaderText = "Status "
    End Sub

    Public Sub Tampildatamobil()

        DA = New MySqlDataAdapter("SELECT * FROM data_mobil", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data_mobil")
        DataGridView1.DataSource = DS.Tables("data_mobil")
        DataGridView1.Refresh()

    End Sub


    Private Sub Data_Mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampildatamobil()
        Call AturGrid1()
        Call kosong()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        If txtnopol.Text = "" Then
            MsgBox("nomor polisi belum diisi")
            txtnopol.Focus()
        Else
            Dim Ubah As String = "Update data_mobil set merk_mobil  = '" & txtmerek.Text & "', type_mobil   = '" & txttype.Text & "', tahun_produksi  = " & txttahun.Text & ", no_polisi = " & txtnopol.Text & ",  harga_sewa    = " & txtharga.Text & ", status  = '" & txtstatus.Text & "' WHERE `no_polisi`   = '" & txtnopol.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Tampildatamobil()
            Call kosong()
            txtnopol.Focus()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        If txtnopol.Text = "" Then
            MsgBox("nomor polisi belum diisi")
            txtnopol.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data data_mobil " & txtnopol.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From data_mobil WHERE `no_polisi`  = '" & txtnopol.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kosong()
                Call Tampildatamobil()
            Else
                Call kosong()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtmerek.Text = .Cells(1).Value
            Me.txttype.Text = .Cells(2).Value
            Me.txttahun.Text = .Cells(3).Value
            Me.txtnopol.Text = .Cells(4).Value

            Me.txtharga.Text = .Cells(5).Value
            Me.txtstatus.Text = .Cells(6).Value

        End With
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If txtmerek.Text = "" Or txttype.Text = "" Or txttahun.Text = "" Or txtnopol.Text = "" Or txtharga.Text = "" Or txtstatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtnopol.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * FROM data_mobil WHERE no_polisi =" & txtnopol.Text & " ", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "Insert Into data_mobil values (NULL,'" & txtmerek.Text & "','" & txttype.Text & "'," & txttahun.Text & "," & txtnopol.Text & "," & txtharga.Text & ",'" & txtstatus.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Terjadi kesalahan")
                RD.Close()
            End If
            Call Tampildatamobil()
            Call kosong()
            txtnopol.Focus()
        End If
    End Sub

    Private Sub txtnopol_TextChanged(sender As Object, e As EventArgs) Handles txtnopol.TextChanged

    End Sub

    Private Sub txtnopol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnopol.KeyPress

        txtmerek.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM data_mobil WHERE no_polisi=" & txtnopol.Text, CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtmerek.Text = RD.Item(1)
                txttype.Text = RD.Item(2)
                txttahun.Text = RD.Item(3)
                txtnopol.Text = RD.Item(4)
                txtharga.Text = RD.Item(5)
                txtstatus.Text = RD.Item(6)
            Else
                Call isi()
                txtnopol.Focus()
            End If
            RD.Close()
        End If

    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged

    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM data_mobil WHERE no_polisi LIKE '%" & txtcari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * FROM data_mobil WHERE no_polisi LIKE '%" & txtcari.Text & "%'", CONN)
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



    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub DataMobilKembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMobilKembaliToolStripMenuItem.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PengambalianMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengambalianMobilToolStripMenuItem.Click

    End Sub
End Class