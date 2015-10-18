Option Strict On

'Potion item:
'Heals the player by upto half
'of the players max life
Public Class CPotion : Inherits CItem

    Private healingPow As Integer

    Public Sub New()
        MyBase.New("Potion", 2, "IT00")
    End Sub

    Public Sub New(i As Integer, id As String, gid As String)
        MyBase.New("Potion", id, i, "IT00", gid)
    End Sub

    Public Overrides Function use(mob As CMob) As Boolean
        healingPow = CInt(mob.getMaxLife / 2)
        If (mob.heal(healingPow)) Then
            Me.decrementUses()
            Return True
        Else
            Return False
        End If
    End Function

End Class
