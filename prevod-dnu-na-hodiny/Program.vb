Option Strict On
Imports System

Module Program
    Public Sub Main()
        Console.WriteLine("Zadej poèet dnù: ")
        Dim PocetDnu As String = Console.ReadLine()
        Console.WriteLine("Zadej poèet hodin: ")
        Dim PocetHodin As String = Console.ReadLine()
        Dim PocetHodinCelkem As Integer = CInt(PocetHodin) + (CInt(PocetDnu) * 24)
        Console.WriteLine(PocetHodinCelkem)
    End Sub

End Module
