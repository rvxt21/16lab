using System;
using System.Collections.Generic;
using System.Text;

namespace _16lab
{
    class TwelveEXers
    {
        //12.	Напишите программу, создающую в цикле несколько объектов этого класса в стеке (свободной памяти).
        //Запишите этот объекты последовательно в двоичный файл, пользуясь методами класса.
        public void CreateStudent()
        {
            Console.WriteLine("Enter num of students:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                list.Add(student);
            }
            NineEx.Nine();
        }
    }
}
