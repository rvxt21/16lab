using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace _16lab
{
   static  class NineEx
    {
        //9.	Используйте  любой ранее разработанный класс. Напишите программу, создающую
        //в цикле несколько объектов этого класса в стеке (свободной памяти).
        //Запишите этот объекты в двоичный файл.
        public static void Nine()
        {
            Console.WriteLine("Enter num of objects:");
            int n =Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[n] = new Student();
            }
            string path= @"E:\ХДУ\text1.txt";
            try
            {
                // создаем объект BinaryWriter
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    foreach (Student s in students)
                    {
                        writer.Write(s.Name);
                        writer.Write(s.Surname);
                        writer.Write(s.Age.ToString());
                        writer.Write(s.Group.ToString());
                    }
                }
                // создаем объект BinaryReader
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        string surname = reader.ReadString();
                        int age = reader.ReadInt32();
                        double group = reader.ReadDouble();

                        Console.WriteLine("Student: {0}  Name: {1}  Age: {2} y   Group: {3} ",
                            name, surname, age, group);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        }
    }
}
