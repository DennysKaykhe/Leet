﻿string leet;

Console.Clear();

Console.Write("Traduza seu texto para Leet:");

leet = Console.ReadLine()!
    .Replace("A", "4")
    .Replace("a", "4")
    .Replace("E", "3")
    .Replace("e", "3")
    .Replace("I", "1")
    .Replace("i", "1")
    .Replace("L", "1")
    .Replace("l", "1")
    .Replace("O", "0")
    .Replace("o", "0")
    .Replace("T", "7")
    .Replace("t", "7")
    .Replace("S", "5")
    .Replace("s", "5");

Console.WriteLine($"{leet}");
