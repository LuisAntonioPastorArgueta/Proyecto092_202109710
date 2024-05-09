<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsuarioForm
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
        Me.txbDPI = New System.Windows.Forms.TextBox()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.txbCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbCantidad = New System.Windows.Forms.TextBox()
        Me.txbContraseña = New System.Windows.Forms.TextBox()
        Me.botLimpiar = New System.Windows.Forms.Button()
        Me.botEliminar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labID = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.botEditar = New System.Windows.Forms.Button()
        Me.botAgregar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txbApellido = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.botRegresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbDPI
        '
        Me.txbDPI.Location = New System.Drawing.Point(175, 131)
        Me.txbDPI.Name = "txbDPI"
        Me.txbDPI.Size = New System.Drawing.Size(113, 20)
        Me.txbDPI.TabIndex = 9
        '
        'txbUsuario
        '
        Me.txbUsuario.Location = New System.Drawing.Point(311, 69)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(136, 20)
        Me.txbUsuario.TabIndex = 15
        '
        'txbCorreoElectronico
        '
        Me.txbCorreoElectronico.Location = New System.Drawing.Point(175, 189)
        Me.txbCorreoElectronico.Name = "txbCorreoElectronico"
        Me.txbCorreoElectronico.Size = New System.Drawing.Size(109, 20)
        Me.txbCorreoElectronico.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(311, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 14)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Contraseña"
        '
        'txbCantidad
        '
        Me.txbCantidad.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCantidad.Location = New System.Drawing.Point(311, 187)
        Me.txbCantidad.Name = "txbCantidad"
        Me.txbCantidad.Size = New System.Drawing.Size(139, 22)
        Me.txbCantidad.TabIndex = 38
        '
        'txbContraseña
        '
        Me.txbContraseña.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbContraseña.Location = New System.Drawing.Point(311, 129)
        Me.txbContraseña.Name = "txbContraseña"
        Me.txbContraseña.Size = New System.Drawing.Size(139, 22)
        Me.txbContraseña.TabIndex = 37
        '
        'botLimpiar
        '
        Me.botLimpiar.BackColor = System.Drawing.Color.Navy
        Me.botLimpiar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botLimpiar.Location = New System.Drawing.Point(510, 154)
        Me.botLimpiar.Name = "botLimpiar"
        Me.botLimpiar.Size = New System.Drawing.Size(121, 26)
        Me.botLimpiar.TabIndex = 36
        Me.botLimpiar.Text = "Limpiar"
        Me.botLimpiar.UseVisualStyleBackColor = False
        '
        'botEliminar
        '
        Me.botEliminar.BackColor = System.Drawing.Color.Navy
        Me.botEliminar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botEliminar.Location = New System.Drawing.Point(510, 125)
        Me.botEliminar.Name = "botEliminar"
        Me.botEliminar.Size = New System.Drawing.Size(121, 26)
        Me.botEliminar.TabIndex = 35
        Me.botEliminar.Text = "Eliminar"
        Me.botEliminar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 14)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Nombre de Usuario"
        '
        'labID
        '
        Me.labID.AutoSize = True
        Me.labID.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labID.Location = New System.Drawing.Point(50, 9)
        Me.labID.Name = "labID"
        Me.labID.Size = New System.Drawing.Size(0, 14)
        Me.labID.TabIndex = 32
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbID.Location = New System.Drawing.Point(22, 9)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(22, 14)
        Me.LbID.TabIndex = 31
        Me.LbID.Text = "ID:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(55, 14)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Teléfono"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 14)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Fecha de nacimiento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 14)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Nombre"
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(22, 187)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(119, 22)
        Me.txbTelefono.TabIndex = 27
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(22, 69)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(119, 22)
        Me.txbNombre.TabIndex = 25
        '
        'botEditar
        '
        Me.botEditar.BackColor = System.Drawing.Color.Navy
        Me.botEditar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botEditar.Location = New System.Drawing.Point(510, 95)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Size = New System.Drawing.Size(121, 26)
        Me.botEditar.TabIndex = 24
        Me.botEditar.Text = "Editar"
        Me.botEditar.UseVisualStyleBackColor = False
        '
        'botAgregar
        '
        Me.botAgregar.BackColor = System.Drawing.Color.Navy
        Me.botAgregar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botAgregar.Location = New System.Drawing.Point(510, 66)
        Me.botAgregar.Name = "botAgregar"
        Me.botAgregar.Size = New System.Drawing.Size(121, 26)
        Me.botAgregar.TabIndex = 23
        Me.botAgregar.Text = "Crear Usuario"
        Me.botAgregar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(176, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 14)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Apellido"
        '
        'txbApellido
        '
        Me.txbApellido.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbApellido.Location = New System.Drawing.Point(176, 69)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(112, 22)
        Me.txbApellido.TabIndex = 41
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(176, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 14)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "DPI"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(177, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(112, 14)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Correo electrónico"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(311, 170)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(130, 14)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Confirmar Contraseña"
        '
        'botRegresar
        '
        Me.botRegresar.BackColor = System.Drawing.Color.Navy
        Me.botRegresar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botRegresar.Location = New System.Drawing.Point(510, 183)
        Me.botRegresar.Name = "botRegresar"
        Me.botRegresar.Size = New System.Drawing.Size(121, 26)
        Me.botRegresar.TabIndex = 47
        Me.botRegresar.Text = "Regresar a Inicio"
        Me.botRegresar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(681, 150)
        Me.DataGridView1.TabIndex = 48
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(22, 131)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(119, 20)
        Me.dtpFechaNacimiento.TabIndex = 49
        '
        'AdminUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 402)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.botRegresar)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txbCantidad)
        Me.Controls.Add(Me.txbContraseña)
        Me.Controls.Add(Me.botLimpiar)
        Me.Controls.Add(Me.botEliminar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.labID)
        Me.Controls.Add(Me.LbID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.botEditar)
        Me.Controls.Add(Me.botAgregar)
        Me.Controls.Add(Me.txbCorreoElectronico)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.txbDPI)
        Me.Name = "AdminUsuarioForm"
        Me.Text = "Pizzeria - Inicio de Sesión"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbDPI As TextBox
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txbCorreoElectronico As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txbCantidad As TextBox
    Friend WithEvents txbContraseña As TextBox
    Friend WithEvents botLimpiar As Button
    Friend WithEvents botEliminar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents labID As Label
    Friend WithEvents LbID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents botEditar As Button
    Friend WithEvents botAgregar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txbApellido As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents botRegresar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
End Class
