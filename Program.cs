Kutuphane kutuphane = new Kutuphane();


Uye uye1 = new Uye("Ali", "İnceman", 1);
Uye uye2 = new Uye("Aleyna", "Doğar",2);

Kitap kitap1 = new Kitap("1984","George Orwell",2000,"Roman");
Kitap kitap2 = new Kitap("Şu Çılgın Türkler","Turgut Özakman",752,"Tarih");
Kitap kitap3 = new Kitap("Diriliş","Turgut Özakman",637,"Tarih");

KisaSureliOduncVerme kisaOdunc = new KisaSureliOduncVerme();
UzunSureliOduncVerme uzunOdunc = new UzunSureliOduncVerme();

//Üye ekleme işlemleri
kutuphane.UyeEkle(uye1);
kutuphane.UyeEkle(uye2);

var uyeler = kutuphane.Uyeler;

//eklenen uyelerin gösterilmesi
foreach(var uye in uyeler){
    Console.WriteLine($"{uye.Ad}");
}

//Kitap ekleme işlemleri
kutuphane.KitapEkle(kitap1);
kutuphane.KitapEkle(kitap2);
kutuphane.KitapEkle(kitap3);

var kitaplar = kutuphane.Kitaplar;
//eklenen kitapların gösterilmesi
foreach(var kitap in kitaplar){
    Console.WriteLine($"{kitap.Ad}");
}

//Ödünç verme işleminin yapılması
kutuphane.KitapOduncVer(uye1,kitap1,kisaOdunc);

//Ödünç verilen kitabın gösterilmesi
var oduncKitaplar = uye1.OduncKitaplar;

foreach(var kitap in oduncKitaplar){
    Console.WriteLine($"{kitap.Ad}");
}

//İade alma işlemi
kutuphane.KitapIadeAl(uye1,kitap1);

//İade alındıktan sonra üyenin ödünç kitaplarının listelenmesi
oduncKitaplar = uye1.OduncKitaplar;
foreach(var kitap in oduncKitaplar){
    Console.WriteLine($"{kitap.Ad}");
}


//Kitap silinmesi ve listenin tekrardan gösterilmesi
kutuphane.KitapSil(kitap2);

kitaplar = kutuphane.Kitaplar;

foreach(var kitap in kitaplar){
    Console.WriteLine($"{kitap.Ad}");
}

//Üye silme işlemi
kutuphane.UyeSil(uye2);
//Üye silindikten sonra uye listesinin tekrardan gösterilmesi
foreach(var uye in uyeler){
    Console.WriteLine($"{uye.Ad}");
}
