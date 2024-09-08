using static System.Console;
 

//  Write a C# program named InchesToCentmeters that declares a named constant that holds the number of centimeters 
//  in an inch: 2.54. Also declare a variable to represent a measurement in inches, 
//  and assign a value. Display the measurement in both inches and centimeters—for example, 
//  3 inches is 7.62 centimeters.
class InchesToCentimeterslnteractive
{
        static void Main()
        {
                Write("How Many inches to convert: ");
                int inches = Convert.ToInt32(ReadLine());
                double result = inches * 2.54;
                WriteLine(result);




        }
}