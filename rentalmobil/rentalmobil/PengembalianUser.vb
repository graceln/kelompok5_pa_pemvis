Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class PengembalianUser
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Home2.Show()
    End Sub

    Sub kosong()
        TxtKTP.Clear()
        TxtIDTransaksi.Clear()
        txtCari.Clear()
        TxtKTP.Focus()
    End Sub
    Sub isi()
        TxtKTP.Clear()
        TxtIDTransaksi.Clear()
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
        DataGridView1.Columns(5).Width = 150
        DataGridView1.Columns(6).Width = 150
        DataGridView1.Columns(7).Width = 150
        DataGridView1.Columns(0).HeaderText = "ID Transaksi"
        DataGridView1.Columns(1).HeaderText = "No. KTP"
        DataGridView1.Columns(2).HeaderText = "No. Polisi"
        DataGridView1.Columns(3).HeaderText = "Tanggal Sewa"
        DataGridView1.Columns(4).HeaderText = "Tanggal Kembali"
        DataGridView1.Columns(5).HeaderText = "Harga Sewa"
        DataGridView1.Columns(6).HeaderText = "Lama Hari"
        DataGridView1.Columns(7).HeaderText = "Total Bayar"
    End Sub
    Sub AturGrid2()
        DataGridView2.RowHeadersVisible = False
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).Width = 150
        DataGridView2.Columns(2).Width = 150
        DataGridView2.Columns(3).Width = 150
        DataGridView2.Columns(4).Width = 150
        DataGridView2.Columns(1).HeaderText = "ID. Transaksi"
        DataGridView2.Columns(2).HeaderText = "No. KTP"
        DataGridView2.Columns(3).HeaderText = "Tanggal Pinjam"
        DataGridView2.Columns(4).HeaderText = "Tanggal Kembali"
    End Sub

    Public Sub TampilTransaksi()

        DA = New MySqlDataAdapter("SELECT * FROM transaksi", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "transaksi")
        DataGridView1.DataSource = DS.Tables("transaksi")
        DataGridView1.Refresh()

    End Sub

    Public Sub TampilPengembalian()

        DA = New MySqlDataAdapter("SELECT * FROM data_pengembalian", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data_pengembalian")
        DataGridView2.DataSource = DS.Tables("data_pengembalian")
        DataGridView2.Refresh()

    End Sub
    Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            Dim ktp, id_transaksi As Integer
            Dim nama, jk, nope As String


            ktp = TxtKTP.Text
            id_transaksi = TxtIDTransaksi.Text


            If TxtIDTransaksi.Text = "" Then
                MsgBox("Data Belum Lengkap")
                TxtKTP.Focus()
                Exit Sub
            Else
                CMD = New MySqlCommand("Select * FROM data_pengembalian WHERE id_transaksi =" & TxtIDTransaksi.Text, CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                If Not RD.HasRows Then
                    RD.Close()
                    Dim query As String = "INSERT INTO data_pengembalian VALUES (NULL, @TextData1, @TextData2, @TextData3, @TextData4)"
                    Using MCD = New MySqlCommand(query, CONN)
                        MCD.Parameters.AddWithValue("@TextData1", id_transaksi)
                        MCD.Parameters.AddWithValue("@TextData2", ktp)
                        MCD.Parameters.AddWithValue("@TextData3", DateTimePicker1.Value)
                        MCD.Parameters.AddWithValue("@TextData4", DateTimePicker2.Value)
                        MCD.ExecuteNonQuery()
                    End Using
                    Dim keluar As String = "UPDATE data_mobil SET status = 'Tersedia' WHERE no_polisi ='" & TxtNopol.Text & "'"
                    CMD = New MySqlCommand(keluar, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
                Else
                    MsgBox("Terjadi kesalahan")
                    RD.Close()
                End If
                Call TampilPengembalian()
                Call AturGrid()
                Call kosong()
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan")
        End Try
    End Sub

    Private Sub TxtIDTransaksi_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM transaksi WHERE id_transaksi='" & TxtIDTransaksi.Text, CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                TxtIDTransaksi.Text = RD.Item(0)
                TxtKTP.Text = RD.Item(1)
                DateTimePicker1.Value = RD.Item(2)
                DateTimePicker2.Value = RD.Item(3)
                TxtIDTransaksi.Focus()
            Else
                Call isi()
                TxtIDTransaksi.Focus()
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

    Private Sub TxtNope_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(ActiveControl, True, True, True, True) ' Berpindah ke kontrol inputan selanjutnya
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM transaksi WHERE no_ktp LIKE '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * FROM transaksi WHERE no_ktp LIKE '%" & txtCari.Text & "%'", CONN)
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

    Private Sub Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilTransaksi()
        Call TampilPengembalian()
        Call kosong()
        Call AturGrid2()
        Call AturGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.TxtIDTransaksi.Text = .Cells(0).Value
            Me.TxtKTP.Text = .Cells(1).Value
            Me.TxtNopol.Text = .Cells(2).Value
            Me.DateTimePicker1.Value = .Cells(3).Value
            Me.DateTimePicker2.Value = .Cells(4).Value
        End With
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        Me.Hide()
        Transaksi.Show()
    End Sub

    Private Sub DataPeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPeminjamToolStripMenuItem.Click
        Me.Hide()
        Peminjam.Show()
    End Sub
End Class