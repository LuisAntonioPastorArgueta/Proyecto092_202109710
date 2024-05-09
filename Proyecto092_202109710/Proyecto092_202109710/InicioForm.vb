Public Class InicioForm
    Private conexion As New ConexionSQLServer()
    Private intentosFallidos As Integer = 0 ' Variable para contar los intentos fallidos de inicio de sesión

    Private Sub iniciarbt_Click(sender As Object, e As EventArgs) Handles iniciarbt.Click
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contraseña As String = txtContra.Text.Trim()

        Try
            ' Verificar campos vacíos
            If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) Then
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener el número de intentos restantes
            Dim intentosRestantes As Integer = 2 - intentosFallidos

            ' Crear una instancia de la clase ConexionSQLServer
            Dim conexion As New ConexionSQLServer()

            ' Verificar el inicio de sesión utilizando la función IniciarSesion
            If conexion.IniciarSesion(usuario, contraseña) Then
                MessageBox.Show("Inicio de sesión exitoso")
                MenuForm.Show()
                Me.Hide()
                ' Restablecer el contador de intentos fallidos después de un inicio de sesión exitoso
                intentosFallidos = 0
            Else
                If conexion.UsuarioBloqueado(usuario) Then
                    MessageBox.Show("La cuenta está bloqueada. Por favor, comuníquese con el administrador.", "Cuenta Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf conexion.UsuarioRegistrado(usuario) Then
                    MessageBox.Show("Contraseña incorrecta. Intentos restantes: " & intentosRestantes.ToString(), "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    intentosFallidos += 1
                    If intentosFallidos = 3 Then
                        conexion.BloquearCuenta(usuario)
                        Dim correoElectronico As String = conexion.ObtenerCorreoElectronico(usuario)
                        If Not String.IsNullOrEmpty(correoElectronico) Then
                            conexion.EnviarCorreoElectronico(correoElectronico)
                            MessageBox.Show("Se ha enviado un correo electrónico de bloqueo a la dirección registrada.", "Cuenta Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Usuario no registrado. Si no tienes una cuenta, créala.", "Crear Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub crearcuentabt_Click(sender As Object, e As EventArgs) Handles crearcuentabt.Click
        CrearUsuarioForm.Show()
        Me.Hide()
    End Sub

    Private Sub inicioadminbt_Click(sender As Object, e As EventArgs) Handles inicioadminbt.Click
        Dim usuario As String = txtUsuario.Text.Trim() ' Obtener el nombre de usuario ingresado
        Try
            ' Verificar el rol del usuario
            Dim rol As String = conexion.ObtenerRolUsuario(usuario)
            If rol = "Administrador" Then
                ' Mostrar el formulario del menú para el usuario administrador
                MenuForm.Show()
                Me.Hide()
            Else
                ' Mostrar un mensaje de acceso denegado si el usuario no es administrador
                MessageBox.Show("Acceso denegado. Debes ser un administrador para acceder a esta función.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al verificar el rol del usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
