using System;
using System.Security.Policy;

public class Student
{
    // Data members/fields
    private int rollNo;
    private string name;
    private string className;
    private string semester;
    private string branch;
    private int[] marks = new int[5];

    // Constructor to initialize student details
    public Student(int rollNo, string name, string className, string semester, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.className = className;
        this.semester = semester;
        this.branch = branch;
    }

    // Method to input marks for 5 subjects
    public void GetMarks()
    {
        Console.WriteLine($"Enter marks for {name} Roll No: {rollNo}");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter marks for Subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }
    }

    // Method to calculate average marks and display result
    public void DisplayResult()
    {
        double totalMarks = 0;
        foreach (int mark in marks)
        {
            totalMarks += mark;
        }
        double average = totalMarks / 5;

        Console.WriteLine($"Average Marks: {average}");

        // Check conditions for pass or fail
        bool failed = false;

        // Check if any subject has marks less than 35
        foreach (int mark in marks)
        {
            if (mark < 35)
            {
                failed = true;
                break;
            }
        }

        // Check average condition for passing
        if (!failed)
        {
            if (average >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed (Average marks less than 50)");
            }
        }
        else
        {
            Console.WriteLine("Result: Failed (Marks less than 35 in one or more subjects)");
        }
    }

    // Method to display student data
    public void DisplayData()
    {
        Console.WriteLine($"Roll No: {rollNo}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Class: {className}");
        Console.WriteLine($"Semester: {semester}");
        Console.WriteLine($"Branch: {branch}");
        Console.WriteLine("Marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {marks[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Example usage:
        Student student1 = new Student(101, "PoojaKulkarni", "12th", "First", "Science");
        student1.GetMarks(); // Input marks for student1
        student1.DisplayData(); // Display student1's details
        student1.DisplayResult(); // Display result for student1

        Console.WriteLine();

        Student student2 = new Student(102, "GirishK", "10th", "Second", "Commerce");
        student2.GetMarks(); // Input marks for student2
        student2.DisplayData(); // Display student2's details
        student2.DisplayResult(); // Display result for student2
    }
}

