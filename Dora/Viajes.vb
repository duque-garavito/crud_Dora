Imports System.Data.SqlClient

Public Class Viajes
    Private viajeId As Object
    Private destino As String
    Private precio As String

    Public Sub New(viajeId As Object, destino As String, precio As String)
        Me.viajeId = viajeId
        Me.destino = destino
        Me.precio = precio
    End Sub
    Public Sub New(id As Integer, DESTINO As String, PRECIO As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        viajeId = id
        txtDestino.Text = DESTINO
        txtPrecio.Text = PRECIO

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Sub txtDestino_TextChanged(sender As Object, e As EventArgs) Handles txtDestino.TextChanged

    End Sub
    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub btnCalcelar_Click(sender As Object, e As EventArgs) Handles btnCalcelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Debug.Print("viaje ID es: " & viajeId)

        Dim Destino As String = txtDestino.Text
        Dim Precio As String = txtPrecio.Text
        If viajeId = 0 Then
            Dim consulta As String = "INSERT INTO viaje(Destino, Precio) VALUES(@Destino, @Precio)"

            Abrir_conexion()
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Destino", Destino)
                comando.Parameters.AddWithValue("@Precio", Precio)
                comando.ExecuteNonQuery()
            End Using
            cerrar_conexion()
            MessageBox.Show("Destino Agregado")
            Me.Close()

        Else
            Try
                Dim consulta As String = "UPDATE viaje SET Destino = @Destino, Precio = @Precio WHERE ID = @ViajeID"
                Abrir_conexion()
                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@Destino", Destino)
                    comando.Parameters.AddWithValue("@Precio", Precio)
                    comando.Parameters.AddWithValue("@ViajeID", viajeId)
                    comando.ExecuteNonQuery()
                End Using
                cerrar_conexion()
                MessageBox.Show("Destino Actualizado")
                Me.Close()
            Catch ex As Exception
                Debug.Print("Error al ejecutar la consulta de actualización: " & ex.Message)
                MessageBox.Show("Error al ejecutar la consulta de actualización: " & ex.Message)
            End Try
        End If
    End Sub



End Class