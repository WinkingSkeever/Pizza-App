Public Class LogisticsForm
    Public logistics As String


    Private Sub Delivery_Click(sender As Object, e As EventArgs) Handles Delivery.Click
        logistics = "Delivery Selected"
    End Sub

    Private Sub PickUp_Click(sender As Object, e As EventArgs) Handles PickUp.Click
        logistics = "Pick-Up Selected"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)


        Label4.Text = logistics



    End Sub

    Private Sub OrderPizza_Click(sender As Object, e As EventArgs) Handles OrderPizza.Click
        UserForm.Show()

    End Sub
End Class