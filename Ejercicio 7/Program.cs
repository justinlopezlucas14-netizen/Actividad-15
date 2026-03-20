double salario;
while (true)
{
    Console.Write("Ingrese salario: ");
    if (double.TryParse(Console.ReadLine(), out salario) && salario >= 0) break;
    {
        Console.WriteLine("Error: El salario no puede ser negativo.");
    }
}