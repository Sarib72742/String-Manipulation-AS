Module Module1

    Sub Main()
        Dim count As Integer

        count = 0

        Console.Write("Please enter no.of donuts: ")
        count = Console.ReadLine

        If count >= 0 And count <= 9 Then
            Console.WriteLine("Number of Donuts: " & count)
        Else
            Console.WriteLine("Number of Donuts: Many ")
        End If
        Console.ReadKey()

    End Sub

End Module
