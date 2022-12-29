int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 9999 && result < 100000)
            {
                 break;
            }
            else
            {
                Console.WriteLine("Число не пятизначное");
            }
            
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}


int number = GetNumber("Введите число");
int numberStart = number / 1000;
int numberFinish = number % 100;
if (numberStart / 10 == numberFinish % 10 && numberStart % 10 == numberFinish / 10)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
   Console.WriteLine("Число не является полиндромом");
}