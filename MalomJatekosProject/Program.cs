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

Console.WriteLine("\n2. feladat");
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
    Console.WriteLine("Több győzelme van mint veresége azaz Nyerő játékos.");
}
else
{
    Console.WriteLine("Többször vesztett mint nyert azaz Vesztő játékos.");
}

Console.WriteLine("\n3. feladat");
Jatekos jatekos3 = new Jatekos(80, "Jatekos Janos");

try
{
    jatekos3.Win(20);
    jatekos3.Win(10);
    jatekos3.Draw();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

if(jatekos3.StartingPoints > jatekos3.Points)
{
    Console.WriteLine($"{jatekos3.Name} negatív összpontszámmal rendelkezik.");
}
else if (jatekos3.StartingPoints < jatekos3.Points)
{
    Console.WriteLine($"{jatekos3.Name} pozitív összpontszámmal rendelkezik.");
}
else
{
    Console.WriteLine($"{jatekos3.Name} semleges összpontszámmal rendelkezik.");
}
Console.WriteLine($"{jatekos3.Draws} döntetlent játszott.");