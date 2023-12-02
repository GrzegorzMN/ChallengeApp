///////////////////
//Program Dzien 4//
///////////////////

//Zmienne
var name = "Ewa";
var sex = 'K';
var age = 25;

if (sex == 'K')
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Inna piękna kobieta");
    }
}
else if (sex == 'M')
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (age > 18 && name == "Grzegorz")
    {
        Console.WriteLine("Pełnoletni Grzegorz");
    }
    else
    {
        Console.WriteLine("Inny mężczyzna");
    }
}