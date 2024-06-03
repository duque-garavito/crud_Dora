Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Inicio

    Private Dni As String
    Private Nombre As String
    Private Apellido As String
    Private Telefono As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPasajeros()
    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        loadPasajeros()
    End Sub

    Private Sub dataTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable.CellDoubleClick
        Debug.Print(dataTable.Item(0, e.RowIndex).Value.ToString())
        'Dim pasajeroId As Integer = e.RowIndex 'fila seleccionada

        pasajeroId = dataTable.Item(0, e.RowIndex).Value.ToString()

        Dni = dataTable.Item(1, e.RowIndex).Value.ToString()
        Nombre = dataTable.Item(2, e.RowIndex).Value.ToString()
        Apellido = dataTable.Item(3, e.RowIndex).Value.ToString()
        Telefono = dataTable.Item(4, e.RowIndex).Value.ToString()
        Dim dialogo As New Dialog(pasajeroId, Dni, Nombre, Apellido, Telefono)
        dialogo.Show()
    End Sub
    Public Sub loadPasajeros()
        Dim consulta As String = "Select * from Pasajeros"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim data As New DataTable
        adaptador.Fill(data)
        dataTable.DataSource = data
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dialogo As New Dialog(0, "", "", "", "")
        dialogo.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dataTable.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = dataTable.SelectedRows(0)
            Debug.Print(filaSeleccionada.Cells("PasajeroID").Value)
            Dim ID As Integer = CInt(filaSeleccionada.Cells("PasajeroID").Value)
            Dim Dni As Integer = filaSeleccionada.Cells("Dni").Value
            Dim Nombre As String = filaSeleccionada.Cells("Nombre").Value.ToString()
            Dim Apellido As String = filaSeleccionada.Cells("Apellido").Value.ToString()
            Dim Telefono As String = filaSeleccionada.Cells("Telefono").Value.ToString()

            Dim dialogo As New Dialog(ID, Dni, Nombre, Apellido, Telefono)
            dialogo.ShowDialog()
        Else
            MessageBox.Show("Selecciona una fila para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        loadPasajeros()
    End Sub

    Private Sub btnElimnar_Click(sender As Object, e As EventArgs) Handles btnElimnar.Click
        If dataTable.SelectedRows.Count > 0 Then
            Dim respuesta As Byte
            respuesta = MsgBox("¿Desea Eliminar Este Pasajero?", MsgBoxStyle.YesNo, "Advertencia")
            If respuesta = vbYes Then
                Dim filaSeleccionada As DataGridViewRow = dataTable.SelectedRows(0)
                Debug.Print(filaSeleccionada.Cells("PasajeroID").Value)
                Dim pasajeroId As Integer = CInt(filaSeleccionada.Cells("PasajeroID").Value)
                Try

                    Dim consulta As String = "DELETE from Pasajeros  WHERE PasajeroID = @PasajeroID"
                    Debug.Print(consulta)
                    Abrir_conexion()
                    Using comando As New SqlCommand(consulta, conexion)

                        comando.Parameters.AddWithValue("@PasajeroID", pasajeroId)

                        Debug.Print(pasajeroId)
                        comando.ExecuteNonQuery()
                    End Using
                    cerrar_conexion()

                    MessageBox.Show("Pasajero eliminado")

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el pasajero" & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Selecciona una fila para Eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable.CellContentClick

    End Sub



    Private Destino As String
    Private Precio As String
    Private viajeId
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable2.CellContentClick

    End Sub
    Private Sub datatable2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadViaje()
    End Sub

    Private Sub datatable2_GotFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        loadViaje()
    End Sub
    Public Sub loadViaje()
        Dim consulta As String = "Select * from viaje"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim data As New DataTable
        adaptador.Fill(data)
        dataTable2.DataSource = data
    End Sub

    Private Sub btnAgregarViaje_Click(sender As Object, e As EventArgs) Handles btnAgregarViaje.Click
        Dim viaje As New Viajes(0, "", "")
        viaje.ShowDialog()
    End Sub

    Private Sub btnActulViaje_Click(sender As Object, e As EventArgs) Handles btnActulViaje.Click
        loadViaje()
    End Sub

    Private Sub dataTable2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable2.CellDoubleClick
        Debug.Print(dataTable2.Item(0, e.RowIndex).Value.ToString())

        Dim viajeId As Integer = Integer.Parse(dataTable2.Item(0, e.RowIndex).Value.ToString())
        Dim Destino As String = dataTable2.Item(1, e.RowIndex).Value.ToString()
        Dim Precio As String = dataTable2.Item(2, e.RowIndex).Value.ToString()

        Dim viajes As New Viajes(viajeId, Destino, Precio)
        viajes.Show()
    End Sub


    Private Sub btnEditarViaje_Click(sender As Object, e As EventArgs) Handles btnEditarViaje.Click
        If dataTable2.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = dataTable2.SelectedRows(0)
            Debug.Print(filaSeleccionada.Cells("ViajeId").Value)
            Dim IDe As Integer = CInt(filaSeleccionada.Cells("viajeId").Value)
            Dim Destino As String = (filaSeleccionada.Cells("Destino").Value)
            Dim Precio As String = filaSeleccionada.Cells("Precio").Value.ToString()

            Dim viajes As New Viajes(IDe, Destino, Precio)
            viajes.Show()
        Else
            MessageBox.Show("seleccione una fila para editar.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminarViaje_Click(sender As Object, e As EventArgs) Handles btnEliminarViaje.Click
        If dataTable2.SelectedRows.Count > 0 Then
            Dim respuesta As Byte
            respuesta = MsgBox("¿Desea Eliminar Este Destino?", MsgBoxStyle.YesNo, "Advertencia")
            If respuesta = vbYes Then
                Dim filaSeleccionada As DataGridViewRow = dataTable2.SelectedRows(0)
                Debug.Print(filaSeleccionada.Cells("ViajeId").Value)
                Dim viajeID As Integer = CInt(filaSeleccionada.Cells("ViajeId").Value)
                Try

                    Dim consulta2 As String = "DELETE from viaje  WHERE ViajeId = @ViajeId"
                    Debug.Print(consulta2)
                    Abrir_conexion()
                    Using comando As New SqlCommand(consulta2, conexion)

                        comando.Parameters.AddWithValue("@viajeId", viajeID)

                        Debug.Print(viajeID)
                        comando.ExecuteNonQuery()
                    End Using
                    cerrar_conexion()

                    MessageBox.Show("destino eliminado")

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el destino" & ex.Message)
                End Try
            End If

        Else
            MessageBox.Show("Selecciona una fila para Eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class