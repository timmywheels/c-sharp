using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Object with name Andrea and salary 2000 called employee1
            var employee1 = new Employee("Andrea", 2000);

            // Instantiates TechnicalEmployee Object with name Tim called employee2
            var employee2 = new TechnicalEmployee("Tim");

            // Instantiates BusinessEmployee Object with name Julie called employee3
            var employee3 = new BusinessEmployee("Julie");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());

        }
    }
}
