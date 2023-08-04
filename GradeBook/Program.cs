using System;
using System.Security.Cryptography;


Console.WriteLine("Welcome to GradeBook BAsiC.\n");
Console.WriteLine("To begin, enter the student's name:\n");
var name = Console.ReadLine();

//assign random grade to student
double randomGrade = RandomNumberGenerator.GenerateRandomNumber(0.0, 100.0);
Console.WriteLine(name + "'s current grade is at " /*+ Letter + " with a "*/ + randomGrade + "%");


/*void letter(string letterGrade)
{
    if (randomGrade >= 90 && randomGrade <= 100)
    {
        letterGrade = "A";
    }
    else if (randomGrade >= 80 && randomGrade < 90)
    {

    }
    else if (randomGrade >= 70 && randomGrade < 80)
    {

    }
    else if (randomGrade >= 60 && randomGrade < 70)
    {

    }
    else
    {

    }
}*/

public class RandomNumberGenerator
{
    private static Random randomNum = new Random();

    public static double GenerateRandomNumber(double minValue, double maxValue)
    {
        double randomValue = minValue + randomNum.NextDouble() * maxValue;
        return Math.Round(randomValue, 2);
    }   
}

