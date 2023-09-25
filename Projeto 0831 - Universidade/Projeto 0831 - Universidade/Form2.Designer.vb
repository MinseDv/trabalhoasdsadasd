<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.components = New System.ComponentModel.Container()
        Dim Timer2 As System.Windows.Forms.Timer
        Dim Timer3 As System.Windows.Forms.Timer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.msgBox = New System.Windows.Forms.GroupBox()
        Me.Txtsenha = New System.Windows.Forms.TextBox()
        Me.Txtnome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.Btncancelar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Timer2 = New System.Windows.Forms.Timer(Me.components)
        Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.msgBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'msgBox
        '
        Me.msgBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.msgBox.Controls.Add(Me.Txtsenha)
        Me.msgBox.Controls.Add(Me.Txtnome)
        Me.msgBox.Controls.Add(Me.Label2)
        Me.msgBox.Controls.Add(Me.Label1)
        Me.msgBox.Location = New System.Drawing.Point(4, 28)
        Me.msgBox.Name = "msgBox"
        Me.msgBox.Size = New System.Drawing.Size(265, 100)
        Me.msgBox.TabIndex = 0
        Me.msgBox.TabStop = False
        '
        'Txtsenha
        '
        Me.Txtsenha.Location = New System.Drawing.Point(56, 59)
        Me.Txtsenha.Name = "Txtsenha"
        Me.Txtsenha.Size = New System.Drawing.Size(197, 20)
        Me.Txtsenha.TabIndex = 3
        '
        'Txtnome
        '
        Me.Txtnome.Location = New System.Drawing.Point(56, 16)
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(197, 20)
        Me.Txtnome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnentrar.Location = New System.Drawing.Point(25, 187)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(106, 35)
        Me.btnentrar.TabIndex = 2
        Me.btnentrar.Text = "Entrar"
        Me.btnentrar.UseVisualStyleBackColor = False
        '
        'Btncancelar
        '
        Me.Btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btncancelar.Location = New System.Drawing.Point(157, 186)
        Me.Btncancelar.Name = "Btncancelar"
        Me.Btncancelar.Size = New System.Drawing.Size(100, 36)
        Me.Btncancelar.TabIndex = 3
        Me.Btncancelar.Text = "Cancelar"
        Me.Btncancelar.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 228)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(232, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(281, 263)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Btncancelar)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.msgBox)
        Me.Name = "frmlogin"
        Me.Text = "Login"
        Me.msgBox.ResumeLayout(False)
        Me.msgBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents msgBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents Txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btnentrar As System.Windows.Forms.Button
    Friend WithEvents Btncancelar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
