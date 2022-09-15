using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Emp emp = new Emp(40000, 11, "sam");

            Console.WriteLine("HRA : " + emp.GetHRA());
            Console.WriteLine("CalculateDA : " + emp.CalculateDA());
            Console.WriteLine("CalculateTotalSalary : " + emp.CalculateTotalSalary());
            Console.WriteLine("CalculatePF : " + emp.CalculatePF());
            Console.WriteLine("CalculateNetpaid : " + emp.CalculateNetpaid());
            Console.WriteLine(emp.DisplayValue());
            Console.ReadLine();


            //4.. rectangle..
            //Rectangle rectangle = new Rectangle(3, 4);
            //rectangle.CalculatePerimeter();
            //Console.WriteLine(rectangle.DisplayValue());


            //3. circle..
            //Circle circle = new Circle(2.5);
            //circle.CalculateArea();
            //Console.WriteLine(circle.DisplayValue());


            //2. stud..
            //    Stud stud = new Stud("dipali", 11, 70, 80, 90);
            //    stud.Percentage();
            //    Console.WriteLine(stud.DisplayValue());


            //1.. employee...
            //Employee employee = new Employee(1300, 1, 70000, 20000, "sam");
            ////employee.CalculateTotalSalary();
            //Console.WriteLine("CalculateTotalSalary : " + employee.CalculateTotalSalary());
            //Console.WriteLine("CalculateNetpaid : " + employee.CalculateNetpaid());
            //Console.WriteLine(employee.DisplayValue());


            //Student s1 = new Student();
            //Console.WriteLine(s1.DisplayValue());

            //Student s2 = new Student( "sam", "dighi","male",30);
            //Console.WriteLine(s2.DisplayValue());


            //Student student = new Student();
            //student.AssignValue();

            //Console.WriteLine(student.DisplayValue());

            //Date date = new Date();
            //date.AssignValue();

            //Console.WriteLine(date.DisplayValue());
        }
    }
}
