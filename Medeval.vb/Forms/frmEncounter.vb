Option Strict On

'The NPC Encounter Form:
'Used to display the conversations
'between the player and the NPC
Public Class frmEncounter

    '-------------Attributes---------------
    Private npc As CMob
    Private game As CGame = frmMain.game
    Private strPrompt As String
    Private hasMorality As Boolean
    Private str1 As String
    Private str2 As String
    '-----------End of Attributes-----------

    'Constructor:
    'Sets the mob to the passed mob and 
    'determines if the current room has morality
    'if the room's mob is dead, update strPrompt to inform
    'user of that
    Public Sub New(mob As CMob, Optional hasMorality As Boolean = False)
        InitializeComponent()
        Me.hasMorality = hasMorality
        npc = mob
        If (Not npc.hasDied) Then
            strPrompt = npc.getDialogs.getCurrentNode.getPrompt
            str1 = npc.getDialogs.getCurrentNode.getR1
            str2 = npc.getDialogs.getCurrentNode.getR2
        Else
            strPrompt = npc.getName & " is dead"
            str1 = "Loot the body"
            str2 = "Leave"
        End If
        updateform()
    End Sub

    'Helper Method:
    'Updates the form with the current mob's image/name
    'and what the mob says if it is not dead
    'also sets the action buttons' texts
    Private Sub updateform()
        pbEncounter.Image = npc.getImg
        lblName.Text = npc.getName
        tbSays.Text = strPrompt
        If (Not strPrompt = npc.getName & " is dead") Then
            npc.getDialogs.getCurrentNode.playPrompt()
        End If
        btnAction1.Text = str1
        btnAction2.Text = str2
    End Sub

    'Stops the audio of the last node and advances the tree if able
    'Handles whether a battle is to be initiated or a loot is being done
    Private Sub btnAction1_Click(sender As System.Object, e As System.EventArgs) Handles btnAction1.Click
        My.Computer.Audio.Stop()
        If (str1 = "Battle") Then
            If (npc.hasDied) Then
                If (Not TypeOf game.getCurrentLvl() Is CFinalLevel) Then
                    MessageBox.Show(npc.getName & " is already dead")
                    Me.Close()
                    Return
                Else
                    MessageBox.Show("You already defeated the king")
                    Me.Close()
                    Return
                End If

            Else
                Dim frm As New frmBattle(npc)
                frm.Show()
            End If

        Else
            If (str1 = "Loot the body") Then
                If (npc.hasDrop) Then
                    Dim item As CItem = npc.getLooted
                    game.getGameState().getPlayer().addToInventory(item)
                    item.setGID(game.getGameState.getID())
                    game.addItem(item)
                    MessageBox.Show("You found a " & item.getName() & " item")
                    Me.Close()
                Else
                    MessageBox.Show(npc.getName & " has no items")
                    Me.Close()
                    Return
                End If
            ElseIf (Not str1 = "Leave") Then
                If (hasMorality) Then
                    game.getGameState().getPlayer().incrementMorality()
                End If
                npc.getDialogs.getCurrentNode.playR1()
                npc.moveDRight()
                strPrompt = npc.getDialogs.getCurrentNode.getPrompt
                str1 = npc.getDialogs.getCurrentNode.getR1
                str2 = npc.getDialogs.getCurrentNode.getR2
                updateform()
            Else
                Me.Close()
            End If
        End If

    End Sub

    'Stops the audio of the last node and advances the tree if able
    'Disable if the action button 2 says "Leave"
    Private Sub btnAction2_Click(sender As System.Object, e As System.EventArgs) Handles btnAction2.Click
        If (str2 = "Battle") Then
            If (npc.getLife <= 0) Then
                MessageBox.Show("This enemy is already dead")
                Return
            End If
            Dim frm As New frmBattle(npc)
            frm.Show()
        End If
        If (Not str2 = "Leave") Then
            If (hasMorality) Then
                game.getGameState().getPlayer().decrementMorality()
            End If
            npc.getDialogs.getCurrentNode.playR2()
            npc.moveDLeft()
            strPrompt = npc.getDialogs.getCurrentNode.getPrompt
            str1 = npc.getDialogs.getCurrentNode.getR1
            str2 = npc.getDialogs.getCurrentNode.getR2
            updateform()
        Else
            btnAction2.Enabled = False
        End If
    End Sub
End Class