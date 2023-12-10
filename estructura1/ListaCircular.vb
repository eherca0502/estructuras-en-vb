Class ListaCircular
    Public Cabeza As Nodo

    Public Sub Agregar(valor As Integer)
        Dim nuevoNodo As New Nodo With {
            .Valor = valor,
            .Siguiente = Cabeza
        }
        If Cabeza Is Nothing Then
            Cabeza = nuevoNodo
            nuevoNodo.Siguiente = Cabeza
        Else
            Dim temp As Nodo = Cabeza
            While temp.Siguiente IsNot Cabeza
                temp = temp.Siguiente
            End While
            temp.Siguiente = nuevoNodo
            nuevoNodo.Siguiente = Cabeza
        End If
    End Sub

    Public Sub Mostrar()
        If Cabeza Is Nothing Then
            Console.WriteLine("La lista circular está vacía.")
        Else
            Dim temp As Nodo = Cabeza
            Console.Write("Contenido de la lista circular: ")
            Do
                Console.Write(temp.Valor & " ")
                temp = temp.Siguiente
            Loop While temp IsNot Cabeza
            Console.WriteLine()
        End If
    End Sub
End Class

