<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Mobil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtmerek = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtnopol = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilKembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPeminjamanTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambalianMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilKembaliToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(905, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.DataMobilKembaliToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPeminjamanTransaksiToolStripMenuItem, Me.PengambalianMobilToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Merek Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Type Mobil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tahun Produksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "No Polisi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Harga sewa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Rp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(409, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(229, 26)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "FORM DATA MOBIL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 61
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(146, 224)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(99, 20)
        Me.txtharga.TabIndex = 62
        '
        'txtmerek
        '
        Me.txtmerek.Location = New System.Drawing.Point(112, 72)
        Me.txtmerek.Name = "txtmerek"
        Me.txtmerek.Size = New System.Drawing.Size(133, 20)
        Me.txtmerek.TabIndex = 63
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(112, 113)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(133, 20)
        Me.txttype.TabIndex = 64
        '
        'txtnopol
        '
        Me.txtnopol.Location = New System.Drawing.Point(112, 184)
        Me.txtnopol.Name = "txtnopol"
        Me.txtnopol.Size = New System.Drawing.Size(133, 20)
        Me.txtnopol.TabIndex = 65
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(278, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(615, 221)
        Me.DataGridView1.TabIndex = 68
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.Location = New System.Drawing.Point(13, 302)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(75, 31)
        Me.btncreate.TabIndex = 69
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(104, 302)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 31)
        Me.btnupdate.TabIndex = 70
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(197, 302)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 31)
        Me.btndelete.TabIndex = 71
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txttahun
        '
        Me.txttahun.Location = New System.Drawing.Point(112, 151)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.Size = New System.Drawing.Size(133, 20)
        Me.txttahun.TabIndex = 72
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(112, 260)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(133, 20)
        Me.txtstatus.TabIndex = 73
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(760, 68)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(133, 20)
        Me.txtcari.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(725, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 15)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Cari"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'DataMobilKembaliToolStripMenuItem
        '
        Me.DataMobilKembaliToolStripMenuItem.Name = "DataMobilKembaliToolStripMenuItem"
        Me.DataMobilKembaliToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataMobilKembaliToolStripMenuItem.Text = "Data User"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'DataPeminjamanTransaksiToolStripMenuItem
        '
        Me.DataPeminjamanTransaksiToolStripMenuItem.Name = "DataPeminjamanTransaksiToolStripMenuItem"
        Me.DataPeminjamanTransaksiToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.DataPeminjamanTransaksiToolStripMenuItem.Text = "Data peminjaman & transaksi"
        '
        'PengambalianMobilToolStripMenuItem
        '
        Me.PengambalianMobilToolStripMenuItem.Name = "PengambalianMobilToolStripMenuItem"
        Me.PengambalianMobilToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.PengambalianMobilToolStripMenuItem.Text = "Pengambalian  Mobil"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMobilKembaliToolStripMenuItem1})
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem1.Text = "Laporan"
        '
        'DataMobilKembaliToolStripMenuItem1
        '
        Me.DataMobilKembaliToolStripMenuItem1.Name = "DataMobilKembaliToolStripMenuItem1"
        Me.DataMobilKembaliToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DataMobilKembaliToolStripMenuItem1.Text = "Data mobil kembali"
        '
        'Data_Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txttahun)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnopol)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtmerek)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Data_Mobil"
        Me.Text = "Data_Mobil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtmerek As TextBox
    Friend WithEvents txttype As TextBox
    Friend WithEvents txtnopol As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btncreate As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txttahun As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMobilKembaliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPeminjamanTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengambalianMobilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataMobilKembaliToolStripMenuItem1 As ToolStripMenuItem
End Class
