Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
'UserId=LAPTOP-HP-CRIST\D'Garavito;Password=
Module ConexionMaestra
    Public conexion As New SqlConnection("server=LAPTOP-HP-CRIST;database=transporte_dora; integrated security=SSPI")
    Public pasajeroId As String
    Public dniPasajero As String
    Public nombrePasajero As String
    Public apellidoPasajero As String
    Public telefonoPasajero As String
    Sub Abrir_conexion()
        If conexion.State <> 0 Then
            Return
        End If
        conexion.Open()
    End Sub

    Sub cerrar_conexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module
