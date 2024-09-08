
using static System.Console;

class HoursAndMinutes
{

    static void Main()
    {
            
            int numOfMinHour = 60;
            int minutes = 197;
            

            int hours = minutes / numOfMinHour;
            int remindingMin = minutes % numOfMinHour;

            WriteLine( "{0} hours and {0} minutes" ,hours , remindingMin);
            

        //----------------------------------------------------------------------------------------
            //THIS PART IS FOR ME

            // int numOfMinHour = 60;
            // Write("Enter number of Minutes: ");
            // int minutes = Convert.ToInt32(ReadLine());

            // int hours = minutes / numOfMinHour;
            // int remindingMin = minutes %numOfMinHour;
            // WriteLine("{0} hours and {0} minutes" , hours, remindingMin);

    }
}