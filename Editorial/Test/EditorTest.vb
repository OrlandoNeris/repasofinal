
Imports Entidades

Module EditorTest

    Sub Main()

        Dim editor1 As New Editor(37159252, "Orlando")

        Imprimir(editor1)

        Dim editor2 As New Editor(37159252, "Or")

        Imprimir(editor2)

        Console.ReadKey()
    End Sub

    Public Sub Imprimir(objeto As Editor)
        Console.WriteLine("Nombre: " & objeto.Nombre)
        Console.WriteLine("DNI: " & objeto.Dni)
    End Sub

End Module
