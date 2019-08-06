Public Class Formulario_Principal
    'Direccionar al formulario Enteros
    Private Sub BtnFPNaturales_Click(sender As Object, e As EventArgs) Handles BtnFPEnteros.Click
        Try
            TimerFPEnteros.Start()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub Formulario_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Timer enteros 
    Private Sub TimerFP_Tick(sender As Object, e As EventArgs) Handles TimerFPEnteros.Tick
        PrgrssBrFP.Increment(15)
        If PrgrssBrFP.Value = 100 Then
            Formularo_Numeros_Enteros.Show()
            Me.Hide()
            TimerFPEnteros.Stop()
        End If
    End Sub
    'Direccionar al formularion Cadena
    Private Sub BtnFPCadenas_Click(sender As Object, e As EventArgs) Handles BtnFPCadenas.Click
        Try
            TimerFPCadena.Start()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    'Timer cadena
    Private Sub TimerFPCadena_Tick(sender As Object, e As EventArgs) Handles TimerFPCadena.Tick
        PrgrssBrFP.Increment(15)
        If PrgrssBrFP.Value = 100 Then
            Formulario_Cadena.Show()
            Me.Hide()
            TimerFPCadena.Stop()
        End If
    End Sub
End Class
