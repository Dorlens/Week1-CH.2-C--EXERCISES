using static System.Console;

// Write a C# program named ProjectedRaises that includes a named constant representing next year’s anticipated 4
//  percent raise for each employee in a company. Also declare variables to represent the current salaries 
//  for three employees. Assign values to the variables, and display, with explanatory text, next year’s salary 
//  for each employee.



class  ProjectedRaises
{



        static void Main()
        {
           const double PERCENT_RAISE = 0.04;
           double employeeSalary1 = 80000.00;
           double employeeSalary2 = 140000.00;
           double employeeSalary3 = 100000.00;


           double nextSalary1=  employeeSalary1 + (employeeSalary1 * PERCENT_RAISE);
           double nextSalary2 = employeeSalary2 +(employeeSalary2 * PERCENT_RAISE);
           double nextSalary3 = employeeSalary3 +(employeeSalary3 * PERCENT_RAISE);

           WriteLine("employee1 salary for next year is {0:c2}" , nextSalary1);
           WriteLine("employee2 salary for next year is {0:c2}", nextSalary2);
           WriteLine("employee3 salary for next year is {0:c2}" , nextSalary3);



        }
}