Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) 
    Console.WriteLine($"1-ое число {a} больше 2-ого числа {b}");
else if (a<b) 
    Console.WriteLine($"2-ое число {b} больше 1-ого числа {a}");
else
    Console.WriteLine($"1-ое число {a} равно 2-му числу {b}");
