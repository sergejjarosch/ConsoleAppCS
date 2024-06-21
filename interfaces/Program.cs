namespace interfaces;

class Program
{
    static void Main(string[] args)
    {
        
    }
}

//- - - Iterfaces - - -
interface IMovable
{
    void Move();
    void ShowMoveSpeed();
}
//- - - Classes - - -

class Vehicle
{
    
}

class Car : Vehicle, IMovable
{
    public void Move()
    {
        
    }

    public void ShowMoveSpeed()
    {
        
    }
}