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

Console.WriteLine("2. feladat");
try
{
    jatekos2.Win(50);
    jatekos2.Win(50);

    jatekos2.Win(5);
    jatekos2.Win(5);
    jatekos2.Win(5);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(jatekos2.Name + " " + jatekos2.Wins + " alkalommal nyert.");

try
{
    jatekos2.Lose(5);
    jatekos2.Lose(5);
    jatekos2.Lose(5);
    jatekos2.Lose(50);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(jatekos2.Name + " aktuális pontszáma: " + jatekos2.Points);
if (jatekos2.Losses < jatekos2.Wins)
{
    Console.WriteLine("Több győzelme van mint veresége/Nyerő játékos");
}
else
{
    Console.WriteLine("Többször vesztett mint nyert/Vesztő játékos");
}