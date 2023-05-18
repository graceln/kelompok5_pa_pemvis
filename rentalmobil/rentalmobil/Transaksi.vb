Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.WebRequestMethods
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Transaksi
    Sub kosong()
        TxtNama.Clear()
        TxtAlamat.Clear()
        TxtKTP.Clear()
        TxtNope.Clear()
        TxtTipeMobil.Clear()
        TxtStatus.Clear()
        TxtNopol.Clear()
        TxtHargaSewa.Clear()
        TxtKTP.Focus()
    End Sub
    Sub isimobil()
        TxtNama.Clear()
        TxtTipeMobil.Clear()
        TxtStatus.Clear()
        TxtNopol.Clear()
        TxtHargaSewa.Clear()
        TxtNopol.Focus()
    End Sub
    Sub isi()
        TxtNama.Clear()
        TxtKTP.Clear()
        TxtNama.Clear()
        TxtJenisKelamin.Clear()
        TxtNope.Clear()
        TxtAlamat.Clear()
        TxtKTP.Focus()
    End Sub

    Sub TampilMobil()
        DA = New MySqlDataAdapter("SELECT * FROM data_mobil WHERE status ='Tersedia'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data_mobil")
        DataGridView2.DataSource = DS.Tables("data_mobil")
        DataGridView2.Refresh()
    End Sub

    Sub TampilTransaksi()
        DA = New MySqlDataAdapter("SELECT * FROM transaksi", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "transaksi")
        DataGridView1.DataSource = DS.Tables("transaksi")
        DataGridView1.Refresh()
    End Sub

    Sub AturGrid2()
        DataGridView2.RowHeadersVisible = False
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).Visible = False
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).Width = 100
        DataGridView2.Columns(5).Width = 100
        DataGridView2.Columns(3).HeaderText = "No. Polisi"
        DataGridView2.Columns(1).HeaderText = "Tipe Mobil"
        DataGridView2.Columns(4).HeaderText = "Harga Sewa"
        DataGridView2.Columns(5).HeaderText = "Status"
    End Sub

    Sub AturGrid1()
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

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As Integer
        i = Me.DataGridView2.CurrentRow.Index
        With DataGridView2.Rows.Item(i)
            Me.TxtNopol.Text = .Cells(3).Value
            Me.TxtTipeMobil.Text = .Cells(1).Value
            Me.TxtHargaSewa.Text = .Cells(4).Value
            Me.TxtStatus.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilMobil()
        Call TampilTransaksi()
        Call kosong()
        Call AturGrid2()
        Call AturGrid1()
    End Sub

    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        Call kosong()
        Call TampilMobil()
        Call TampilTransaksi()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        ' Ambil tanggal dari DateTimePicker
        Dim tanggal1 As Date = DateTimePicker1.Value
        Dim tanggal2 As Date = DateTimePicker2.Value

        ' Hitung selisih tanggal
        Dim selisih As TimeSpan = tanggal2 - tanggal1

        ' Ambil jumlah hari dari selisih tanggal
        Dim jumlahHari As Integer = selisih.Days

        Dim Harga As Integer = TxtHargaSewa.Text * jumlahHari
        TxtJumlahHari.Text = jumlahHari
        TxtTotal.Text = Harga

    End Sub

    Private Sub txtKTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKTP.KeyPress
        TxtNama.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM data_peminjam WHERE no_ktp=" & TxtKTP.Text, CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                TxtNama.Text = RD.Item(1)
                TxtJenisKelamin.Text = RD.Item(2)
                TxtNope.Text = RD.Item(3)
                TxtAlamat.Text = RD.Item(4)
            Else
                Call isi()
                TxtKTP.Focus()
            End If
            RD.Close()
        End If

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Dim ktp, harga, lama, totalbayar As Integer
        Dim nopol, nama, jk, nope, alamat As String
        Dim tglpinjam, tglbalik As DateTime

        ktp = TxtKTP.Text
        nama = TxtNama.Text
        jk = TxtJenisKelamin.Text
        nope = TxtNope.Text
        alamat = TxtAlamat.Text
        nopol = TxtNopol.Text
        tglpinjam = DateTimePicker1.Value
        tglbalik = DateTimePicker2.Value
        harga = TxtHargaSewa.Text
        lama = TxtJumlahHari.Text
        totalbayar = TxtTotal.Text

        If TxtKTP.Text = "" Or TxtNopol.Text = "" Or TxtJumlahHari.Text = "" Or TxtTotal.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TxtKTP.Focus()
            Exit Sub
        Else
            Dim query As String = "INSERT INTO transaksi VALUES (NULL, @TextData1, @TextData2, @TextData3, @TextData4, @TextData5, @TextData6, @TextData7)"
            Using MCD = New MySqlCommand(query, CONN)
                MCD.Parameters.AddWithValue("@TextData1", ktp)
                MCD.Parameters.AddWithValue("@TextData2", nopol)
                MCD.Parameters.AddWithValue("@TextData3", tglpinjam)
                MCD.Parameters.AddWithValue("@TextData4", tglbalik)
                MCD.Parameters.AddWithValue("@TextData5", harga)
                MCD.Parameters.AddWithValue("@TextData6", lama)
                MCD.Parameters.AddWithValue("@TextData7", totalbayar)
                MCD.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
            End Using
            Dim keluar As String = "UPDATE data_mobil SET status = 'Keluar' WHERE no_polisi ='" & nopol & "'"
            CMD = New MySqlCommand(keluar, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
        End If
        Call TampilMobil()
        Call TampilTransaksi()
        Call kosong()
        TxtKTP.Focus()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        Dim imageData As Byte()
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.TxtKTP.Text = .Cells(1).Value
            CMD = New MySqlCommand("Select * FROM data_peminjam WHERE no_ktp=" & TxtKTP.Text, CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows = True Then
                TxtNama.Text = RD.Item(1)
                TxtJenisKelamin.Text = RD.Item(2)
                TxtNope.Text = RD.Item(3)
                TxtAlamat.Text = RD.Item(4)
            End If
            RD.Close()

            Me.TxtNopol.Text = .Cells(2).Value
            CMD = New MySqlCommand("Select * FROM data_mobil WHERE no_polisi ='" & TxtNopol.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows = True Then
                TxtTipeMobil.Text = RD.Item(1)
                TxtHargaSewa.Text = RD.Item(4)
                TxtStatus.Text = RD.Item(5)
            End If

            RD.Close()

            Dim index As Integer
            index = DataGridView1.CurrentRow.Cells(0).Value
            CMD = New MySqlCommand("Select * FROM transaksi WHERE id_transaksi ='" & index & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows = True Then
                DateTimePicker1.Value = RD.Item(3)
                DateTimePicker2.Value = RD.Item(4)
                TxtJumlahHari.Text = RD.Item(6)
                TxtTotal.Text = RD.Item(7)
            End If

            RD.Close()
        End With

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        Dim index As Integer
        index = DataGridView1.CurrentRow.Cells(0).Value

        If index = 0 Then
            MsgBox("Data belum dipilih")
            TxtKTP.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data transaksi ID =  " & index & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From transaksi WHERE id_transaksi = " & index, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kosong()
                Call TampilTransaksi()
            Else
                Call kosong()
            End If
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DataPeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPeminjamToolStripMenuItem.Click
        Me.Hide()
        Peminjam.Show()
    End Sub
End Class