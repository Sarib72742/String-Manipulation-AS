Module Module1

    Sub Main()
        Dim Highest, Count, count1, count2 As Integer
        Dim str1, myChar, thisChar, newChar, countchar As String

        str1 = ""
        Highest = 0
        Count = 0
        count1 = 0
        count2 = 0
        myChar = ""
        thisChar = ""
        newChar = ""

        Console.Write("Enter STRING: ")
        str1 = Console.ReadLine

        For count1 = 1 To Len(str1)
            newChar = Mid(str1, count1, 1)
            Count = 0
            For count2 = 1 To Len(str1)
                thisChar = Mid(str1, count2, 1)
                If thisChar = newChar Then
                    Count = Count + 1
                End If
            Next count2
            If Count > Highest Then
                Highest = Count
                myChar = newChar
            End If
        Next count1
        Console.WriteLine(myChar & " appeared " & Highest & " number of times.")
        Console.ReadKey()
    End Sub

End Module
