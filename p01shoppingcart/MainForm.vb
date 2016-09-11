Public Class MainForm
    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click

        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black

    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
    End Sub
End Class