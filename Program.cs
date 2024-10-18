
Console.WriteLine("18.10.2024 - 02.11.2024 Tarihli Ödev");
Console.WriteLine("-------------------------------------");


Console.WriteLine("\n");



/*
Console.WriteLine("Girilen sayının çift - tek kontrolü (if)");
Console.WriteLine("-----------------------------------------");



int sayı, kalan;

sayı = Convert.ToInt32(Console.ReadLine());

kalan = sayı % 2;

if (kalan == 0) {

    Console.WriteLine("Bu girdiğimiz sayı çift sayıdır.");

}

else {

    Console.WriteLine("Bu girdiğimiz sayı tek sayıdır.");
}


*/

/*

Console.WriteLine("1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi - switch yapısı");
Console.WriteLine("---------------------------------------------------------------------------------");


int sayılar = int.Parse(Console.ReadLine());

switch (sayılar) {

    case 1: Console.WriteLine("Bir"); break;
    case 2: Console.WriteLine("İki"); break;
    case 3: Console.WriteLine("Üç"); break;
    case 4: Console.WriteLine("Dört"); break;
    case 5: Console.WriteLine("Beş"); break;
    case 6: Console.WriteLine("Altı"); break;
    case 7: Console.WriteLine("Yedi"); break;
    case 8: Console.WriteLine("Sekiz"); break;
    case 9: Console.WriteLine("Dokuz"); break;
    case 10: Console.WriteLine("On"); break;

    default: Console.Write("Yanlış sayı girdiniz!"); break;

}


*/


/*


Console.WriteLine("Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarılı değilse başarısız uyarısı veren C# kodu");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");


string Kullanıcı_adı, şifre;

Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");

Kullanıcı_adı = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Lütfen şifrenizi giriniz: ");

şifre = Console.ReadLine(); 



if (Kullanıcı_adı == ("admin") && şifre == ("Admin_32453@")) {

    Console.WriteLine("Oturumunuz başarıyla açılmıştır.");

}

else {

    Console.WriteLine("Oturumunuz açılamadı.");
}



*/



/*


Console.WriteLine("10-20 20-30 30-40 arası sıcaklık durumlarına göre ekrana (normal - sıcak - çok sıcak) uyarısı veren veren C# kodu");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");


int sıcaklık_değeri;

sıcaklık_değeri = Convert.ToInt32(Console.ReadLine());

if (10 <= sıcaklık_değeri && sıcaklık_değeri < 20)
{

    Console.WriteLine("Hava sıcaklığı normal.");
}

else if (20 <= sıcaklık_değeri && sıcaklık_değeri < 30)
{

    Console.WriteLine("Hava sıcak.");
}

else if (30 <= sıcaklık_değeri && sıcaklık_değeri <= 40)
{

    Console.WriteLine("Hava çok sıcak.");
}

else {

    Console.WriteLine("Lütfen bu örneğe göre 10 ile 40 arasında bir değer giriniz.");
}


*/


Console.ReadKey();




