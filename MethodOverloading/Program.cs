namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
           var intAdd = Add(2, 2);
            Console.WriteLine(intAdd);

            var decimalAdd = Add(2.0m, 2.0m);

            var addWithBool = Add(0, 1, false);
            Console.WriteLine(addWithBool);
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isChecked)
        {
            var sum = numOne + numTwo; 

            if(isChecked && sum > 1)
            {
                return $"{sum} dollars";      
            }
            else if(isChecked && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString(); 
            }

        }
    }
}
