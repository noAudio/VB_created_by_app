Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String
        Dim secondName As String
        Dim thirdName As String

        firstName = txtFirstName.Text
        secondName = txtSecondName.Text
        thirdName = txtThirdName.Text

        If txtFirstName.Text = "" Or txtSecondName.Text = "" Or txtThirdName.Text = "" Then
            lblOutput.Text = "Please input your full name!"
        ElseIf txtFirstName.Text <> "" And txtSecondName.Text <> "" And txtThirdName.Text <> "" Then
            lblOutput.Text = "This app was created by " + firstName + " " + secondName + " " + thirdName
        End If
    End Sub
End Class
