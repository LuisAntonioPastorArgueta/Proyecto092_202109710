Public Class AdminForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdminUsuarioForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class