Public Class Home
    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnKeluarAkun_Click(sender As Object, e As EventArgs) Handles BtnKeluarAkun.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar akun?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub BtnPeminjam_Click(sender As Object, e As EventArgs) Handles BtnPeminjam.Click
        Me.Hide()
        Peminjam.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Transaksi.Show()
    End Sub
End Class