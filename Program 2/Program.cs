string Name = "Ewa";
bool Gender = true;
int Age = 33;

if (Gender == true && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else  if (Gender == true && Age >= 30)
{
    Console.WriteLine("Kobieta mająca 30 lat lub więcej");
}
else if (Gender == false && Age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else Console.WriteLine("Pełnoletni mężczyzna");
