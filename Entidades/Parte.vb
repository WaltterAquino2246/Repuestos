Public Class Parte

    Implements IParte


    Public Sub New(nombre As String, precio As Decimal)
        Me.Nombre = nombre
        Me.Precio = precio
    End Sub


    Public Sub New(nombre As String, precio As Decimal, original As Parte)
        Me.New(nombre, precio)
        Me.Original = original
    End Sub


    Private _nombre As String
    Public Property Nombre As String Implements IParte.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)

            If value = "" Then
                Throw New Exception("Nombre invalido")
            End If
            _nombre = value
        End Set
    End Property



    Private _precio As Decimal
    Public Property Precio As Decimal Implements IParte.Precio
        Get
            Return _precio
        End Get
        Set(value As Decimal)

            If value <= 0 Then
                Throw New Exception("Precio invalido!")
            End If
            _precio = value
        End Set
    End Property


    Public Function Tostring() As String
        Return Nombre
    End Function

    Private _original As Parte
    Public Property Original() As Parte
        Get
            Return _original
        End Get
        Set(ByVal value As Parte)
            _original = value
        End Set
    End Property

End Class
