﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnPengembalian = New System.Windows.Forms.Button()
        Me.BtnPeminjam = New System.Windows.Forms.Button()
        Me.BtnMobil = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPeminjamDanTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilKembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnKeluarAkun = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnKembali
        '
        Me.BtnKembali.Location = New System.Drawing.Point(108, 428)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(213, 65)
        Me.BtnKembali.TabIndex = 15
        Me.BtnKembali.Text = "DATA MOBIL KEMBALI"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'BtnPengembalian
        '
        Me.BtnPengembalian.Location = New System.Drawing.Point(340, 286)
        Me.BtnPengembalian.Name = "BtnPengembalian"
        Me.BtnPengembalian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPengembalian.Size = New System.Drawing.Size(213, 65)
        Me.BtnPengembalian.TabIndex = 14
        Me.BtnPengembalian.Text = "PENGEMBALIAN MOBIL"
        Me.BtnPengembalian.UseVisualStyleBackColor = True
        '
        'BtnPeminjam
        '
        Me.BtnPeminjam.Location = New System.Drawing.Point(108, 357)
        Me.BtnPeminjam.Name = "BtnPeminjam"
        Me.BtnPeminjam.Size = New System.Drawing.Size(213, 65)
        Me.BtnPeminjam.TabIndex = 13
        Me.BtnPeminjam.Text = "DATA PEMINJAM"
        Me.BtnPeminjam.UseVisualStyleBackColor = True
        '
        'BtnMobil
        '
        Me.BtnMobil.Location = New System.Drawing.Point(108, 286)
        Me.BtnMobil.Name = "BtnMobil"
        Me.BtnMobil.Size = New System.Drawing.Size(213, 65)
        Me.BtnMobil.TabIndex = 12
        Me.BtnMobil.Text = "DATA MOBIL"
        Me.BtnMobil.UseVisualStyleBackColor = True
        '
        'BtnUser
        '
        Me.BtnUser.Location = New System.Drawing.Point(108, 215)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(213, 65)
        Me.BtnUser.TabIndex = 11
        Me.BtnUser.Text = "DATA USER"
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 525)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(680, 32)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 60)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "RENTAL MOBIL JAYA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataUserToolStripMenuItem, Me.DataMobilToolStripMenuItem, Me.KeluarAkunToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'DataMobilToolStripMenuItem
        '
        Me.DataMobilToolStripMenuItem.Name = "DataMobilToolStripMenuItem"
        Me.DataMobilToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DataMobilToolStripMenuItem.Text = "Data Mobil"
        '
        'KeluarAkunToolStripMenuItem
        '
        Me.KeluarAkunToolStripMenuItem.Name = "KeluarAkunToolStripMenuItem"
        Me.KeluarAkunToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.KeluarAkunToolStripMenuItem.Text = "Keluar Akun"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPeminjamDanTransaksiToolStripMenuItem, Me.PengembalianMobilToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'DataPeminjamDanTransaksiToolStripMenuItem
        '
        Me.DataPeminjamDanTransaksiToolStripMenuItem.Name = "DataPeminjamDanTransaksiToolStripMenuItem"
        Me.DataPeminjamDanTransaksiToolStripMenuItem.Size = New System.Drawing.Size(343, 34)
        Me.DataPeminjamDanTransaksiToolStripMenuItem.Text = "Data Peminjam dan Transaksi"
        '
        'PengembalianMobilToolStripMenuItem
        '
        Me.PengembalianMobilToolStripMenuItem.Name = "PengembalianMobilToolStripMenuItem"
        Me.PengembalianMobilToolStripMenuItem.Size = New System.Drawing.Size(343, 34)
        Me.PengembalianMobilToolStripMenuItem.Text = "Pengembalian Mobil"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMobilKembaliToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataMobilKembaliToolStripMenuItem
        '
        Me.DataMobilKembaliToolStripMenuItem.Name = "DataMobilKembaliToolStripMenuItem"
        Me.DataMobilKembaliToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DataMobilKembaliToolStripMenuItem.Text = "Data Mobil Kembali"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(158, 34)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'BtnKeluarAkun
        '
        Me.BtnKeluarAkun.Location = New System.Drawing.Point(340, 357)
        Me.BtnKeluarAkun.Name = "BtnKeluarAkun"
        Me.BtnKeluarAkun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnKeluarAkun.Size = New System.Drawing.Size(213, 65)
        Me.BtnKeluarAkun.TabIndex = 17
        Me.BtnKeluarAkun.Text = "KELUAR AKUN"
        Me.BtnKeluarAkun.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(340, 428)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnExit.Size = New System.Drawing.Size(213, 65)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(213, 65)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "TRANSAKSI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 35)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "MENU ADMIN"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 557)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnUser)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnKeluarAkun)
        Me.Controls.Add(Me.BtnMobil)
        Me.Controls.Add(Me.BtnPeminjam)
        Me.Controls.Add(Me.BtnPengembalian)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnPengembalian As Button
    Friend WithEvents BtnPeminjam As Button
    Friend WithEvents BtnMobil As Button
    Friend WithEvents BtnUser As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarAkunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPeminjamDanTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMobilKembaliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnKeluarAkun As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
