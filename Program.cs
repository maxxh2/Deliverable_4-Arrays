/* Name: Maxx Hernandez
 * Date: 02/09/2023
 * Description: C# Deliverable 4 (Arrays)
 */
namespace deliverable4_Arrays
{
    class Program
    {
        static int Fibonacci_Sequence(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci_Sequence(n-2) + Fibonacci_Sequence(n-1);
            }
        }

        public static void Main(string[] args)
        {
            int n = 25;
                for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + Fibonacci_Sequence(i)+ "");
            }
        }
    }
}