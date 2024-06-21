
namespace VirtualMethoden;

class Program
{
    static void Main(string[] args)
    {
        Tiere[] verhalten =
        {
            new Hund(),
            new Katze()
        };

        for (int i = 0; i < 10; i++)
        {
            foreach (var tier in verhalten)
            {
                tier.MakeSound();
            }
        }
        
    }
}

class Tiere
{
    public virtual void MakeSound()
    {
    }
}

class Hund : Tiere
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("wuff, Wuff");
    }
}

class Katze : Tiere
{
    public override void MakeSound()
    {
        Console.WriteLine("Mijau....");
    }
}