using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_Volkov
{
    public class Student
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Student(string name, string password)
        {
            if (name == "" || password == "") throw new ArgumentException("Значения name и password не могут быть пустыми!");
            Name = name;
            Password = password;
        }
    }
}
