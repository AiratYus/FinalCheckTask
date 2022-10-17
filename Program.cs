void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine(array[array.Length - 1]);
}

string[] ReadArray()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int length = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите элементы массива: ");

    var array = new string[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

var initial = ReadArray();

const int filterLength = 3;

var temp = new string[initial.Length];
var ti = 0;
for (int i = 0; i < initial.Length; i++)
{
    if (initial[i].Length <= filterLength)
    {
        temp[ti] = initial[i];
        ti++;
    }
}

var result = new string[ti];
var ri = 0;
while (ti > 0)
{
    result[ri] = temp[ri];
    ri++;
    ti--;
}

Console.WriteLine("Результат:");
PrintArray(result);
