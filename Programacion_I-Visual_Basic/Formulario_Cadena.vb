Public Class Formulario_Cadena
    Dim cad As Class_Cadena
    Private Sub ProcedimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcedimientoToolStripMenuItem.Click

    End Sub

    Private Sub Formulario_Cadena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cad = New Class_Cadena()
    End Sub

    Private Sub BtnFCCargar_Click(sender As Object, e As EventArgs) Handles BtnFCCargar.Click
        TimerFC.Start()
        'cad.cargar(RchTBoxFC1.Text)
    End Sub

    Private Sub TimerFC_Tick(sender As Object, e As EventArgs) Handles TimerFC.Tick
        PrgrssBrFC.Increment(15)
        If PrgrssBrFC.Value = 100 Then
            cad.cargar(RchTBoxFC1.Text)
            PrgrssBrFC.Value = 0
            TimerFC.Stop()
        End If
    End Sub

    Private Sub BtnFCDescargar_Click(sender As Object, e As EventArgs) Handles BtnFCDescargar.Click
        RchTBoxFC2.Text = cad.descargar
    End Sub

    Private Sub BtnFCLimpiar_Click(sender As Object, e As EventArgs) Handles BtnFCLimpiar.Click
        RchTBoxFC1.Clear()
        RchTBoxFC2.Clear()
    End Sub

    Private Sub BtnFCSalir_Click(sender As Object, e As EventArgs) Handles BtnFCSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnFCLimTxtBx1_Click(sender As Object, e As EventArgs) Handles BtnFCLimTxtBx1.Click
        RchTBoxFC1.Clear()
    End Sub

    Private Sub BtnFCLimTxtBx2_Click(sender As Object, e As EventArgs) Handles BtnFCLimTxtBx2.Click
        RchTBoxFC2.Clear()
    End Sub
End Class