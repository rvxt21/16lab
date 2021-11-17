using System;
using System.Collections.Generic;
using System.Text;

namespace _16lab
{
    static class Table
    {
        static int tableWidth = 73;
        public static void MainF()
        {
            int point= 0;
            Console.WriteLine("Enter operation:\n1-Add new student,then show table\n2-Show table");
            point=Convert.ToInt32(Console.ReadLine());
            if (point == 1) { AddStudent();
                //ShowTable();
            }
            else if (point == 2)
            {
                ShowTable();
            } 
        }
        static public void ShowTable()
        {
            Student st = new Student("Ivan", "Safontev", 18, 231);
            Student st1 = new Student("Egor", "Dolgushov", 18, 231);
            Student st2 = new Student("Anna", "Ivanova", 18, 211);
            Console.Clear();
            PrintLine();
            AlignCentre("List of students", 5);
            PrintLine();
            PrintRow("Name", "Surname", "Age", "Group");
            PrintLine();
            PrintRow(st.Name, st.Surname, st.Age.ToString(), st.Group.ToString());
            PrintLine();
            PrintRow(st1.Name, st1.Surname, st1.Age.ToString(), st1.Group.ToString());
            PrintLine();
            PrintRow(st2.Name, st2.Surname, st2.Age.ToString(), st2.Group.ToString());
            PrintLine();
            
        }
        static public void AddStudent()
        {
            int num = 0;
            Console.WriteLine("Please enter num of students you want to add:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter name student num{num}:");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter surname student num{num}:");
                string surname = Console.ReadLine();
                Console.WriteLine($"Enter age of student num{num}:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter group of student num{num}:");
                int group = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(name, surname, age, group);
                ShowTable();
                PrintRow(student.Name, student.Surname, student.Age.ToString(), student.Group.ToString());
                PrintLine();
            }
        }
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
