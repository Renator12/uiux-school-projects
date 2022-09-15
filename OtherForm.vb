Public Class OtherForm
    Public name As String
    Public Sub New(text1 As String)

        ' This call is required by the designer.
        InitializeComponent()
        name = text1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        MessageBox.Show("Closing file")
        Close()

    End Sub


End Class