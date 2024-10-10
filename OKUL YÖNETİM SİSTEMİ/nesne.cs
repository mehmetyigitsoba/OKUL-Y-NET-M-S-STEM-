using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKUL_YÖNETİM_SİSTEMİ
{ 
    namespace nesne
    {
        public class ogretmenler
        {
                public string ogretmenadi;
        public string ogretmensoyadi;
        public int ogretmenyasi;


    }
        public class dersler
        {
            public int dersinSınıfı;
            public string ders;
            public string dersinHocası;
            public string []dersinOgrencileri;


            public class sınıflar
        {
            public int sınıf;
        }
       
            
           
            public class ogrenciler
            {
                public string ogrenciadi;
                public string ogrencisoyadi;
                public int ogrenciyasi;
                public int ogrencinotu;




            }
        }
        

    }
   
}
