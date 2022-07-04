Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
if(number.Length != 5)
{
Console.WriteLine($"Число {number} не является пятизначным");
}
else if(number[0] == number[4] & number[1] == number[3])
{
Console.WriteLine($"Число {number} является палиндромом");
}
else
{
Console.WriteLine($"Число {number} не является палиндромом");
}