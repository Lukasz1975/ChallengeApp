
using System.Reflection.Metadata;
/// Przygotuj program, który policzy ile jakich cyfr
/// występuje w podanej liczbie
/// 
/// Przykład:
/// Wyniki dla liczby: 4566
/// 0 => 0
/// 1 => 0
/// 2 => 0
/// 3 => 0
/// 4 => 1
/// 5 => 1
/// 6 => 2
/// 7 => 0
/// 8 => 0
/// 9 => 0
int number = 33111975;
string numberAsString = number.ToString();
char[] chars = numberAsString.ToArray();
int[] result = new int[10];

Console.WriteLine("Poniżej wynik dla liczby " + number);

for (int i=0; i<10; i++)
{
    result[i] = 0;

    foreach (char oneDigit in chars)
    {
        if (oneDigit == '0')
        {
            result[0]++;
        }
        else if (oneDigit == '1')
        {
            result[1]++;
        }
        else if (oneDigit == '2')
        {
            result[2]++;
        }
        else if (oneDigit == '3')
        {
            result[3]++;
        }
        else if (oneDigit == '4')
        {
            result[4]++;
        }
        else if (oneDigit == '5')
        {
            result[5]++;
        }
        else if (oneDigit == '6')
        {
            result[6]++;
        }
        else if (oneDigit == '7')
        {
            result[7]++;
        }
        else if (oneDigit == '8')
        {
            result[8]++;
        }
        else if (oneDigit == '9')
        {
            result[9]++;
        }
    }
    Console.WriteLine(i + " => " + result[i]);
}