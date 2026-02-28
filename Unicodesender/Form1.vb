Imports System.Windows.Forms

Public Class Form1
    Dim Uni As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txt.Text = "202E"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        End
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Uni = CInt("&H" + txt.Text)
        Me.Hide()
        SendKeys.Send(ChrW(Uni))
        System.Threading.Thread.Sleep(1000)
        Me.Show()
    End Sub
End Class
