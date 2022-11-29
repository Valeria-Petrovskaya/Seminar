Console.Clear ();
Console.Write("Ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = (n / 10) % 10;
Console.Write($"Вторая цифра: {n1}");
