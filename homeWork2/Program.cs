using System;

namespace homeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;//bir deyer veririk
            int dividednumber = 7;//ve bir bolunen deyer elave edirik
            int remainder = number % dividednumber; //bir qaliq yaradiriq
            if (remainder==0 ) //eger qaliq beraberdirse 0'a her sey hazirdir demekdi
            {
                Console.WriteLine("bolunur");
            }

            else if(remainder<dividednumber/2) // qaliqin ortasini tapiriq
            {
                
                Console.WriteLine("bolunmur, bolunen en yaxin reqem:  " + (number-remainder));// en yaxin asaqi deyeri ortaya cixardiriq
            }
            else if (remainder == dividednumber / 2)
            {
                Console.WriteLine("eded iki terefin ortasindadir");// deyer eger iki deyerin ortadirsa 
            }
            else
            {
                Console.WriteLine("bolunmur, bolunen en yaxin reqem:  " + (number + dividednumber - remainder));//en yaxin ust deyerini ortaya cixardiriq
            }
        }
    }
}
