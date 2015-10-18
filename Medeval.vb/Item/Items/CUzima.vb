Option Strict On

'The Uzima Item:
'Increases life and heals the user
Public Class CUzima : Inherits CItem

    Public Sub New()
        MyBase.New("Uzima", 1, "IT04")
        Dim r As New Random
        Dim delta As Integer = r.Next(0, 2)
        Me.addToUses(delta)
    End Sub

    Public Sub New(i As Integer, id As String, gid As String)
        MyBase.New("Uzima", id, i, "IT04", gid)
    End Sub

    Public Overrides Function use(mob As CMob) As Boolean
        If (TypeOf (mob) Is CPlayer) Then
            Dim r As New Random
            Dim delta As Integer = r.Next(mob.getMaxLife, CInt(Math.Ceiling(mob.getMaxLife * 2.5)))
            mob.increaseMaxLife(delta)
            mob.heal(1000)
            Me.decrementUses()
            Return True
        Else
            Return False
        End If
    End Function
End Class

