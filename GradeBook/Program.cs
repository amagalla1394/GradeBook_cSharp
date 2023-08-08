using System;
using System.Security.Cryptography;

public class GradeBook
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to GradeBook BAsiC.\n");
        Console.WriteLine("To begin, enter the student's name:\n");
        var name = Console.ReadLine();

        //assign random grade to student
        double randomGrade = RandomNumberGenerator.GenerateRandomNumber(0.0, 100.0);
        string letterGrade = LetterGradeConversion(randomGrade);
        Console.WriteLine(name + "'s current grade is at " + letterGrade + " with a " + randomGrade + "%");

    }

    public static string LetterGradeConversion(double numericGrade)
    {
        if (numericGrade >= 90.0)
        {
            return "A";
        }
        else if (numericGrade >= 80.0)
        {
            return "B";
        }
        else if (numericGrade >= 70.0)
        {
            return "C";
        }
        else if (numericGrade >= 60.0)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}


public class RandomNumberGenerator
{
    private static Random randomNum = new Random();

    public static double GenerateRandomNumber(double minValue, double maxValue)
    {
        double randomValue = minValue + randomNum.NextDouble() * maxValue;
        return Math.Round(randomValue, 2);
    }   
}
