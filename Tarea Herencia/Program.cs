// Ejemplo 1: Herencia Simple (Clase Base y Derivada)
using System;

class Animal
{
    public string Nombre { get; set; }
    public void EmitirSonido()
    {
        Console.WriteLine("Este animal hace un sonido");
    }
}

class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine("Guau guau!");
    }
}

// Ejemplo 2: Herencia Multinivel
class Mamifero : Animal
{
    public void Amamantar()
    {
        Console.WriteLine("Este mamífero amamanta a sus crías");
    }
}

class Gato : Mamifero
{
    public void Maullar()
    {
        Console.WriteLine("Miau Miau!");
    }
}

// Ejemplo 3: Herencia Jerárquica
class Ave : Animal
{
    public void Volar()
    {
        Console.WriteLine("Esta ave puede volar");
    }
}

class Aguila : Ave
{
    public void Cazar()
    {
        Console.WriteLine("El águila está cazando");
    }
}

// Ejemplo 4: Implementación de Interfaces (Simulación de Herencia Múltiple)
interface IVehiculo
{
    void Arrancar();
}

interface IVolador
{
    void Despegar();
}

class Avion : IVehiculo, IVolador
{
    public void Arrancar()
    {
        Console.WriteLine("El avión ha arrancado");
    }
    public void Despegar()
    {
        Console.WriteLine("El avión ha despegado");
    }
}

// Ejemplo 5: Clases Abstractas y Herencia
abstract class Figura
{
    public abstract double CalcularArea();
}

class Circulo : Figura
{
    public double Radio { get; set; }
    public Circulo(double radio)
    {
        Radio = radio;
    }
    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro { Nombre = "Firulais" };
        miPerro.EmitirSonido();
        miPerro.Ladrar();
        
        Gato miGato = new Gato { Nombre = "Misu" };
        miGato.Amamantar();
        miGato.Maullar();
        
        Avion miAvion = new Avion();
        miAvion.Arrancar();
        miAvion.Despegar();
        
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine($"El área del círculo es: {miCirculo.CalcularArea()}");
    }
}
