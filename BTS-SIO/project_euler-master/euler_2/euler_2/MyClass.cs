using System;
namespace euler_2
{
    public class MyClass
    {
        static void Main() 
        {
            int somme = 0;
            int fib3 = 2;
            int fib6 = 0;
            int result = 2;
            while(result < 4000000)
            {
                if (result % 2 == 0)
                {
                    somme += result;
                }
                result = 4*fib3 + fib6;
                fib6 = fib3;
                fib3 = result;
            }
            Console.WriteLine("La somme des valeurs paires de la suite de Fibonacci est :"+somme);
        }
    }
}
