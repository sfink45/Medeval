Option Strict On
Imports System.Data.OleDb
'Data Tier:
'Handles all the saved game
'data for the program
Public Class CData
    '-------------Attributes--------------------------
    Private conGames As New  _
        OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbSaveGames.accdb")

    Private daGames As OleDbDataAdapter

    Private dsGames As DataSet
    '----------End of Attributes----------------------

    'Empty Constructor
    Public Sub New()

    End Sub

    'Read the tblInventory table from the database
    'and convert it to a collection that stores
    'all the inventory items for the current games
    Public Function readInventory(ByRef c As Collection, msg As String) As Boolean
        Dim sql As String
        dsGames = New DataSet
        sql = "SELECT * FROM tblInventory;"
        Try
            daGames = New OleDbDataAdapter(sql, conGames)
            daGames.Fill(dsGames, "tblInventory")
            c = convertToICol(dsGames)
            Return True
        Catch ex As Exception
            msg = ex.Message
            Return False
        End Try
    End Function

    'Read the tblGameState table from the database
    'and convert it to a collection holding all of
    'the information of every saved game's state
    '(player info, current room, current level)
    Public Function readTable(ByRef gc As Collection,
                             ByRef msg As String) As Boolean
        Dim sql As String
        dsGames = New DataSet
        sql = "SELECT tblGameState.*FROM tblGameState;"
        Try
            daGames = New OleDbDataAdapter(sql, conGames)

            daGames.Fill(dsGames, "tblGameState")
            gc = convertToGCol(dsGames)
            'gc.Remove(1)
            Return True
        Catch ex As Exception
            msg = ex.Message
            Return False
        End Try
    End Function

    'Helper Method:
    'Converts the passed dataset into a collection
    'of CItems
    Private Function convertToICol(ds As DataSet) As Collection
        Dim c As New Collection

        For Each dr As DataRow In ds.Tables("tblInventory").Rows
            Dim item As CItem
            Select Case dr("Item1").ToString
                Case "Potion"
                    item = New CPotion(Integer.Parse(dr("Item1_Q").ToString), dr("IID").ToString, dr("GID").ToString)
                Case "Amandla"
                    item = New CAmandla(Integer.Parse(dr("Item1_Q").ToString), dr("IID").ToString, dr("GID").ToString)
                Case Else
                    item = New CPotion(Integer.Parse(dr("Item1_Q").ToString), dr("IID").ToString, dr("GID").ToString)
            End Select
            c.Add(item, item.getID)
        Next
        Return c
    End Function

    'Helper Method:
    'Convert the passed dataset
    'into a collection of CGameStates
    'Hold player/game information
    Private Function convertToGCol(ds As DataSet) As Collection
        Dim c As New Collection
        Dim dr As DataRow

        For Each dr In ds.Tables("tblGameState").Rows
            Dim gs As New CGameState(New CPlayer(Convert.ToInt16(dr("Speed")), Convert.ToInt16(dr("Atk")), Convert.ToInt16(dr("Def")), _
                                                 Convert.ToInt16(dr("Stamina")), Convert.ToInt16(dr("Strength")), Convert.ToInt16(dr("Luck")),
                                                 (dr("PlayerName")).ToString), dr(0).ToString)
            gs.getPlayer().setMoral(Integer.Parse(dr("Morality").ToString))
            gs.getPlayer().setSouls(Integer.Parse(dr("Souls").ToString))
            gs.getPlayer().setStrength(Integer.Parse(dr("Strength").ToString))
            gs.setLvl(Integer.Parse(dr(1).ToString))
            gs.setCurrentRoom(Integer.Parse(dr(2).ToString))
            c.Add(gs, gs.getID)
        Next
        Return c
    End Function

    'Insert a new game state item into the dataset
    'Player starts out in room 0 of the first level
    Public Sub saveNewGame(gs As CGameState)
        Dim p As CPlayer = gs.getPlayer()
        Dim sql As String
        sql = "INSERT INTO tblGameState VALUES('" & gs.getID & "', 0, 0, '" & p.getName() & "', " & _
        p.getLife & ", " & p.getLife & ", " & p.getSpeed & ", 1, " & p.getAtk & ", " & p.getDef & ", " & _
        p.getStrength & ", " & p.getLuck & ", 0)"
        doCmd(sql)
    End Sub

    'Update the current game state
    'with the current player's stats
    'and the current room/level
    Public Sub saveGame(gs As CGameState)
        Dim sql As String
        Dim p As CPlayer = gs.getPlayer()
        sql = "UPDATE tblGameState SET LevelNum =" & gs.getLvlNum & ", RoomNum =" & gs.getRoomNum & ", Atk = " & p.getAtk & ", Def = " & p.getDef & ", " & _
            "Speed = " & p.getSpeed & ", Morality = " & p.getMorality & ", MaxLife = " & p.getMaxLife & ", Stamina = " & p.getLife & ", Souls = " & p.getSouls & " " & _
            "WHERE ID ='" & gs.getID & "';"
        doCmd(sql)
    End Sub

    'Helper method:
    'Executes the passed sql command in 
    'the database
    Private Sub doCmd(sql As String)
        Dim cmd As OleDb.OleDbCommand
        Try
            cmd = New OleDb.OleDbCommand(sql, conGames)
            conGames.Open()
            cmd.ExecuteNonQuery()
            conGames.Close()
        Catch ex As Exception
            MessageBox.Show("In doCmd: " & ex.Message)
        End Try
    End Sub

    'Remove the passed gamestate from
    'the database. Also deletes the 
    'inventory associated with the
    'game state
    Sub remove(gamesel As CGameState)
        Dim sql As String
        sql = "DELETE FROM tblGameState WHERE ID= '" & gamesel.getID & "'"
        doCmd(sql)
        If (gamesel.getPlayer.getInventory.Count > 0) Then
            deleteInventory(gamesel)
        Else
            Return
        End If
    End Sub

    'Delete the passed gamestate's 
    'inventory from the database
    Sub deleteInventory(gs As CGameState)
        Dim sql As String = "DELETE FROM tblInventory WHERE (((tblInventory.IID)= '"
        For Each item As CItem In gs.getPlayer.getInventory
            gs.getPlayer.getInventory.Remove(item.getItemId())
            sql = sql & item.getID & "')"
            If (gs.getPlayer.getInventory.Count <= 0) Then
                Exit For
            Else
                sql = sql & " OR ((tblInventory.IID) = '"
            End If
        Next
        sql = sql & "AND tblInventory.GID = '" & gs.getID & "');"
        doCmd(sql)
    End Sub

    'Delete the passed item from the database
    'where the GID of the item = gamestate ID
    Sub deleteItem(myItem As CItem, gs As CGameState)
        Dim sql As String
        sql = "DELETE FROM tblInventory WHERE IID= '" & myItem.getID & "' AND GID = '" & gs.getID() & "'"
        doCmd(sql)
    End Sub

    'Update the passed gamestate's inventory
    'with the passed item's new quantity
    Sub updateInventory(myItem As CItem, gs As CGameState)
        Dim sql As String
        sql = "UPDATE tblInventory SET Item1_Q = " & myItem.getUses & " WHERE IID= '" & myItem.getID & "' AND GID = '" & gs.getID() & "'"
        doCmd(sql)
    End Sub

    'Add the passed item to the database with
    'the passed gamestate's ID
    Sub addItem(item As CItem, gs As CGameState)
        Dim sql As String
        sql = "INSERT INTO tblInventory VALUES('" & item.getID & "', '" & gs.getID & "', '" & item.getName & "', " & item.getUses & ")"
        doCmd(sql)
    End Sub

End Class
