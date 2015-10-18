Option Strict On

Public MustInherit Class CMob

    '---------Attributes----------
    Private level As Integer
    Private life As Integer
    Private maxLife As Integer
    Private speed As Integer
    Private atk As Integer
    Private def As Integer
    Private luck As Integer
    Private name As String
    Private isAggressive As Boolean
    Private isDead As Boolean = False
    Private isGuarded As Boolean = False
    Private img As Image
    Protected dialog As CDialogTree
    Private dropItem As CItem
    '-----End of Attributes-----

    'Super Constructor
    'Sets all the values to the required variables
    '-----------------------------------------------------------------------------
    Protected Sub New(lvl As Integer, life As Integer, speed As Integer, atk As Integer, _
                      def As Integer, luck As Integer, name As String)
        Me.level = lvl
        Me.life = life
        Me.maxLife = life
        Me.speed = speed
        Me.atk = atk
        Me.def = def
        Me.luck = luck
        Me.name = name
        Me.isDead = False
    End Sub

    Protected Sub New(lvl As Integer, life As Integer, maxLife As Integer, speed As Integer, atk As Integer, _
                      def As Integer, luck As Integer, name As String)
        Me.level = lvl
        Me.life = life
        Me.maxLife = maxLife
        Me.speed = speed
        Me.atk = atk
        Me.def = def
        Me.luck = luck
        Me.isDead = False
        Me.name = name
    End Sub

    Protected Sub New(lvl As Integer, life As Integer, speed As Integer, atk As Integer, _
                     def As Integer, luck As Integer, name As String, isAggressive As Boolean, img As Image, node As CDialogNode, Optional item As CItem = Nothing)
        Me.level = lvl
        Me.life = life
        Me.maxLife = life
        Me.speed = speed
        Me.atk = atk
        Me.def = def
        Me.luck = luck
        Me.isAggressive = isAggressive
        Me.name = name
        Me.img = img
        Me.dropItem = item
        Me.isDead = False
        Me.dialog = New CDialogTree(node)
    End Sub
    '---------------------End of Constructors--------------------------------------

    '--------------Dialog Tree Movers----------------
    Public Sub moveDRight()
        dialog.goRight()
    End Sub
    Public Sub moveDLeft()
        dialog.goLeft()
    End Sub
    '---------End of Dialog Tree Movers--------------

    '------------Getters-------------------
    Public Function getLevel() As Integer
        Return Me.level
    End Function
    Public Function getLuck() As Integer
        Return Me.luck
    End Function
    Public Function getLife() As Integer
        Return Me.life
    End Function
    Public Function getMaxLife() As Integer
        Return Me.maxLife
    End Function
    Public Function getSpeed() As Integer
        Return Me.speed
    End Function
    Public Function getAtk() As Integer
        Return Me.atk
    End Function
    Public Function getDef() As Integer
        Return Me.def
    End Function
    Public Overridable Function getName() As String
        Return Me.name
    End Function
    Public Function getPersonality() As Boolean
        Return Me.isAggressive
    End Function
    Public Overridable Function getImg(Optional str As String = Nothing) As Image
        Return Me.img
    End Function
    Public Overridable Function getDialogs() As CDialogTree
        Return Me.dialog
    End Function
    Public Function hasDied() As Boolean
        Return Me.isDead
    End Function
    Public Function hasDrop() As Boolean
        If (Me.dropItem Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function getGuardState() As Boolean
        Return Me.isGuarded
    End Function
    '-----------End of Getters-------------
    'takeDmg Method:
    'Deal damage to the instance of mob
    'Half damage if the mob is blocking
    Public Sub takeDmg(attack As Integer, ByRef dmg As Integer, Optional blocking As Boolean = False)
        If (blocking) Then
            dmg = CInt(Math.Ceiling(attack / 2))
        Else
            dmg = attack
        End If
        life -= dmg
    End Sub

    'Heal Method:
    'Increase life by the passed amount
    'If life would be greater than the max
    'life attribute, life = maxLife
    Public Function heal(amount As Integer) As Boolean
        If (maxLife - life <= 0) Then
            Return False
        ElseIf (maxLife - life <= amount) Then
            life = maxLife
        Else
            life += amount
        End If
        Return True
    End Function

    'Attack method:
    'calls the takDmg method of mob parameter
    'only if the conditions to achieve a hit are met
    'deals damage to the target mob and returns true if hit
    'else returns false
    Public Function attack(mob As CMob, ByRef i As Integer) As Boolean
        Dim r As New Random()
        If (Not mob.dodge(Me.speed)) Then
            Dim dmg As Integer = Me.atk
            Dim d20 As Integer = r.Next(1, 20)
            If (dmg <= mob.def) Then
                dmg = 1
            Else
                dmg -= mob.def
            End If
            If (Me.luck >= d20) Then

                mob.takeDmg(dmg, i, mob.isGuarded)
            Else
                mob.takeDmg(dmg, i, mob.isGuarded)
            End If
            If (mob.getLife <= 0) Then
                mob.die()
            End If
            mob.endGuard()
            Return True
        Else
            mob.endGuard()
            Return False
        End If

    End Function

    'Dodge method:
    'called whenever a mob attacks
    'compares the speeds of the two mobs
    'and checks for a hit
    'Returns true if dodge was successful
    'Else returns false
    Public Function dodge(speed As Integer) As Boolean
        Dim r As New Random
        Dim d20 As Integer = r.Next(1, 20)
        If (Me.speed >= d20 And speed <= 20) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Die Method:
    'set the mob instance 
    'attribute isDead = True
    Public Sub die()
        Me.isDead = True
    End Sub

    'Guard Method:
    'set the mob instance
    'attribute isGuarded = True
    Public Sub guard()
        Me.isGuarded = True
    End Sub

    'EndGuard Method:
    'set the mob instance
    'attribute isGuarded = False
    Public Sub endGuard()
        Me.isGuarded = False
    End Sub

    '---------Increase Stat Method-------
    Public Sub increaseAtk(i As Integer)
        Me.atk += i
    End Sub
    Public Sub increaseSpeed(i As Integer)
        Me.speed += i
    End Sub
    Public Sub increaseLuck(i As Integer)
        Me.luck += i
    End Sub
    Public Sub increaseMaxLife(i As Integer)
        Me.maxLife += i
    End Sub
    Protected Sub increaseLevel(i As Integer)
        atk += CInt(Math.Ceiling(Math.Log(i)))
        life += CInt(Math.Ceiling(Math.Log(i)))
        maxLife += CInt(Math.Ceiling(Math.Log(i)))
        def += CInt(Math.Ceiling(Math.Log(i)))
    End Sub
    '-------End of Increase stats--------

    'Set dropItem to passed Item
    Public Sub setItem(item As CItem)
        Me.dropItem = item
    End Sub

    'Return the mob's drop item
    'Returns nothing if item = nothing
    'Else sets drop to nothing and returns
    'the item
    Function getLooted() As CItem
        If (dropItem Is Nothing) Then
            Return Nothing
        Else
            Dim temp As CItem = dropItem
            dropItem = Nothing
            Return temp
        End If
    End Function

End Class
