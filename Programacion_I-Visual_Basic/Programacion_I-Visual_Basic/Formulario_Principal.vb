Public Class Formulario_Principal
    Private Sub BtnFPNaturales_Click(sender As Object, e As EventArgs) Handles BtnFPNaturales.Click
        Try
            Me.Hide()
            Formularo_Numeros_Naturales.Show()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub
End Class
