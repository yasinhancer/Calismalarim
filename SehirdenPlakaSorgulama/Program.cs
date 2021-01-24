using System;
using System.Collections.Generic;
namespace SehirdenPlakaSorgulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŞEHİRDEN PLAKA SORGULAMA");
            Console.WriteLine("");
            Dictionary<string, int> SehirPlaka = new Dictionary<string, int>();
            SehirPlaka.Add("adana", 01);
            SehirPlaka.Add("adıyaman", 02);
            SehirPlaka.Add("afyonkarahisar", 03);
            SehirPlaka.Add("ağrı", 04);
            SehirPlaka.Add("amasya", 05);
            SehirPlaka.Add("ankara",06);
            SehirPlaka.Add("antalya",07);
            SehirPlaka.Add("artvin",08);
            SehirPlaka.Add("aydın",09);
            SehirPlaka.Add("balıkesir",10);
            SehirPlaka.Add("bilecik",11);
            SehirPlaka.Add("bingöl",12);
            SehirPlaka.Add("bitlis",13); 
            SehirPlaka.Add("bolu",14);
            SehirPlaka.Add("burdur",15);
            SehirPlaka.Add("bursa",16);
            SehirPlaka.Add("çanakkale",17);
            SehirPlaka.Add("çankırı",18);
            SehirPlaka.Add("çorum",19);
            SehirPlaka.Add("denizli",20);
            SehirPlaka.Add("diyarbakır",21);
            SehirPlaka.Add("edirne",22);
            SehirPlaka.Add("elazığ",23);
            SehirPlaka.Add("erzincan",24);
            SehirPlaka.Add("erzurum",25);
            SehirPlaka.Add("eskişehir",26);
            SehirPlaka.Add("gaziantep",27);
            SehirPlaka.Add("giresun",28);
            SehirPlaka.Add("gümüşhane",29);
            SehirPlaka.Add("hakkari",30);
            SehirPlaka.Add("hatay",31);
            SehirPlaka.Add("ısparta",32);
            SehirPlaka.Add("mersin",33);
            SehirPlaka.Add("istanbul",34);
            SehirPlaka.Add("izmir",35);
            SehirPlaka.Add("kars",36);
            SehirPlaka.Add("kastamonu",37);
            SehirPlaka.Add("kayseri",38);
            SehirPlaka.Add("kırklareli",39);
            SehirPlaka.Add("kırşehir",40);
            SehirPlaka.Add("kocaeli",41);
            SehirPlaka.Add("konya",42);
            SehirPlaka.Add("kütahya",43);
            SehirPlaka.Add("malatya",44);
            SehirPlaka.Add("manisa",45);
            SehirPlaka.Add("kahramanmaraş",46);
            SehirPlaka.Add("mardin",47);
            SehirPlaka.Add("muğla",48);
            SehirPlaka.Add("muş",49);
            SehirPlaka.Add("nevşehir",50);
            SehirPlaka.Add("niğde",51);
            SehirPlaka.Add("ordu",52);
            SehirPlaka.Add("rize",53);
            SehirPlaka.Add("sakarya",54);
            SehirPlaka.Add("samsun",55);
            SehirPlaka.Add("siirt",56);
            SehirPlaka.Add("sinop",57);
            SehirPlaka.Add("sivas",58);
            SehirPlaka.Add("tekirdağ",59);
            SehirPlaka.Add("tokat",60);
            SehirPlaka.Add("trabzon",61);
            SehirPlaka.Add("tunceli",62);
            SehirPlaka.Add("şanlıurfa",63);
            SehirPlaka.Add("uşak",64);
            SehirPlaka.Add("van",65);
            SehirPlaka.Add("yozgat",66);
            SehirPlaka.Add("zonguldak",67);
            SehirPlaka.Add("aksaray",68);
            SehirPlaka.Add("bayburt",69);
            SehirPlaka.Add("karaman",70);
            SehirPlaka.Add("kırıkkale",71);
            SehirPlaka.Add("batman",72);
            SehirPlaka.Add("şırnak",73);
            SehirPlaka.Add("bartın",74);
            SehirPlaka.Add("ardahan",75);
            SehirPlaka.Add("ığdır",76);
            SehirPlaka.Add("yalova",77);
            SehirPlaka.Add("karabük",78);
            SehirPlaka.Add("kilis",79);
            SehirPlaka.Add("osmaniye",80);
            SehirPlaka.Add("düzce",81);

            Console.WriteLine("Hangi şehrin plakasını öğrenmek istiyorsun? (küçük harflerle yazınız)");
            
            string girilenSehir = Console.ReadLine();
            try
            {
                Console.WriteLine(girilenSehir + " şehrinin plaka kodu: " + SehirPlaka[girilenSehir]);
            }
            catch 
            {
                Console.WriteLine(girilenSehir + " adında bir şehir bulunamadı.");
            }


        }
    }
}
