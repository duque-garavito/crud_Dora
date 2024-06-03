Imports System.Data.SqlClient

Public Class Dialog
    Public PasajeroID As Integer


    Public Sub New(id As Integer, dni As String, nombre As String, apellido As String, telefono As String) 'constructor
        InitializeComponent()
        PasajeroID = id
        txtDni.Text = dni

        txtNombre.Text = nombre
        txtApellido.Text = apellido
        txtTelefono.Text = telefono
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Debug.Print("pasajero ID es: " & PasajeroID)

        Dim Dni As Integer = Integer.Parse(txtDni.Text)
        Dim Nombre As String = txtNombre.Text
        Dim Apellido As String = txtApellido.Text
        Dim Telefono As String = txtTelefono.Text
        If PasajeroID = 0 Then

            Dim consulta As String = "INSERT INTO Pasajeros(DNI, Nombre, Apellido, Telefono) VALUES (@Dni, @Nombre, @Apellido, @Telefono)"
            Abrir_conexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Dni", Dni)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@Apellido", Apellido)
                comando.Parameters.AddWithValue("@Telefono", Telefono)
                comando.ExecuteNonQuery()
            End Using
            cerrar_conexion()

            MessageBox.Show("Pasajero Registrado")
            Me.Close()

        Else
            Debug.Print(ErrorToString)
            Try

                Dim consulta As String = "UPDATE Pasajeros SET DNI = @Dni, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono WHERE PasajeroID = @PasajeroID"
                Debug.Print(consulta)
                Abrir_conexion()
                Using comando As New SqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@PasajeroID", PasajeroID)
                    comando.Parameters.AddWithValue("@Dni", Dni)
                    comando.Parameters.AddWithValue("@Nombre", Nombre)
                    comando.Parameters.AddWithValue("@Apellido", Apellido)
                    comando.Parameters.AddWithValue("@Telefono", Telefono)
                    Debug.Print(PasajeroID)
                    comando.ExecuteNonQuery()
                End Using
                cerrar_conexion()

                MessageBox.Show("Pasajero Actualizado")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el pasajero" & ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Me.Close()
    End Sub

    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub txtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDni_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged

    End Sub
End Class
