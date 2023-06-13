Console.Clear();

Console.Write("Введите целое число:  ");
string userInput1 = Console.ReadLine() ?? "";
int N = int.Parse(userInput1);

int i = 0; 

while (i < N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine ($" {i} ");
    }
    i++;
}