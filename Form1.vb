Imports System.Windows

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NEXTBUTTON.Click
        Dim NewWindow As New OtherForm(WindowName.Text)
        NewWindow.Show()
        NewWindow.NameLabel.Text = WindowName.Text
        NewWindow.Text = WindowName.Text
    End Sub

    Private Sub OffButton_Click(sender As Object, e As EventArgs) Handles OffButton.Click
        Close()
    End Sub


End Class
