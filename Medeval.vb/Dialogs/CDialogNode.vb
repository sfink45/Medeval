Option Strict On

'Dialog Node Class
Public Class CDialogNode
    '------------Attributes-----------------
    Private prompt As String
    Private response1 As String
    Private response2 As String
    Private value As Integer
    Private leftNode As CDialogNode = Nothing
    Private rightNode As CDialogNode = Nothing
    Private promptAudio As IO.UnmanagedMemoryStream
    Private r1audio As IO.UnmanagedMemoryStream
    Private r2audio As IO.UnmanagedMemoryStream
    '----------End of Attributes--------------

    Public Sub New(prompt As String, response1 As String, response2 As String, val As Integer, _
                   promptaudio As IO.UnmanagedMemoryStream, r1audio As IO.UnmanagedMemoryStream, r2audio As IO.UnmanagedMemoryStream)
        Me.prompt = prompt
        Me.response1 = response1
        Me.response2 = response2
        Me.value = val
        Me.leftNode = leftNode
        Me.rightNode = rightNode
        Me.promptAudio = promptaudio
        Me.r1audio = r1audio
        Me.r2audio = r2audio
    End Sub

    '-----------Getters----------------
    Public Function getR1() As String
        Return Me.response1
    End Function
    Public Function getR2() As String
        Return Me.response2
    End Function
    Public Function getVal() As Integer
        Return Me.value
    End Function
    Public Function getPrompt() As String
        Return Me.prompt
    End Function
    Public Function getRNode() As CDialogNode
        Return Me.rightNode
    End Function
    Public Function getLNode() As CDialogNode
        Return Me.leftNode
    End Function
    '-------End of Getters----------------

    Public Sub playPrompt()
        My.Computer.Audio.Play(promptAudio, AudioPlayMode.Background)
    End Sub

    Public Sub playR1()
        My.Computer.Audio.Play(r1audio, AudioPlayMode.WaitToComplete)
    End Sub

    Public Sub playR2()
        My.Computer.Audio.Play(r2audio, AudioPlayMode.WaitToComplete)
    End Sub

    Public Sub setRNode(node As CDialogNode)
        Me.rightNode = node
    End Sub

    Public Sub setLNode(node As CDialogNode)
        Me.leftNode = node
    End Sub

    'Used to determine if the end of the 
    'conversation has been reached
    Public Function hasRightNode() As Boolean
        If (rightNode Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function hasLeftNode() As Boolean
        If (leftNode Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub setRightNode(rNode As CDialogNode)
        rightNode = rNode
    End Sub

    Public Sub setLeftNode(lNode As CDialogNode)
        leftNode = lNode
    End Sub

End Class
