Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Peminjam


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
        TxtAlamat.Clear()
        TxtKTP.Clear()
        TxtNope.Clear()
        ComboBoxJK.ResetText()
        txtCari.Clear()
        PictureBox1.Image = Nothing
        TxtKTP.Focus()
    End Sub
    Sub isi()
        TxtNama.Clear()
        TxtKTP.Clear()
        TxtNama.Clear()
        ComboBoxJK.ResetText()
        TxtNope.Clear()
        TxtAlamat.Clear()
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
        DataGridView1.Columns(4).HeaderText = "Alamat"
    End Sub

    Private Function resizeImage(ByVal img As Image, ByVal w As Integer, ByVal h As Integer) As Image
        Try
            Dim newImageSize As New Bitmap(w, h)
            Using g As Graphics = Graphics.FromImage(newImageSize)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(img, New Rectangle(0, 0, w, h))
            End Using
            Return newImageSize
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Sub TampilPeminjam()

        DA = New MySqlDataAdapter("SELECT * FROM data_peminjam", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data_peminjam")
        DataGridView1.DataSource = DS.Tables("data_peminjam")
        DataGridView1.Refresh()

    End Sub

    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function


    Private Sub Peminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilPeminjam()
        Call AturGrid()
        Call kosong()
    End Sub

    Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp|Semua File|*.*" ' Filter untuk hanya menampilkan file gambar
        openFileDialog.Title = "Pilih Gambar"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            PictureBox1.Image = Image.FromFile(imagePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim ktp As Integer
        Dim nama, jk, nope, alamat As String


        ktp = TxtKTP.Text
        nama = TxtNama.Text
        jk = ComboBoxJK.Text
        nope = TxtNope.Text
        alamat = TxtAlamat.Text


        Dim image As Image = PictureBox1.Image
        Dim imageData As Byte() = ImageToByteArray(image)


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
                    MCD.Parameters.AddWithValue("@TextData5", alamat)
                    MCD.Parameters.AddWithValue("@ImageData", imageData)
                    MCD.ExecuteNonQuery()
                    MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
                End Using
            Else
                MsgBox("Terjadi kesalahan")
                RD.Close()
            End If
            Call TampilPeminjam()
            Call AturGrid()
            Call kosong()
            txtNama.Focus()
        End If
    End Sub
    Private Function ImageToByteArray(ByVal image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        Dim imageData As Byte()
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)

            Me.TxtKTP.Text = .Cells(0).Value
            Me.TxtNama.Text = .Cells(1).Value
            Me.ComboBoxJK.Text = .Cells(2).Value
            Me.TxtNope.Text = .Cells(3).Value
            Me.TxtAlamat.Text = .Cells(4).Value
            imageData = .Cells(5).Value
            Dim image As Image = ByteArrayToImage(imageData)
            Me.PictureBox1.Image = image
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End With

    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim ktp As Integer
        Dim nama, jk, nope, alamat As String


        ktp = TxtKTP.Text
        nama = TxtNama.Text
        jk = ComboBoxJK.Text
        nope = TxtNope.Text
        alamat = TxtAlamat.Text


        Dim image As Image = PictureBox1.Image
        Dim imageData As Byte() = ImageToByteArray(image)


        If TxtKTP.Text = "" Then
            MsgBox("No. KTP belum diisi")
            TxtKTP.Focus()
        Else

            RD.Close()
            Dim query As String = "UPDATE data_peminjam SET no_ktp = @TextData1 , nama_p = @TextData2, jenis_kelamin_p = @TextData3, no_hp_p = @TextData4, alamat_p = @TextData5, urlfoto = @ImageData WHERE no_ktp = @TextData1"
            Using MCD = New MySqlCommand(query, CONN)
                MCD.Parameters.AddWithValue("@TextData1", ktp)
                MCD.Parameters.AddWithValue("@TextData2", nama)
                MCD.Parameters.AddWithValue("@TextData3", jk)
                MCD.Parameters.AddWithValue("@TextData4", nope)
                MCD.Parameters.AddWithValue("@TextData5", alamat)
                MCD.Parameters.AddWithValue("@ImageData", imageData)
                MCD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
            Call TampilPeminjam()
            Call kosong()
            TxtKTP.Focus()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKTP.Text = "" Then
            MsgBox("No. KTP belum diisi")
            TxtKTP.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data peminjam " & TxtKTP.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From data_peminjam WHERE no_ktp = '" & TxtKTP.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kosong()
                Call TampilPeminjam()
            Else
                Call kosong()
            End If
        End If
    End Sub

    Private Sub BtnBersihkan_Click(sender As Object, e As EventArgs) Handles BtnBersihkan.Click
        Call kosong()
        Call TampilPeminjam()
        Call AturGrid()
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
                TxtAlamat.Text = RD.Item(4)
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

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        Me.Hide()
        Transaksi.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class