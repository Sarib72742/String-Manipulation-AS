Module Module1

    Sub Main()
        Dim str1, FirstChars, LastChars As String
        Dim spacepos, lenstr As Integer

        str1 = ""
        FirstChars = ""
        LastChars = ""
        spacepos = 0
        lenstr = 0

        Console.Write("please enter string: ")
        str1 = Console.ReadLine
        spacepos = InStr(str1, " ")
        lenstr = Len(str1)
        If lenstr <= 2 Then
            Console.WriteLine(str1)
        ElseIf spacepos = 0 Then
            FirstChars = Left(str1, 2)
            LastChars = Right(str1, 2)
        Else
            FirstChars = Left(str1, 2)
            LastChars = Mid(str1, spacepos - 2, 2)
        End If
        Console.WriteLine("New string " & FirstChars & LastChars)
        Console.ReadKey()

    End Sub

End Module
