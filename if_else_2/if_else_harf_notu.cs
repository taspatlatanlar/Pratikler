using System;

namespace if_else_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Merhaba, vize notunuzu giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            float ortalama = (float)((vize * 0.4) + (final * 0.6));
            Console.WriteLine("Not ortalamanız: " + ortalama);

            if(ortalama >= 90){
                Console.WriteLine("AA");
            }
            else if(ortalama >= 85){
                Console.WriteLine("BA");
            }
            else if(ortalama >= 80){
                Console.WriteLine("BB");
            }
            else if(ortalama >= 75){
                Console.WriteLine("CB");
            }
            else if(ortalama >= 70){
                Console.WriteLine("CC");
            }
            else if(ortalama >= 65){
                Console.WriteLine("DC");
            }
            else if(ortalama >= 60){
                Console.WriteLine("DD");
            }
            else{
                Console.WriteLine("Dersten Kaldınız!");
            }

        }
    }
}
