using System;
namespace euler_5
{
    public class MyClass
    {
        static void Main()
        {
            /*
            Un programme qui teste qu'un nombre est divisible par tous les nombres à partir de 20 jsuqu'à 1 est
            trop long à exécuter            
            */
            /*
            On décompose en produit de facteur 1ers les nombres de 1 à 20
            */
            /*
            2² = 4; 3*2 = 6; 2³ = 8; 3² = 9; 2*5 = 10;
            2²*3 = 12; 2*7 = 14; 3*5 = 15; 2⁴ = 16; 2*9 = 18; 2²*5 = 20;
            Les autres nombres sont 1ers donc le calcul est déjà fait           
            */
            /*
            PPCM(1,...,20) = 2⁴*3²*5*7*11*13*17*19 = 232792560
            */
            /*
            On peut réaliser ce programme là également 
            */
            int a = 20;
            while(true)
            {
                bool divid = true;
                for(int i=2; i <= 20; i++)
                {
                    if(a%i != 0)
                    {
                        divid = false;
                        break;
                    }
                }
                if (divid == false)
                {
                    a += 20;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
