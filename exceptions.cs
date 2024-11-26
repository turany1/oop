public class Exceptions
{
      public class ReminderIsNotZeroException  : Exception
    {
         public ReminderIsNotZeroException (string message) : base(message)
        { }
    }
    static double SafeDivision(double x, double y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        if (x % y !=0 )
            throw new ReminderIsNotZeroException ("The reminder is not zero. Please change your values.");
        
        return x / y; 
   }
    public static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double result;
        try
        {
            result = SafeDivision(a, b);
            Console.WriteLine(a +" divided by " + b + " = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Attempted divide by zero.");
        }
        catch (ReminderIsNotZeroException NotZero)
        {
            Console.WriteLine($"Error: {NotZero.Message}");
        }
        
    }
}