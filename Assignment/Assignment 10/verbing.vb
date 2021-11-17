Module Module1

    Sub Main()
        Dim str, check1, newstr As String
        Dim lenstr As Integer

        str = ""
        lenstr = 0
        Const ING = "ing"
        check1 = ""
        newstr = ""

        Console.Write("ENTER STRING: ")
        str = Console.ReadLine
        str = LCase(str)

        check1 = Right(str, 3)
        lenstr = Len(str)
        If lenstr < 3 Then
            newstr = str
        ElseIf check1 = ING Then

            newstr = str & "ly"
        Else
            newstr = str & "ing"
        End If
        Console.WriteLine("NEW STRING: " & newstr)
        Console.ReadKey()

    End Sub

End Module
