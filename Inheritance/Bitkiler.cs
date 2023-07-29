public class Bitkiler:Canlilar{

    protected void Fotosentez(){
        System.Console.WriteLine("Bitkiler fotosentez yapar");
    }

    
}

public class TohumluBitkiler:Bitkiler{

    public TohumluBitkiler(){
        base.Fotosentez();
        base.Beslenme();
        base.Bosaltım();
        base.Solunum();
    }
    public void TohumlaCogalma(){
        System.Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
    }
}

public class TohumsuzBitkiler:Bitkiler{
    
    public TohumsuzBitkiler(){
        base.Fotosentez();
        base.Beslenme();
        base.Bosaltım();
        base.Solunum();
    }
    public void SporlaCogalma(){
        System.Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
    }
}
