// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 & num < 8)
{
    if (num > 5 & num < 8)
    {
        System.Console.WriteLine($"{num}й день недели является выходным.");
    }
    if (num > 0 & num < 6)
    {
    System.Console.WriteLine($"{num}й день недели НЕ является выходным.");
    }
}
else
{
    System.Console.WriteLine("Такого номера дня недели не существует");
}

