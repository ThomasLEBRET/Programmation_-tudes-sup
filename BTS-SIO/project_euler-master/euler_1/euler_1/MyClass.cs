using System;
namespace euler_1
{
    class MyClass
    {
        static void Main()
        {
            //Trouver la somme de tous les multiples de 3 ou 5 inférieurs à 1000.
            int somme = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    somme += i;
                }
            }
            Console.WriteLine("La somme de tous les multiples de 3 et 5 strictement inférieurs à 1000 est : " + somme);
        }
    }
}
