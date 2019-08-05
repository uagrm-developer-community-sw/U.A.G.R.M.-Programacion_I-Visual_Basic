Public Class Formulario_Principal
    Private Sub BtnFPNaturales_Click(sender As Object, e As EventArgs) Handles BtnFPEnteros.Click
        Try
            TimerFP.Start()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub Formulario_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TimerFP_Tick(sender As Object, e As EventArgs) Handles TimerFP.Tick
        PrgrssBrFP.Increment(15)
        If PrgrssBrFP.Value = 100 Then
            Formularo_Numeros_Enteros.Show()
            Me.Hide()
            TimerFP.Stop()
        End If
    End Sub
End Class
