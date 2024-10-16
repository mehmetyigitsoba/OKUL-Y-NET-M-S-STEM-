using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKUL_YÖNETİM_SİSTEMİ
{ 
    
       
            
           
            public class ogrenci
            {
              
                public string ogrenciadi;
                public string ogrencisoyadi;
                public int ogrenciyasi;
                public int ogrencinotu;
        public  static int []ogrrencilerinsifreleri = {};
        public int ogrencisifre;
                public static ArrayList ogrenciler = new ArrayList() ;
                
                public static void OGRENCIEKLE()
                {
            
           
                    int i = 0;
                    while (true)
                    {
                        
                       
                        Console.WriteLine("öğrenci eklemeye devam etmek için-1\nçıkmak için-2\nhangi işlemi yapmak istiyorsunuz");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Array.Resize(ref ogrrencilerinsifreleri, ogrrencilerinsifreleri.Length + 1);
                            Console.WriteLine("öğrenci adı girin");
                            string ad = Console.ReadLine();
                            Console.WriteLine("öğrenci soyadı girin");
                            string soyad = Console.ReadLine();
                            Console.WriteLine("öğrenci yaşı girin");
                            int yas = Convert.ToInt32(Console.ReadLine());
                          
                           
                            int[] sifre = new int[6];
                            Random r = new Random();
                            int b = 0;
                            while (b < 6)
                            {
                                sifre[b] = r.Next(1, 10);
                                b++;
                            }
                           
                            Console.WriteLine($"önerilen şifre: {sifre[0]}{sifre[1]}{sifre[2]}{sifre[3]}{sifre[4]}{sifre[5]}");
                            Console.WriteLine("istediğiniz şifreyi rakamlarla oluşturup,sisteme ekleyin");
                            int ogrencisifre1 = Convert.ToInt32(Console.ReadLine());
                            ogrenciler.Add(new ogrenci() { ogrenciadi = ad, ogrencisoyadi = soyad, ogrenciyasi = yas ,ogrencisifre=ogrencisifre1});
                            ogrrencilerinsifreleri[i] = ogrencisifre1;
                            i++;
        

                        }
                        else if (secim == 2)
                        {
                            break;
                        }
                    }
                }
              
                    
                    
                
           
                    
                public static void OGRENCIGUNCELLEME()
                {
            int i = 0;
            
            for ( i = 0; i < ogrenciler.Count; i++)
            {
                ogrenci a = (ogrenci)ogrenciler[i];
                Console.WriteLine($"indexno:{i}:öğrenci{a.ogrenciadi}{a.ogrencisoyadi}{a.ogrenciyasi}{a.ogrencinotu}");
            }
            Console.WriteLine("güncellemek istediğiniz öğrenci indexno:");
            int indexno = Convert.ToInt32(Console.ReadLine());
            ogrenci b = (ogrenci)ogrenciler[indexno];
            Console.WriteLine("ismi güncelleyin ");
            b.ogrenciadi = Console.ReadLine();
            Console.WriteLine("soyismi güncelleyin ");
            b.ogrencisoyadi = Console.ReadLine();
        }
        public static void OGRENCISIL()
        {
            int i = 0;
            
            for (i = 0; i < ogrenciler.Count; i++)
            {
                ogrenci a = (ogrenci)ogrenciler[i];
                Console.WriteLine($"indexno:{i}:öğrenci{a.ogrenciadi}{a.ogrencisoyadi}");
            }
            Console.WriteLine("silmek istediğiniz öğrenci indexno:");
            int indexno = Convert.ToInt32(Console.ReadLine());
            ogrenciler.RemoveAt(indexno);

        }
        public static void OGRENCILISTELEME()
        {
            int i = 0;
            
            for (i = 0; i < ogrenciler.Count; i++)
            {
                ogrenci a = (ogrenci)ogrenciler[i];
                Console.WriteLine($"öğrenci:{a.ogrenciadi} {a.ogrencisoyadi},YAŞ:{a.ogrenciyasi}");
            }
        }
            }
        
        

    
   
}
