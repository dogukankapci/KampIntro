using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack              // heap        // değerler
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Ali" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);  // Engin'i yazmaz çünkü new'lediğin anda içi boş yepyeni bir şey açtı. Adresi başka bir yerde. Bu yüzden önceden girdiklerin başka yerde kaldı. 
                                            // dizilerin problemi bu: genişletemiyoruz. sadece olanı kullandırıyor.


            //---------------------------------------------------------------------------------------------------

            // 1. Kullanım:
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");

            // 2. Kullanım:
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}
