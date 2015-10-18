Option Strict On

'Start Guard Mob
Public Class CStartGuard : Inherits CMob

    Private Shared image As Image = My.Resources.guard

    'Constructor:
    'Calls the superclass constructor
    'and sets the dropItem to a random
    'Citem
    Public Sub New()
        MyBase.New(1, 3, 3, 3, 1, 1, "Guard", False, image, New CDialogNode("Oy! What the bloody hell do you think you're doing? This is a restricted area!",
                                                                         "The ground thrists for your blood!", "I am merely passing, fellow soldier", 0, My.Resources.bloodyhell, My.Resources.thegroundthrists, My.Resources.merelypb))
        Dim r As New Random
        Dim i As Integer = r.Next(1, 100)
        Select Case i
            Case Is <= 20
                Me.setItem(New CZufall())
                Exit Select
            Case Is <= 30
                Me.setItem(New CUzima())
                Exit Select
            Case Is <= 80
                Me.setItem(New CCeleritas())
                Exit Select
            Case Else
                Me.setItem(New CAmandla())
                Exit Select
        End Select
        fillDialogs()
    End Sub

    Private Sub fillDialogs()
        'Start Right
        dialog.addtoTree(New CDialogNode("And your head will make a great mount on my wall!", "Battle", "Leave", 1, My.Resources.greatmount, Nothing, Nothing))

        'Start Left
        dialog.addtoTree(New CDialogNode("You are not a soldier! I will kill you for your lies!", "Battle", "Leave", -1, My.Resources.payforyourlies, Nothing, Nothing))

    End Sub
End Class
