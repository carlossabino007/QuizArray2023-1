// See https://aka.ms/new-console-template for more information
using QuizArray2023_1.Logic;

Console.WriteLine("Hello, World!");
Console.WriteLine("ARRAY QUIZ");
var twoDimensions = new TwoDimension(5, 3);
twoDimensions.Fill();
Console.WriteLine("two dimensions Array  =>");
Console.WriteLine(twoDimensions);
var oneDimension  = twoDimensions.ToOneDimension();
Console.WriteLine("One dimension array =>");
Console.WriteLine(oneDimension);
Console.WriteLine("Fin...");


