Module Module1

    Sub Main()
        Dim str1, thisChar As String
        Dim Acount, Scount, Dcount As Integer

        str1 = ""
        Acount = 0
        Dcount = 0
        Scount = 0
        thisChar = ""

        Console.Write("Enter string 1: ")
        str1 = Console.ReadLine()
        For count = 1 To Len(str1)
            thisChar = Mid(str1, count, 1)
            If Asc(thisChar) >= 65 And Asc(thisChar) <= 90 Then
                Acount = Acount + 1
            ElseIf Asc(thisChar) >= 97 And Asc(thisChar) <= 122 Then
                Acount = Acount + 1
            ElseIf Asc(thisChar) >= 48 And Asc(thisChar) <= 57 Then
                Dcount = Dcount + 1
            Else
                Scount = Scount + 1
            End If
        Next

        Console.WriteLine("No. of alphabets in a string = " & Acount)
        Console.WriteLine("No. of Digits in a string = " & Dcount)
        Console.WriteLine("No. of Symbols in a string = " & Scount)
        Console.ReadKey()
    End Sub

End Module
