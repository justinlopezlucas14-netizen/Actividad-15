int edad;
while (true)
{
    Console.Write("Ingrese su edad: ");
    if (int.TryParse(Console.ReadLine(), out edad))
    {
        Console.WriteLine($"Edad ingresada: {edad}");
        break;
    }
    Console.WriteLine("Error: Ingrese un número entero válido.");
}