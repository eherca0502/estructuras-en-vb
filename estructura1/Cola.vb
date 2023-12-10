Class Cola
    Private Items As New List(Of Integer)

    Public Sub Encolar(valor As Integer)
        Items.Insert(0, valor)
    End Sub

    Public Function Desencolar() As Integer
        If Not EstaVacia() Then
            Dim valorDesencolado As Integer = Items.Last()
            Items.RemoveAt(Items.Count - 1)
            Return valorDesencolado
        End If
        Return -1 ' Otra opción es lanzar una excepción indicando que la cola está vacía
    End Function

    Public Function EstaVacia() As Boolean
        Return Items.Count = 0
    End Function

    Public Sub Mostrar()
        If EstaVacia() Then
            Console.WriteLine("La cola está vacía.")
        Else
            Console.Write("Contenido de la cola: ")
            For Each item As Integer In Items
                Console.Write(item & " ")
            Next
            Console.WriteLine()
        End If
    End Sub
End Class

