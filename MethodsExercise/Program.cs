namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Introduction();
            Console.WriteLine(Addition(1,2,3));
            Console.WriteLine(Subtraction(8,7,6));   
            Console.WriteLine(Multiply(4,2,5));
            Console.WriteLine(Division(8,2,2));
        }

        public static void Introduction()
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Are you a male or female?");
            string gender = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your hobby?");
            string hobby = Console.ReadLine();
            Console.WriteLine($"So you are {name}, {gender}, {age} years old, and your hobby is {hobby}? Nice to meet you!");
        }

        public static int Addition(params int[] numbers)
        {
            int total = 0; 
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        
        public static int Subtraction(params int[] numbers)
        {
            int total = numbers[0]; 
            foreach (int number in numbers)
            {
                total -= number;
            }
            return total + numbers[0];
        }
        
        public static int Multiply(params int[] numbers)
        {
            int total = 1; 
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }
        
        public static double Division(params double[] numbers)
        {
            double total = numbers[0]; 
            foreach (double number in numbers)
            {
                total /= number;
            }
            return total * numbers[0];
        }
    }
}
