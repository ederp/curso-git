using System;
using System.Collections.Generic;

namespace Secao6Listas {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= qtd; i++) {
                Employee e = new Employee();
                Console.WriteLine("Employee #{0}:", i);
                Console.Write("Id: ");
                e.setId(int.Parse(Console.ReadLine()));
                Console.Write("Name: ");
                e.setName(Console.ReadLine());
                Console.Write("Salary: ");
                e.setSalary(double.Parse(Console.ReadLine()));

                employees.Add(e);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int id = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(x => x.getId() == id);
            if (emp == null) {
                Console.WriteLine("This id does not exist!");
            }
            else {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());
                emp.increaseSalary(percent);
            }
            //Imprime a lista de empregados
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees) {
                Console.WriteLine(obj);
            }
        }
    }
}
