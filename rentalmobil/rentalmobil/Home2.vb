Public Class Home2
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        TransaksiUser.Show()
    End Sub

    Private Sub BtnPeminjam_Click(sender As Object, e As EventArgs) Handles BtnPeminjam.Click
        Me.Hide()
        PeminjamUser.Show()
    End Sub

    Private Sub BtnPengembalian_Click(sender As Object, e As EventArgs) Handles BtnPengembalian.Click
        Me.Hide()
        PengembalianUser.Show()
    End Sub

    Private Sub BtnKeluarAkun_Click(sender As Object, e As EventArgs) Handles BtnKeluarAkun.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar akun?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Login2.Show()
        End If
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem1.Click
        Me.Hide()
        TransaksiUser.Show()
    End Sub

    Private Sub DataPeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPeminjamToolStripMenuItem.Click
        Me.Hide()
        PeminjamUser.Show()
    End Sub

    Private Sub PengembalianMoobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianMoobilToolStripMenuItem.Click
        Me.Hide()
        PengembalianUser.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class