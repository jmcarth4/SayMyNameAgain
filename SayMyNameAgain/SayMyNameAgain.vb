'Jessica McArthur
'RCET0265
'Spring 2020
'Say My Name Again
'https:

Option Explicit On
Option Strict On
Option Compare Text

Module SayMyNameAgain

    Sub Main()
        'variables declared 
        Dim userInput As String

        'user is asked their name.
        Console.WriteLine("Quelle est votre nom? Comment t'appelle tu? {Greetings earthling! What do they refer to you as?}")
        userInput = Console.ReadLine()

        'user input is tested. If the user is Emily or Joe a response is generated.
        'Since I am amazing I have my own greeting. All other responses shut the program down.
        Select Case userInput
            Case "Emily"
                Console.WriteLine("Salut! Bonjour! Bonsoir! Bonjouree! " & userInput & " Go buy a flying monkey")
            Case "Joe"
                Console.WriteLine("Salut! Bonjour! Bonsoir! Bonjouree! " & userInput & " Go buy a flying monkey")
            Case "Jessica"
                Console.WriteLine("The world blew up and you missed it")
            Case Else
        End Select

        Console.ReadLine()
    End Sub

End Module
