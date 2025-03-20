using MalomJatekosProject.Models;

Console.WriteLine("1. feladat");
try
{
    Jatekos jatekos = new Jatekos(-100, "Negativ Noel");
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Jatekos jatekos2 = new Jatekos(100, "Pozitiv Pista");
Console.WriteLine(jatekos2);