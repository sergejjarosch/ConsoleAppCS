namespace ConsoleAppHeroBatle;

class Program
{
    static void Main(string[] args)
    {
        Knight ritter1 = new Knight(100, 10);
        Barbarian angreifer1 = new Barbarian(100, 1, 7, 2);
        ritter1.TakeDamage(500);
        angreifer1.TakeDamage(250);
        
        Console.WriteLine("Ritter:");
        ritter1.ShowInfo();

        Console.WriteLine("Angreifer: ");
        angreifer1.ShowInfo();

    }
}

// Gemeinsamme Klasse, mit den Basiswerten.
class Warrior // Warrior ist die BASIS klasse der weiteren klassen
{
    protected int Health;
    protected int Armor;
    protected int Damage;
    public Warrior(int health, int armor, int damage) 
    {
        Health = health;
        Armor = armor;
        Damage = damage;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage - Armor;
    }
    public void ShowInfo()
    {
        Console.WriteLine(Health);
    }
}

//Klasse Knight -> erbt von Warrior und hat eigene Methode.
class Knight : Warrior
{
    //Konstruktor ÜBERNAHME aus der BASIS klasse -> Warrior
    public Knight(int health, int damage) : base(health, 5, damage){}
    public void Pray()
    {
        Armor += 2;
    }


}
//Klasse Barbarian -> erbt von Warrior und hat eigene Methode.
class Barbarian : Warrior
{
    //Wenn in BASIS Klasse ein konstriktor definiert ist,
    //Muss auch ein konstruktor in der ErbeKlasse sein.

    public int AttackSpeed;
    
    public Barbarian(int health, int armor, int damage, int attackSpeed) : 
        base(health, armor, damage * attackSpeed) {}
    public void Shout()
    {
        Armor -= 2;
        Health += 10;
    }
}