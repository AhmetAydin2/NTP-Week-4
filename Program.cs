// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Matematiksel hesaplama yapan parametresiz ve geriye dönen metot (Üçgen Alanı)

class Alan
{
    static double UçgenAlaniHesapla(double taban, double yükseklik)
    {
        return (taban * yükseklik / 2);
    }


    static void main()
    {
        Console.WriteLine("Tabanı giriniz");
        double taban = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yüksekliği giriniz");
        double yükseklik = Convert.ToDouble(Console.ReadLine());

        double alan = UçgenAlaniHesapla(taban, yükseklik);

        Console.WriteLine("Üçgenin alanı:"+alan);
   
    }
}

//Dizideki en büyük değeri bulan parametreli ve geriye dönen metot

class EnBüyük
{
    static int EnBüyükBul(int[] dizi)
    {
        int enbüyük=dizi[0];

        foreach(int i in dizi)
        {
            if (i > enbüyük)
            {
                enbüyük = i;
            }
        }
        return enbüyük;
    }

    static void Main()
    {
        int[] dizi = { 1, 5, 7, 8, 3, 4, 9 };

        int enbüyük = EnBüyükBul(dizi);
        Console.WriteLine("Dizinin en büyük elemanı:" + enbüyük);
    }
}

//Aşırı Yüklenmiş (Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma

class Toplama
{

    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    static int CalculateSum(int a,int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        int twoint = CalculateSum(8, 7);
        Console.WriteLine("İki int sayının toplamı:"+twoint);

        double twodouble = CalculateSum(5.6,3.9);
        Console.WriteLine("İki double sayının toplamı"+twodouble);

        int threeint = CalculateSum(4,5,6);
        Console.WriteLine("Üç int sayının toplamı:"+threeint);

    }
}



//Recursive Metot ile Fibonacci Dizisi Hesaplama

class Fibonaccci
{
    static int fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return fibonacci(n - 1)+fibonacci(n-2);
        }
    }

    static void Main()
    {
        int sayi = 8;
        int sonuç = fibonacci(sayi);
        Console.WriteLine("{sayi}.Fibonacci sayısı:"+sonuç);
    }
}

//Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama

class Ortalama
{
    static double OrtalamaHesaplama(params double[] sayilar)
    {
        double toplam = 0;

        foreach (double sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam/sayilar.Length;
    }
    static void Main()
    {
        Console.WriteLine("Ortalama 1:" + OrtalamaHesaplama(8, 10, 15));
        Console.WriteLine("Ortalama 2:" + OrtalamaHesaplama(22, 14, 33));
        Console.WriteLine("Ortalama 3:" + OrtalamaHesaplama(7, 42, 13));
    }
}

//Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot

class Filtreleme
{
    static int filtreleme(int[]dizi,int Filtre)
    {
        int toplam = 0;

        foreach(int sayi in dizi)
        {
            if(sayi > Filtre)
            {
                toplam += sayi;
            } 
        }
        return toplam;
    }
    static void Main()
    {
        int[] dizi = { 10, 20, 30, 40, 50, 60, 70 };
        int Filtre = 30;

        int toplam = filtreleme(dizi, Filtre);
        Console.WriteLine("Dizide {Filtre} değerinden büyük sayıların toplamı:" + toplam);
    }
}



//Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma

class YaşFarkı
{
    static int YaşFarkıHesaplama(int yaş = 18)
    {
        return yaş - 18;
    }
    static void Main()
    {
        int fark1=YaşFarkıHesaplama();
        Console.WriteLine("Yaş farkı:" + fark1);

        int fark2 = YaşFarkıHesaplama(30);
        Console.WriteLine("Yaş farkı:" + fark2);

        int fark3 = YaşFarkıHesaplama(46);
        Console.WriteLine("Yaş farkı:" + fark3);
    }
}

//Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot

class metod
{
    static List<string> Veriler(string[] dizi)
    {
        string sonuc =new List<string>();

        foreach (string eleman in dizi)
        {
            if (eleman.Length > 5)
            {
                sonuc.Add(eleman);  
            }
        }
        return sonuc;
    }
    static void Main()
    {
        string[] kelimeler = { "Mercedes", "Bmw", "Audi", "Reanılt", "Peugeot", "Volkwagen" };

        string uzunkelimeler=Veriler(kelimeler);

        foreach (string s in kelimeler)
        {
            Console.WriteLine(s);
        }
    }
}