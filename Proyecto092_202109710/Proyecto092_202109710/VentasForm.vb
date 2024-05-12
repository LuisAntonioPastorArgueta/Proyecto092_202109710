Public Class VentasForm
    Private Sub botEliminar_Click(sender As Object, e As EventArgs) Handles botEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer
        Dim idInventario As Integer
        Dim inventario As ConexionSQLServer

        If Not DataGridView1.CurrentRow Is Nothing Then
            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            idInventario = CInt(DataGridView1(0, NumeroDeFilaSeleccionada).Value.ToString())

            inventario = New ConexionSQLServer
            inventario.EliminarInventario(idInventario)

            MessageBox.Show("Registro eliminado satisfactoriamente.")

            ActualizarTabla()
        Else
            MessageBox.Show("Selecciona una fila para eliminar.")
        End If
    End Sub

    Private Sub botLimpiar_Click(sender As Object, e As EventArgs) Handles botLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub ActualizarTabla()
        Dim inventario As ConexionSQLServer
        inventario = New ConexionSQLServer
        DataGridView1.DataSource = inventario.ObtenerInventario()
    End Sub

    Private Sub botEditar_Click(sender As Object, e As EventArgs) Handles botEditar.Click
        Try
            Dim NumeroDeFilaSeleccionada As Integer
            Dim idInventario As Integer
            Dim inventario As ConexionSQLServer

            If DataGridView1.CurrentRow Is Nothing Then
                MessageBox.Show("Selecciona una fila para editar.")
                Return
            End If

            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            idInventario = CInt(DataGridView1(0, NumeroDeFilaSeleccionada).Value.ToString())

            ' Obtener los datos actualizados de los campos
            Dim nombreIngrediente As String = txbNombreIngrediente.Text.Trim()
            Dim cantidad As Integer = Integer.Parse(txbCantidad.Text)
            Dim unidadMedida As String = txbUnidadMedida.Text.Trim()
            Dim precioUnitario As Decimal = Decimal.Parse(txbPrecioUnitario.Text)
            Dim proveedor As String = txbProveedor.Text.Trim()
            Dim telefonoProveedor As String = txbTelefonoProveedor.Text.Trim()
            Dim fechaCaducidad As Date = dtpFechaCaducidad.Value
            Dim notas As String = txbNotas.Text.Trim()

            inventario = New ConexionSQLServer
            inventario.ActualizarInventario(idInventario, nombreIngrediente, cantidad, unidadMedida, precioUnitario, proveedor, telefonoProveedor, fechaCaducidad, notas)

            MessageBox.Show("Registro actualizado correctamente")
            ActualizarTabla() ' Asegúrate de actualizar la tabla después de editar el registro
        Catch ex As FormatException
            MessageBox.Show("Error de formato. Asegúrate de ingresar valores válidos en los campos correspondientes.")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el registro: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim NumeroDeFilaSeleccionada As Integer = e.RowIndex

        If NumeroDeFilaSeleccionada >= 0 AndAlso NumeroDeFilaSeleccionada < DataGridView1.Rows.Count Then
            ' Asigna los valores de la fila seleccionada a los TextBox correspondientes
            txbId.Text = DataGridView1(0, NumeroDeFilaSeleccionada).Value.ToString()
            txbNombreIngrediente.Text = DataGridView1(1, NumeroDeFilaSeleccionada).Value.ToString()
            txbCantidad.Text = DataGridView1(2, NumeroDeFilaSeleccionada).Value.ToString()
            txbUnidadMedida.Text = DataGridView1(3, NumeroDeFilaSeleccionada).Value.ToString()
            txbPrecioUnitario.Text = DataGridView1(4, NumeroDeFilaSeleccionada).Value.ToString()
            txbProveedor.Text = DataGridView1(5, NumeroDeFilaSeleccionada).Value.ToString()
            txbTelefonoProveedor.Text = DataGridView1(6, NumeroDeFilaSeleccionada).Value.ToString()
            dtpFechaCaducidad.Value = Convert.ToDateTime(DataGridView1(7, NumeroDeFilaSeleccionada).Value)
            txbNotas.Text = DataGridView1(8, NumeroDeFilaSeleccionada).Value.ToString()
        Else
            MessageBox.Show("Selecciona una fila válida")
        End If
    End Sub

    Private Sub LimpiarCampos()
        ' Limpia todos los campos del formulario
        txbId.Text = ""
        txbNombreIngrediente.Text = ""
        txbCantidad.Text = ""
        txbUnidadMedida.Text = ""
        txbPrecioUnitario.Text = ""
        txbProveedor.Text = ""
        txbTelefonoProveedor.Text = ""
        dtpFechaCaducidad.Value = DateTime.Now
        txbNotas.Text = ""
    End Sub

    Private Sub botRegresar_Click(sender As Object, e As EventArgs) Handles botRegresar.Click
        MenuForm.Show()
    End Sub

    Private Sub botMostrar_Click_1(sender As Object, e As EventArgs) Handles botMostrar.Click
        ActualizarTabla()
    End Sub

    Private Sub botAgregar_Click(sender As Object, e As EventArgs) Handles botAgregar.Click
        Try
            ' Obtener los datos ingresados en los campos de texto
            Dim nombreIngrediente As String = txbNombreIngrediente.Text.Trim()
            Dim cantidad As Integer = Integer.Parse(txbCantidad.Text)
            Dim unidadMedida As String = txbUnidadMedida.Text.Trim()
            Dim precioUnitario As Decimal = Decimal.Parse(txbPrecioUnitario.Text)
            Dim proveedor As String = txbProveedor.Text.Trim()
            Dim telefonoProveedor As String = txbTelefonoProveedor.Text.Trim()
            Dim fechaCaducidad As Date = dtpFechaCaducidad.Value
            Dim notas As String = txbNotas.Text.Trim()

            ' Instanciar la clase ConexionSQLServer
            Dim inventario As ConexionSQLServer = New ConexionSQLServer()

            ' Llamar a la función para agregar un nuevo registro al inventario
            inventario.AgregarInventario(nombreIngrediente, cantidad, unidadMedida, precioUnitario, proveedor, telefonoProveedor, fechaCaducidad, notas)

            ' Actualizar la tabla después de agregar el nuevo registro
            ActualizarTabla()

            ' Mostrar mensaje de éxito
            MessageBox.Show("Registro agregado correctamente")
        Catch ex As FormatException
            MessageBox.Show("Error de formato. Asegúrate de ingresar valores válidos en los campos correspondientes.")
        Catch ex As Exception
            MessageBox.Show("Error al agregar el registro: " & ex.Message)
        End Try
    End Sub

End Class