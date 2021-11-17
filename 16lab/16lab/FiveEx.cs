using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace _16lab
{
    static class FiveEx
    {
        public static void Five()
        {
            //5.	Напишите программу,
            //предлагающую пользователю ввести его фамилию, имя и отчество ,
            //а затем выводящую эти сведения в текстовый файл.
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            File.WriteAllText(@"E:\ХДУ\text1.txt", text);
        }
    }
}
