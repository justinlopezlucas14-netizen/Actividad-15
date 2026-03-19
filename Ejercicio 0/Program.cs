int edad;
Console.Write("Ingrese su edad: ");
if (int.TryParse(Console.ReadLine(), out edad))
{
    Console.WriteLine("Edad válida");
}
else
{
    Console.WriteLine("Edad invalidada");
}
