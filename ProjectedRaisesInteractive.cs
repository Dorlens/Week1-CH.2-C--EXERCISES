using static System.Console;

// Convert the ProjectedRaises class to an interactive application named ProjectedRaisesInteractive. 
// Instead of assigning values to the salaries, accept them from the user as input.

class ProjectedRaisesInteractive
{
    static void Main()
    {

            const double PERCENT_RAISE = 0.04;

            WriteLine("Enter employee1 Salary:  ");
            double employeeSalary1 = Convert.ToDouble(ReadLine());

            WriteLine("Enter employee2 Salary: ");
            double employeeSalary2 = Convert.ToDouble(ReadLine());

            WriteLine("Enter employee3 Salary: ");
            double employeeSalary3 = Convert.ToDouble(ReadLine());


            double nextYearSalary1 = employeeSalary1 + (employeeSalary1 * PERCENT_RAISE);
            double nextYearSalary2 = employeeSalary2 + (employeeSalary2 * PERCENT_RAISE);
            double nextYearSalary3 = employeeSalary3 + (employeeSalary3 * PERCENT_RAISE);


            WriteLine("Employee1 salary for next year is {0:c2}" , nextYearSalary1);
            WriteLine("Employee2 salary for next year is {0:c2}" , nextYearSalary2);
            WriteLine("Employee3 salary for next year is {0:c2}" , nextYearSalary3);



    }
}