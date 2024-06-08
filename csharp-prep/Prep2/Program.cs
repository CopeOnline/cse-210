using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string response = Console.ReadLine();

        int grade = int.Parse(response);

        int sign = grade % 10;

        string letter;
        string mod;

        string passFail;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (sign >= 7)
        {
            mod = "+";
        }
        else if (sign < 3)
        {
            mod = "-";
        }
        else
        {
            mod = null;
        }

        if (grade >= 97 || grade < 60)
        {
            mod = null;
        }

        if (grade >= 70)
        {
            passFail = "You passed! Great work!";
        }
        else
        {
            passFail = "You failed. Better luck next time!"
        }
        Console.Write($"Your grade is {letter}{mod}");
        Console.Write(passFail);
    }
}