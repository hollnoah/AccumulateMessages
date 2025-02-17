'Noah Holloway
'RCET 2265
'Spring 2025
'Accumulate Messages
Imports System

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static message As New Text.StringBuilder
        If clear Then
            message.Clear()
        ElseIf Not String.IsNullOrEmpty(newMessage) Then
            message.AppendLine(newMessage)
        End If

        Return message.ToString
    End Function


End Module
