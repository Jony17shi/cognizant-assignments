// See https://aka.ms/new-console-template for more information
using System;
class ReportCard
{
    static void Main()
    {
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Standard (STD):");
        string standard = Console.ReadLine();
        Console.WriteLine("Enter Division (Div):");
        string division = Console.ReadLine();
        Console.WriteLine("Enter number of subjects:");
        int numSubjects = Convert.ToInt32(Console.ReadLine());
        double totalMarks = 0;
        for (int i = 1; i <= numSubjects; i++)
        {
            Console.WriteLine($"Enter marks for subject {i}:");
            totalMarks += Convert.ToDouble(Console.ReadLine());
        }
        double averageScore = totalMarks / numSubjects;
        Console.WriteLine("\nReport Card");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Name      : {name}");
        Console.WriteLine($"Standard  : {standard}");
        Console.WriteLine($"Division  : {division}");
        Console.WriteLine($"Average Score : {averageScore:F2}");
        Console.WriteLine("-------------------------------------");
    }
}

