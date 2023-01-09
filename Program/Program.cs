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
