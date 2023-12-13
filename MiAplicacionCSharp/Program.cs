using System;

partial class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1: Variables y Operadores
        int numero1 = 10;
        int numero2 = 20;
        int resultado = numero1 + numero2;
        Console.WriteLine("El resultado es: " + resultado);

        // Ejercicio 2: Estructuras de Control
        int edad = 21;
        if (edad >= 18)
        {
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            Console.WriteLine("La persona no es mayor de edad.");
        }

        // Ejercicio 3 y 4: Programación Orientada a Objetos - Clases, Objetos y Métodos
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Juan",
            Edad = 20,
            Calificacion = 85
        };
        estudiante1.MostrarInformacion();

        // Ejercicio 5: Programación Orientada a Objetos - Herencia
        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            Nombre = "Pedro",
            Edad = 25,
            Calificacion = 90,
            Titulo = "Ingeniero en Sistemas"
        };
        graduado1.MostrarInformacion();
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Calificacion { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Calificación: {Calificacion}");
    }
}

class EstudianteGraduado : Estudiante
{
    public string Titulo { get; set; }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Título: {Titulo}");
    }
}