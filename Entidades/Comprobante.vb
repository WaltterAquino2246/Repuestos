Public Class Comprobante

    Implements IComprobante

    Public Sub New(numero As UInteger)
        Me.Numero = numero
        comprobante = New List(Of ComprobanteDetalle)
    End Sub


    Private _numero As UInteger
    Public Property Numero As UInteger Implements IComprobante.Numero
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property


    Private comprobante As List(Of ComprobanteDetalle)
    Public Sub AddDetalle(parte As IParte, cantidad As UShort) Implements IComprobante.AddDetalle
        comprobante.Add(New ComprobanteDetalle(parte, cantidad))
    End Sub

    Public Function GetAlldetalles() As List(Of ComprobanteDetalle) Implements IComprobante.GetAlldetalles
        Return comprobante
    End Function

    Public Function CalcularTotal() As Decimal Implements IComprobante.CalcularTotal
        Return 0
    End Function
End Class
