Option Strict On

'Abstract Item class
Public MustInherit Class CItem

    Private name As String
    Private id As String
    Private itemid As String
    Private gid As String
    Private remainingUses As Integer
    Private Shared count As Integer = 0

    Public Sub New(name As String, id As String, remainingUses As Integer, itemid As String, gid As String)
        Me.name = name
        Me.remainingUses = remainingUses
        If (Integer.Parse(id.Substring(1)) >= count) Then
            count = Integer.Parse(id.Substring(1)) + 1
        End If
        Me.itemid = itemid
        Me.id = id
        Me.gid = gid
    End Sub

    Public Sub New(name As String, remainingUses As Integer, itemid As String)
        Me.name = name
        Me.remainingUses = remainingUses
        Me.itemid = itemid
        Me.id = "I" & count.ToString("D2")
        count += 1

    End Sub

    Protected Sub decrementUses()
        remainingUses -= 1
    End Sub

    Public Sub addToUses(i As Integer)
        Me.remainingUses += i
    End Sub

    Public MustOverride Function use(mob As CMob) As Boolean

    Public Function getUses() As Integer
        Return Me.remainingUses
    End Function

    Public Function getID() As String
        Return Me.id
    End Function

    Public Function getGID() As String
        Return Me.gid
    End Function

    Public Function getItemId() As String
        Return Me.id
    End Function

    Public Function getName() As String
        Return Me.name
    End Function

    Public Sub setGID(gid As String)
        Me.gid = gid
    End Sub

    Public Overrides Function ToString() As String
        Return Me.name & " : " & Me.remainingUses & " uses"
    End Function
End Class
