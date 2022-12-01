Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x = 2;

while(x <= a){
    Console.Write($" {x}," );
    x = x + 2;
}