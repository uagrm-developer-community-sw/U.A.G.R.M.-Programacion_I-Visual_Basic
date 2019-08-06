Public Class Class_Cadena
    Private s As String
    Sub cadena()
        s = ""
    End Sub
    Sub cargar(ByVal s1 As String)
        s = s1
    End Sub
    Function descargar() As String
        Return s
    End Function
    '============================='
    '        HERRAMIENTAS         '
    '============================='
    Function Verificar_Consonantes(ByVal i As Integer) As Boolean
        Dim Cons As String = "bcdfghjklmnñpqrstvwxyzBCDFGHJKLMNÑPQRSTVWXYZ"
        If InStr(Cons, s(i)) >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Verificar_Caracter(ByVal s1 As String, ByVal i As Integer) As Boolean
        If InStr(s1, s(i)) >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Verificar_Vocales(ByVal i As Integer) As Boolean
        Dim Vocales As String = "aeiouAEIOU"
        If InStr(Vocales, s(i)) >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function Contar_Vocales() As Integer
        Dim i, c As Integer
        c = 0
        For i = 0 To Len(s) - 1
            If Verificar_Vocales(i) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Sub eliminar_caracter_en_pos(ByVal pos As Integer)
        s = s.Remove(pos, 1)
    End Sub
    Function Invertir_Palabra(ByVal pal As String) As String
        Dim i As Integer
        Dim s1 As String = ""
        For i = 0 To Len(pal) - 1
            s1 = s1.Insert(i, pal(Len(pal) - (i + 1)))
        Next
        Return s1
    End Function
    Sub Intercambiar_Palabras(ByVal i As Integer, ByVal j As Integer)
        Dim pal, pal1 As String
        Dim posI, posJ, Aux As Integer
        If i <= Cantidad_Palabras() And j <= Cantidad_Palabras() Then
            If i > j Then
                Aux = i : i = j : j = Aux
            End If
            pal = Obtener_Palabra(i)
            pal1 = Obtener_Palabra(j)
            posI = Posicion(i)
            s = s.Remove(posI, Len(pal) + 1)
            s = s.Insert(posI, pal1 + " ")
            posJ = Posicion(j)
            If j = Cantidad_Palabras() Then
                s = s.Remove(posJ, Len(pal1))
                posJ = Len(s)
                s = s.Insert(posJ, pal)
            Else
                s = s.Remove(posJ, Len(pal1) + 1)
                posJ = Posicion(j)
                s = s.Insert(posJ, pal + " ")
            End If
        End If
    End Sub
    Function Obtener_Palabra_mas_Extensa() As String
        Dim i As Integer
        Dim PalExt, pal As String
        PalExt = Obtener_Palabra(1)
        For i = 2 To Cantidad_Palabras()
            pal = Obtener_Palabra(i)
            If Len(pal) > Len(PalExt) Then
                PalExt = pal
            End If
        Next
        Return PalExt
    End Function
    Function Obtener_Palabra_mas_Corta() As String
        Dim i As Integer
        Dim PalCor, pal As String
        PalCor = Obtener_Palabra(1)
        For i = 2 To Cantidad_Palabras()
            pal = Obtener_Palabra(i)
            If Len(pal) < Len(PalCor) Then
                PalCor = pal
            End If
        Next
        Return PalCor
    End Function
    Sub Elimnar_Palabra_mas_Extensa()
        Dim i, iPalExt As Integer
        Dim PalExt, pal As String
        PalExt = Obtener_Palabra(1)
        iPalExt = 1
        For i = 2 To Cantidad_Palabras()
            pal = Obtener_Palabra(i)
            If Len(pal) > Len(PalExt) Then
                iPalExt = i
                PalExt = pal
            End If
        Next
        Eliminar_Palabra(iPalExt)
    End Sub
    Sub Elimnar_Palabra_mas_Corta()
        Dim i, iPalCor As Integer
        Dim PalCor, pal As String
        PalCor = Obtener_Palabra(1)
        iPalCor = 1
        For i = 2 To Cantidad_Palabras()
            pal = Obtener_Palabra(i)
            If Len(pal) < Len(PalCor) Then
                iPalCor = i
                PalCor = pal
            End If
        Next
        Eliminar_Palabra(iPalCor)
    End Sub
    Sub Eliminar_Palabra(ByVal i As Integer)
        Dim pos As Integer
        Dim pal As String
        If i <= Cantidad_Palabras() Then
            pos = Posicion(i)
            pal = Obtener_Palabra(i)
            If i = Cantidad_Palabras() Then
                s = s.Remove(pos, Len(pal))
            Else
                s = s.Remove(pos, Len(pal) + 1)
            End If
        End If
        s = Trim(s)
    End Sub
    Function Verificar_Palabra(ByVal s1 As String, ByVal i As Integer) As Boolean
        If InStr(s1, Obtener_Palabra(i)) >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    'i : ordinal de la palabra
    Function Posicion(ByVal i As Integer) As Integer
        Dim c, pos As Integer
        Dim pal As String
        pos = 0
        If i <= Cantidad_Palabras() Then
            c = 1
            While c < i
                pal = Obtener_Palabra(c)
                pos = pos + Len(pal) + 1
                c = c + 1
            End While
        End If
        Return pos
    End Function
    Function Cantidad_Palabras() As Integer
        Dim s1 As String = s + " "
        Dim pal As String = " "
        Dim x, p As Integer
        x = 0
        While s1 <> ""
            p = InStr(s1, " ")
            pal = Mid(s1, 1, p - 1)
            s1 = Mid(s1, p + 1)
            If pal <> "" Then
                x = x + 1
            End If
        End While
        Return x
    End Function
    Function Obtener_Palabra(ByVal i As Integer) As String
        Dim pal As String = ""
        Dim s1 As String = s + " "
        Dim x, p As Integer
        x = 1 : pal = ""
        If i <= Cantidad_Palabras() Then
            While x <= i
                p = InStr(s1, " ")
                pal = Mid(s1, 1, p - 1)
                s1 = Mid(s1, p + 1)
                If pal <> "" Then
                    x = x + 1
                End If
            End While
        End If
        Return pal
    End Function
    Sub Invertir()
        Dim i As Integer
        Dim s1 As String = ""
        For i = 0 To Len(s) - 1
            s1 = s1.Insert(i, s(Len(s) - (i + 1)))
        Next
        s = s1
    End Sub

    '============================='
    '           PRACTICO          '
    '============================='
    '1. Contar consonantes, sean mayúsculas o minúsculas de una cadena Ej. S="Hola Juan" => el resultado es 4 (h,l,J,n)
    Function Contar_Consonantes() As Integer
        Dim i, c As Integer
        c = 0
        For i = 0 To Len(s) - 1
            If Verificar_Consonantes(i) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    '2. Contar caracteres diferentes de una cadena.
    Function Contar_Caracteres_Diferentes() As Integer
        Dim i, c As Integer
        Dim s1 As String = ""
        c = 0
        For i = 0 To Len(s) - 1
            If Not (Verificar_Caracter(s1, i)) Then
                s1 = s1 + s(i)
                c = c + 1
            End If
        Next
        Return c
    End Function
    '3.Verificar si una cadena tiene las 5 vocales, sean estas mayúsculas o minúsculas.
    Function Verificar_las_5_Vocales() As Boolean
        Dim i, c As Integer
        Dim s1 As String = ""
        Dim cad As Class_Cadena = New Class_Cadena
        cad.cargar(Me.s)
        cad.s = UCase(cad.s)
        c = 0
        For i = 0 To Len(cad.s) - 1
            If cad.Verificar_Vocales(i) Then
                If InStr(s1, cad.s(i)) >= 1 Then
                Else
                    s1 = s1 + cad.s(i)
                    c = c + 1
                End If
            End If
        Next
        If c = 5 Then
            Return True
        Else
            Return False
        End If
    End Function
    '4. VErificar si una cadena tiene mas vocales que consonantes.
    Function Mas_Vocales_q_Consonantes() As Boolean
        If Contar_Vocales() > Contar_Consonantes() Then
            Return True
        Else
            Return False
        End If
    End Function
    '5. Eliminar caracteres repetidos y continuos de una cadena.
    Sub Eliminar_Caracteres_Repetidos_y_Continuos()
        Dim i, j As Integer
        For i = 0 To Len(s) - 1
            j = i + 1
            While j < Len(s)
                If s(j) = s(i) Then
                    eliminar_caracter_en_pos(j)
                Else
                    j = j + 1
                End If
            End While

        Next
    End Sub
    '6. Contar palabras palíndromas de una cadena
    Function Contar_palabras_palindromas() As Integer
        Dim s1 As String = s + " "
        Dim pal As String = " "
        Dim x, p As Integer
        x = 0
        While s1 <> ""
            p = InStr(s1, " ")
            pal = Mid(s1, 1, p - 1)
            s1 = Mid(s1, p + 1)
            If pal <> "" And Invertir_Palabra(pal) = pal Then
                x = x + 1
            End If
        End While
        Return x
    End Function
    '7.Eliminar una palabra p de una cadena (Solo una)
    Sub Eliminar_1_palabra(ByVal pal As String)
        Dim p As Integer
        p = InStr(s, pal)
        s = s.Remove(p - 1, Len(pal) + 1)
    End Sub

    '8. Ordenar las palabras por el numero de caracteres diferentes. De menor a mayor.
    Sub Ordenar_Palabras_x_Numero_Caracteres_Diferentes_de_menor_a_MAYOR()
        Dim sa, sb As Class_Cadena
        Dim i, j As Integer
        Dim pal As String
        sa = New Class_Cadena
        sb = New Class_Cadena
        For i = 1 To Cantidad_Palabras()
            pal = Obtener_Palabra(i)
            sa.cargar(pal)
            For j = i + 1 To Cantidad_Palabras()
                pal = Obtener_Palabra(j)
                sb.cargar(pal)
                If sa.Contar_Caracteres_Diferentes > sb.Contar_Caracteres_Diferentes Then
                    Intercambiar_Palabras(i, j)
                    sa.cargar(sb.descargar)
                End If
            Next
        Next
    End Sub
    '9. Intercalar palabras de acuerdo a su longitud. La mas extensa, 
    '   luego las mas corta, la segunda extensa, .. y así sucesivamente.
    Sub Intercalar_Palabras_Extensa_Corta()
        Dim i As Integer
        Dim cad As Class_Cadena
        Dim sw As Boolean = True
        Dim sa As String
        sa = ""
        cad = New Class_Cadena
        cad.cargar(Me.descargar)
        For i = 1 To Cantidad_Palabras()
            If sw Then
                sa = sa + " " + cad.Obtener_Palabra_mas_Extensa()
                cad.Elimnar_Palabra_mas_Extensa()
            Else
                sa = sa + " " + cad.Obtener_Palabra_mas_Corta()
                cad.Elimnar_Palabra_mas_Corta()
            End If
            sw = Not (sw)
        Next
        sa = Trim(sa)
        s = sa
    End Sub
    '10. Invertir las palabras de una cadena. Las palabras del final al principio y asi sucesivamente.
    Sub invertir_pals()
        Dim sa As Class_Cadena
        Dim p As UShort
        Dim pal, s1 As String
        sa = New Class_Cadena
        s = s + " "
        s1 = " "
        While s <> ""
            p = InStr(s, " ")
            pal = Mid(s, 1, p - 1)
            s = Mid(s, p + 1)
            sa.cargar(pal)
            s1 = sa.descargar + " " + s1
        End While
        s = Mid(s1, 1, Len(s1) - 1)
        s = Trim(s)
    End Sub
    '11. Elimnar palabras repetidas y continuas de una cadena.
    Sub Eliminar_Palabras_Repetidas_y_Continuas()
        Dim i, j As Integer
        Dim pal, pal1 As String
        For i = 1 To Cantidad_Palabras() - 1
            j = i + 1
            pal = Obtener_Palabra(i)
            While j <= Cantidad_Palabras()
                pal1 = Obtener_Palabra(j)
                If pal = pal1 Then
                    Eliminar_Palabra(j)
                Else
                    j = j + 1
                End If
            End While
        Next
    End Sub
    '12. Contar palabras diferentes de una cadena. Se asume que existen palabras repetidas.
    Function Contar_Palabras_Diferentes() As Integer
        Dim i, c As Integer
        Dim s1 As String = ""
        c = 0
        For i = 1 To Cantidad_Palabras()
            If Not (Verificar_Palabra(s1, i)) Then
                s1 = s1 + Obtener_Palabra(i)
                c = c + 1
            End If
        Next
        Return c
    End Function

End Class
