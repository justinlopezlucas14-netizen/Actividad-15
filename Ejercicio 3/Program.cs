int estudiantes;
while (true) 
{
    Console.WriteLine("Cantidad de estudiantes: ");
    if (int.TryParse(Console.ReadLine(),out estudiantes) && estudiantes >= 0) break;
    {
        Console.WriteLine("Error:Ingrese un entero positivo. ");
    }

}
