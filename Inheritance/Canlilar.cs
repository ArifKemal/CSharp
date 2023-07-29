public class Canlilar{
    protected void Beslenme(){
        System.Console.WriteLine("Canlılar beslenir");
    }

    protected void Solunum(){
        System.Console.WriteLine("Canlılar solunum yapar");
    }

    protected void Bosaltım(){
        System.Console.WriteLine("Canlılar boşaltım yapar");
    }

    public virtual void UyaranlaraTepki(){
        System.Console.WriteLine("Canlılar uyaranlara tepki verir");
    }



}