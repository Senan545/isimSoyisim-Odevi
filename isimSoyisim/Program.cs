using System;

namespace isimSoyisim
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region Ödevimsi (Senan yaptı)

            Console.Write("İsim ve Soyisim Giriniz: ");
            string isimSoyisim = Console.ReadLine();

            isimSoyisim = isimSoyisim.Trim();
            isimSoyisim = isimSoyisim.ToLower();

            string [] isimSoyisimDizi = isimSoyisim.Split(' '); // isim ve soyisim ayrimi

            string isim = isimSoyisimDizi[0];  //ilk isim
            string soyisim = isimSoyisimDizi[isimSoyisimDizi.Length-1];  //son isim


            isim = isim[0].ToString().ToUpper() + isim.Substring(1); // Bas Harf Buyutmesi
            soyisim = soyisim[0].ToString().ToUpper() + soyisim.Substring(1);
            Console.WriteLine("Hoşgeldiniz {0} {1}", isim, soyisim);

            soyisim = soyisim.ToUpper(); // soyisim BUYUK harflarla
            Console.WriteLine("Hoşgeldiniz {0} {1} ", isim, soyisim);

            #endregion

            #region Hazır / String

            //isim.ToLower();// Değeri Güncellemez/değiştirmez
            //isim.ToUpper();// Değeri Güncellemez/değiştirmez

            //bool a = isim.Contains('e');
            //bool b = isim.Contains("E");

            //bool x2 = isim.StartsWith("ZE");
            //bool x = isim.EndsWith("E");

            //int x = isim.IndexOf("E",2,3);
            //int x2= isim.LastIndexOf("E");
            //Console.WriteLine("birşeyler yaz");

            //isim = isim.Insert(3,"-");//Insert ilgili değişkenin değerine müdahale etmez.
            //string x = isim.Remove(2,isim.Length);

            // Zekai
            //isim = isim.Replace("ZE","AB");
            //isim = isim.ReplaceLineEndings("/CFLR");

            //isim = isim.PadLeft(18,'@');
            //isim = isim.PadRight(28,'!');
            //string b = isim.PadRight(15);
            //string x = isim.Substring(1,4);
            //char[] aa = {'S','E', 'D', 'A','T' };
            //string aa = "Merhaba";
            // isim.CopyTo(1,aa,2,aa.Length-3);

            //for (int i = 0; i < aa.Length; i++)
            //{
            //    Console.WriteLine(  aa[i]);
            //}
            //string isim = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.";

            //string[] kelimeler =  isim.Split(' ');

            //Console.WriteLine(kelimeler.Length);
            ////for (int i = 0; i < kelimeler.Length; i++)
            ////{
            ////    Console.WriteLine(kelimeler[i]);
            ////    kac++;
            ////}


            //string isim = "ali sasasi velida said hardadi";

            //string aranacak = "velida";
            //int nerede = isim.IndexOf(aranacak);

            //Console.WriteLine(isim.Length);

            //Console.WriteLine(isim.Substring(nerede, aranacak.Length));


            //for (int i = 0; i < isim.Split('e').Length; i++)
            //{
            //    Console.WriteLine(isim.Split('e')[i]);
            //}

            //isim = isim.Trim();
            //isim = isim.Trim('!');

            //isim = isim.TrimStart();
            //isim = isim.TrimEnd();

            //Console.WriteLine(x);//ZEK-İYE
            //Console.WriteLine(x2);//ZEK-İYE
            //Console.Write( a );
            //Console.Write( b );
            //Console.WriteLine("dasdasdad");



            #endregion
        }
    }
}
