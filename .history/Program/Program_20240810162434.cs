﻿
namespace Program;

class Program
{
    static void Main(string[] args)

    {
        System.Console.Write("Find");
        string? inputPara = Console.ReadLine();

        string[] convertToArray = GetParas(inputPara);
        if (convertToArray.Length == 0 || string.IsNullOrEmpty(inputPara))
        {
            System.Console.WriteLine("FIND: Parameter format not correct");
            return;
        }

        var Option = new SetOption();




    }

    private static string[] GetParas(string input)
    {
        string[] convertToArray = input.Split(" ");
        return convertToArray;
    }
}