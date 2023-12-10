Class Arbol
    Public Raiz As NodoArbol

    Public Sub New(valor As Integer)
        Raiz = New NodoArbol With {
            .Valor = valor
        }
    End Sub

    Public Sub AgregarHijo(padreValor As Integer, valor As Integer)
        Dim padre As NodoArbol = BuscarNodo(Raiz, padreValor)
        If padre IsNot Nothing Then
            padre.Hijos.Add(New NodoArbol With {.Valor = valor})
        Else
            Console.WriteLine($"No se encontró el nodo con valor {padreValor}.")
        End If
    End Sub

    Private Function BuscarNodo(nodo As NodoArbol, valor As Integer) As NodoArbol
        If nodo IsNot Nothing AndAlso nodo.Valor = valor Then
            Return nodo
        End If

        For Each hijo As NodoArbol In nodo.Hijos
            Dim nodoEncontrado As NodoArbol = BuscarNodo(hijo, valor)
            If nodoEncontrado IsNot Nothing Then
                Return nodoEncontrado
            End If
        Next

        Return Nothing
    End Function

    Public Sub Mostrar()
        Console.WriteLine("Árbol:")
        MostrarRecursivo(Raiz, 0)
    End Sub

    Private Sub MostrarRecursivo(nodo As NodoArbol, nivel As Integer)
        If nodo IsNot Nothing Then
            Console.WriteLine($"{New String(" ", nivel * 4)}{nodo.Valor}")
            For Each hijo As NodoArbol In nodo.Hijos
                MostrarRecursivo(hijo, nivel + 1)
            Next
        End If
    End Sub
End Class


