using System;
namespace euler_6
{
    public class MyClass
    {
        static void Main()
        {
            /*
             Différence entre la somme des carrés des cent premiers nombres naturels et le carré de la somme.
            */
            int sum = 0;
            int square = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum += i * i;
                square += i;
            }
            square *= square;
            int result = square - sum;
            Console.WriteLine(result);
        }
    }
}
