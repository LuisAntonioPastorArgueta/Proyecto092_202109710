﻿Public Class MenuForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentasForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InventarioForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Has cerrado sesión.", "¡Hasta pronto!", MessageBoxButtons.OK)
        Me.Close()
    End Sub

End Class