Console.Clear ();
Console.Write("Ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100)
{Console.Write("Третьей цифры нет");
}
else{
    while (n > 999)
        {
            n = n / 10; 
        }
Console.Write($"Третья цифра: {n % 10}"); 
}

