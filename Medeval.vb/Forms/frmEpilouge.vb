Option Strict On

'The Epilouge Form:
'Used for the wrapping up
'the last part of the story
'and taking the player's last choice
Public Class frmEpilouge

    '--------------Attributes------------------
    Private game As CGame
    Private sound As IO.UnmanagedMemoryStream
    '---------End of Attributes---------------

    'Constructor:
    'Sets the passed game to the
    'game attribute of the form
    Public Sub New(game As CGame)
        InitializeComponent()
        lblThanks.Visible = False
        btnQuit.Visible = False
        btnToMain.Visible = False
        Me.game = game
    End Sub

    'Closes the game and exits to windows
    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    'Closes the form and returns user to
    'the main menu
    Private Sub btnToMain_Click(sender As System.Object, e As System.EventArgs) Handles btnToMain.Click
        Dim frm As New frmMain
        frm.Show()
        Me.Close()
    End Sub

    'Helper Method:
    'Sets the text of the textbox
    'to the passed string
    Private Sub setText(str As String)
        tbEpilouge.Text = str
    End Sub

    'Action Button Clicked Methods:
    'Sets the epilouge's text and sound to 
    'different solutions based on the player morality
    '=========================================================================================
    Private Sub btnKill_Click(sender As System.Object, e As System.EventArgs) Handles btnKill.Click
        btnKill.Visible = False
        btnSpare.Visible = False
        If (game.getGameState.getPlayer.getMorality >= 0) Then
            setText("With the tyrant king no longer, a great roar of praise and thanksgiving rose up from the commoners of Iman as they welcomed their Savior as their leader.  Never before had there been a wiser or fairer ruler.  Peace swept over the land and the chaos of the past was forgotten.  The heavens themselves smiled upon the earth during the Savior’s reign and blessed the land with a bountiful harvest that yielded more crops than the mind could even comprehend.  The kingdom continued to prosper until the Savior’s death many years later.  A violent race for the throne commenced as the people of Iman could not decide the next ruler.  Brother was pitted against brother and son against father as a civil war broke out. At the end of the war, Iman was in ruins and unable to recover.  The rest of Iman’s history was forgotten. ")
            sound = My.Resources.PosMorKillKing
            tmrdelay.Start()
        Else
            setText("With the tyrant king no longer, a great roar of praise and thanksgiving rose up from the commoners of Iman as they welcomed their Savior as their leader.  While the Savior ruled competently over the land, she was always tormented by the choices she had made during her rise to power.  Every night, she was tormented the screams of agony and flashes of fires.  The Savior knew her hands could never be wiped clean of the innocent blood that had been shed because of her actions.  Years later, the guilt became too much and fell upon her own sword to escape it.  Following the Savior’s death, A violent race for the throne commenced as the people of Iman could not decide the next ruler.  Brother was pitted against brother and son against father as a civil war broke out. At the end of the war, Iman was in ruins and unable to recover.  The rest of Iman’s history was forgotten.")
            sound = My.Resources.negMorKillKing
            tmrdelay.Start()
        End If

    End Sub

    Private Sub btnSpare_Click(sender As System.Object, e As System.EventArgs) Handles btnSpare.Click
        btnKill.Visible = False
        btnSpare.Visible = False
        If (game.getGameState.getPlayer.getMorality >= 0) Then
            setText("The Savior exiled the former king from Iman to the icy plains of the North, where he remained the rest of his life.  Back in the kingdom, a great roar of praise and thanksgiving rose up from the commoners of Iman as they welcomed their Savior as their leader.  Never before had there been a wiser or fairer ruler.  Peace swept over the land and the chaos of the past was forgotten.  The heavens themselves smiled upon the earth during the Savior’s reign and blessed the land with a bountiful harvest that yielded more crops than the mind could even comprehend.  The kingdom continued to prosper until the Savior’s death many years later.  However, the Savior continued to influence Iman beyond the grave.  The civilians of Iman chose to live in harmony with one another as the wisest ruler had all those years ago.  And, to this day, there has never been a more successful kingdom than that of Iman.")
            sound = My.Resources.PosMorNotKillKing
            tmrdelay.Start()
        Else
            setText("The Savior exiled the former king from Iman to the icy plains of the North, where he remained the rest of his life.  Back in the kingdom, a great roar of praise and thanksgiving rose up from the commoners of Iman as they welcomed their Savior as their leader.  However, the tumultuous song of the people did not last forever.  The Savior was corrupted by the power given to her like the king before.  She ruled over the inhabitants with an iron fist as she vied for more power.  The heavens, seeing that their Savior had been unable to resist the intoxication of power, sent another Savior to overthrow the former.  A destructive civil war broke out that pitted brother against brother, father against son.  At the end of the war, Iman was in ruins and unable to recover.  The rest of Iman’s history was forgotten.")
            sound = My.Resources.negMorNotKillKing
            tmrdelay.Start()
        End If
    End Sub
    '=====================End of Action Button Mehtods======================================================

    'Plays a wait to complete audio for the cutscene
    'kind of feel while the user listens to the effects 
    'of their choices on Iman
    Private Sub tmrdelay_Tick(sender As System.Object, e As System.EventArgs) Handles tmrdelay.Tick
        My.Computer.Audio.Play(sound, AudioPlayMode.WaitToComplete)
        btnQuit.Visible = True
        btnToMain.Visible = True
        lblThanks.Visible = True
        tmrdelay.Stop()
    End Sub

    'On Load:
    'Set the stage for the player's
    'final choice
    Private Sub frmEpilouge_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setText("The king is lays on the floor, battered and bloodied.  My mission was a success, the tyrant king of Iman " & _
                "possesses his power no longer. The era of the Savior has dawned and I can now become ruler. " & _
                "My first executive decision is whether to let the old king’s life continue or to end it with my own doing.")
    End Sub
End Class