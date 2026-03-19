DateTime fecha;
while (true)
{
    Console.Write("Ingrese fecha(dd/mm/aaaa): ");
    if (DateTime.TryParse(Console.ReadLine(), out fecha))
    {
        Console.WriteLine($"Fecha corta: {fecha.ToShortDateString()}");
        break;
    }
    Console.WriteLine("Formato de fecha inválido.");
}
