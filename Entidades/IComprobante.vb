Public Interface IComprobante

    Property Numero As UInteger

    Sub AddDetalle(parte As IParte, cantidad As UShort)
    Function GetAlldetalles() As List(Of ComprobanteDetalle)

    Function CalcularTotal() As Decimal




End Interface
