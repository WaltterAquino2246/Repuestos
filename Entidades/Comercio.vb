Public Class Comercio

    Private Shared partes As New List(Of IParte)
    Private Shared comprobantes As New List(Of IComprobante)


    Public Shared Sub AdddParte(parte As IParte)
        partes.Add(parte)
    End Sub


    Public Shared Function GetOriginales(nombre As String) As List(Of IParte)
        Dim parteo As Parte
        Dim partei As New List(Of IParte)

        For Each item In partes
            parteo = item

            If parteo.Original Is Nothing Then
                partei.Add(item)
            End If
        Next

        Return partei
    End Function

    Public Shared Function GetAlternativos(parte As IParte) As List(Of IParte)
        Dim lista As New List(Of IParte)
        Dim partea As Parte

        For Each item In partes
            partea = item
            If partea.Original Is parte Then
                lista.Add(item)
            End If
        Next

        Return lista
    End Function

    Public Shared Sub AddComprobante(comprobante As IComprobante)
        comprobantes.add(comprobante)
    End Sub

    Public Shared Function GetAllCotizaciones() As List(Of IComprobante)
        Dim lista As New List(Of IComprobante)
        Return lista
    End Function



End Class
