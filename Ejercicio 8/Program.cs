double valor;
while (true)
{
    Console.Write("Número para raíz cuadrada: ");
    if (double.TryParse(Console.ReadLine(), out valor) && valor >= 0)
    {
        Console.WriteLine($"Raíz: {Math.Sqrt(valor)}");
        break;
    }
    Console.WriteLine("Error: Ingrese un número no negativo.");
}