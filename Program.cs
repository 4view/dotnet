using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
       Car bmw = new Car("BMW");

       bmw.Move();
    }   
    
    
}

abstract class Transport
{

    public string Name { get; }

    public Transport(string name)
    {
        Name = name;
    }
    public void Move() => Console.WriteLine($"{Name} is moving");
}

class Ship : Transport 
{
    public Ship(string name) : base(name) {}
}

class Aircraft : Transport 
{
    public Aircraft(string name) : base(name) {}
}

class Car : Transport 
{
    public Car(string name) : base(name) {}
}

