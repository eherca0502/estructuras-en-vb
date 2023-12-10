Imports System

Module Program
    Sub Main()
        Dim listaSimple As New ListaSimple()
        Dim listaCircular As New ListaCircular()
        Dim pila As New Pila()
        Dim cola As New Cola()
        Dim arbol As New Arbol(1)
        Dim grafo As New Grafo()

        Do
            Console.WriteLine("------- Men� -------")
            Console.WriteLine("1. Lista Simple")
            Console.WriteLine("2. Lista Circular")
            Console.WriteLine("3. Pila")
            Console.WriteLine("4. Cola")
            Console.WriteLine("5. �rbol")
            Console.WriteLine("6. Grafo")
            Console.WriteLine("7. Salir")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    MenuListaSimple(listaSimple)
                Case 2
                    MenuListaCircular(listaCircular)
                Case 3
                    MenuPila(pila)
                Case 4
                    MenuCola(cola)
                Case 5
                    MenuArbol(arbol)
                Case 6
                    MenuGrafo(grafo)
                Case 7
                    Console.WriteLine("Saliendo del programa. �Hasta luego!")
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuListaSimple(ByRef listaSimple As ListaSimple)
        Do
            Console.WriteLine("------- Men� Lista Simple -------")
            Console.WriteLine("1. Agregar elemento")
            Console.WriteLine("2. Mostrar lista")
            Console.WriteLine("3. Volver al men� principal")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a agregar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    listaSimple.Agregar(valor)
                    Console.WriteLine("Elemento agregado con �xito.")
                Case 2
                    Console.WriteLine("Lista Simple:")
                    listaSimple.Mostrar()

                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuListaCircular(ByRef listaCircular As ListaCircular)
        Do
            Console.WriteLine("------- Men� Lista Circular -------")
            Console.WriteLine("1. Agregar elemento")
            Console.WriteLine("2. Mostrar lista")
            Console.WriteLine("3. Volver al men� principal")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a agregar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    listaCircular.Agregar(valor)
                    Console.WriteLine("Elemento agregado con �xito.")
                Case 2
                    Console.WriteLine("Lista Circular:")
                    listaCircular.Mostrar()
                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuPila(ByRef pila As Pila)
        Do
            Console.WriteLine("------- Men� Pila -------")
            Console.WriteLine("1. Apilar elemento")
            Console.WriteLine("2. Desapilar elemento")
            Console.WriteLine("3. Mostrar pila")
            Console.WriteLine("4. Volver al men� principal")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a apilar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    pila.Apilar(valor)
                    Console.WriteLine("Elemento apilado con �xito.")
                Case 2
                    Dim elementoDesapilado As Integer = pila.Desapilar()
                    If elementoDesapilado <> -1 Then
                        Console.WriteLine($"Elemento desapilado: {elementoDesapilado}")
                    Else
                        Console.WriteLine("La pila est� vac�a.")
                    End If
                Case 3
                    Console.WriteLine("Pila:")
                    pila.Mostrar()
                Case 4
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuCola(ByRef cola As Cola)
        Do
            Console.WriteLine("------- Men� Cola -------")
            Console.WriteLine("1. Encolar elemento")
            Console.WriteLine("2. Desencolar elemento")
            Console.WriteLine("3. Mostrar cola")
            Console.WriteLine("4. Volver al men� principal")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a encolar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    cola.Encolar(valor)
                    Console.WriteLine("Elemento encolado con �xito.")
                Case 2
                    Dim elementoDesencolado As Integer = cola.Desencolar()
                    If elementoDesencolado <> -1 Then
                        Console.WriteLine($"Elemento desencolado: {elementoDesencolado}")
                    Else
                        Console.WriteLine("La cola est� vac�a.")
                    End If
                Case 3
                    Console.WriteLine("Cola:")
                    cola.Mostrar()
                Case 4
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub


    Sub MenuArbol(ByRef arbol As Arbol)
        Do
            Console.WriteLine("------- Men� �rbol -------")
            Console.WriteLine("1. Agregar hijo")
            Console.WriteLine("2. Mostrar �rbol")
            Console.WriteLine("3. Volver al men� principal")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor del padre: ")
                    Dim valorPadre As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Ingrese el valor del nuevo hijo: ")
                    Dim valorHijo As Integer = Convert.ToInt32(Console.ReadLine())
                    arbol.AgregarHijo(valorPadre, valorHijo)
                    Console.WriteLine("Hijo agregado con �xito.")
                Case 2
                    Console.WriteLine("�rbol:")
                    arbol.Mostrar()
                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuGrafo(ByRef grafo As Grafo)
        Do
            Console.WriteLine("------- Men� Grafo -------")
            Console.WriteLine("1. Agregar v�rtice")
            Console.WriteLine("2. Agregar arista")
            Console.WriteLine("3. Mostrar grafo")
            Console.WriteLine("4. Volver al men� principal")
            Console.Write("Seleccione una opci�n: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor del v�rtice: ")
                    Dim valorVertice As Integer = Convert.ToInt32(Console.ReadLine())
                    grafo.AgregarVertice(valorVertice)
                    Console.WriteLine("V�rtice agregado con �xito.")
                Case 2
                    Console.Write("Ingrese el valor del origen: ")
                    Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Ingrese el valor del destino: ")
                    Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                    grafo.AgregarArista(origen, destino)
                    Console.WriteLine("Arista agregada con �xito.")
                Case 3
                    Console.WriteLine("Grafo:")
                    grafo.Mostrar()
                Case 4
                    Exit Do
                Case Else
                    Console.WriteLine("Opci�n no v�lida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub
End Module
