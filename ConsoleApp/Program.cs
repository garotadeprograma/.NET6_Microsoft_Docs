﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;

Console.WriteLine($"{Environment.NewLine}Hello, {name}");
Console.WriteLine($"{Environment.NewLine}Accessed on {currentDate}");
