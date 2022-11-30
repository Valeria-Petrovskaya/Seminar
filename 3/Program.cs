Console.Clear();
Console.WriteLine("День недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Такого дня нет, введите заново: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n ==6 || n==7)
    Console.Write("Выходной день");
else
    Console.Write("Будний день");
