Option Strict On

'The Old Man Mob
'Used for setting up the story
'And introducing the looting mechanic if
'the user so desires to do it
Public Class COldMan : Inherits CMob

    '------------------Attributes--------------------
    Private Shared img As Image = My.Resources.oldman
    '-------------End of Attributes-------------------


    'Constructor:
    'Calls the superclass constructor
    'and fills out the dialog tree for the
    'character
    Public Sub New()
        'Default path 0.
        MyBase.New(1, 1, 1, 1, 1, 1, "Old Man", False, img, New CDialogNode("It is my honour to be in the presence of the Saviour...", _
                                                                         "Where am I?", "What do you mean, Saviour?", 0, My.Resources.honor, My.Resources.whereami, _
                                                                         My.Resources.saviorwdum), New CPotion())
        fillDialog()
    End Sub


    'Set up the dialog tree for the mob
    Private Sub fillDialog()
        'Start Right
        '===========================================================================================================================

        dialog.addtoTree(New CDialogNode("One would think that the Savior would know the area she is to redeem. " _
                               & "But it matters not to me. You are in the Iman's 'King's' dungeon. ", "Why am I imprisoned?", "What do you mean, Saviour?", 8, _
                               My.Resources.itmattersnot, My.Resources.why, My.Resources.saviorwdum))
        '1st choice right
        '------------------------------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("Because the king fears you. You possess the one power that he can never attain: The power of the Conduit!", _
                                    "The Conduit?", "Leave", 9, My.Resources.bckfu, My.Resources.what, Nothing))
        'Next choice
        dialog.addtoTree(New CDialogNode("Do you not even know about the Conduit!?! It is the most powerful item " _
                          & "in the universe! The seers say that it was crafted by the Creator himself " _
                          & "to absorb the lives of the deceased to the underworld. The say the embodiment " _
                          & "of the Conduit will come to overthrow the kingdom when entropy reigns over this " _
                          & "land. And it will be done with its soul absorbing powers!", "Soul absorbing powers?", "Leave", 10, _
                          My.Resources.conduithistory, My.Resources.soul_absorbing, Nothing))


        dialog.addtoTree(New CDialogNode("The conduit needed the power in order to bring the souls of the lost to the " _
          & "underworld. However, when the embodiment comes, she will be able to command the " _
          & "souls of her fallen enemies to demonstrate arcane powers beyond imagination.", "Like getting out of this cell?", "Leave", 11, _
          My.Resources.beyondimagination, My.Resources.getoutofthedungeon, Nothing))
        dialog.addtoTree(New CDialogNode("Exactly! However, you do not have any souls in the Conduit. I will give my " _
  & "soul into your hands so that you may overthrow the tyrant of Iman! May your journey see " _
  & "you well, Savior.", "Leave", "Leave", 12, My.Resources.journeyseeyouwell, Nothing, Nothing))

        '1st choice left
        '-------------------------------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("The seers never said that the Savior would be intellegent... You are the one " _
                          & "that was prophesied to overthrow the tyrant of the land! And it shall be " _
                          & "Through your use of the Conduit!", "The Conduit?", "Leave", 3, _
                          My.Resources.seersneversaid, My.Resources.what, Nothing))
        '2nd choice right
        dialog.addtoTree(New CDialogNode("Do you not even know about the Conduit!?! It is the most powerful item " _
                  & "in the universe! The seers say that it was crafted by the Creator himself " _
                  & "to absorb the lives of the deceased to the underworld. The say the embodiment " _
                  & "of the Conduit will come to overthrow the kingdom when entropy reigns over this " _
                  & "land. And it will be done with its soul absorbing powers!", "Soul absorbing powers?", "Leave", 5, _
                  My.Resources.conduithistory, My.Resources.soul_absorbing, Nothing))

        dialog.addtoTree(New CDialogNode("The conduit needed the power in order to bring the souls of the lost to the " _
          & "underworld. However, when the embodiment comes, she will be able to command the " _
          & "souls of her fallen enemies to demonstrate arcane powers beyond imagination.", "Like getting out of this cell?", "Leave", 6, My.Resources.beyondimagination, _
          My.Resources.getoutofthedungeon, Nothing))

        dialog.addtoTree(New CDialogNode("Exactly! However, you do not have any souls in the Conduit. I will give my " _
  & "soul into your hands so that you may overthrow the tyrant of Iman! May your journey see " _
  & "you well, Savior.", "Leave", "Leave", 7, My.Resources.journeyseeyouwell, Nothing, Nothing))


        'Start Left
        '========================================================================================================================

        '--------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("The seers never said that the Savior would be intellegent... You are the one " _
                         & "that was prophesied to overthrow the tyrant of the land! And it shall be " _
                         & "Through your use of the Conduit!", "The Conduit?", "Leave", -4, My.Resources.seersneversaid, My.Resources.what, Nothing))

        dialog.addtoTree(New CDialogNode("Do you not even know about the Conduit!?! It is the most powerful item " _
       & "in the universe! The seers say that it was crafted by the Creator himself " _
       & "to absorb the lives of the deceased to the underworld. The  seers say the embodiment " _
       & "of the Conduit will come to overthrow the kingdom when entropy reigns over this " _
       & "land. And it will be done with its soul absorbing powers!", "Soul absorbing powers?", "Leave", -3, My.Resources.conduithistory, My.Resources.soul_absorbing, Nothing))

        dialog.addtoTree(New CDialogNode("The conduit needed the power in order to bring the souls of the lost to the " _
          & "underworld. However, when the embodiment comes, she will be able to command the " _
          & "souls of her fallen enemies to demonstrate arcane powers beyond imagination.", "Like getting out of this cell?", "Leave", -2, My.Resources.beyondimagination, _
          My.Resources.getoutofthedungeon, Nothing))
        dialog.addtoTree(New CDialogNode("Exactly! However, you do not have any souls in the Conduit. I will give my " _
  & "soul into your hands so that you may overthrow the tyrant of Iman! May your journey see " _
  & "you well, Savior.", "Leave", "Leave", -1, My.Resources.journeyseeyouwell, Nothing, Nothing))
    End Sub

    Public Overrides Function getDialogs() As CDialogTree
        Dim pos As Integer = MyBase.getDialogs().getCurrentNode.getVal
        If (pos = -1 Or pos = 7 Or pos = 12) Then
            Me.die()
            Return MyBase.getDialogs()
        Else
            Return MyBase.getDialogs()
        End If
    End Function


End Class
