using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generics
{
    internal class LinqModel
    {
        public void empDetails()
        {
            List<Employee> employees = new List<Employee>()
      {
          new Employee() {id = 1,name="Priya",salary=10000},
          new Employee() {id = 2,name="Preethi",salary=15000},
          new Employee() {id = 3,name="Gowtham",salary=12000}
      };

            var res1 = employees.OrderBy(e => e.name).ToList();
            Console.WriteLine("Order By name : ");
            foreach (var employee in res1)
            {
                Console.WriteLine(employee.id + " " + employee.name + " " + employee.salary);
            }

            var res2 = employees.OrderBy(e => e.salary).ThenBy(e=>e.name).ToList();
            Console.WriteLine("Order By name and salary : ");
            foreach (var employee in res2)
            {
                Console.WriteLine(employee.id+" "+employee.name+" "+employee.salary);
            }
        }
        
}
}

