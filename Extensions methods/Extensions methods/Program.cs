namespace Extensions_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
       
           
            
                int number = 5;
                Console.WriteLine(number.IsOdd());  // true
                Console.WriteLine(number.IsEven()); // false

                string str = "Hello123";
                Console.WriteLine(str.HasDigit()); // true

                string password = "Password1";
                Console.WriteLine(password.CheckPassword()); // true

                string text = "hello world";
                Console.WriteLine(text.Capitalize()); // "Hello world"
            
        }

    }
}

