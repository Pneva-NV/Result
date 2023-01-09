string[] Array;
int count;

Console.Write("Введите количество элементов массива: ");
count = Convert.ToInt32(Console.ReadLine());

Array = new string[count];

Console.WriteLine("Введите элементы (строки), входящие в массив:");
for (int i = 0; i < Array.Length; i++)
{
    Console.Write("Элемент[{0}] - ", i);
    Array[i] = Console.ReadLine();
}

void Print(string[] Array)
{
    Console.Write($"[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"\"{Array[i]}\"");
        if (i != Array.Length - 1)
            Console.Write(", ");
    }
    Console.Write($"]");
}

Console.WriteLine();
Print(Array);
Console.Write($" -> ");
