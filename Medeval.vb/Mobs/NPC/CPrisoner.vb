Option Strict On

'Prisoner Mob:
'Introduces the morality choices
'to the player
Public Class CPrisoner : Inherits CMob

    '------------------Attributes------------------------
    Private Shared img As Image = My.Resources.prisoner
    '------------End of Attributes--------------------

    Public Sub New()
        MyBase.New(1, 3, 4, 1, 1, 1, "Prisoner", False, img, New CDialogNode("Hero... Please...", "Open the cell", "Hide", _
                                                                          0, My.Resources.hero, My.Resources.dontworry, My.Resources.sosorry))
        fillDialog()
    End Sub

    Private Sub fillDialog()
        'Start Right
        dialog.addtoTree(New CDialogNode("‘In am forever in your debt, thank you. You truly are the Savior of Iman!’" & vbNewLine & _
                                         "The guards sees the two of us and starts running toward our position. I say to the prisoner: ‘You go! " & _
                                         "I will take care of the guard!’ The prisoner runs off as I engage the enemy.", "Battle", "Leave", 1, My.Resources.savedprisoner, Nothing, Nothing))

        'Start Left
        dialog.addtoTree(New CDialogNode("Hero! Please don't leave! I have a wife/husband and 5 children! Hero! NOOOO!" & vbNewLine & _
    "The guard with a torch approaches the cell and steps inside. I hear the guard say : ‘The king has told me to make sure the prisoner " & _
    "is warm. I think its a tad chilly in here, no? Maybe some fire would help!’" & vbNewLine & _
    "The shadows of my alcove recede as the guard sets the prisoner’s cell aflame.  The otherwise empty darkness is filled with the " & _
    "pained screams of the prisoner as the fire slowly eats away his body and releases his soul.", "Leave", "Leave", -1, My.Resources.notsavedprisoner, Nothing, Nothing))
    End Sub

    'Sets the current image of the mob
    'used to make the prisoner appear to be a
    'guard if the player choses to save prisoner
    Public Overrides Function getImg(Optional str As String = Nothing) As System.Drawing.Image
        Dim pos As Integer = dialog.getCurrentNode.getVal
        If (pos = 1 And str = "Battle") Then
            Return My.Resources.guard
        Else
            Return CPrisoner.img
        End If
    End Function

    'Sets the name of current mob
    'used to make the prisoner appear to be a guard
    'if the player choses to save the prisoner
    Public Overrides Function getName() As String
        Dim pos As Integer = dialog.getCurrentNode.getVal
        If (pos = 1) Then
            Return "Guard"
        Else
            If (pos = -1) Then
                Me.die()
            End If
            Return MyBase.getName()
        End If

    End Function
End Class
