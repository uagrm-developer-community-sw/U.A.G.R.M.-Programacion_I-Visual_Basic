Public Class Formulario_Cadena
    Dim cad As Class_Cadena
    Private Sub ProcedimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcedimientoToolStripMenuItem.Click

    End Sub

    Private Sub Formulario_Cadena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cad = New Class_Cadena()
    End Sub
    'Cargar - Btn
    Private Sub BtnFCCargar_Click(sender As Object, e As EventArgs) Handles BtnFCCargar.Click
        TimerFC.Start()
        'cad.cargar(RchTBoxFC1.Text)
    End Sub
    'Timerfc
    Private Sub TimerFC_Tick(sender As Object, e As EventArgs) Handles TimerFC.Tick
        PrgrssBrFC.Increment(15)
        If PrgrssBrFC.Value = 100 Then
            cad.cargar(RchTBoxFC1.Text)
            PrgrssBrFC.Value = 0
            TimerFC.Stop()
        End If
    End Sub
    'Descargar - Btn
    Private Sub BtnFCDescargar_Click(sender As Object, e As EventArgs) Handles BtnFCDescargar.Click
        RchTBoxFC3.Text = cad.descargar
    End Sub
    'Limpiar - Btn
    Private Sub BtnFCLimpiar_Click(sender As Object, e As EventArgs) Handles BtnFCLimpiar.Click
        RchTBoxFC1.Clear()
        RchTBoxFC2.Clear()
        RchTBoxFC3.Clear()
    End Sub
    'Salir - Btn
    Private Sub BtnFCSalir_Click(sender As Object, e As EventArgs) Handles BtnFCSalir.Click
        Me.Close()
    End Sub
    'Limipar Txtbx1 - Btn
    Private Sub BtnFCLimTxtBx1_Click(sender As Object, e As EventArgs) Handles BtnFCLimTxtBx1.Click
        RchTBoxFC1.Clear()
    End Sub
    'Limipar Txtbx2 - Btn
    Private Sub BtnFCLimTxtBx2_Click(sender As Object, e As EventArgs) Handles BtnFCLimTxtBx2.Click
        RchTBoxFC2.Clear()
    End Sub
    'Cargar - StripMenu
    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        BtnFCCargar.PerformClick()
    End Sub
    ' Descargar - StripMenu
    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        BtnFCDescargar.PerformClick()
    End Sub
    'Limpiar - StripMenu
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        BtnFCLimpiar.PerformClick()
    End Sub
    'Salir - StripMenu
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        BtnFCSalir.PerformClick()
    End Sub
    'Verificar consonantes
    Private Sub VerificarConsonantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarConsonantesToolStripMenuItem.Click
        RchTBoxFC3.Text = Convert.ToString(cad.Verificar_Consonantes(Convert.ToString(RchTBoxFC1.Text)))
    End Sub
    'Limipar Txtbx3 - Btn
    Private Sub BtnFCLimTxtBx3_Click(sender As Object, e As EventArgs) Handles BtnFCLimTxtBx3.Click
        RchTBoxFC3.Clear()
    End Sub
End Class