Module Module1

    Sub Main()
        Dim str1, firststr, laststr As String
        Dim notpos, badpos As Integer

        str1 = ""
        firststr = ""
        laststr = ""
        notpos = 0
        badpos = 0


        Console.Write("Please enter string: ")
        str1 = Console.ReadLine
        notpos = InStr(str1, "not")
        badpos = InStr(str1, "bad")
        If notpos < badpos Then
            firststr = Left(str1, notpos - 1)
            laststr = Right(str1, Len(str1) - (badpos + 2))
        End If
        Console.WriteLine("REPLACE STRING: " & firststr & " " & "good" & " " & laststr)
        Console.ReadKey()

    End Sub

End Module
