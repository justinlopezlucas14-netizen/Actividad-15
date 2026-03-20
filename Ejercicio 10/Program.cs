int cant;
while (true)
{
    Console.Write("Cantidad de productos a comprar: ");
    if (int.TryParse(Console.ReadLine(), out cant) && cant > 0)
    {
        for (int i = 1; i <= cant; i++)
        {
            Console.Write($"Ingrese nombre del producto {i}: ");
            Console.ReadLine();
        }
        break;
    }
    Console.WriteLine("Ingrese un número entero positivo.");
}