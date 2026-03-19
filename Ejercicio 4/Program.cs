int anio;
while (true)
{
    Console.Write("Año de nacimiento (1900-2026): ");
    if (int.TryParse(Console.ReadLine(), out anio) && anio >= 1900 && anio <= 2026) break;
    {
        Console.WriteLine("Error: Año fuera de rango lógico.");
    }
}
