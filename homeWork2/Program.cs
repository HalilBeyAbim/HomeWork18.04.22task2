using System;

namespace homeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir reqem daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine()); //bir deyer veririk
            int dividednumber = 7;//ve bir bolunen deyer elave edirik
            int remainder = number % dividednumber; //bir qaliq yaradiriq
            int DividedSN =  number - remainder; //kicik regemi tapmaq ucun bir hell
            int DividedLN =number + dividednumber - remainder; //boyuk regemi tapmaq ucun bir hell


            if (remainder == 0) //eger qaliq beraberdirse 0'a her sey hazirdir demekdi
            {
                Console.WriteLine("7'ye bolunur");
            }

            else if (remainder < dividednumber -3 || remainder> dividednumber +4) // burada yaxin olan asagi ve yuxari regemlerini ortaya cixardiriq
            {
                Console.WriteLine("\n bolunmur, bolunen en yaxin asaqi reqem:  " + (DividedSN)+ "\n ve en yaxin yuxari reqem: " + DividedLN);// en yaxin asaqi deyeri ortaya cixardiriq
            }



            //burada ekrana tek tek neticeleri nece cixartmaq olardi onu gosterecem
            //

            //Console.Write("bir reqem daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine()); //bir deyer veririk
            //int dividednumber = 7;//ve bir bolunen deyer elave edirik
            //int remainder = number % dividednumber; //bir qaliq yaradiriq
            //int DividedSN = number - remainder;
            //int DividedLN = number + dividednumber - remainder;


            //if (remainder == 0) 
            //{
            //    Console.WriteLine("7'ye bolunur");
            //}

            //else if (remainder < dividednumber -3) 
            //{
            //    Console.WriteLine("bolunmur, bolunen en yaxin asaqi reqem:  " + (DividedSN));
            //
            //
            //
            //else if (remainder > dividednumber +4)
            //{
            //    Console.WriteLine("bolunmur, bolunen en yaxin reqem:  " + (DividedLN));
            //} 
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //


















        }
    }
}
