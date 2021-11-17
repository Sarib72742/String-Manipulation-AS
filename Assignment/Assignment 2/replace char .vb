Module Module1

    Sub Main()
        Dim Str1, Str2, mychar1, mychar2, currentchar As String
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        mychar1 = ""
        mychar2 = ""
        currentchar = ""
        Count = 0

        Console.Write("Enter String : ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to remove : ")
        mychar1 = Console.ReadLine

        Console.Write("Enter character to replce : ")
        mychar2 = Console.ReadLine

        For Count = 1 To Len(Str1)
            currentchar = Mid(Str1, Count, 1)
            If currentchar = mychar1 Then
                currentchar = mychar2
            End If
            Str2 = Str2 & currentchar
        Next

        Console.WriteLine("Final string = " & Str2)
        Console.ReadKey()
    End Sub

End Module
