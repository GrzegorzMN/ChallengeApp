///////////////////
//Program Dzien 4//
///////////////////

//Zmienne
var Name = "Ewa";
var Sex = 'K';
var Age = 25;

if (Sex == 'K')
{
    if (Name == "Ewa" && Age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (Age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Inna piękna kobieta");
    }
}
else
{
    if(Age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (Age > 18 && Name == "Grzegorz")
    {
        Console.WriteLine("Pełnoletni Grzegorz");
    }
    else
    {
        Console.WriteLine("Inny mężczyzna");
    }
}