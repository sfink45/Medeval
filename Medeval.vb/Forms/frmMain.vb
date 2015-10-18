Option Strict On

'The Main Form
Public Class frmMain

    Public Shared game As New CGame

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Dim frm As New frmLoadGame
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As System.Object, e As System.EventArgs) Handles btnNewGame.Click
        Dim frm As New frmNewGame
        frm.Show()
        Me.Close()
    End Sub

    Private Sub frmMain_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If (game.getGameCol.Count <= 0) Then
            btnLoad.Visible = False
        Else
            btnLoad.Visible = True
        End If

    End Sub

    Private Sub btnCreds_Click(sender As System.Object, e As System.EventArgs) Handles btnCreds.Click
        Dim frm As New frmCredits
        frm.Show()
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim msg As String = ""
        My.Computer.Audio.Play(My.Resources.placeholding_title, AudioPlayMode.BackgroundLoop)
        If (Not game.getSavedGames(msg)) Then
            MessageBox.Show(msg)
        End If

    End Sub
End Class
