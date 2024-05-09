Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Public Class ConexionSQLServer
    Private connectionString As String
    Private connection As SqlConnection

    Public Sub New()
        ' Configurar la cadena de conexión para Windows Authentication en localhost
        connectionString = "Data Source=LAPTOP-LP\SQLEXPRESS;Initial Catalog=Proyecto092;Integrated Security=True"
        connection = New SqlConnection(connectionString)
    End Sub
    Public Function IniciarSesion(usuario As String, contraseña As String) As Boolean
        Dim usuarioRegistrado As Boolean = False
        Dim cuentaActiva As Boolean = False

        Try
            connection.Open()

            ' Consulta SQL para verificar el usuario y la contraseña
            Dim query As String = "SELECT EstadoCuenta FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.Parameters.AddWithValue("@Contraseña", contraseña)
                Dim estadoCuenta As String = Convert.ToString(command.ExecuteScalar())

                If estadoCuenta IsNot Nothing Then
                    usuarioRegistrado = True
                    If estadoCuenta = "Activo" Then
                        cuentaActiva = True
                    End If
                End If
            End Using
        Catch ex As SqlException
            MessageBox.Show("Error de SQL al iniciar sesión: " & ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        ' Devolver verdadero solo si el usuario está registrado y la cuenta está activa
        Return usuarioRegistrado AndAlso cuentaActiva
    End Function

    Public Function UsuarioBloqueado(usuario As String) As Boolean
        Dim bloqueado As Boolean = False

        Try
            connection.Open()

            ' Consulta SQL para verificar si el usuario está bloqueado
            Dim query As String = "SELECT EstadoCuenta FROM Usuarios WHERE Usuario = @Usuario"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Usuario", usuario)
                Dim estadoCuenta As String = Convert.ToString(command.ExecuteScalar())

                If estadoCuenta IsNot Nothing AndAlso estadoCuenta = "Bloqueado" Then
                    bloqueado = True
                End If
            End Using
        Catch ex As SqlException
            MessageBox.Show("Error de SQL al verificar si el usuario está bloqueado: " & ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al verificar si el usuario está bloqueado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        Return bloqueado
    End Function

    Public Function UsuarioRegistrado(usuario As String) As Boolean
        Dim registrado As Boolean = False

        Try
            connection.Open()

            ' Consulta SQL para verificar si el usuario está registrado
            Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Usuario", usuario)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    registrado = True
                End If
            End Using
        Catch ex As SqlException
            MessageBox.Show("Error de SQL al verificar si el usuario está registrado: " & ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al verificar si el usuario está registrado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        Return registrado
    End Function


    Public Function ObtenerCorreoElectronico(usuario As String) As String
        Dim correoElectronico As String = ""
        Try
            connection.Open()
            Dim query As String = "SELECT CorreoElectronico FROM Usuarios WHERE Usuario = @Usuario"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Usuario", usuario)
            correoElectronico = Convert.ToString(command.ExecuteScalar())
        Catch ex As Exception
            Console.WriteLine("Error al obtener la dirección de correo electrónico: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return correoElectronico
    End Function

    Public Sub EnviarCorreoElectronico(correoElectronico As String)
        Try
            Dim fromAddress As New MailAddress("luis2003pastor@gmail.com", "Luis Pastor")
            Dim toAddress As New MailAddress(correoElectronico)
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New NetworkCredential("luis2003pastor@gmail.com", "WICHO/pastor")
            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = "Cuenta Bloqueada"
            message.Body = "Tu cuenta ha sido bloqueada debido a múltiples intentos de inicio de sesión fallidos."
            smtp.Send(message)
            MessageBox.Show("Se ha enviado un correo electrónico de bloqueo a la dirección registrada.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo electrónico: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BloquearCuenta(usuario As String)
        Try
            connection.Open()
            Dim query As String = "UPDATE Usuarios SET EstadoCuenta = 'Bloqueado' WHERE Usuario = @Usuario"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error al bloquear la cuenta: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function ObtenerRolUsuario(usuario As String) As String
        Dim rol As String = ""
        Try
            connection.Open()
            Dim query As String = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Usuario", usuario)
            rol = Convert.ToString(command.ExecuteScalar())
        Catch ex As Exception
            Console.WriteLine("Error al obtener el rol del usuario: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return rol
    End Function

    Public Sub InsertarUsuario(nombre As String, apellido As String, dpi As String, fechaNacimiento As Date, telefono As String, usuario As String, correoElectronico As String, contraseña As String, rol As String, estadoCuenta As String)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Usuarios (Nombre, Apellido, DPI, FechaNacimiento, Teléfono, Usuario, CorreoElectronico, Contraseña, Rol, EstadoCuenta) VALUES (@Nombre, @Apellido, @DPI, @FechaNacimiento, @Teléfono, @Usuario, @CorreoElectronico, @Contraseña, @Rol, @EstadoCuenta)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Apellido", apellido)
            command.Parameters.AddWithValue("@DPI", dpi)
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
            command.Parameters.AddWithValue("@Teléfono", telefono)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico)
            command.Parameters.AddWithValue("@Contraseña", contraseña)
            command.Parameters.AddWithValue("@Rol", rol)
            command.Parameters.AddWithValue("@EstadoCuenta", estadoCuenta)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error al insertar el usuario: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub ActualizarUsuario(id As Integer, nombre As String, apellido As String, dpi As String, fechaNacimiento As Date, telefono As String, usuario As String, correoElectronico As String, contraseña As String, rol As String, estadoCuenta As String)
        Try
            connection.Open()
            Dim query As String = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, DPI = @DPI, FechaNacimiento = @FechaNacimiento, Teléfono = @Teléfono, Usuario = @Usuario, CorreoElectronico = @CorreoElectronico, Contraseña = @Contraseña, Rol = @Rol, EstadoCuenta = @EstadoCuenta WHERE ID = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Apellido", apellido)
            command.Parameters.AddWithValue("@DPI", dpi)
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
            command.Parameters.AddWithValue("@Teléfono", telefono)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico)
            command.Parameters.AddWithValue("@Contraseña", contraseña)
            command.Parameters.AddWithValue("@Rol", rol)
            command.Parameters.AddWithValue("@EstadoCuenta", estadoCuenta)
            command.Parameters.AddWithValue("@ID", id)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error al actualizar el usuario: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub EliminarUsuario(id As Integer)
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Usuarios WHERE ID = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", id)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error al eliminar el usuario: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function ObtenerUsuarios() As DataTable
        Dim dataTable As New DataTable()
        Try
            connection.Open()
            Dim query As String = "SELECT ID, Nombre, Apellido, DPI, FechaNacimiento, Teléfono, Usuario, CorreoElectronico, Contraseña, Rol, EstadoCuenta FROM Usuarios"
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(dataTable)
        Catch ex As Exception
            Console.WriteLine("Error al obtener los usuarios: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return dataTable
    End Function
End Class