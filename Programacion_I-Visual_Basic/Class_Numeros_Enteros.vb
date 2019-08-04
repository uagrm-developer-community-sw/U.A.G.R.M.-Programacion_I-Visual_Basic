Public Class Class_Numeros_Enteros
    Private num As Integer
    Public Sub Class_Numeros_Enteros()
        num = 0
    End Sub
    Public Sub Cargar(ByVal dato As Integer)
        num = dato
    End Sub
    Public Function descargar() As Integer
        Return num
    End Function
    'CONTAR DIGITOS
    Public Function contar_digito() As Integer
        Dim n, c As Integer
        n = num
        c = 0
        While num > 0
            num = num \ 10
            c = c + 1
        End While
        Return c
    End Function
    'DIGITO MAYOR
    Public Function digito_mayor() As Integer
        Dim n, d, f As Integer
        n = num
        f = n Mod 10 : n = n \ 10
        While n > 0
            d = n Mod 10 : n = n \ 10
            If f > d Then
            Else
                f = d
            End If
        End While
        Return f
    End Function
    'DIGITO MENOR
    Public Function digito_menor() As Integer
        Dim n, d, f As Integer
        n = num
        f = n Mod 10 : n = n \ 10
        While n > 0
            d = n Mod 10 : n = n \ 10
            If f < d Then
            Else
                f = d
            End If
        End While
        Return f
    End Function
End Class
