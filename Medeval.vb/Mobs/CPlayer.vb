Option Strict On

'Player Mob:
'The user controlled mob
Public Class CPlayer : Inherits CMob
    '------------Attributes---------------------------
    Private stamina As Integer
    Private strength As Integer
    Private souls As Integer = 0
    Private morality As Integer = 0
    Private inventory As Collection
    '---------End of Attributes-----------------------

    'Constructor:
    'Calls the superclass constructor
    'and initializes the player with
    'the passed attributes and a new 
    'inventory collection
    Public Sub New(speed As Integer, atk As Integer, def As Integer, stamina As Integer, strength As Integer, luck As Integer, name As String)
        MyBase.New(1, stamina + 5, speed, atk, def, luck, name)
        Me.stamina += 5
        Me.souls = 1
        Me.strength = strength
        inventory = New Collection
    End Sub

    '---------------Morality Methods------------------
    Public Sub incrementMorality()
        morality += 1
    End Sub

    Public Sub decrementMorality()
        morality -= 1
    End Sub
    '----------End of Morality Methods--------------

    'Remove the item from
    'the inventory collection
    Public Sub tossItem(item As CItem)
        inventory.Remove(item.getItemId)
    End Sub

    'Add the passed item into the inventory
    'collection. If the item already exists
    '(done by checking itemid), then just 
    'increment the uses
    Public Function addToInventory(item As CItem) As Boolean
        If (Me.inventory.Count <= strength) Then
            If (isNewItem(item)) Then
                Dim myItem As CItem = TryCast(inventory.Item(item.getItemId), CItem)
                myItem.addToUses(item.getUses())
            Else
                inventory.Add(item, item.getItemId)
            End If
            Return True
        Else
            Return False
        End If
    End Function

    'Returns whether the passed item
    'is a new item to add to the collection
    Public Function isNewItem(item As CItem) As Boolean
        Return Not inventory.Contains(item.getItemId)
    End Function

    'Use Item Method:
    'If the item cannot be used
    'Return false
    'Else use the item and toss if the uses = 0
    'delete item from data or just update if 
    'uses > 0
    Public Function useItem(item As CItem, game As CGame) As Boolean
        Dim myItem As CItem = TryCast(inventory.Item(item.getItemId), CItem)
        If (myItem.use(Me)) Then
            If (myItem.getUses <= 0) Then
                Me.tossItem(myItem)
                game.deleteItem(myItem)
            Else
                game.updateInventory(myItem)
            End If
            Return True
        Else
            Return False
        End If
    End Function


    '-------------Getters-----------------------------
    Public Function getMorality() As Integer
        Return Me.morality
    End Function

    Public Function getInventory() As Collection
        Return Me.inventory
    End Function

    Public Function getNumItems() As Integer
        Return inventory.Count
    End Function

    Public Sub soulUp()
        souls += 1
        MyBase.increaseLevel(souls)
    End Sub

    Function getStrength() As Integer
        Return Me.strength
    End Function

    Function getSouls() As Integer
        Return Me.souls
    End Function
    '---------End of Getters--------------------------

    '---------------Setters---------------------------
    Public Sub setInventory(c As Collection)
        Me.inventory = c
    End Sub
    Public Sub setSouls(i As Integer)
        Me.souls = i
    End Sub
    Public Sub setMoral(i As Integer)
        Me.morality = i
    End Sub
    Public Sub setStrength(i As Integer)
        Me.strength = i
    End Sub
    '--------------End of Setters---------------------

End Class
