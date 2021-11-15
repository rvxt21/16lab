using System;
using System.Collections.Generic;
using System.Text;

namespace _16lab
{
    class Student
    {
        private string name;
        private string surname;
        private int age;
        private int group;
        public Student(string name,string surname,int age,int group)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.group = group;
        }
        public Student()
        {
            Console.WriteLine("Enter name student:");
            name = Console.ReadLine();
            Console.WriteLine("Enter surname student:");
            surname = Console.ReadLine();
            Console.WriteLine("Enter age of student:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter group of student:");
            group = Convert.ToInt32(Console.ReadLine());
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
    }
}
