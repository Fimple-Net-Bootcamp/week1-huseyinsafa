public class Kutuphane
{
    private List<Kitap> kitaplar;

    public List<Kitap> Kitaplar
    {
        get { return kitaplar; }
    }

    private List<Uye> uyeler;
    
    public List<Uye> Uyeler
    {
        get { return uyeler; }
    }

    public Kutuphane()
    {

        kitaplar = new List<Kitap>();
        uyeler = new List<Uye>();

    }

    public void KitapEkle(Kitap kitap)
    {
        kitaplar.Add(kitap);
    }

    public void KitapSil(Kitap kitap)
    {
        kitaplar.Remove(kitap);
    }

    public void KitapOduncVer(Uye uye, Kitap kitap,IOduncIslemleri oduncIslemi)
    {
        if (kitaplar.Contains(kitap) && uyeler.Contains(uye))
            oduncIslemi.OduncAl(uye,kitap);
        else{
            Console.WriteLine("Lütfen Geçerli Bir Kitap Veya Üye İle Deneyiniz.");
        }
        
    }

    public void KitapIadeAl(Uye uye, Kitap kitap)
    {
        if (uyeler.Contains(uye) && uye.OduncKitaplar.Contains(kitap))        
            uye.kitapIadeEt(kitap);
        else{
            Console.WriteLine("Lütfen Geçerli Bir Kitap Veya Üye İle Deneyiniz.");
        }      
    }

    public void UyeEkle(Uye uye)
    {
        uyeler.Add(uye);
    }

    public void UyeSil(Uye uye)
    {
        uyeler.Remove(uye);
    }
    
}