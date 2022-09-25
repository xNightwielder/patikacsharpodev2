using System;
using System.Collections;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
string[] sesliHarfler = {"a","e","ı","i","o","ö","u","ü"};
List<string> cumledekiSesliHarfler = new List<string>();

Console.WriteLine("Bir Cümle Giriniz.");
string cumle = Console.ReadLine();

for(int i = 0;i<cumle.Length;i++){
    for(int j = 0; j<sesliHarfler.Length;j++){
        if(cumle[i].ToString() == sesliHarfler[j]){
            
        cumledekiSesliHarfler.Add(cumle[i].ToString());
            
                
        }
            
        }
            
             
        }

Console.WriteLine("Cümledeki Sesli Harfler : ");
foreach(var item in cumledekiSesliHarfler){
    
        Console.Write(item + ", ");
    
        
}


