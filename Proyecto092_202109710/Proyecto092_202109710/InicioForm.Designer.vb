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
        Me.crearcuentabt = New System.Windows.Forms.Button()
        Me.iniciarbt = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inicioadminbt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crearcuentabt
        '
        Me.crearcuentabt.BackColor = System.Drawing.Color.DarkBlue
        Me.crearcuentabt.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crearcuentabt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.crearcuentabt.Location = New System.Drawing.Point(189, 253)
        Me.crearcuentabt.Name = "crearcuentabt"
        Me.crearcuentabt.Size = New System.Drawing.Size(92, 23)
        Me.crearcuentabt.TabIndex = 15
        Me.crearcuentabt.Text = "Crear cuenta"
        Me.crearcuentabt.UseVisualStyleBackColor = False
        '
        'iniciarbt
        '
        Me.iniciarbt.BackColor = System.Drawing.Color.DarkBlue
        Me.iniciarbt.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iniciarbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.iniciarbt.Location = New System.Drawing.Point(65, 253)
        Me.iniciarbt.Name = "iniciarbt"
        Me.iniciarbt.Size = New System.Drawing.Size(101, 23)
        Me.iniciarbt.TabIndex = 14
        Me.iniciarbt.Text = "Iniciar sesión"
        Me.iniciarbt.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.Location = New System.Drawing.Point(115, 212)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(177, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Has olvidado tu contraseña?"
        '
        'txtContra
        '
        Me.txtContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.Location = New System.Drawing.Point(65, 170)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(216, 20)
        Me.txtContra.TabIndex = 12
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(65, 112)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(216, 20)
        Me.txtUsuario.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ACCEDER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(62, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'inicioadminbt
        '
        Me.inicioadminbt.BackColor = System.Drawing.Color.DarkBlue
        Me.inicioadminbt.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicioadminbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.inicioadminbt.Location = New System.Drawing.Point(65, 282)
        Me.inicioadminbt.Name = "inicioadminbt"
        Me.inicioadminbt.Size = New System.Drawing.Size(216, 23)
        Me.inicioadminbt.TabIndex = 16
        Me.inicioadminbt.Text = "Iniciar sesión como administrador"
        Me.inicioadminbt.UseVisualStyleBackColor = False
        '
        'InicioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 359)
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
End Class
