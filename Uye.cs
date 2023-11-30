public class Uye : IYazdirilabilir
{

    private string ad;

    public String Ad {
        get {return ad;}
        set{ad=value;}
    }
    
    private string soyad;

    public String Soyad{
        get{return soyad;}
        set{soyad=value;}
    }

    private int uyelikNumarasi;

    public int UyelikNumarasi{
        get{return uyelikNumarasi;}
        set{uyelikNumarasi=value;}
    }

    private List<Kitap> oduncKitaplar;

    public List<Kitap> OduncKitaplar{
        get{return oduncKitaplar;}
        set{oduncKitaplar=value;}

    }

    public Uye(string ad, string soyad, int uyelikNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        UyelikNumarasi = uyelikNumarasi;
        OduncKitaplar = new List<Kitap>();
    }

    
    public void kitapOduncAl(Kitap kitap)
    {
        OduncKitaplar.Add(kitap);
    }

    public void kitapIadeEt(Kitap kitap)
    {
        OduncKitaplar.Remove(kitap);
    }

    public void Yazdir()
    {
        Console.WriteLine("Uye bilgileri Aşağıda Gösteriliyor.");
        Console.WriteLine($"{Ad} {Soyad} {UyelikNumarasi}");
        foreach(var kitap in OduncKitaplar){
           kitap.Yazdir();
        }
    }
}