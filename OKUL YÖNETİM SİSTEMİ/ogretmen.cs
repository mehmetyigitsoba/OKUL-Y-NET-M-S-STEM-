
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;


namespace OKUL_YÖNETİM_SİSTEMİ
{


   
            public class ogretmen
            {
                public string ogretmenadi;
                public string ogretmensoyadi;
                public int ogretmenyasi;
                public int ogretmennotu;
                public static ArrayList ogretmenler = new ArrayList();
                public static void OGRETMENEKLE()
                {
                     int i = 0;
                     while (true)
            {
                Console.WriteLine("öğretmen eklemeye devam etmek için-1\nçıkmak için-2\nhangi işlemi yapmak istiyorsunuz");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("öğretmen adı girin");
                    string ad = Console.ReadLine();
                    Console.WriteLine("öğretmen soyadı girin");
                    string soyad = Console.ReadLine();
                    Console.WriteLine("öğretmen yaşı girin");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    ogretmenler.Add(new ogretmen() { ogretmenadi = ad, ogretmensoyadi = soyad, ogretmenyasi = yas });

                }
                else if (secim == 2)
                {
                    break;
                }
            }
                }
                public static void OGRETMENGUNCELLEME()
                {
            int i = 0;
            ogretmen a = (ogretmen)ogretmenler[i];
            for ( i = 0; i < ogretmenler.Count; i++)
            {
               
                Console.WriteLine($"indexno:{i}:öğretmen{a.ogretmenadi}{a.ogretmensoyadi}{a.ogretmenyasi}{a.ogretmennotu}");
            }
            Console.WriteLine("güncellemek istediğiniz öğretmen indexno:");
            int indexno = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine("ismi güncelleyin ");
            a.ogretmenadi = Console.ReadLine();
            Console.WriteLine("soyismi güncelleyin ");
            a.ogretmensoyadi = Console.ReadLine();
        }
        public static void OGRETMENSIL()
        {
            int i = 0;
            ogretmen a = (ogretmen)ogretmenler[i];
            for (i = 0; i < ogretmenler.Count; i++)
            {

                Console.WriteLine($"indexno:{i}:öğretmen{a.ogretmenadi}{a.ogretmensoyadi}");
            }
            Console.WriteLine("silmek istediğiniz öğretmen indexno:");
            int indexno = Convert.ToInt32(Console.ReadLine());
            ogretmenler.RemoveAt(indexno);

        }
        public static void OGRETMENLISTELEME()
        {
            int i = 0;
            ogretmen a = (ogretmen)ogretmenler[i];
            for (i = 0; i < ogretmenler.Count; i++)
            {

                Console.WriteLine($"öğretmen:{a.ogretmenadi} {a.ogretmensoyadi},YAŞ:{a.ogretmenyasi}");
            }
        }
            }








    

}
