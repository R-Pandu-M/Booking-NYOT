<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pembayaran
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
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Via_Pembayaran = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Movie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Waktu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Theater = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tunai = New System.Windows.Forms.RadioButton()
        Me.non_tunai = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.konfirm = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.lanjut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Via_Pembayaran, Me.Total})
        Me.ListView2.Location = New System.Drawing.Point(12, 350)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(308, 97)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'Via_Pembayaran
        '
        Me.Via_Pembayaran.Text = "Via Pembayaran"
        Me.Via_Pembayaran.Width = 115
        '
        'Total
        '
        Me.Total.Text = "Total Pembayaran"
        Me.Total.Width = 112
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.Movie, Me.Waktu, Me.Theater})
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(425, 226)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'No
        '
        Me.No.Text = "No"
        '
        'Movie
        '
        Me.Movie.Text = "Film"
        '
        'Waktu
        '
        Me.Waktu.Text = "Waktu"
        '
        'Theater
        '
        Me.Theater.Text = "Theater"
        '
        'tunai
        '
        Me.tunai.AutoSize = True
        Me.tunai.Location = New System.Drawing.Point(12, 267)
        Me.tunai.Name = "tunai"
        Me.tunai.Size = New System.Drawing.Size(52, 17)
        Me.tunai.TabIndex = 3
        Me.tunai.TabStop = True
        Me.tunai.Text = "Tunai"
        Me.tunai.UseVisualStyleBackColor = True
        '
        'non_tunai
        '
        Me.non_tunai.AutoSize = True
        Me.non_tunai.Location = New System.Drawing.Point(70, 267)
        Me.non_tunai.Name = "non_tunai"
        Me.non_tunai.Size = New System.Drawing.Size(75, 17)
        Me.non_tunai.TabIndex = 4
        Me.non_tunai.TabStop = True
        Me.non_tunai.Text = "Non Tunai"
        Me.non_tunai.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 290)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'konfirm
        '
        Me.konfirm.Location = New System.Drawing.Point(326, 395)
        Me.konfirm.Name = "konfirm"
        Me.konfirm.Size = New System.Drawing.Size(75, 23)
        Me.konfirm.TabIndex = 7
        Me.konfirm.Text = "Konfirmasi"
        Me.konfirm.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(326, 424)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 23)
        Me.hapus.TabIndex = 8
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'lanjut
        '
        Me.lanjut.Location = New System.Drawing.Point(423, 424)
        Me.lanjut.Name = "lanjut"
        Me.lanjut.Size = New System.Drawing.Size(75, 23)
        Me.lanjut.TabIndex = 9
        Me.lanjut.Text = "Lanjut"
        Me.lanjut.UseVisualStyleBackColor = True
        '
        'form_pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 459)
        Me.Controls.Add(Me.lanjut)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.konfirm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.non_tunai)
        Me.Controls.Add(Me.tunai)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView2)
        Me.Name = "form_pembayaran"
        Me.Text = "Form Pembayaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Movie As System.Windows.Forms.ColumnHeader
    Friend WithEvents Waktu As System.Windows.Forms.ColumnHeader
    Friend WithEvents Theater As System.Windows.Forms.ColumnHeader
    Friend WithEvents tunai As System.Windows.Forms.RadioButton
    Friend WithEvents non_tunai As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents konfirm As System.Windows.Forms.Button
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents lanjut As System.Windows.Forms.Button
    Friend WithEvents Via_Pembayaran As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader

End Class
