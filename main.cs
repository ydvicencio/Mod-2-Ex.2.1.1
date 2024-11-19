using System;

class Program
{
 static double IncToCm(double inches)
  {
   //convert in to cm
   return inches * 2.54;
 }
  public static void Main(string[] args)
  {

    //enter multiple values in inches by user separated by spaces
    Console.WriteLine("Enter multiple values in inches separated by spaces: ");

    //make single string with multiple values
    string inches = Console.ReadLine();

    //split string into array of strings
    string[] inchesArray = inches.Split(' ');

    //loop through array of strings
    foreach (string value in inchesArray)
    {
        try
        {
          //convert string to double
          double inchesDouble = Convert.ToDouble(value);

          //convert inches to cm
          double cm = IncToCm(inchesDouble);

          //display reults
          Console.WriteLine("{0} inches is {1} centimeters", inchesDouble, cm);
        }
      catch (FormatException)
        {
          //display error message
          Console.WriteLine("Invalid input: '{0}'. Please enter a valid number.", value);
    
      }
  }
    //pause program
    Console.ReadLine();
    
    }
}
      



          

          
        
    
      


    
  