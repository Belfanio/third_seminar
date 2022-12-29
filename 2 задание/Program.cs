int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
        break;     
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

double getCoordinate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double coordinate = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
    return coordinate;
}

int x1 = GetNumber("Введите координату x1 - ");
int y1 = GetNumber("Введите координату y1 - ");
int z1 = GetNumber("Введите координату z1 - ");
int x2 = GetNumber("Введите координату x2 - ");
int y2 = GetNumber("Введите координату y2 - ");
int z2 = GetNumber("Введите координату z2 - ");

double coordinate = getCoordinate(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между точками = {coordinate}");