using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    abstract class Student
    {

        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }
        public abstract bool Ispassed(double grade);
    }
    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade) { }
        public override bool Ispassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade) { }
        public override bool Ispassed(double grade)
        {
            return grade > 80.0;

        }

    }
    class program
    {
        public static void Main()
        {
            Undergraduate undergrad = new Undergraduate("Girish", 35, 79.0);
            Graduate grad = new Graduate("Kulkarni", 100, 90.0);
            Console.WriteLine($"{undergrad.Name} passed: {undergrad.Ispassed(undergrad.Grade)}");
            Console.WriteLine($"{grad.Name} passed: {grad.Ispassed(grad.Grade)}");
            Console.Read();
        }
    }
}


