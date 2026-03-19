int num;
while (true)
{
    Console.Write("Ingrese un número entero: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine(num % 2 == 0 ? "Es Par" : "Es Impar");
        break;
    }
    Console.WriteLine("Dato incorrecto.");
}
