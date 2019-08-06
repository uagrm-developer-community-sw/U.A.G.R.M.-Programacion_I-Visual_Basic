Public Class Class_Cadena
    Private c As String
    Sub cadena()
        c = ""
    End Sub
    Sub cargar(ByVal s As String)
        c = s
    End Sub
    Function descargar() As String
        Return c
    End Function

    '1. Contar consonantes, sean mayúsculas o minúsculas de una cadena Ej. S="Hola Juan" => el resultado es 4 (h,l,J,n)

End Class
