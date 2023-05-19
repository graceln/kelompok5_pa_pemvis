Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then txtUsername.Focus()
        ' Cek apakah karakter yang dimasukkan adalah huruf kecil
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

        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(ActiveControl, True, True, True, True) ' Berpindah ke kontrol inputan selanjutnya
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If e.KeyChar = Chr(13) Then BtnLogin.Focus()
        End If
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login2.Show()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click_1(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * FROM user WHERE username='" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Visible = False
            Home.Show()
            Home.ToolStripStatusLabel1.Text = RD.GetString(0)
            Home.ToolStripStatusLabel2.Text = RD.GetString(1)
            Home.ToolStripStatusLabel3.Text = RD.GetString(2)
            If Home.ToolStripStatusLabel3.Text <> "Admin" Then
                Home.LoginToolStripMenuItem.Enabled = False
            Else
                Home.LoginToolStripMenuItem.Enabled = True
            End If
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Username atau Password Salah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Login2.Show()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class
