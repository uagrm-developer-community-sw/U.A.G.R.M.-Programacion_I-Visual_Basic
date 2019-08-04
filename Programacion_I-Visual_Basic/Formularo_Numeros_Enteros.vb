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
        CNEatural.Cargar(TxtBx1.Text)
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
    Private Sub NinclnumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NinclnumToolStripMenuItem.Click
        TxtBx3.Text = CNEatural.contar_digitos_submultiplos_m(TxtBx2.Text)
    End Sub
End Class