using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKUL_YÖNETİM_SİSTEMİ
{
    public class sınıfveders
    {
        public  string sınıf;
        public  string ders;
        public string dersinogrenci;
        //public static string[] dersogrencileri1 = {};
        
        public static ArrayList sınıflar = new ArrayList();
        public string dersinogretmeni;
        public static ArrayList dersler = new ArrayList();
        public static string [][]dersinogrenciler ={};
        //public static int[] elemanuzunlugu = {};
        
        public static void SINIFVEDERSEKLE()
        {
            
            int z = 0;
            
            while (true)
            {
                
                
                int w = 0;
               
                    Array.Resize(ref dersinogrenciler, dersinogrenciler.Length + 1);
                    Console.WriteLine("sınıf ekle");
                    string sinif = Console.ReadLine();
                    sınıflar.Add(sinif);
                    Console.WriteLine("ders ekle");
                    string ders = Console.ReadLine();
                    
                    int t = 0;
                    for (int p = 0; p < ogretmen.ogretmenler.Count; p++)
                    {
                        ogretmen l = (ogretmen)ogretmen.ogretmenler[t];
                        Console.WriteLine($"indexno:{t},öğretmen{l.ogretmenadi}{l.ogretmensoyadi}");
                        t++;
                    }
                    Console.WriteLine("bu derse eklemek istediğiniz öğretmenin indexno:");
                    int indexno1 = Convert.ToInt32(Console.ReadLine());
                    ogretmen n = (ogretmen)ogretmen.ogretmenler[indexno1];
                    dersler.Add(new sınıfveders() { ders = ders, sınıf = sinif,dersinogretmeni=n.ogretmenadi+n.ogretmensoyadi });



                    
                    string[] dersogrenci = { };
                   
                            for (int c = 0; c < ogrenci.ogrenciler.Count; c++)
                            {
                                ogrenci k = (ogrenci)ogrenci.ogrenciler[c];
                                Console.WriteLine($"indexno:{c},öğrenci{k.ogrenciadi}{k.ogrencisoyadi}");
                                
                            }
                            
                          
                            
                            while (w < 8)
                            {
                                
                                Console.WriteLine("derse öğrenci eklemeye devam etmek için-1\nçıkmak için-2");
                                int secenek = Convert.ToInt32(Console.ReadLine());
                                if (secenek == 1)
                                {

                                    Array.Resize(ref dersogrenci, dersogrenci.Length + 1);
                                    Console.WriteLine("eklemek istediğiniz öğrencinin indexno");
                                    int indexno = Convert.ToInt32(Console.ReadLine());
                                    ogrenci m = (ogrenci)ogrenci.ogrenciler[indexno];
                                    dersogrenci[w] = m.ogrenciadi + m.ogrencisoyadi;
                                  
                                   
                                    
                                    w++;



                                }
                                else if (secenek == 2)
                                {

                                    dersinogrenciler[z] = dersogrenci;
                                    z++;
                                    break;
                                }
                            }


                        
               
            }
                
            


        }
        
        public static void SINIFVEDERSLISTELEME()
        {
            Console.WriteLine("Sınıf için-1\nders için -2\nçıkmak için-0");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                foreach (var item in sınıflar)
                {
                    Console.WriteLine(item);
                }
            }
            else if (secim == 2)
            {
                
                for (int i = 0; i < dersler.Count; i++)
                {
                    sınıfveders n = (sınıfveders)dersler[i];
                    Console.WriteLine($"İNDEXNO:{i},sınıf:{n.sınıf}ders:{n.ders},dersin öğretmeni:{n.dersinogretmeni}");
                }
                Console.WriteLine("eklemek istediğiniz dersin indexno:");
                int b = Convert.ToInt32(Console.ReadLine());
                sınıfveders m = (sınıfveders)dersler[b];
                Console.WriteLine($"sınıf:{m.sınıf}ders:{m.ders},dersin öğretmeni:{m.dersinogretmeni}");
                Console.WriteLine("dersin öğrencileri:");
                foreach (var item in dersinogrenciler[b])
                {
                    Console.WriteLine(item);
                }
              
               
               






                
                

            }
        }
    }
}
