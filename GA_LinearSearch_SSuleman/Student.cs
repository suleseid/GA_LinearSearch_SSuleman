using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinearSearch_SSuleman
{
    public class Student
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }
        public int Grade { get; set; } // New property for grade

        public Student(string name, string category, int level, int grade)
        {
            Name = name;
            Category = category;
            Level = level;
            Grade = grade;
        }

        public static bool ContainsStudent(Student[] students, string searchKey)
        {
            foreach (var student in students)
            {
                if (student.Name == searchKey)
                    return true;
            }
            return false;
        }

        public static int StudentByCategory(Student[] students, string searchKey)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Category == searchKey)
                    return i;
            }
            return -1;
        }

        public static List<int> AllStudentsOfACategory(Student[] students, string searchKey)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Category == searchKey)
                    indexes.Add(i);
            }
            return indexes;
        }

        // Define the AddStudent method
        public static void AddStudent(ref Student[] students, string name, string category, int level, int grade)
        {
            List<Student> tempList = new List<Student>(students);
            tempList.Add(new Student(name, category, level, grade));
            students = tempList.ToArray();
        }

        public static List<Student> AllStudentsOnLevel(Student[] students, int searchKey)
        {
            List<Student> studentsOnLevel = new List<Student>();
            foreach (var student in students)
            {
                if (student.Level == searchKey)
                    studentsOnLevel.Add(student);
            }
            return studentsOnLevel;
        }


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

