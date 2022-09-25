// See https://aka.ms/new-console-template for more information
int[] girilenSayilar = new int[20];
int sayi;
bool sayiMi;
string girilenSayi;

Console.WriteLine("20 tane sayı giriniz :");
for(int i=0;i<20;i++){
    girilenSayi = Console.ReadLine();
    sayiMi = int.TryParse(girilenSayi, out sayi);
    if(sayiMi){
        girilenSayilar[i] = sayi;
    }
    else{
        Console.WriteLine("Lütfen sayı giriniz");
        continue;
    }

}

Array.Sort(girilenSayilar);

Console.WriteLine("Girilen En Küçük 3 Sayının Ortalaması = " + (girilenSayilar[0] + girilenSayilar[1] + girilenSayilar[2]) / 3);
Console.WriteLine("Girilen En Büyük 3 Sayının Ortalaması = " + (girilenSayilar[girilenSayilar.Length-1] + girilenSayilar[girilenSayilar.Length-2] + girilenSayilar[girilenSayilar.Length-3]) / 3);


