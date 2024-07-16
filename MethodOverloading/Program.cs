using System.Net;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            var sum = x + y;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }

            
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Add(2, 2)); Console.WriteLine(Add(4.0m, 8.0m)); 
           int x = 32;
           int y = 38;
           Console.WriteLine(Add( 6, 24, false));
        }
    }
}
