using System;

class Program {
    static void Main() {
        try {
            int a = 20, b = 0;
            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException ex) {
            Console.WriteLine("ERROR: Cannot divide by zero");
        }
        finally {
            Console.WriteLine("Execution Completed");
        }
    }
}
