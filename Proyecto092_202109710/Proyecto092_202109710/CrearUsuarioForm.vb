Imports System.Text.RegularExpressions

Public Class CrearUsuarioForm
    Private Sub botAgregar_Click(sender As Object, e As EventArgs) Handles botAgregar.Click
        Try
            Dim nombre As String = txbNombre.Text.Trim()
            Dim apellido As String = txbApellido.Text.Trim()
            Dim dpi As String = txbDPI.Text.Trim()
            Dim telefono As String = txbTelefono.Text.Trim()
            Dim fechaNacimiento As Date = dtpFechaNacimiento.Value
            Dim usuario As String = txbUsuario.Text.Trim()
            Dim correoElectronico As String = txbCorreoElectronico.Text.Trim()
            Dim contrasena As String = txbContrasena.Text.Trim()
            Dim rol As String = "Normal"
            Dim estadoCuenta As String = "Activo" ' Por defecto, nuevo usuario activo
            Dim id As Integer = "2"


            ' Validar que ningún campo esté en blanco
            If nombre = "" OrElse apellido = "" OrElse dpi = "" OrElse telefono = "" OrElse usuario = "" OrElse correoElectronico = "" OrElse contrasena = "" OrElse rol = "" Then
                Throw New ArgumentException("Por favor, completa todos los campos.")
            End If

            ' Verificar si la contraseña coincide con la verificación de contraseña
            If Not contrasena.Equals(txbVerificarContrasena.Text.Trim()) Then
                Throw New ArgumentException("La contraseña y la verificación de contraseña no coinciden.")
            End If

            ' Verificar si el usuario ya existe
            Dim usuarios As New ConexionSQLServer()
            If usuarios.UsuarioRegistrado(usuario) Then
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro nombre de usuario.", "Nombre de usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validar que el nombre y el apellido contengan solo letras
            If Not Regex.IsMatch(nombre, "^[a-zA-Z]+$") Then
                Throw New ArgumentException("El nombre solo debe contener letras.")
            End If

            If Not Regex.IsMatch(apellido, "^[a-zA-Z]+$") Then
                Throw New ArgumentException("El apellido solo debe contener letras.")
            End If

            ' Validar que el DPI y el teléfono contengan solo números
            If Not IsNumeric(dpi) Then
                Throw New ArgumentException("El DPI debe contener solo números.")
            End If

            If Not IsNumeric(telefono) Then
                Throw New ArgumentException("El teléfono debe contener solo números.")
            End If

            ' Insertar el nuevo usuario en la base de datos
            usuarios.InsertarUsuario(id, nombre, apellido, dpi, fechaNacimiento, telefono, usuario, correoElectronico, contrasena, rol, estadoCuenta)

            ' Limpiar los campos después de agregar un nuevo usuario
            LimpiarCampos()

            ' Mostrar mensaje de éxito
            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As FormatException
            MessageBox.Show("Error de formato. Asegúrate de ingresar valores válidos en los campos correspondientes.")
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al agregar el usuario: " & ex.Message)
        End Try
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
        txbContrasena.Text = ""
        txbVerificarContrasena.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InicioForm.Show()
        Me.Hide()
    End Sub
End Class
