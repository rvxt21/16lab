using System;

namespace _16lab
{
    class Program
    {
        static int tableWidth = 73;
        static void Main(string[] args)
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
            PrintRow(st.Name, st.Surname,st.Age.ToString(),st.Group.ToString());
            PrintLine();
            PrintRow(st1.Name,st1.Surname,st1.Age.ToString(),st1.Group.ToString());
            PrintLine();
            PrintRow(st2.Name, st2.Surname, st2.Age.ToString(), st2.Group.ToString());
            PrintLine();
            Console.ReadLine();
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

