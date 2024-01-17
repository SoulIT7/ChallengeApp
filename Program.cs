var name = "Ewa";
bool isWoman = true;
var age = 25;

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else if (age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa lat 30");
}
else
{
    Console.WriteLine("Nic");
}
