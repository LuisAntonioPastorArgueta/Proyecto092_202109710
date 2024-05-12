Public Class InicioForm
    Private conexion As New ConexionSQLServer()
    Private intentosFallidos As Integer = 0 ' Variable para contar los intentos fallidos de inicio de sesión

    Private Sub iniciarbt_Click(sender As Object, e As EventArgs) Handles iniciarbt.Click
        Dim usuario As String
        Dim contrasena As String

        ' Ocultar los caracteres de la contraseña
        txtContra.PasswordChar = "*"c
        usuario = txtUsuario.Text
        contrasena = txtContra.Text
        Dim conexion As New ConexionSQLServer()

        If conexion.IniciarSesion(usuario, contrasena) Then
            MessageBox.Show("¡Bienvenido!")
            ' Si las credenciales son correctas, mostrar el formulario del menú
            MenuForm.Show()
            ' También podrías cerrar este formulario si ya no es necesario
            Me.Hide()
        End If
    End Sub

    Private Sub inicioadminbt_Click(sender As Object, e As EventArgs) Handles inicioadminbt.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContra.Text

        ' Ocultar los caracteres de la contraseña
        txtContra.UseSystemPasswordChar = True

        Dim conexion As New ConexionSQLServer()

        If conexion.Administrador(usuario, contrasena) Then
            MessageBox.Show("¡Bienvenido!")
            ' Si las credenciales son correctas, mostrar el formulario del menú de administrador
            AdminForm.Show()
            ' También podrías cerrar este formulario si ya no es necesario
            Me.Hide()
        End If
    End Sub

    Private Sub crearcuentabt_Click(sender As Object, e As EventArgs) Handles crearcuentabt.Click
        CrearUsuarioForm.Show()
    End Sub
End Class
