using System;
using System.Collections.Generic;
using System.Text;

namespace _16lab
{
    static class SecondEx
    {
        public static void Second()
        {
            //2.	Напишите программу, предлагающую 
            //пользователю ввести  с клавиатуры его фамилию,
            //имя и отчество как единое целое, а затем выводящую их на экран.
            /*
            Console.WriteLine("Enter surname,name,middle name:");
            string[] fio = Console.ReadLine().Split(' ');
            Console.WriteLine(fio[0] + " " + fio[1][0] + " " + fio[2][0]);
            Console.ReadLine();
            */
            //7.	Измените программы п.1 и п.2 на циклические.
            Console.WriteLine("Enter num of operations:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] newFio = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter surname,name,middle name:");
                string[] fio = Console.ReadLine().Split(' ');
                newFio[i] = fio[0] + " " + fio[1][0] + " " + fio[2][0];
            }
            for (int i = 0; i < newFio.Length; i++)
            {
                Console.WriteLine(newFio[i]);
            }
        }
    }
}

