using System;

namespace StudentManagementApp
{
    class Program
    {
        public static void Main()
        {
            string[] names = { "Alice", "Bob", "Charlie" , "Ethan" };
            long[] ids = { 201, 202, 203, 204 }; 
            string[] departments = { "IT", "BBA", "ECE", "ME" };
            double[] cgpas = { 3.9, 2.2, 3.7,3.4};

            
            Student[] students = new Student[4]; 

  
            for (int i = 0; i < 4; i++)
            {
                students[i] = new Student(names[i], ids[i], departments[i], cgpas[i]);
                students[i].PrintDetails();
            }

          
            students[2].ChangeDepartment("CSE");
        }
    }

    class Student
    {
        public string Name;
        public long Id;
        public string Department;
        public double Cgpa;

     
        public Student(string name, long id, string department, double cgpa)
        {
            this.Name = name;
            this.Id = id;
            this.Department = department;
            this.Cgpa = cgpa;
        }

    
        public void PrintDetails() 
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Department: {Department}, CGPA: {Cgpa}");
        }


        public void ChangeDepartment(string newDept)
        {
            this.Department = newDept;
            Console.WriteLine($"{Name}'s department has been changed to {Department}.");
        }
    }
}
