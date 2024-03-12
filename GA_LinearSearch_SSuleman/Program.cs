using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinearSearch_SSuleman
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Student[] students = {
            new Student("Alice", "Science", 1, 85),
            new Student("Bob", "Math", 2, 65),
            new Student("Charlie", "Science", 1, 75),
            new Student("David", "Math", 3, 90),
            new Student("Eve", "History", 2, 70) };

            // 1. ContainsStudent method
            bool contains = Student.ContainsStudent(students, "Charlie");
            Console.WriteLine("Contains Charlie: " + contains);

            // 2. StudentByCategory method
            int index = Student.StudentByCategory(students, "Math");
            Console.WriteLine("Student index with Math category: " + index);

            // 3. AllStudentsOfACategory method
            List<int> indexes = Student.AllStudentsOfACategory(students, "Science");
            Console.WriteLine("Indexes of students in Science category: " + string.Join(", ", indexes));

            // 4. AllStudentsOnLevel method
            List<Student> studentsOnLevel = Student.AllStudentsOnLevel(students, 3);
            Console.WriteLine("Students on level 3:");
            foreach (var student in studentsOnLevel)
            {
                Console.WriteLine($"{student.Name}, {student.Category}, Level: {student.Level}");
            }

            // Add new student
            AddStudent(ref students, "Frank", "Science", 3, 80);

            // Display students after addition
            Console.WriteLine("Students after addition:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Grade: {student.Grade}");
            }
            // Display students with grades above 70
            Console.WriteLine("Students with Grades Above 70:");
            foreach (var student in students)
            {
                if (student.Grade > 70)
                    Console.WriteLine($"{student.Name}, Grade: {student.Grade}");
            }

            // Display students with grades
            Console.WriteLine("Students with Grades:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Grade: {student.Grade}");
            }
            Console.WriteLine();

            // Remove student at index 1
            RemoveStudentAtIndex(ref students, 1); 

            // Display students after removal
            Console.WriteLine("Students after removal:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Grade: {student.Grade}");
            }
        }

        // Define the AddStudent method
        public static void AddStudent(ref Student[] students, string name, string category, int level, int grade)
        {
            List<Student> tempList = new List<Student>(students);
            tempList.Add(new Student(name, category, level, grade));
            students = tempList.ToArray();
        }

        // Define the RemoveStudentAtIndex method
        public static void RemoveStudentAtIndex(ref Student[] students, int index)
        {
            if (index < 0 || index >= students.Length)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            List<Student> tempList = new List<Student>(students);
            tempList.RemoveAt(index);
            students = tempList.ToArray();
        }
    }
}
