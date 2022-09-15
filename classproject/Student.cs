using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    public class Student
    {
        private string name, address, gender;
         private int age;

        public Student()
        {
            name =" dipali";
            address = "dighi";
            gender = "female";
            age = 23;
        }

       public Student(string name, string address, string gender, int age)
        {
            this.name = name;
            this.address = address;
            this.gender = gender;
            this.age = age;
        }

        public string DisplayValue()
        {
            return $"Student Details is:   {name}/ {address}/ {gender}/ {age} ";
        }
    }
}
