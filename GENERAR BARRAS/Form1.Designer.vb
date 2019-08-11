<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxGENERAR = New System.Windows.Forms.TextBox()
        Me.ButtonCREAR = New System.Windows.Forms.Button()
        Me.PictureBoxGENERAR = New System.Windows.Forms.PictureBox()
        Me.ButtonGUARDAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton128 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonQR = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPDF417 = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBoxLEER = New System.Windows.Forms.PictureBox()
        Me.ButtonLEER = New System.Windows.Forms.Button()
        Me.TextBoxLEER = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonIMPRIMIR = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBoxGENERAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxLEER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxGENERAR
        '
        Me.TextBoxGENERAR.BackColor = System.Drawing.Color.Black
        Me.TextBoxGENERAR.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxGENERAR.Location = New System.Drawing.Point(13, 26)
        Me.TextBoxGENERAR.Name = "TextBoxGENERAR"
        Me.TextBoxGENERAR.Size = New System.Drawing.Size(401, 22)
        Me.TextBoxGENERAR.TabIndex = 100
        Me.TextBoxGENERAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCREAR
        '
        Me.ButtonCREAR.BackColor = System.Drawing.Color.Black
        Me.ButtonCREAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonCREAR.Location = New System.Drawing.Point(312, 77)
        Me.ButtonCREAR.Name = "ButtonCREAR"
        Me.ButtonCREAR.Size = New System.Drawing.Size(100, 40)
        Me.ButtonCREAR.TabIndex = 1
        Me.ButtonCREAR.Text = "CREAR"
        Me.ButtonCREAR.UseVisualStyleBackColor = False
        '
        'PictureBoxGENERAR
        '
        Me.PictureBoxGENERAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBoxGENERAR.Location = New System.Drawing.Point(12, 123)
        Me.PictureBoxGENERAR.Name = "PictureBoxGENERAR"
        Me.PictureBoxGENERAR.Size = New System.Drawing.Size(400, 300)
        Me.PictureBoxGENERAR.TabIndex = 2
        Me.PictureBoxGENERAR.TabStop = False
        '
        'ButtonGUARDAR
        '
        Me.ButtonGUARDAR.BackColor = System.Drawing.Color.Black
        Me.ButtonGUARDAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonGUARDAR.Location = New System.Drawing.Point(272, 431)
        Me.ButtonGUARDAR.Name = "ButtonGUARDAR"
        Me.ButtonGUARDAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonGUARDAR.TabIndex = 3
        Me.ButtonGUARDAR.Text = "GUARDAR"
        Me.ButtonGUARDAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton128)
        Me.GroupBox1.Controls.Add(Me.RadioButtonQR)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPDF417)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 46)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CODIGO"
        '
        'RadioButton128
        '
        Me.RadioButton128.AutoSize = True
        Me.RadioButton128.Location = New System.Drawing.Point(107, 20)
        Me.RadioButton128.Name = "RadioButton128"
        Me.RadioButton128.Size = New System.Drawing.Size(50, 20)
        Me.RadioButton128.TabIndex = 2
        Me.RadioButton128.Text = "128"
        Me.RadioButton128.UseVisualStyleBackColor = True
        '
        'RadioButtonQR
        '
        Me.RadioButtonQR.AutoSize = True
        Me.RadioButtonQR.Checked = True
        Me.RadioButtonQR.Location = New System.Drawing.Point(208, 20)
        Me.RadioButtonQR.Name = "RadioButtonQR"
        Me.RadioButtonQR.Size = New System.Drawing.Size(48, 20)
        Me.RadioButtonQR.TabIndex = 1
        Me.RadioButtonQR.TabStop = True
        Me.RadioButtonQR.Text = "QR"
        Me.RadioButtonQR.UseVisualStyleBackColor = True
        '
        'RadioButtonPDF417
        '
        Me.RadioButtonPDF417.AutoSize = True
        Me.RadioButtonPDF417.Location = New System.Drawing.Point(6, 21)
        Me.RadioButtonPDF417.Name = "RadioButtonPDF417"
        Me.RadioButtonPDF417.Size = New System.Drawing.Size(80, 20)
        Me.RadioButtonPDF417.TabIndex = 0
        Me.RadioButtonPDF417.Text = "PDF417"
        Me.RadioButtonPDF417.UseVisualStyleBackColor = True
        '
        'PictureBoxLEER
        '
        Me.PictureBoxLEER.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBoxLEER.Location = New System.Drawing.Point(552, 123)
        Me.PictureBoxLEER.Name = "PictureBoxLEER"
        Me.PictureBoxLEER.Size = New System.Drawing.Size(400, 300)
        Me.PictureBoxLEER.TabIndex = 101
        Me.PictureBoxLEER.TabStop = False
        '
        'ButtonLEER
        '
        Me.ButtonLEER.BackColor = System.Drawing.Color.Black
        Me.ButtonLEER.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonLEER.Location = New System.Drawing.Point(686, 431)
        Me.ButtonLEER.Name = "ButtonLEER"
        Me.ButtonLEER.Size = New System.Drawing.Size(140, 40)
        Me.ButtonLEER.TabIndex = 102
        Me.ButtonLEER.Text = "LEER"
        Me.ButtonLEER.UseVisualStyleBackColor = False
        '
        'TextBoxLEER
        '
        Me.TextBoxLEER.BackColor = System.Drawing.Color.Black
        Me.TextBoxLEER.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxLEER.Location = New System.Drawing.Point(552, 26)
        Me.TextBoxLEER.Multiline = True
        Me.TextBoxLEER.Name = "TextBoxLEER"
        Me.TextBoxLEER.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxLEER.Size = New System.Drawing.Size(400, 44)
        Me.TextBoxLEER.TabIndex = 103
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonIMPRIMIR
        '
        Me.ButtonIMPRIMIR.BackColor = System.Drawing.Color.Black
        Me.ButtonIMPRIMIR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonIMPRIMIR.Location = New System.Drawing.Point(12, 431)
        Me.ButtonIMPRIMIR.Name = "ButtonIMPRIMIR"
        Me.ButtonIMPRIMIR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonIMPRIMIR.TabIndex = 104
        Me.ButtonIMPRIMIR.Text = "IMPRIMIR"
        Me.ButtonIMPRIMIR.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 483)
        Me.Controls.Add(Me.ButtonIMPRIMIR)
        Me.Controls.Add(Me.TextBoxLEER)
        Me.Controls.Add(Me.ButtonLEER)
        Me.Controls.Add(Me.PictureBoxLEER)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonGUARDAR)
        Me.Controls.Add(Me.ButtonCREAR)
        Me.Controls.Add(Me.TextBoxGENERAR)
        Me.Controls.Add(Me.PictureBoxGENERAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GENERADOR CODIGOS DE BARRAS"
        CType(Me.PictureBoxGENERAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxLEER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxGENERAR As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCREAR As System.Windows.Forms.Button
    Friend WithEvents PictureBoxGENERAR As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonPDF417 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton128 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonQR As System.Windows.Forms.RadioButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBoxLEER As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonLEER As System.Windows.Forms.Button
    Friend WithEvents TextBoxLEER As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
