namespace VirtualMethoden;

class Program
{
    static void Main(string[] args)
    {
        Hund labrador = new Hund();
        Katze ushi = new Katze();
        labrador.MakeSound();
        ushi.MakeSound();
    }
}

class Tier
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Ein tierisches Gereusch+++++");
    }
}

class Hund : Tier
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("wuff, Wuff");
    }
}

class Katze : Tier
{
    public override void MakeSound()
    {
        Console.WriteLine("Mijau....");
    }
}