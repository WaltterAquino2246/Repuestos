Imports Entidades
Module ComercioTest


    Public Sub comerciot()

        Dim parte1 As New Parte("Router meraki", 50000)
        Dim parte2 As New Parte("Router Tp-Link", 50000, parte1)
        Dim parte3 As New Parte("Router Arnet", 50000, parte1)

        Comercio.AdddParte(parte1)
        Comercio.AdddParte(parte2)
        Comercio.AdddParte(parte3)




        'For Each item In Comercio.GetOriginales("Router Tp-Link")
        'Console.WriteLine(item.Nombre & " " & item.Precio)
        'Next

        For Each item In Comercio.GetAlternativos(parte1)
            Console.WriteLine(item.Nombre & " " & item.Precio)
        Next


    End Sub

End Module
