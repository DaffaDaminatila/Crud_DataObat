<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crudobat
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produsen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_kd = New System.Windows.Forms.TextBox()
        Me.txt_stok = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.input = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.cari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_produsen = New System.Windows.Forms.TextBox()
        Me.txt_supplier = New System.Windows.Forms.TextBox()
        Me.ID_SUPPLIER = New System.Windows.Forms.Label()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode, Me.supplier_id, Me.nama_obat, Me.produsen, Me.stok, Me.harga})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1086, 417)
        Me.DataGridView1.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 8
        Me.no.Name = "no"
        Me.no.Width = 50
        '
        'kode
        '
        Me.kode.HeaderText = "KODE OBAT"
        Me.kode.MinimumWidth = 8
        Me.kode.Name = "kode"
        Me.kode.Width = 70
        '
        'supplier_id
        '
        Me.supplier_id.HeaderText = "ID SUPPLIER"
        Me.supplier_id.MinimumWidth = 8
        Me.supplier_id.Name = "supplier_id"
        Me.supplier_id.Width = 70
        '
        'nama_obat
        '
        Me.nama_obat.HeaderText = "NAMA OBAT"
        Me.nama_obat.MinimumWidth = 8
        Me.nama_obat.Name = "nama_obat"
        Me.nama_obat.Width = 150
        '
        'produsen
        '
        Me.produsen.HeaderText = "PRODUSEN"
        Me.produsen.MinimumWidth = 8
        Me.produsen.Name = "produsen"
        Me.produsen.Width = 150
        '
        'stok
        '
        Me.stok.HeaderText = "STOK OBAT"
        Me.stok.MinimumWidth = 8
        Me.stok.Name = "stok"
        Me.stok.Width = 70
        '
        'harga
        '
        Me.harga.HeaderText = "HARGA (Rp)"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        Me.harga.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KD_OBAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "STOK_OBAT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NAMA_OBAT"
        '
        'txt_kd
        '
        Me.txt_kd.Location = New System.Drawing.Point(193, 29)
        Me.txt_kd.Name = "txt_kd"
        Me.txt_kd.Size = New System.Drawing.Size(250, 26)
        Me.txt_kd.TabIndex = 5
        '
        'txt_stok
        '
        Me.txt_stok.Location = New System.Drawing.Point(193, 157)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Size = New System.Drawing.Size(250, 26)
        Me.txt_stok.TabIndex = 8
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(193, 93)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(250, 26)
        Me.txt_nama.TabIndex = 9
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(474, 99)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(83, 36)
        Me.input.TabIndex = 10
        Me.input.Text = "INPUT"
        Me.input.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(722, 101)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(90, 34)
        Me.delete.TabIndex = 11
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(590, 99)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(95, 36)
        Me.update.TabIndex = 12
        Me.update.Text = "UPDATE"
        Me.update.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(590, 163)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(95, 33)
        Me.cancel.TabIndex = 13
        Me.cancel.Text = "CANCEL"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(433, 248)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(423, 26)
        Me.txt_cari.TabIndex = 14
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(873, 245)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(94, 32)
        Me.cari.TabIndex = 15
        Me.cari.Text = "SEARCH"
        Me.cari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "PRODUSEN"
        '
        'txt_produsen
        '
        Me.txt_produsen.Location = New System.Drawing.Point(193, 125)
        Me.txt_produsen.Name = "txt_produsen"
        Me.txt_produsen.Size = New System.Drawing.Size(250, 26)
        Me.txt_produsen.TabIndex = 17
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(193, 61)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Size = New System.Drawing.Size(250, 26)
        Me.txt_supplier.TabIndex = 18
        '
        'ID_SUPPLIER
        '
        Me.ID_SUPPLIER.AutoSize = True
        Me.ID_SUPPLIER.Location = New System.Drawing.Point(47, 67)
        Me.ID_SUPPLIER.Name = "ID_SUPPLIER"
        Me.ID_SUPPLIER.Size = New System.Drawing.Size(110, 20)
        Me.ID_SUPPLIER.TabIndex = 19
        Me.ID_SUPPLIER.Text = "SUPPLIER ID"
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(193, 189)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(250, 26)
        Me.txt_harga.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "HARGA"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.remove
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.remove
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(1068, 12)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(30, 26)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 22
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'crudobat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 723)
        Me.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.ID_SUPPLIER)
        Me.Controls.Add(Me.txt_supplier)
        Me.Controls.Add(Me.txt_produsen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txt_stok)
        Me.Controls.Add(Me.txt_kd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "crudobat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "crudobat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_kd As TextBox
    Friend WithEvents txt_stok As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents input As Button
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents cancel As Button
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents cari As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_produsen As TextBox
    Friend WithEvents txt_supplier As TextBox
    Friend WithEvents ID_SUPPLIER As Label
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents supplier_id As DataGridViewTextBoxColumn
    Friend WithEvents nama_obat As DataGridViewTextBoxColumn
    Friend WithEvents produsen As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
End Class
