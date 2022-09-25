using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        ArrayList alinanSayilar = new ArrayList();
        ArrayList asalOlan = new ArrayList();
        ArrayList asalOlmayan = new ArrayList();
        int sayi;
        int count=0;
        string alinanSayi;
        bool sayiMi;
        Console.WriteLine("20 Adet Sayı Giriniz : ");

        for(int i=0;i<20;i++){
            alinanSayi = Console.ReadLine();
            sayiMi = int.TryParse(alinanSayi, out sayi);
            if(sayiMi && sayi>0){
                alinanSayilar.Add(sayi);
            }
            
            else{
                Console.WriteLine("Lütfen sayı veya 0'dan büyük sayı giriniz");
                continue;
            }

            
        }

        foreach(var item in alinanSayilar){
            if(Convert.ToInt32(item) == 1){
                asalOlmayan.Add(item);
                break;
            }
            for(int j = Convert.ToInt32(item)-1; j>1;j--){
                if(Convert.ToInt32(item) % j == 0){
                    count+=1;
                    
                }
                
            }

            if(count > 0){
                asalOlmayan.Add(item);
            }
            else{
                asalOlan.Add(item);
            }

            count = 0;
        }
        Console.WriteLine("Asal Olan Sayılar : ");
        foreach(var item in asalOlan){
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine("Asal Olmayan Sayılar : ");
        foreach(var item in asalOlmayan){
            Console.WriteLine(item);
        }

    }
}
