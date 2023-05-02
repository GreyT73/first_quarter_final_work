Console.WriteLine("Задача: Написать программу, которая из имеющегося " +
"массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам."
+ " Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма."
+ "При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");
Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
int secondLength = 0;
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите любое слово или символы: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) secondLength++;
}

System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

string[] secondArray = new string[secondLength];
int k = 0;
for (int i = 0; i < length; i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[k] = array[i];
        k++;
    }
}

System.Console.WriteLine($"Массив в котором только значения длиной менее 3-х символов: [{string.Join(", ", secondArray)}]");

