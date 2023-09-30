namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Fibonacci numbers you want to generate:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {

                if (i == 0 || i == 1)
                {
                    numbers[i] = 1;
                }
                else
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }
                Console.Write(numbers[i] + " ");
            }
        }
    }
}