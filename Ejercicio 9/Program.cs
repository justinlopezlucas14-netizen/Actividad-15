float nota;
while (true)
{
    Console.Write("Nota del estudiante (0-100): ");
    if (float.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 100)
    {
        Console.WriteLine(nota >= 60 ? "Aprobado" : "Reprobado");
        break;
    }
    Console.WriteLine("Nota inválida.");
}
