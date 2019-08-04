Public Class Formulario_Principal
    Private Sub BtnFPNaturales_Click(sender As Object, e As EventArgs) Handles BtnFPEnteros.Click
        Try
            Me.Hide()
            Formularo_Numeros_Enteros.Show()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub
End Class
