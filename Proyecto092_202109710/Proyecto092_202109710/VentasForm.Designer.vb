<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm
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
        Me.dtpFechaCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.botRegresar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txbCantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbProveedor = New System.Windows.Forms.TextBox()
        Me.botLimpiar = New System.Windows.Forms.Button()
        Me.botEliminar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labID = New System.Windows.Forms.Label()
        Me.txbId = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.txbNombreIngrediente = New System.Windows.Forms.TextBox()
        Me.botEditar = New System.Windows.Forms.Button()
        Me.botAgregar = New System.Windows.Forms.Button()
        Me.txbNotas = New System.Windows.Forms.TextBox()
        Me.txbUnidadMedida = New System.Windows.Forms.TextBox()
        Me.txbPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.botMostrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaCaducidad
        '
        Me.dtpFechaCaducidad.Location = New System.Drawing.Point(23, 141)
        Me.dtpFechaCaducidad.Name = "dtpFechaCaducidad"
        Me.dtpFechaCaducidad.Size = New System.Drawing.Size(119, 20)
        Me.dtpFechaCaducidad.TabIndex = 77
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(862, 150)
        Me.DataGridView1.TabIndex = 76
        '
        'botRegresar
        '
        Me.botRegresar.BackColor = System.Drawing.Color.Crimson
        Me.botRegresar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botRegresar.Location = New System.Drawing.Point(555, 190)
        Me.botRegresar.Name = "botRegresar"
        Me.botRegresar.Size = New System.Drawing.Size(121, 26)
        Me.botRegresar.TabIndex = 75
        Me.botRegresar.Text = "Regresar a Menú"
        Me.botRegresar.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(178, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(38, 14)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "Notas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(177, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 14)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Precio unitario"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(177, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 14)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Cantidad"
        '
        'txbCantidad
        '
        Me.txbCantidad.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCantidad.Location = New System.Drawing.Point(177, 79)
        Me.txbCantidad.Name = "txbCantidad"
        Me.txbCantidad.Size = New System.Drawing.Size(112, 22)
        Me.txbCantidad.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 14)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Proveedor"
        '
        'txbProveedor
        '
        Me.txbProveedor.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbProveedor.Location = New System.Drawing.Point(312, 139)
        Me.txbProveedor.Name = "txbProveedor"
        Me.txbProveedor.Size = New System.Drawing.Size(201, 22)
        Me.txbProveedor.TabIndex = 67
        '
        'botLimpiar
        '
        Me.botLimpiar.BackColor = System.Drawing.Color.Crimson
        Me.botLimpiar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botLimpiar.Location = New System.Drawing.Point(555, 161)
        Me.botLimpiar.Name = "botLimpiar"
        Me.botLimpiar.Size = New System.Drawing.Size(121, 26)
        Me.botLimpiar.TabIndex = 66
        Me.botLimpiar.Text = "Limpiar"
        Me.botLimpiar.UseVisualStyleBackColor = False
        '
        'botEliminar
        '
        Me.botEliminar.BackColor = System.Drawing.Color.Crimson
        Me.botEliminar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botEliminar.Location = New System.Drawing.Point(555, 132)
        Me.botEliminar.Name = "botEliminar"
        Me.botEliminar.Size = New System.Drawing.Size(121, 26)
        Me.botEliminar.TabIndex = 65
        Me.botEliminar.Text = "Eliminar"
        Me.botEliminar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(312, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 14)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Unidad de medida"
        '
        'labID
        '
        Me.labID.AutoSize = True
        Me.labID.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labID.Location = New System.Drawing.Point(51, 19)
        Me.labID.Name = "labID"
        Me.labID.Size = New System.Drawing.Size(0, 14)
        Me.labID.TabIndex = 63
        '
        'txbId
        '
        Me.txbId.AutoSize = True
        Me.txbId.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbId.Location = New System.Drawing.Point(23, 19)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(22, 14)
        Me.txbId.TabIndex = 62
        Me.txbId.Text = "ID:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(116, 14)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Teléfono proveedor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 14)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Fecha caducidad"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 14)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Nombre Ingrediente"
        '
        'txbTelefonoProveedor
        '
        Me.txbTelefonoProveedor.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefonoProveedor.Location = New System.Drawing.Point(23, 197)
        Me.txbTelefonoProveedor.Name = "txbTelefonoProveedor"
        Me.txbTelefonoProveedor.Size = New System.Drawing.Size(119, 22)
        Me.txbTelefonoProveedor.TabIndex = 58
        '
        'txbNombreIngrediente
        '
        Me.txbNombreIngrediente.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombreIngrediente.Location = New System.Drawing.Point(23, 79)
        Me.txbNombreIngrediente.Name = "txbNombreIngrediente"
        Me.txbNombreIngrediente.Size = New System.Drawing.Size(119, 22)
        Me.txbNombreIngrediente.TabIndex = 57
        '
        'botEditar
        '
        Me.botEditar.BackColor = System.Drawing.Color.Crimson
        Me.botEditar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botEditar.Location = New System.Drawing.Point(555, 102)
        Me.botEditar.Name = "botEditar"
        Me.botEditar.Size = New System.Drawing.Size(121, 26)
        Me.botEditar.TabIndex = 56
        Me.botEditar.Text = "Editar"
        Me.botEditar.UseVisualStyleBackColor = False
        '
        'botAgregar
        '
        Me.botAgregar.BackColor = System.Drawing.Color.Crimson
        Me.botAgregar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botAgregar.Location = New System.Drawing.Point(555, 73)
        Me.botAgregar.Name = "botAgregar"
        Me.botAgregar.Size = New System.Drawing.Size(121, 26)
        Me.botAgregar.TabIndex = 55
        Me.botAgregar.Text = "Agregar"
        Me.botAgregar.UseVisualStyleBackColor = False
        '
        'txbNotas
        '
        Me.txbNotas.Location = New System.Drawing.Point(176, 199)
        Me.txbNotas.Name = "txbNotas"
        Me.txbNotas.Size = New System.Drawing.Size(337, 20)
        Me.txbNotas.TabIndex = 54
        '
        'txbUnidadMedida
        '
        Me.txbUnidadMedida.Location = New System.Drawing.Point(312, 79)
        Me.txbUnidadMedida.Name = "txbUnidadMedida"
        Me.txbUnidadMedida.Size = New System.Drawing.Size(201, 20)
        Me.txbUnidadMedida.TabIndex = 53
        '
        'txbPrecioUnitario
        '
        Me.txbPrecioUnitario.Location = New System.Drawing.Point(176, 141)
        Me.txbPrecioUnitario.Name = "txbPrecioUnitario"
        Me.txbPrecioUnitario.Size = New System.Drawing.Size(113, 20)
        Me.txbPrecioUnitario.TabIndex = 52
        '
        'botMostrar
        '
        Me.botMostrar.BackColor = System.Drawing.Color.Crimson
        Me.botMostrar.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.botMostrar.Location = New System.Drawing.Point(555, 46)
        Me.botMostrar.Name = "botMostrar"
        Me.botMostrar.Size = New System.Drawing.Size(121, 26)
        Me.botMostrar.TabIndex = 78
        Me.botMostrar.Text = "Mostrar "
        Me.botMostrar.UseVisualStyleBackColor = False
        '
        'VentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 450)
        Me.Controls.Add(Me.botMostrar)
        Me.Controls.Add(Me.dtpFechaCaducidad)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.botRegresar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txbCantidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txbProveedor)
        Me.Controls.Add(Me.botLimpiar)
        Me.Controls.Add(Me.botEliminar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.labID)
        Me.Controls.Add(Me.txbId)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txbTelefonoProveedor)
        Me.Controls.Add(Me.txbNombreIngrediente)
        Me.Controls.Add(Me.botEditar)
        Me.Controls.Add(Me.botAgregar)
        Me.Controls.Add(Me.txbNotas)
        Me.Controls.Add(Me.txbUnidadMedida)
        Me.Controls.Add(Me.txbPrecioUnitario)
        Me.Name = "VentasForm"
        Me.Text = "VentasForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaCaducidad As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents botRegresar As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txbCantidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txbProveedor As TextBox
    Friend WithEvents botLimpiar As Button
    Friend WithEvents botEliminar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents labID As Label
    Friend WithEvents txbId As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txbTelefonoProveedor As TextBox
    Friend WithEvents txbNombreIngrediente As TextBox
    Friend WithEvents botEditar As Button
    Friend WithEvents botAgregar As Button
    Friend WithEvents txbNotas As TextBox
    Friend WithEvents txbUnidadMedida As TextBox
    Friend WithEvents txbPrecioUnitario As TextBox
    Friend WithEvents botMostrar As Button
End Class
