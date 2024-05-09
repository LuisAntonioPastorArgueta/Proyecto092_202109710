Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AdminUsuarioForm
    Inherits Form

    Private Sub botEliminar_Click(sender As Object, e As EventArgs) Handles botEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer
        Dim idUsuario As Integer
        Dim usuarios As ConexionSQLServer

        If Not DataGridView1.CurrentRow Is Nothing Then
            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            idUsuario = CInt(DataGridView1(0, NumeroDeFilaSeleccionada).Value.ToString())

            usuarios = New ConexionSQLServer
            usuarios.EliminarUsuario(idUsuario)

            MessageBox.Show("Usuario eliminado satisfactoriamente.")

            ActualizarTabla()
        Else
            MessageBox.Show("Selecciona una fila para eliminar.")
        End If
    End Sub

    Private Sub botLimpiar_Click(sender As Object, e As EventArgs) Handles botLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
    End Sub

    Private Sub ActualizarTabla()
        Dim usuarios As ConexionSQLServer
        usuarios = New ConexionSQLServer
        DataGridView1.DataSource = usuarios.ObtenerUsuarios()
    End Sub



    Private Sub botEditar_Click(sender As Object, e As EventArgs) Handles botEditar.Click
        Dim NumeroDeFilaSeleccionada As Integer
        Dim idUsuario As Integer
        Dim usuarios As ConexionSQLServer

        If Not DataGridView1.CurrentRow Is Nothing Then
            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            idUsuario = CInt(DataGridView1(0, NumeroDeFilaSeleccionada).Value.ToString())

            ' Obtener los datos actualizados de los campos
            Dim nombre As String = txbNombre.Text.Trim()
            Dim apellido As String = txbApellido.Text.Trim()
            Dim dpi As String = txbDPI.Text.Trim()
            Dim fechaNacimiento As Date = Convert.ToDateTime(dtpFechaNacimiento.Value)
            Dim telefono As String = txbTelefono.Text.Trim()
            Dim usuario As String = txbUsuario.Text.Trim()
            Dim correoElectronico As String = txbCorreoElectronico.Text.Trim()
            Dim contraseña As String = txbContraseña.Text.Trim()
            Dim estadoCuenta As String = "Activo"
            Dim rol As String = "Normal"


            usuarios = New ConexionSQLServer
            usuarios.ActualizarUsuario(idUsuario, nombre, apellido, dpi, fechaNacimiento, telefono, usuario, correoElectronico, contraseña, rol, estadoCuenta)

            MessageBox.Show("Usuario actualizado correctamente")
            ActualizarTabla()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim NumeroDeFilaSeleccionada As Integer

        If Not DataGridView1.CurrentRow Is Nothing Then
            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            LbID.Text = DataGridView1(0, NumeroDeFilaSeleccionada).Value.ToString()
            txbNombre.Text = DataGridView1(1, NumeroDeFilaSeleccionada).Value.ToString()
            txbApellido.Text = DataGridView1(2, NumeroDeFilaSeleccionada).Value.ToString()
            txbDPI.Text = DataGridView1(3, NumeroDeFilaSeleccionada).Value.ToString()
            dtpFechaNacimiento.Value = Convert.ToDateTime(DataGridView1(4, NumeroDeFilaSeleccionada).Value)
            txbTelefono.Text = DataGridView1(5, NumeroDeFilaSeleccionada).Value.ToString()
            txbUsuario.Text = DataGridView1(6, NumeroDeFilaSeleccionada).Value.ToString()
            txbCorreoElectronico.Text = DataGridView1(7, NumeroDeFilaSeleccionada).Value.ToString()
            txbContraseña.Text = DataGridView1(8, NumeroDeFilaSeleccionada).Value.ToString()

        Else
            MessageBox.Show("Selecciona una fila")
        End If
    End Sub

    Private Sub LimpiarCampos()
        ' Limpiar todos los campos del formulario
        txbNombre.Text = ""
        txbApellido.Text = ""
        txbDPI.Text = ""
        dtpFechaNacimiento.Value = DateTime.Now
        txbTelefono.Text = ""
        txbUsuario.Text = ""
        txbCorreoElectronico.Text = ""
        txbContraseña.Text = ""
    End Sub

    Private Sub botAgregar_Click(sender As Object, e As EventArgs) Handles botAgregar.Click

    End Sub
End Class
