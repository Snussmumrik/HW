Console.Clear();

Console.Write("Введите целое число:  ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);


if (a % 2 == 1)
{
    Console.WriteLine ($" {a}  нечетное число ");
}
else
{
    Console.WriteLine ($" {a} четное число ");
}