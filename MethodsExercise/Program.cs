namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine(
                $"One day, {userName} was walking through the woods wearing a {favColor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;

        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;

        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }



        static void Main(string[] args)
        {
            //Madlib();
            //Console.WriteLine(Add(numOne:2, numTwo:2));
            //Console.WriteLine(Subtract(numOne:2, numTwo:2));
            //Console.WriteLine(Multiply(numOne:2, numTwo:2));
            //Console.WriteLine(Divide(numOne:2, numTwo:2));
            Console.WriteLine(Sum(5, 5, 5));

        }
    }
}
