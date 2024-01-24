Imports System

Module Program
    Sub Main()
        On Error GoTo Err
        'allowing user to enter a value
        Console.WriteLine("Enter a number: ")
        Dim userInput As String = Console.ReadLine()

        'converting user input to a numeric value
        Dim number As Double = Convert.ToDouble(userInput)
        'if user input is a numeric value, perform the calculation
        Dim result As Double = number * number
        Console.WriteLine($" The square root of {number} is: {result} ")
        Dim sum As Double = number + number
        Console.WriteLine($"The sum of {number} and {number} is: {sum}")

        'reset error handling
        On Error GoTo 0
        Exit Sub

Err:
        'error message if user input is a non numeric value
        Console.WriteLine("Error: Invalid. Please enter a valid numeric value.")

        'reset error handling
        On Error GoTo 0
    End Sub
End Module
