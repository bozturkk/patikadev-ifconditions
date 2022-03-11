using System;

namespace IfElseIf // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time < 11) // klasik if yapısı
            {
                Console.WriteLine("Günaydın");
            }
            else if(time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi akşamlar");
            }

            string sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi akşamlar"; //single line if yapısı
            

            
            Console.WriteLine(sonuc);
        }
    }
}
