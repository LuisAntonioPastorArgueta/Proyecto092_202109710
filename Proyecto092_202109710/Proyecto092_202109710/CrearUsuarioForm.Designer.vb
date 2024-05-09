<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuarioForm
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
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txbApellido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbVerificarContraseña = New System.Windows.Forms.TextBox()
        Me.txbContraseña = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.botAgregar = New System.Windows.Forms.Button()
        Me.txbCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.txbDPI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(63, 157)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(119, 20)
        Me.dtpFechaNacimiento.TabIndex = 68
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(352, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(130, 14)
        Me.Label21.TabIndex = 67
        Me.Label21.Text = "Confirmar Contraseña"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(218, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(112, 14)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Correo electrónico"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(217, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 14)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "DPI"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(217, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 14)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Apellido"
        '
        'txbApellido
        '
        Me.txbApellido.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbApellido.Location = New System.Drawing.Point(217, 95)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(112, 22)
        Me.txbApellido.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 14)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Contraseña"
        '
        'txbVerificarContraseña
        '
        Me.txbVerificarContraseña.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbVerificarContraseña.Location = New System.Drawing.Point(352, 213)
        Me.txbVerificarContraseña.Name = "txbVerificarContraseña"
        Me.txbVerificarContraseña.Size = New System.Drawing.Size(139, 22)
        Me.txbVerificarContraseña.TabIndex = 61
        '
        'txbContraseña
        '
        Me.txbContraseña.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbContraseña.Location = New System.Drawing.Point(352, 155)
        Me.txbContraseña.Name = "txbContraseña"
        Me.txbContraseña.Size = New System.Drawing.Size(139, 22)
        Me.txbContraseña.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(352, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 14)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Nombre de Usuario"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(66, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(55, 14)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Teléfono"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(63, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 14)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Fecha de nacimiento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(63, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 14)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Nombre"
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(63, 213)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(119, 22)
        Me.txbTelefono.TabIndex = 55
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(63, 95)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(119, 22)
        Me.txbNombre.TabIndex = 54
        '
        'botAgregar
        '
        Me.botAgregar.BackColor = System.Drawing.Color.Navy
        Me.botAgregar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botAgregar.Location = New System.Drawing.Point(160, 264)
        Me.botAgregar.Name = "botAgregar"
        Me.botAgregar.Size = New System.Drawing.Size(121, 26)
        Me.botAgregar.TabIndex = 53
        Me.botAgregar.Text = "Crear Usuario"
        Me.botAgregar.UseVisualStyleBackColor = False
        '
        'txbCorreoElectronico
        '
        Me.txbCorreoElectronico.Location = New System.Drawing.Point(216, 215)
        Me.txbCorreoElectronico.Name = "txbCorreoElectronico"
        Me.txbCorreoElectronico.Size = New System.Drawing.Size(109, 20)
        Me.txbCorreoElectronico.TabIndex = 52
        '
        'txbUsuario
        '
        Me.txbUsuario.Location = New System.Drawing.Point(352, 95)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(136, 20)
        Me.txbUsuario.TabIndex = 51
        '
        'txbDPI
        '
        Me.txbDPI.Location = New System.Drawing.Point(216, 157)
        Me.txbDPI.Name = "txbDPI"
        Me.txbDPI.Size = New System.Drawing.Size(113, 20)
        Me.txbDPI.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(217, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "CREAR USUARIO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(300, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 26)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Iniciar Sesión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CrearUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(575, 332)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txbVerificarContraseña)
        Me.Controls.Add(Me.txbContraseña)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.botAgregar)
        Me.Controls.Add(Me.txbCorreoElectronico)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.txbDPI)
        Me.Name = "CrearUsuarioForm"
        Me.Text = "Crear Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txbApellido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txbVerificarContraseña As TextBox
    Friend WithEvents txbContraseña As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents botAgregar As Button
    Friend WithEvents txbCorreoElectronico As TextBox
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txbDPI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
