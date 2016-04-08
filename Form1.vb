Public Class UserForm
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToad.CheckedChanged

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKong.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButtonPeach.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Specials_Click(sender As Object, e As EventArgs) Handles Specials.Click
        SpecialsForm.Show()
    End Sub

    Private Sub OrderPizza_Click(sender As System.Object, e As System.EventArgs) Handles OrderPizza.Click
        OrderPizzaForm.Show()

    End Sub
End Class
