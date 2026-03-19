decimal precio;
while (true) 
{
    Console.Write("Ingrese el precio: ");
    if (decimal.TryParse(Console.ReadLine(), out precio) && precio > 0) break;
    {
        Console.WriteLine("Error:Ingrese un entero positivo. ");
    }
}