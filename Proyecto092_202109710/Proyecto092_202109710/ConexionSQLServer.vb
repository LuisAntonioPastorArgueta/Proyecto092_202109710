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
    Public Function IniciarSesion(usuario As String, contrasena As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"
        Dim count As Integer

        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Usuario", usuario)
            cmd.Parameters.AddWithValue("@Contrasena", contrasena)
            connection.Open()
            count = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        If count > 0 Then
            Dim queryEstado As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND EstadoCuenta = 'Activo'"
            Dim countEstado As Integer

            Using cmdEstado As New SqlCommand(queryEstado, connection)
                cmdEstado.Parameters.AddWithValue("@Usuario", usuario)
                countEstado = Convert.ToInt32(cmdEstado.ExecuteScalar())
            End Using

            If countEstado > 0 Then
                Return True
            Else
                MessageBox.Show("La cuenta de usuario no está activa. Por favor, contacte al administrador.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Public Function Administrador(usuario As String, contrasena As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"
        Dim count As Integer

        Using cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Usuario", usuario)
            cmd.Parameters.AddWithValue("@Contrasena", contrasena)
            connection.Open()
            count = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        If count > 0 Then
            Dim queryRol As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Rol = 'Admin'"
            Dim countRol As Integer

            Using cmdRol As New SqlCommand(queryRol, connection)
                cmdRol.Parameters.AddWithValue("@Usuario", usuario)
                countRol = Convert.ToInt32(cmdRol.ExecuteScalar())
            End Using

            If countRol > 0 Then
                Return True
            Else
                MessageBox.Show("No tiene permiso para acceder como administrador.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function


    Public Sub InsertarUsuario(id As Integer, nombre As String, apellido As String, dpi As String, fechaNacimiento As Date, telefono As String, usuario As String, correoElectronico As String, contrasena As String, rol As String, estadoCuenta As String)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Usuarios (ID, Nombre, Apellido, DPI, FechaNacimiento, Telefono, Usuario, CorreoElectronico, Contrasena, Rol, EstadoCuenta) VALUES (@ID, @Nombre, @Apellido, @DPI, @FechaNacimiento, @Teléfono, @Usuario, @CorreoElectronico, @Contrasena, @Rol, @EstadoCuenta)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", id)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Apellido", apellido)
            command.Parameters.AddWithValue("@DPI", dpi)
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
            command.Parameters.AddWithValue("@Teléfono", telefono)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico)
            command.Parameters.AddWithValue("@Contrasena", contrasena)
            command.Parameters.AddWithValue("@Rol", rol)
            command.Parameters.AddWithValue("@EstadoCuenta", estadoCuenta)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error al insertar el usuario: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

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

    Public Sub ActualizarUsuario(id As Integer, nombre As String, apellido As String, dpi As String, fechaNacimiento As Date, telefono As String, usuario As String, correoElectronico As String, contrasena As String, rol As String, estadoCuenta As String)
        Try
            connection.Open()
            Dim query As String = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, DPI = @DPI, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Usuario = @Usuario, CorreoElectronico = @CorreoElectronico, Rol = @Rol, EstadoCuenta = @EstadoCuenta, Contrasena = @Contrasena WHERE ID = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", id)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Apellido", apellido)
            command.Parameters.AddWithValue("@DPI", dpi)
            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
            command.Parameters.AddWithValue("@Telefono", telefono)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico)
            command.Parameters.AddWithValue("@Contrasena", contrasena)
            command.Parameters.AddWithValue("@Rol", rol)
            command.Parameters.AddWithValue("@EstadoCuenta", estadoCuenta)
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
            Dim query As String = "SELECT ID, Nombre, Apellido, DPI, FechaNacimiento, Telefono, Usuario, CorreoElectronico, Contrasena, Rol, EstadoCuenta FROM Usuarios"
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(dataTable)
        Catch ex As Exception
            Console.WriteLine("Error al obtener los usuarios: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return dataTable
    End Function

    Public Sub AgregarInventario(nombre As String, cantidad As Integer, unidadMedida As String, precioUnitario As Decimal, proveedor As String, telefonoProveedor As String, fechaCaducidad As Date, notas As String)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Inventario (NombreIngrediente, Cantidad, UnidadMedida, PrecioUnitario, Proveedor, TelefonoProveedor, FechaCaducidad, Notas) VALUES (@Nombre, @Cantidad, @UnidadMedida, @PrecioUnitario, @Proveedor, @TelefonoProveedor, @FechaCaducidad, @Notas)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@UnidadMedida", unidadMedida)
            command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
            command.Parameters.AddWithValue("@Proveedor", proveedor)
            command.Parameters.AddWithValue("@TelefonoProveedor", telefonoProveedor)
            command.Parameters.AddWithValue("@FechaCaducidad", fechaCaducidad)
            command.Parameters.AddWithValue("@Notas", notas)
            command.ExecuteNonQuery()
            MessageBox.Show("Ingrediente agregado correctamente")
        Catch ex As Exception
            Console.WriteLine("Error al agregar ingrediente: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub ActualizarInventario(id As Integer, nombre As String, cantidad As Integer, unidadMedida As String, precioUnitario As Decimal, proveedor As String, telefonoProveedor As String, fechaCaducidad As Date, notas As String)
        Try
            connection.Open()
            Dim query As String = "UPDATE Inventario SET NombreIngrediente = @Nombre, Cantidad = @Cantidad, UnidadMedida = @UnidadMedida, PrecioUnitario = @PrecioUnitario, Proveedor = @Proveedor, TelefonoProveedor = @TelefonoProveedor, FechaCaducidad = @FechaCaducidad, Notas = @Notas WHERE Id = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", id)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@UnidadMedida", unidadMedida)
            command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
            command.Parameters.AddWithValue("@Proveedor", proveedor)
            command.Parameters.AddWithValue("@TelefonoProveedor", telefonoProveedor)
            command.Parameters.AddWithValue("@FechaCaducidad", fechaCaducidad)
            command.Parameters.AddWithValue("@Notas", notas)
            command.ExecuteNonQuery()
            MessageBox.Show("Ingrediente actualizado correctamente")
        Catch ex As Exception
            Console.WriteLine("Error al actualizar ingrediente: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub EliminarInventario(id As Integer)
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Inventario WHERE Id = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", id)
            command.ExecuteNonQuery()
            MessageBox.Show("Ingrediente eliminado correctamente")
        Catch ex As Exception
            Console.WriteLine("Error al eliminar ingrediente: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function ObtenerInventario() As DataTable
        Dim dt As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al obtener el inventario: " & ex.Message)
        End Try

        Return dt
    End Function
End Class