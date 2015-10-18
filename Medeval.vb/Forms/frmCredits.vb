Option Strict On

'Credits Helper Form:
'Merely shows the people that helped
'work on this project
Public Class frmCredits

    'Return back to the main menu
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'Go to the JabberJockey Games Website!
    Private Sub lnkLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLink.LinkClicked
        Me.lnkLink.LinkVisited = True
        System.Diagnostics.Process.Start("http://thejabberjockey.webs.com/ ")
    End Sub
End Class