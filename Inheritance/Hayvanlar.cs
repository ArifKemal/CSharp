public class Hayvanlar:Canlilar{

    protected void Adaptasyon(){
        System.Console.WriteLine("Hayvanlar adapte olabilir");
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        System.Console.WriteLine("Hayvanlar temasa tepki verir");
    }

}

public class Surungenler:Hayvanlar{
    
    public Surungenler(){
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltım();
        base.Solunum();
    }
    public void Surunmek(){
        System.Console.WriteLine("Sürüngenler sürünür");
    }
}

public class Kuslar:Hayvanlar{

    public Kuslar(){
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltım();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void Ucmak(){
        System.Console.WriteLine("Kuşlar uçar");
    }
}