
using System.ComponentModel.Design;
/// Napisz w Program.cs kod, w którym
/// - zadeklarujesz zmienną z imieniem
/// - zadeklarujesz zmienną z płcią (dobierz zmienną)
/// - zadeklarujesz zmienną z wiekiem
/// - zweryfikujesz dane i wyświetlisz jeden z komunikatów
/// (1): "Kobieta poniżej 30 lat"
/// (2): "Ewa, lat 33"
/// (3): "Niepełnoletni mężczyzna"
/// ------------------------------
/// (możesz dodać swoje)
var name = "Ewa";
var sex = "male";
var age = 80;

if (name == "Ewa" && sex == "female" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex != "female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (sex != "female" && age > 18 && age < 80)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
else if (sex != "female" && age >= 80)
{
    Console.WriteLine("Bardzo pełnoletni mężczyzna");
}