// Напишите программу, которая на вход принимает число и выдает, является ли четным (делится ли оно на два без остатка)

Console.WriteLine("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("четное число");
    
}

else
if (number % 2 == 1)

{
    Console.WriteLine("нечетное число");
   
} 

