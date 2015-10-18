Option Strict On

'Game Window Form
Public Class frmGameWindow
    Private mainmenu As frmMain
    Private game As CGame = frmMain.game
    Private lvl As CLevel

    Private Sub ToWindowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToWindowsToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub launchLevel()
        lvl = game.getCurrentLvl()
        CLevel.setCurrentRoom(game.getGameState.getRoomNum)
        Dim room As CRoom = lvl.getCurrentRoom()
        If (Not lvl.isLvlCleared()) Then
            If (room.enabled()) Then
                launchRoom(room)
            Else
                MessageBox.Show("You can not move that way")
            End If
        End If

    End Sub

    Private Sub launchRoom(room As CRoom)
        tbInfo.Text = lvl.getCurrentRoom.getDescription()
        lvl.getCurrentRoom.enter()
        If (lvl.getCurrentRoom.isEvent Or lvl.getCurrentRoom.isMorality) Then
            btnInspect.Visible = True
        Else
            btnInspect.Visible = False
        End If
    End Sub

    Private Sub btnInventory_Click(sender As System.Object, e As System.EventArgs) Handles btnInventory.Click
        If (game.getGameState.getPlayer.getNumItems <= 0) Then
            MessageBox.Show("You have no items")
        Else
            Dim frm As New frmInventory
            frm.Show()
        End If
    End Sub

    Private Sub updateStat()
        tbstat.Text = game.getGameState.getPlayer.getName & vbNewLine & game.getGameState.getPlayer.getLife() & "/" & game.getGameState.getPlayer.getMaxLife()
    End Sub

    Private Sub frmGameWindow_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        updateStat()
        launchLevel()
        If (TypeOf (lvl) Is CFinalLevel And Not lvl.getCurrentRoom.isEnemy()) Then
            btnInspect.Enabled = False
        End If
    End Sub

    Private Sub btnInspect_Click(sender As System.Object, e As System.EventArgs) Handles btnInspect.Click
        If (lvl.getCurrentRoom.isEvent()) Then

            My.Computer.Audio.Stop()
            Dim frm As New frmEncounter(lvl.getCurrentRoom.getEvent, lvl.getCurrentRoom.isMorality)
            lvl.getCurrentRoom.doEvent()
            frm.Show()
        Else
            MessageBox.Show("Users should never see this")
        End If
    End Sub

    Private Sub btnAdvance_Click(sender As System.Object, e As System.EventArgs) Handles btnAdvance.Click
        If (lvl.getCurrentRoom.isEnemy) Then
            MessageBox.Show(lvl.getCurrentRoom.getEvent.getName & " blocks the path")
            Return
        End If
        If (TypeOf (game.getCurrentLvl()) Is CFinalLevel) Then
            Dim frm As New frmEpilouge(game)
            frm.Show()
            Me.Close()
        ElseIf (lvl.move()) Then
            game.getGameState().setRoom(lvl.getCurrentRoomNum())
            If (lvl.isLvlCleared()) Then
                game.getGameState.increaselvl()
                game.getGameState.setRoom(0)
            End If
            launchLevel()
            game.saveGame()

        Else
            MessageBox.Show("Next room is either unavailable or not enabled yet")
        End If
    End Sub

    Private Sub ToMainMenuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToMainMenuToolStripMenuItem.Click
        mainmenu = New frmMain
        mainmenu.Show()
        Me.Close()
    End Sub
End Class