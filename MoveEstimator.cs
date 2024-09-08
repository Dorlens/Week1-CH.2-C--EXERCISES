using static System.Console;

// Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile. 
// Write a program named MoveEstimator that prompts a user for and accepts estimates for the number of hours for a 
// job and the number of miles involved in the move and displays the total moving fee.



class MoveEstimator 
{
    static void Main()
    {

        int baseRate = 200;
        int perHour = 150;
        int milesRate = 3;

            Write("Enter the number of Hours: ");
            double numOfHours = Convert.ToDouble(ReadLine());

            Write("Enter many miles");
            double numOfMiles = Convert.ToDouble(ReadLine());


            double totalCost =  baseRate +  perHour * numOfHours * numOfMiles + milesRate;


                WriteLine("the total is {0}, {1}" , totalCost, baseRate);







    }
}