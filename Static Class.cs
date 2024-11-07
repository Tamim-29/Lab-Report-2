using System;
public class BankAccount
{
  
    public static double Total;
    public static double  Calculate(double balance , double rate)
    {
      Total=balance*rate;
      return Total;
    }
}
public class program 
{
  static void Main()
  {
 double Interest=BankAccount.Calculate(1200,0.05);
 Console.WriteLine("Total Interest:" + Interest);
    
  }
}
