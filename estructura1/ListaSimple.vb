Class ListaSimple
    Public Cabeza As Nodo

    Public Sub Agregar(valor As Integer)
        Dim nuevoNodo As New Nodo With {
            .Valor = valor,
            .Siguiente = Cabeza
        }
        Cabeza = nuevoNodo
    End Sub

    Public Sub Mostrar()
        If Cabeza Is Nothing Then
            Console.WriteLine("La lista simple está vacía.")
        Else
            Dim temp As Nodo = Cabeza
            Console.Write("Contenido de la lista simple: ")
            While temp IsNot Nothing
                Console.Write(temp.Valor & " ")
                temp = temp.Siguiente
            End While
            Console.WriteLine()
        End If
    End Sub
End Class

