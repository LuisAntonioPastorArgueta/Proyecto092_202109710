<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioForm))
        Me.crearcuentabt = New System.Windows.Forms.Button()
        Me.iniciarbt = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inicioadminbt = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crearcuentabt
        '
        Me.crearcuentabt.BackColor = System.Drawing.Color.DarkBlue
        Me.crearcuentabt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crearcuentabt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.crearcuentabt.Location = New System.Drawing.Point(192, 196)
        Me.crearcuentabt.Name = "crearcuentabt"
        Me.crearcuentabt.Size = New System.Drawing.Size(114, 29)
        Me.crearcuentabt.TabIndex = 15
        Me.crearcuentabt.Text = "Crear cuenta"
        Me.crearcuentabt.UseVisualStyleBackColor = False
        '
        'iniciarbt
        '
        Me.iniciarbt.BackColor = System.Drawing.Color.DarkBlue
        Me.iniciarbt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iniciarbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.iniciarbt.Location = New System.Drawing.Point(192, 153)
        Me.iniciarbt.Name = "iniciarbt"
        Me.iniciarbt.Size = New System.Drawing.Size(114, 29)
        Me.iniciarbt.TabIndex = 14
        Me.iniciarbt.Text = "Iniciar sesión"
        Me.iniciarbt.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 256)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(168, 19)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Has olvidado tu contraseña?"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtContra
        '
        Me.txtContra.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.Location = New System.Drawing.Point(12, 215)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(162, 29)
        Me.txtContra.TabIndex = 12
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(13, 154)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(162, 29)
        Me.txtUsuario.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Accede a tu cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'inicioadminbt
        '
        Me.inicioadminbt.BackColor = System.Drawing.Color.DarkBlue
        Me.inicioadminbt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicioadminbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.inicioadminbt.Location = New System.Drawing.Point(192, 233)
        Me.inicioadminbt.Name = "inicioadminbt"
        Me.inicioadminbt.Size = New System.Drawing.Size(114, 29)
        Me.inicioadminbt.TabIndex = 16
        Me.inicioadminbt.Text = "Administrador"
        Me.inicioadminbt.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "¡BIENVENIDO!"
        '
        'InicioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(327, 305)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.inicioadminbt)
        Me.Controls.Add(Me.crearcuentabt)
        Me.Controls.Add(Me.iniciarbt)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InicioForm"
        Me.Text = "Iniciar Sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents crearcuentabt As Button
    Friend WithEvents iniciarbt As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inicioadminbt As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
