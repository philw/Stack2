Module Module1

    Sub Main()

        Dim stack As New StringStack
        Dim item As String
        Dim userOption As String

        Do
            stack.ShowStack()

            Console.WriteLine("The options are:")
            Console.WriteLine("  Push")
            Console.WriteLine("  Pop")
            Console.WriteLine("  Peek")
            Console.WriteLine("  Exit")
            Console.Write("enter option: ")
            userOption = Console.ReadLine.ToLower

            Select Case userOption
                Case "push"
                    Console.Write("Enter string to push onto the stack: ")
                    item = Console.ReadLine
                    stack.Push(item)
                Case "pop"
                    item = stack.Pop
                    Console.WriteLine("{0} has been removed from the stack", item)
                Case "peek"
                    item = stack.Peek
                    Console.WriteLine("The item on the top of the stack is {0}", item)
            End Select

        Loop Until userOption = "exit"

    End Sub

End Module
