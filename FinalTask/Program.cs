// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.

string[] city = {"Moscow", "Hamburg", "Munchen", "Drezden", "Minsk", "Ufa", "Bor", "Loo", "x2"};
int i = 0;
int j = 0;
string[] city2 = new string[10];
while(i < city.Length)
{
    if(city[i].Length <= 3)
    {
       city2[j] = city[i] + " ";
    }
    i++;
    j++;
}
foreach(string str in city2)
{
    Console.Write(str);
}
