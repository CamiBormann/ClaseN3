<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Numero = New Label()
        Num = New Label()
        txt2 = New TextBox()
        txt1 = New TextBox()
        Button1 = New Button()
        c1 = New ComboBox()
        label = New Label()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Numero
        ' 
        Numero.AutoSize = True
        Numero.Location = New Point(30, 198)
        Numero.Name = "Numero"
        Numero.Size = New Size(60, 15)
        Numero.TabIndex = 0
        Numero.Text = "Numero 1"
        ' 
        ' Num
        ' 
        Num.AutoSize = True
        Num.Location = New Point(30, 243)
        Num.Name = "Num"
        Num.Size = New Size(60, 15)
        Num.TabIndex = 1
        Num.Text = "Numero 2"
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(160, 235)
        txt2.Name = "txt2"
        txt2.Size = New Size(100, 23)
        txt2.TabIndex = 2
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(160, 195)
        txt1.Name = "txt1"
        txt1.Size = New Size(100, 23)
        txt1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(75, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' c1
        ' 
        c1.FormattingEnabled = True
        c1.Items.AddRange(New Object() {"", "+", "-", "*", "/"})
        c1.Location = New Point(160, 283)
        c1.Name = "c1"
        c1.Size = New Size(100, 23)
        c1.TabIndex = 5
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(30, 291)
        label.Name = "label"
        label.Size = New Size(108, 15)
        label.TabIndex = 6
        label.Text = "Escoje la operacion"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images
        PictureBox1.Location = New Point(43, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 177)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(201, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Actividad 2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(353, 450)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(label)
        Controls.Add(c1)
        Controls.Add(Button1)
        Controls.Add(txt1)
        Controls.Add(txt2)
        Controls.Add(Num)
        Controls.Add(Numero)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "Calculadora Kitty"
        WindowState = FormWindowState.Minimized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Numero As Label
    Friend WithEvents Num As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents c1 As ComboBox
    Friend WithEvents label As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button

End Class
