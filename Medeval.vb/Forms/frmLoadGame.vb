Option Strict On

'The Load Game Form
Public Class frmLoadGame
    Private game As CGame = frmMain.game
    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Dim gamesel As CGameState
        gamesel = TryCast(lbGames.SelectedItem, CGameState)
        If (Not gamesel Is Nothing) Then
            Dim gw As New frmGameWindow
            game.open(gamesel)
            gw.Show()
            My.Computer.Audio.Stop()
            Me.Close()
        Else
            MessageBox.Show("No game was selected", "Select a game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
    End Sub

    Private Sub frmLoadGame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        updateBox()
    End Sub

    Private Sub updateBox()
        lbGames.Items.Clear()
        For Each cgs As CGameState In game.getGameCol
            lbGames.Items.Add(cgs)
        Next
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Dim frm As New frmMain
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim gamesel As CGameState
        gamesel = TryCast(lbGames.SelectedItem, CGameState)
        If (Not gamesel Is Nothing) Then
            game.remove(gamesel)
            updateBox()
        Else
            MessageBox.Show("No game was selected", "Select a game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
    End Sub
End Class