Option Strict On

'Amandla item:
'Increase the player's attack
'Power
Public Class CAmandla : Inherits CItem

    Public Sub New()
        MyBase.New("Amandla", 2, "IT01")
        Dim r As New Random
        Dim delta As Integer = r.Next(0, 2)
        Me.addToUses(delta)
    End Sub

    Public Sub New(i As Integer, id As String, gid As String)
        MyBase.New("Amandla", id, i, "IT01", gid)
    End Sub

    Public Overrides Function use(mob As CMob) As Boolean
        If (TypeOf (mob) Is CPlayer) Then
            Dim atk As Integer = mob.getAtk
            Dim r As New Random
            Dim fx As Integer = r.Next(CInt(Math.Ceiling(atk / 2)), CInt(Math.Ceiling(atk * 1.5)))
            mob.increaseAtk(fx)
            Me.decrementUses()
            Return True
        Else
            Return False
        End If
    End Function
End Class
