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
            Console.WriteLine("------- Menú -------")
            Console.WriteLine("1. Lista Simple")
            Console.WriteLine("2. Lista Circular")
            Console.WriteLine("3. Pila")
            Console.WriteLine("4. Cola")
            Console.WriteLine("5. Árbol")
            Console.WriteLine("6. Grafo")
            Console.WriteLine("7. Salir")
            Console.Write("Seleccione una opción: ")

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
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!")
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuListaSimple(ByRef listaSimple As ListaSimple)
        Do
            Console.WriteLine("------- Menú Lista Simple -------")
            Console.WriteLine("1. Agregar elemento")
            Console.WriteLine("2. Mostrar lista")
            Console.WriteLine("3. Volver al menú principal")
            Console.Write("Seleccione una opción: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a agregar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    listaSimple.Agregar(valor)
                    Console.WriteLine("Elemento agregado con éxito.")
                Case 2
                    Console.WriteLine("Lista Simple:")
                    listaSimple.Mostrar()

                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuListaCircular(ByRef listaCircular As ListaCircular)
        Do
            Console.WriteLine("------- Menú Lista Circular -------")
            Console.WriteLine("1. Agregar elemento")
            Console.WriteLine("2. Mostrar lista")
            Console.WriteLine("3. Volver al menú principal")
            Console.Write("Seleccione una opción: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a agregar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    listaCircular.Agregar(valor)
                    Console.WriteLine("Elemento agregado con éxito.")
                Case 2
                    Console.WriteLine("Lista Circular:")
                    listaCircular.Mostrar()
                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuPila(ByRef pila As Pila)
        Do
            Console.WriteLine("------- Menú Pila -------")
            Console.WriteLine("1. Apilar elemento")
            Console.WriteLine("2. Desapilar elemento")
            Console.WriteLine("3. Mostrar pila")
            Console.WriteLine("4. Volver al menú principal")
            Console.Write("Seleccione una opción: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a apilar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    pila.Apilar(valor)
                    Console.WriteLine("Elemento apilado con éxito.")
                Case 2
                    Dim elementoDesapilado As Integer = pila.Desapilar()
                    If elementoDesapilado <> -1 Then
                        Console.WriteLine($"Elemento desapilado: {elementoDesapilado}")
                    Else
                        Console.WriteLine("La pila está vacía.")
                    End If
                Case 3
                    Console.WriteLine("Pila:")
                    pila.Mostrar()
                Case 4
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuCola(ByRef cola As Cola)
        Do
            Console.WriteLine("------- Menú Cola -------")
            Console.WriteLine("1. Encolar elemento")
            Console.WriteLine("2. Desencolar elemento")
            Console.WriteLine("3. Mostrar cola")
            Console.WriteLine("4. Volver al menú principal")
            Console.Write("Seleccione una opción: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor a encolar: ")
                    Dim valor As Integer = Convert.ToInt32(Console.ReadLine())
                    cola.Encolar(valor)
                    Console.WriteLine("Elemento encolado con éxito.")
                Case 2
                    Dim elementoDesencolado As Integer = cola.Desencolar()
                    If elementoDesencolado <> -1 Then
                        Console.WriteLine($"Elemento desencolado: {elementoDesencolado}")
                    Else
                        Console.WriteLine("La cola está vacía.")
                    End If
                Case 3
                    Console.WriteLine("Cola:")
                    cola.Mostrar()
                Case 4
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub


    Sub MenuArbol(ByRef arbol As Arbol)
        Do
            Console.WriteLine("------- Menú Árbol -------")
            Console.WriteLine("1. Agregar hijo")
            Console.WriteLine("2. Mostrar árbol")
            Console.WriteLine("3. Volver al menú principal")
            Console.Write("Seleccione una opción: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor del padre: ")
                    Dim valorPadre As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Ingrese el valor del nuevo hijo: ")
                    Dim valorHijo As Integer = Convert.ToInt32(Console.ReadLine())
                    arbol.AgregarHijo(valorPadre, valorHijo)
                    Console.WriteLine("Hijo agregado con éxito.")
                Case 2
                    Console.WriteLine("Árbol:")
                    arbol.Mostrar()
                Case 3
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub

    Sub MenuGrafo(ByRef grafo As Grafo)
        Do
            Console.WriteLine("------- Menú Grafo -------")
            Console.WriteLine("1. Agregar vértice")
            Console.WriteLine("2. Agregar arista")
            Console.WriteLine("3. Mostrar grafo")
            Console.WriteLine("4. Volver al menú principal")
            Console.Write("Seleccione una opción: ")

            Dim opcion As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese el valor del vértice: ")
                    Dim valorVertice As Integer = Convert.ToInt32(Console.ReadLine())
                    grafo.AgregarVertice(valorVertice)
                    Console.WriteLine("Vértice agregado con éxito.")
                Case 2
                    Console.Write("Ingrese el valor del origen: ")
                    Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Ingrese el valor del destino: ")
                    Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                    grafo.AgregarArista(origen, destino)
                    Console.WriteLine("Arista agregada con éxito.")
                Case 3
                    Console.WriteLine("Grafo:")
                    grafo.Mostrar()
                Case 4
                    Exit Do
                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select

            Console.WriteLine()
        Loop While True
    End Sub
End Module
