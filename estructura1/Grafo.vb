Class Grafo
    Public Vertices As New Dictionary(Of Integer, List(Of Integer))

    Public Sub AgregarVertice(valor As Integer)
        If Not Vertices.ContainsKey(valor) Then
            Vertices(valor) = New List(Of Integer)()
        End If
    End Sub

    Public Sub AgregarArista(origen As Integer, destino As Integer)
        If Vertices.ContainsKey(origen) AndAlso Vertices.ContainsKey(destino) Then
            Vertices(origen).Add(destino)
            Vertices(destino).Add(origen)
        End If
    End Sub

    Public Sub Mostrar()
        Console.WriteLine("Grafo:")
        For Each vertice As Integer In Vertices.Keys
            Console.Write($"{vertice}: ")
            For Each adyacente As Integer In Vertices(vertice)
                Console.Write($"{adyacente} ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Class


