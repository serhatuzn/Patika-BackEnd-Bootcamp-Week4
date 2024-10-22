using System;

namespace OopPractice
{
    internal class Program
    {
        // Main metodu, programın başlangıç noktasıdır.
        static void Main(string[] args)
        {
            // 1. Öğrenci nesnesi oluşturuluyor ve bilgileri atanıyor.
            Person ogr1 = new Person();
            ogr1.Ad = "Serhat";
            ogr1.Soyad = "Uzun";
            ogr1.DogumTarih = new DateTime(2003, 12, 15);

            // 2. Öğrenci nesnesi oluşturuluyor ve bilgileri atanıyor.
            Person ogr2 = new Person();
            ogr2.Ad = "Elif Nur";
            ogr2.Soyad = "Kaya";
            ogr2.DogumTarih = new DateTime(2002, 7, 7);

            // 3. Öğrenci nesnesi oluşturuluyor ve bilgileri atanıyor.
            Person ogr3 = new Person();
            ogr3.Ad = "Beyza";
            ogr3.Soyad = "Uzun";
            ogr3.DogumTarih = new DateTime(2009, 9, 12);

            // 4. Öğrenci nesnesi oluşturuluyor ve bilgileri atanıyor.
            Person ogr4 = new Person();
            ogr4.Ad = "Fatma Nisa";
            ogr4.Soyad = "Kaya";
            ogr4.DogumTarih = new DateTime(2007, 8, 25);

            // Öğretmen nesnesi oluşturuluyor ve bilgileri atanıyor.
            Person ogretmen = new Person();
            ogretmen.Ad = "Süleyman Zafer";
            ogretmen.Soyad = "Uzkay";
            ogretmen.DogumTarih = new DateTime(1976, 6, 16);

            // Öğretmenin bilgileri konsola yazdırılıyor.
            // ToShortDateString() metodu ile doğum tarihi yalnızca gün/ay/yıl formatında gösteriliyor.
            Console.WriteLine($"Öğretmen bilgileri \r\nİsim: {ogretmen.Ad} *** Soyisim: {ogretmen.Soyad} *** Doğum tarihi: {ogretmen.DogumTarih.ToShortDateString()} ");

            // 1. Öğrencinin bilgileri konsola yazdırılıyor.
            Console.WriteLine($"Öğrenci Bilgileri \r\nİsim: {ogr1.Ad} *** Soyisim: {ogr1.Soyad} *** Doğum tarihi: {ogr1.DogumTarih.ToShortDateString()} ");

            // 2. Öğrencinin bilgileri konsola yazdırılıyor.
            Console.WriteLine($"İsim: {ogr2.Ad} *** Soyisim: {ogr2.Soyad} *** Doğum tarihi: {ogr2.DogumTarih.ToShortDateString()} ");

            // 3. Öğrencinin bilgileri konsola yazdırılıyor.
            Console.WriteLine($"İsim: {ogr3.Ad} *** Soyisim: {ogr3.Soyad} *** Doğum tarihi: {ogr3.DogumTarih.ToShortDateString()} ");

            // 4. Öğrencinin bilgileri konsola yazdırılıyor.
            Console.WriteLine($"İsim: {ogr4.Ad} *** Soyisim: {ogr4.Soyad} *** Doğum tarihi: {ogr4.DogumTarih.ToShortDateString()} ");
        }
    }

    // Person sınıfı, öğrenci ve öğretmen bilgilerini tutmak için oluşturuldu.
    // Bu sınıfın 3 özelliği var: Ad, Soyad ve DoğumTarih.
    public class Person
    {
        // Ad özelliği (get/set ile dışarıdan erişilebilir ve değiştirilebilir).
        public string Ad { get; set; }

        // Soyad özelliği (get/set ile dışarıdan erişilebilir ve değiştirilebilir).
        public string Soyad { get; set; }

        // DoğumTarih özelliği, DateTime türünde doğum tarihi bilgisini tutar.
        public DateTime DogumTarih { get; set; }
    }
}
