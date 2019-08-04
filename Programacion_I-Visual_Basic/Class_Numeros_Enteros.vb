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
    'ENCONTRAR EL DIGITO MAYOR
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
    'ENCONTRAR EL DIGITO MENOR
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
    'CONTAR DIGITOS SUBMULTIPLOS DE M
    Public Function contar_digitos_submultiplos_m(ByVal m As Integer) As Integer
        Dim n, c, d As Integer
        n = num
        c = 0
        While n > 0
            d = n Mod 10 : n = n \ 10
            If (m Mod d) = 0 Then
                c = c + 1
            End If
        End While
        Return c
    End Function
    'CONTAR LAS VECES QUE M SE ENCUENTRA EN N 
    Public Function contar_veces_m_encuentra_n(ByVal m As Integer) As Integer
        Dim an As Class_Numeros_Enteros
        Dim n, nd, c, ds As Integer
        n = num
        an = New Class_Numeros_Enteros
        an.Cargar(m)
        nd = an.contar_digito()
        c = 0
        While n > 0
            ds = n Mod (10 ^ nd) : n = n \ 10
            If ds = m Then
                c = c + 1
            End If
        End While
        Return c
    End Function
    'BUSCAR SI EXISTE UN DIGITO EN UN NUMERO DE Class_Numero_Entero
    Public Function buscar_existe_digito_class_numero_entero(ByVal d As Integer) As Boolean
        Dim n, e As Integer
        Dim b As Boolean
        n = num
        b = False
        While (n > 0) And (b = False)
            e = n Mod 10 : n = n \ 10
            If e = d Then
                b = True
            End If
        End While
        Return b
    End Function
    'VERIFICAR SI TODOS LOS DIGITOS SON IGUALES
    Public Function verificar_digitos_iguales() As Boolean
        Dim n, e, d As Integer
        Dim b As Boolean
        n = num
        e = n Mod 10 : n = n \ 10
        b = True
        While (n > 0) And (b = True)
            d = n Mod 10 : n = n \ 10
            If Not (d = e) Then
                b = False
            End If
        End While
        Return b
    End Function
    'FRECUENCIA DE UN DIGITO
    Public Function frecuencia_de_un_digito(ByVal d As Integer) As Integer
        Dim f, n, e As Integer
        n = num
        f = 0
        While n > 0
            e = n Mod 10 : n = n \ 10
            If e = d Then
                f = f + 1
            End If
        End While
        Return f
    End Function
    'VERIFICAR SI TODOS LOS DIGITOS SE REPITEN
    Public Function verificar_todos_digitos_repiten() As Boolean
        Dim n, d As Integer
        Dim b As Boolean
        n = num
        b = True
        While (n > 0) And (b = True)
            d = n Mod 10 : n = n \ 10
            If Not (frecuencia_de_un_digito(d) > 1) Then
                b = False
            End If
        End While
        Return b
    End Function
    'INVERTIR UN NUMERO DE Class_Numero_Entero
    Public Sub invertir_un_numero_class_numero_entero()
        Dim n, d As Integer
        n = 0
        While num > 0
            d = num Mod 10 : num = num \ 10
            n = (n * 10) + d
        End While
        num = n
    End Sub
    'VERIFICAR SI UN NUMERO DE Class_Numero_Entero ES CAPICUA
    Public Function verificar_class_numero_entero_es_capicua() As Boolean
        Dim na As Class_Numeros_Enteros
        na = New Class_Numeros_Enteros()
        na.Cargar(num)
        na.invertir_un_numero_class_numero_entero()
        Return (na.descargar() = num)
    End Function
    'CONVERTIR UN NUMERO DE Class_Numero_Entero EN BINARIO
    Public Function dec_bin() As Integer
        Dim na, n, d, c As Integer
        na = num
        c = -1
        n = 0
        While na > 0
            d = na Mod 2 : na = na \ 2
            c = c + 1
            n = n + d * (10 ^ c)
        End While
        Return n
    End Function
    'CONVERTIR UN DECIMAL A OTRA BASE(2..9)
    Public Function convertir_decimal_otra_base(ByVal b As Integer) As Integer
        Dim na, n1, d, c As Integer
        na = num
        c = -1
        n1 = 0
        While na > 0
            d = na Mod b : na = na \ b
            c = c + 1
            n1 = n1 + d * (10 ^ c)
        End While
        Return n1
    End Function
    'FORMAR UN NUMERO DE Class_Numero_Entero CON DIGITOS PARES
    Public Function formar_numero_class_numeros_enteros_con_digitos_pares() As Integer
        Dim na, n1, d, c As Integer
        na = num
        c = -1
        n1 = 0
        While na > 0
            d = na Mod 10 : na = na \ 10
            If (d Mod 2) = 0 Then
                c = c + 1
                n1 = n1 + d * (10 ^ c)
            End If
        End While
        Return n1
    End Function
    'FUSIONAR DOS NUMEROS DE Class_Numero_Entero
    Public Function fusionar_dos_numeros_class_numeros_enteros(ByVal n1 As Integer) As Integer
        Dim nr, c, m As Integer
        nr = num
        c = 0
        m = n1
        While m > 0
            m = m \ 10
            c = c + 1
        End While
        nr = nr * (10 ^ c) + n1
        Return nr
    End Function
    'SEGMENTAR ORDENADAMENTE EN PARES E IMPARES
    Public Sub segmentar_ordenadamente_pares_impares()
        Dim n1, n2, c1, c2, d As Integer
        n1 = 0
        n2 = 0
        c1 = -1
        c2 = -1
        While num > 0
            d = num Mod 10 : num = num \ 10
            If (d Mod 2) = 0 Then
                c1 = c1 + 1
                n2 = n2 + d * (10 ^ c1)
            Else
                c2 = c2 + 1
                n1 = n1 + d * (10 ^ c2)
            End If
        End While
        num = n2
        num = fusionar_dos_numeros_class_numeros_enteros(n1)
    End Sub
    'CORTAR UN DIGITO DE UN NUMERO DE Class_Numero_Entero
    Public Sub cortar_digitos_class_numeros_enteros(ByVal dig As Integer)
        Dim n1, c, d As Integer
        n1 = 0
        c = -1
        Do
            d = num Mod 10 : num = num \ 10
            If d <> dig Then
                c = c + 1
                n1 = n1 + d * (10 ^ c)
            End If
        Loop Until (d = dig) Or (num = 0)
        num = fusionar_dos_numeros_class_numeros_enteros(n1)
    End Sub
    'ORDENAR DIGITOS
    Public Sub ordenar_digitos()
        Dim n1, d As Integer
        n1 = 0
        While num > 0
            d = digito_menor()
            n1 = (n1 * 10) + d
            cortar_digitos_class_numeros_enteros(d)
        End While
        num = n1
    End Sub
    'INTERCALAR DIGITOS (MAYOR,MENOR,MAYOR,MENOR,...)
    Public Sub intercalar_mayor_menor()
        Dim n1, d As Integer
        Dim b As Boolean
        b = True
        n1 = 0
        While num > 0
            If b = True Then
                d = digito_mayor()
            Else
                d = digito_menor()
            End If
            n1 = (n1 * 10) + d
            cortar_digitos_class_numeros_enteros(d)
            b = Not b
        End While
        num = n1
    End Sub
    'VERIFICAR SI UN NUMERO ES FIBONACCI
    Public Function verificar_numero_fibonacci(ByVal m As Integer) As Boolean
        Dim a, b, c As Integer
        Dim b1 As Boolean
        a = -1
        b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until (c >= m)
        If c = m Then
            b1 = True
        Else
            b1 = False
        End If
        Return b1
    End Function

    '******************************************************************************'
    '                          PRACTICO I PARTE
    '******************************************************************************'


    'CONTAR DIGITOS CON FRECUENCIA PAR
    'CONTAR DIGITOS QUE PERTENCEN A LA SERIE FIBONACCI
    'VERIFICAR SI TODOS LOS DIGITOS SON PRIMOS
    'VERIFICAR SI LOS DIGITOS ESTAN EN ORDEN DESCENDENTE
    'ELIMINAR DIGITOS MULTIPLOS DE D1
    'REORDENAR DIGITOS (PRIMOS AL PRINCIPIO, NO PRIMOS AL FINAL)
    'FORMAR UN NUMERO CON DIGITOS REPETIDOS
    'VERIFICAR SI TODOS LOS DIGITOS NO SE REPITE

    '******************************************************************************'
    '                          PRACTICO II PARTE
    '******************************************************************************'
    'VERIFICAR SI LOS DIGITOS ESTAN EN RAZON DE DOS
    'ROTAR UN DIGITO
    'INTERCALAR (PRIMOS, NO PRIMOS,PRIMOS, NO PRIMOS,...)
    'ROTAR M DIGITOS
End Class
