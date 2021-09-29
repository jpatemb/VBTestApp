Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome")
        MsgBox("bitch!")
        MsgBox("to")
        MsgBox("the")
        MsgBox("Thunderdome")

        MessageBox.Show("Welcome to the Thunderdome bitch!")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "James "
        stLastName = "Embrey"

        MsgBox("Hello and welcome " & stFirstName & stLastName + "! I hope you are having a wonderful day!")

        stFirstName = "Semaj "
        stLastName = "Yember"

        MsgBox("Hello and welcome " & stFirstName & stLastName + "! I hope you are having a wonderful day!")

    End Sub



End Class
