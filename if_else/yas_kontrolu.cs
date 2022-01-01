using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz, yaşınızı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz yaş: " + yas);

            if(yas < 0){
                Console.WriteLine("Yaşınız negatif olamaz!");
            }
            else if(yas >= 18){
                Console.WriteLine("Mekana girebilirsiniz, iyi eğlenceler.");
            }
            else{
                Console.WriteLine("Bu mekana girmek için çok gençsiniz!");
            }
        }
    }
}
