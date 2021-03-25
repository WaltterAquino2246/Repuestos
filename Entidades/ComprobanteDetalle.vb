Public Class ComprobanteDetalle

    Public Sub New(parte As IParte, cantidad As UShort)
        Me.Parte = parte
        Me.Cantidad = cantidad
    End Sub



    Private _parte As IParte
    Public Property Parte() As IParte
        Get
            Return _parte
        End Get
        Set(ByVal value As IParte)
            _parte = value
        End Set
    End Property

    Private _comprobante As IComprobante
    Public Property Comprobante() As IComprobante
        Get
            Return _comprobante
        End Get
        Set(ByVal value As IComprobante)
            value.AddDetalle(Me.Parte, Me.Cantidad)
            _comprobante = value
        End Set
    End Property

    Private _cantidad As UShort
    Public Property Cantidad() As UShort
        Get
            Return _cantidad
        End Get
        Set(ByVal value As UShort)
            _cantidad = value
        End Set
    End Property


    Public Function Total() As Decimal
        Return 0
    End Function

    Public Function Tostring() As String
        Return ""
    End Function



End Class
