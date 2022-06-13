//#region Girilen iki sayının toplamı
//Console.WriteLine("İki rakam giriniz: ");
//Console.WriteLine("1. Rakam: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Girdiğiniz ilk rakam: " + num1);
//Console.WriteLine("2. Rakam: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Girdiğiniz ikinci rakam: " + num2);
//Console.WriteLine($"İki sayinin toplami: {num1 + num2}");
//#endregion

//#region Girilen iki sayının karesi
//Console.WriteLine("1. sayi: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Girdiğiniz sayi {num1}");
//Console.WriteLine("2. sayi: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Karelerinin toplamı: {(num1 * num1) + (num2*num2)} ");
//#endregion

//#region Küplerinin toplamı
////#region Çözüm 1
////double result = 0;
////for (int i = 1; i <= 10; i++)
////{
////    result += Math.Pow(i, 3);
////}

////Console.WriteLine(result);
////#endregion

////#region Çözüm 2
////double result = 0;
////foreach (var item in result.ToString())
////{
////    for (int i = 1; i < 11; i++)
////        result += Math.Pow(i, 3);
////}
////Console.WriteLine(result);
////#endregion
//#region
////double result = 0;
////int i = 1;
////while (i <= 10)
////{
////    result = Math.Pow(i, 3);
////    i++;
////}
////Console.WriteLine(result);   

//#endregion
//#endregion

//#region Doğum tarihi girilen kişinin yaş hesabı
////Console.WriteLine("Lütfen doğum tarihini giriniz");
////DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
////TimeSpan result = DateTime.Now - dateOfBirth;
////Console.WriteLine($"Yaşınız: {result.Days / 365}");

//Console.WriteLine("Lütfen doğum tarihini giriniz");
//DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
//DateTime bugun = DateTime.Now;

//int yas = bugun.Year - dogumTarihi.Year;


//if (dogumTarihi > bugun.AddDays(-yas))
//    yas--;
//Console.WriteLine(yas);
//#endregion

//#region Faktoriyel
//try
//{
//    int factorial = 1;
//    Console.WriteLine("Lütfen bir sayı giriniz:");
//    int num = Convert.ToInt32(Console.ReadLine());
//    //for (int i = num; i > 0; i--)
//    //{
//    //    factorial *= i;
//    //}

//    //while(num > 0)
//    //{
//    //    factorial *= num;
//    //    num--;
//    //}

//    //do
//    //{
//    //    factorial *= num;
//    //    num--;
//    //} while (num > 0);
//    string result_ = "";
//    while (num > 0)
//    {
//        factorial *= num;
//        if (num != 1)
//            result_ += $"{num} x ";
//        else
//            result_ += $"{num} = {factorial}";
//        num--;
//    }
//    Console.WriteLine(result_);
//}
//catch
//{
//    Console.WriteLine("Geçerli bilgi giriniz!");
//}

//#endregion

//#region Çarpma işlemi sonucunu toplama yaparak bulma
//int num1;
//int num2;
//Console.WriteLine("birinci sayı");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"İlk ({num1}) girdiğiniz sayı");
//Console.WriteLine("ikinci sayi");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"İkinci ({num2}) girdiğiniz sayı");

////int carpma = 0;
////for(int i = 0; i < num1; i++)
////{
////    carpma += num2;
////}
////Console.WriteLine(($"{num1} X {num2} = {carpma}"));

////int sayac = num2;
////int sonuc = 0;
////while (sayac > 0)
////{
////    sonuc += num1;
////    sayac--;
////}
////Console.WriteLine($"{num1} X {num2} = {sonuc}");

////int result = 0;
////int sayac = num2;
////do
////{
////    result += num1;
////    sayac--;
////} while (sayac > 0);
////Console.WriteLine(result);

//#endregion

//#region Bölme işlemini çıkarma ile yapma
//Console.WriteLine("Birinci sayi");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("İkinci sayi");
//int num2 = Convert.ToInt32(Console.ReadLine());

////int result = 0;
////int num1_ = num1;
////int kalan = 0;
////for(int i = 0; i < num1_; i++)
////{
////    num1 -= num2;
////    result++;
////    if (num1 < num2)
////    {
////        kalan = num1;
////        break;
////    }
////}
////Console.WriteLine($"{num1_} / {num2} = {result} | Kalan {kalan}");

//int sayac = num1;
//int result = 0;
//while (sayac > 0)
//{
//    num1 -= num2;
//    result++;
//    if (num1 < num2)
//        break;

//}
//Console.WriteLine(result);
//#endregion

//#region girilen sayının kaç basamaklı olduğunu bulmak
//Console.WriteLine("Lütfen 1 sayı giriniz: ");
//int num = Convert.ToInt32(Console.ReadLine());
////float num = float.Parse(Console.ReadLine());
////int sayac = 0;
////for (; num >= 10;)
////{
////    num /= 10;
////    sayac++;
////}
////sayac++;
////Console.WriteLine($"{num} değerinin basamak sayısı {sayac}");
//int result = 0;    
//for (; ; )
//{
//    num /= 10;
//    result++;
//    if (num < 10)
//        break;
//}
//result++;
//Console.WriteLine(result);
//#endregion

#region 3 basamaklı sayının basamaklarının küpleri toplamının sayının kendisine eşit olup olmadığı
Console.WriteLine("3 basamaklı bir sayı giriniz");
int num = Convert.ToInt32(Console.ReadLine());
if (Basamak(num) == true)
{

}

static bool Basamak(int num)
{
    int basamakSayisi = 1;
    while(true)
    {
        basamakSayisi++;
        num /= 10;
        if (num < 10)
            break;
    }

    return basamakSayisi == 3 ? true : false;
}
#endregion