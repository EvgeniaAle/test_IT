//Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.//
string [] M;
Console.WriteLine ("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split();
var result = new string [M .Length];
var realSize = 0;
foreach (var value in M)
{
    if (value.Length<=3)
    {result[realSize] = value;
    realSize++;
    }
}
Console.WriteLine(String.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);