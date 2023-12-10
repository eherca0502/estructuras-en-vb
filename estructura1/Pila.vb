Class Pila
    Private Items As New List(Of Integer)

    Public Sub Apilar(valor As Integer)
        Items.Add(valor)
    End Sub

    Public Function Desapilar() As Integer
        If Not EstaVacia() Then
            Dim valorDesapilado As Integer = Items.Last()
            Items.RemoveAt(Items.Count - 1)
            Return valorDesapilado
        End If
        Return -1 ' Otra opción es lanzar una excepción indicando que la pila está vacía
    End Function

    Public Function EstaVacia() As Boolean
        Return Items.Count = 0
    End Function

    Public Sub Mostrar()
        If EstaVacia() Then
            Console.WriteLine("La pila está vacía.")
        Else
            Console.WriteLine("Contenido de la pila:")
            For Each item As Integer In Items
                Console.WriteLine(item)
            Next
        End If
    End Sub
End Class

