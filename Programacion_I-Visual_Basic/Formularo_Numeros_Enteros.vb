Public Class Formularo_Numeros_Enteros
    Dim CNEatural As Class_Numeros_Enteros
    'SALIR BTN
    Private Sub BtnFNNSalir_Click(sender As Object, e As EventArgs) Handles BtnFNNSalir.Click
        Me.Close()
    End Sub
    'LIMPIAR TODO TEXTO BTN
    Private Sub BtnFNNLimpiar_Click(sender As Object, e As EventArgs) Handles BtnFNNLimpiar.Click
        TxtBx1.Clear()
        TxtBx2.Clear()
        TxtBx3.Clear()
    End Sub
    'LIMPIAR TEXTBOX 1 BTN
    Private Sub BtnFNNLimTxtBx1_Click(sender As Object, e As EventArgs) Handles BtnFNNLimTxtBx1.Click
        TxtBx1.Clear()
    End Sub
    'LIMPIAR TEXTBOX 2 BTN
    Private Sub BtnFNNLimTxtBx2_Click(sender As Object, e As EventArgs) Handles BtnFNNLimTxtBx2.Click
        TxtBx2.Clear()
    End Sub
    'LIMPIAR TEXTBOX 3 BTN
    Private Sub BtnFNNLimTxtBx3_Click(sender As Object, e As EventArgs) Handles BtnFNNLimTxtBx3.Click
        TxtBx3.Clear()
    End Sub
    'SALIR MNSTRING
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        BtnFNNSalir.PerformClick()
    End Sub
    'LIMPIAR TODO TEXTOS "MNSTRING"
    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        BtnFNNLimpiar.PerformClick()
    End Sub
    'CARGAR BTN
    Private Sub BtnFNNCargar_Click(sender As Object, e As EventArgs) Handles BtnFNNCargar.Click
        TimerFNE.Start()
        'CNEatural.Cargar(TxtBx1.Text)
    End Sub
    'ACTIVAR FORMULARIO
    Private Sub Formularo_Numeros_Naturales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CNEatural = New Class_Numeros_Enteros()
    End Sub
    'DESCARGAR BTN
    Private Sub BtnFNNDescargar_Click(sender As Object, e As EventArgs) Handles BtnFNNDescargar.Click
        TxtBx3.Text = CNEatural.descargar()
    End Sub
    'CARGAR "MNSTRING"
    Private Sub CARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARToolStripMenuItem.Click
        BtnFNNCargar.PerformClick()
    End Sub
    'DESCARGAR "MNSTRING"
    Private Sub DESCARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem.Click
        BtnFNNDescargar.PerformClick()
    End Sub
    'CONTAR DIGITOS "MNSTRING"
    Private Sub ContarDgitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContarDgitosToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.contar_digito()
    End Sub
    'CONTAR LAS VECES QUE M SE ENCUENTRA EN N "MNSTRING"
    Private Sub ContarLasVecesQueMSeEncuentraEnNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContarLasVecesQueMSeEncuentraEnNToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.contar_veces_m_encuentra_n(TxtBx2.Text)
    End Sub
    'DIGITO MAYOR "MNSTRING"
    Private Sub DigitoMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitoMayorToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.digito_mayor()
    End Sub
    'DIGITO MENOR "MNSTRING"
    Private Sub DigitoMenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitoMenorToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.digito_menor()
    End Sub
    'CONTAR DIGITOS SUBMULTIPLOS DE M "MNSTRING"
    Private Sub NinclnumToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TxtBx3.Text = CNEatural.contar_digitos_submultiplos_m(TxtBx2.Text)
    End Sub
    'PROCESO DE TIMER 
    Private Sub TimerFNE_Tick(sender As Object, e As EventArgs) Handles TimerFNE.Tick
        PrgrssBrFNE.Increment(15)
        If PrgrssBrFNE.Value = 100 Then
            CNEatural.Cargar(TxtBx1.Text)
            PrgrssBrFNE.Value = 0
            TimerFNE.Stop()
        End If
    End Sub
    'CONTAR DIGITOS SUBMULTIPLOS DE M
    Private Sub CONTARDIGITOSSUBMULTIPLOSDEMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTARDIGITOSSUBMULTIPLOSDEMToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.contar_digitos_submultiplos_m(TxtBx2.Text)
    End Sub
    'BUSCAR SI EXISTE UN DIGITO EN UN NUMERO DE Class_Numero_Entero
    Private Sub BuscarSiExisteUnDigitoEnUnNEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarSiExisteUnDigitoEnUnNEToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.buscar_existe_digito_class_numero_entero(TxtBx2.Text)
    End Sub
    'VERIFICAR SI TODOS LOS DIGITOS SON IGUALES
    Private Sub VERIFICARSITODOSLOSDIGITOSSONIGUALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSITODOSLOSDIGITOSSONIGUALESToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_digitos_iguales()
    End Sub
    'FRECUENCIA DE UN DIGITO
    Private Sub FRECUENCIADEUNDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FRECUENCIADEUNDIGITOToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.frecuencia_de_un_digito(TxtBx2.Text)
    End Sub
    'VERIFICAR SI TODOS LOS DIGITOS SE REPITEN
    Private Sub VERIFICARSITODOSLOSDIGITOSSEREPITENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSITODOSLOSDIGITOSSEREPITENToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_todos_digitos_repiten()
    End Sub
    'INVERTIR UN NUMERO DE Class_Numero_Entero
    Private Sub INVERTIRUNNUMERODEClassNumeroEnteroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INVERTIRUNNUMERODEClassNumeroEnteroToolStripMenuItem.Click
        CNEatural.invertir_un_numero_class_numero_entero()
    End Sub
    'VERIFICAR SI UN NUMERO DE Class_Numero_Entero ES CAPICUA
    Private Sub VERIFICARSIUNNUMERODEClassNumeroEnteroESCAPICUAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSIUNNUMERODEClassNumeroEnteroESCAPICUAToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_class_numero_entero_es_capicua()
    End Sub
    'CONVERTIR UN NUMERO DE Class_Numero_Entero EN BINARIO
    Private Sub CONVERTIRUNNUMERODEClassNumeroEnteroENBINARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONVERTIRUNNUMERODEClassNumeroEnteroENBINARIOToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.convertir_numero_class_numero_entero_binario()
    End Sub
    'CONVERTIR UN DECIMAL A OTRA BASE(2..9)
    Private Sub CONVERTIRUNDECIMALAOTRABASE29ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONVERTIRUNDECIMALAOTRABASE29ToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.convertir_decimal_otra_base(TxtBx2.Text)
    End Sub
    'FORMAR UN NUMERO DE Class_Numero_Entero CON DIGITOS PARES
    Private Sub FORMARUNNUMERODEClassNumeroEnteroCONDIGITOSPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMARUNNUMERODEClassNumeroEnteroCONDIGITOSPARESToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.formar_numero_class_numeros_enteros_con_digitos_pares()
    End Sub
    'FUSIONAR DOS NUMEROS DE Class_Numero_Entero
    Private Sub FUSIONARDOSNUMEROSDEClassNumeroEnteroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FUSIONARDOSNUMEROSDEClassNumeroEnteroToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.fusionar_dos_numeros_class_numeros_enteros(TxtBx2.Text)
    End Sub
    'SEGMENTAR ORDENADAMENTE EN PARES E IMPARES
    Private Sub SEGMENTARORDENADAMENTEENPARESEIMPARESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEGMENTARORDENADAMENTEENPARESEIMPARESToolStripMenuItem.Click
        CNEatural.segmentar_ordenadamente_pares_impares()
    End Sub
    'CORTAR UN DIGITO DE UN NUMERO DE Class_Numero_Entero
    Private Sub CORTARUNDIGITODEUNNUMERODEClassNumeroEnteroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CORTARUNDIGITODEUNNUMERODEClassNumeroEnteroToolStripMenuItem.Click
        CNEatural.cortar_digitos_class_numeros_enteros(TxtBx2.Text)
    End Sub
    'ORDENAR DIGITOS
    Private Sub ORDENARDIGITOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDIGITOSToolStripMenuItem.Click
        CNEatural.ordenar_digitos()
    End Sub
    'INTERCALAR DIGITOS (MAYOR,MENOR,MAYOR,MENOR,...)
    Private Sub INTERCALARDIGITOSMAYORMENORMAYORMENORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERCALARDIGITOSMAYORMENORMAYORMENORToolStripMenuItem.Click
        CNEatural.intercalar_mayor_menor()
    End Sub
    'VERIFICAR SI UN NUMERO ES FIBONACCI
    Private Sub VERIFICARSIUNNUMEROESFIBONACCIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSIUNNUMEROESFIBONACCIToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_numero_fibonacci(TxtBx2.Text)
    End Sub
    'CONTAR DIGITOS CON FRECUENCIA PAR
    Private Sub CONTARDIGITOSCONFRECUENCIAPARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTARDIGITOSCONFRECUENCIAPARToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.contar_digitos_frecuencia_par()
    End Sub
    'CONTAR DIGITOS QUE PERTENECEN A LA SERIE FIBONACCI
    Private Sub CONTARDIGITOSQUEPERTENCENALASERIEFIBONACCIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTARDIGITOSQUEPERTENCENALASERIEFIBONACCIToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.contar_digitos_pertenecen_serie_fibonacci()
    End Sub
    'VERIFICAR SI TODOS LOS DIGITOS SON PRIMOS
    Private Sub VERIFICARSITODOSLOSDIGITOSSONPRIMOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSITODOSLOSDIGITOSSONPRIMOSToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_todos_digitos_primos(TxtBx2.Text)
    End Sub
    'VERIFICAR SI LOS DIGITOS ESTAN EN ORDEN DESCENDENTE
    Private Sub VERIFICARSILOSDIGITOSESTANENORDENDESCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSILOSDIGITOSESTANENORDENDESCENDENTEToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_digitos_orden_decendente()
    End Sub
    'ELIMINAR DIGITOS MULTIPLOS DE D
    Private Sub ELIMINARDIGITOSMULTIPLOSDED1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARDIGITOSMULTIPLOSDED1ToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.eliminar_digitos_multiplos_d(TxtBx2.Text)
    End Sub
    'REORDENAR DIGITOS (PRIMOS AL PRINCIPIO, NO PRIMOS AL FINAL)
    Private Sub REORDENARDIGITOSPRIMOSALPRINCIPIONOPRIMOSALFINALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REORDENARDIGITOSPRIMOSALPRINCIPIONOPRIMOSALFINALToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.reordenar_digitos_primos_NoPrimos()
    End Sub
    'FORMAR UN NUMERO CON DIGITOS REPETIDOS
    Private Sub FORMARUNNUMEROCONDIGITOSREPETIDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMARUNNUMEROCONDIGITOSREPETIDOSToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.formar_numero_digitos_repetidos()
    End Sub
    'VERIFICAR SI TODOS LOS DIGITOS NO SE REPITE
    Private Sub VERIFICARSITODOSLOSDIGITOSNOSEREPITENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSITODOSLOSDIGITOSNOSEREPITENToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_todos_digitos_Norepiten()
    End Sub
    'VERIFICAR SI LOS DIGITOS ESTAN EN RAZON DE DOS
    Private Sub VERIFICARSILOSDIGITOSESTANENRAZONDEDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERIFICARSILOSDIGITOSESTANENRAZONDEDOSToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.verificar_estan_razon_dos()
    End Sub
    'ROTAR UN DIGITO
    Private Sub ROTARUNDIGITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROTARUNDIGITOToolStripMenuItem.Click
        CNEatural.rotar_un_digito()
    End Sub
    'INTERCALAR (PRIMOS, NO PRIMOS,PRIMOS, NO PRIMOS,...)
    Private Sub INTERCALARPRIMOSNOPRIMOSPRIMOSNOPRIMOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERCALARPRIMOSNOPRIMOSPRIMOSNOPRIMOSToolStripMenuItem.Click
        CNEatural.intercalar_primos_Noprimos()
    End Sub
    'ROTAR M DIGITOS
    Private Sub ROTARMDIGITOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROTARMDIGITOSToolStripMenuItem.Click
        CNEatural.rotar_m_digitos(TxtBx2.Text)
    End Sub
End Class