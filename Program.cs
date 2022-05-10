// Создание и заполненнение первоначального массива

string[] arrayOriginal = new string[] { "hello", "2", "world", ":-)" };

// Вывод оригинального массива
Console.WriteLine(PrintArray(arrayOriginal)); 

// Если длина = 0, то выводим сообщение о том, что во всех строках > 4 символов
if (FindLenght(arrayOriginal) == 0) 
{
    Console.WriteLine("Во всех элементах исходного массива больше 4 символов."); 
}
else
{
    string[] arrayResult = new string[FindLenght(arrayOriginal)]; // Создаём итоговый массив
    FillArray(arrayOriginal, arrayResult); // Заполняем итоговый массив
    Console.WriteLine(PrintArray(arrayResult)); // Выводим
}

// Метод, находящий длину итогового массива
int FindLenght(string[] array) 
{
    int size = array.Length;

    int arrayResultLenght = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResultLenght++;
        }
    }
    return arrayResultLenght;
}
// Метод, заполняющий итоговый массив строками, в которых <= 3 символа из исходного массива.
void FillArray(string[] array1, string[] array2) 
{
    int size = array1.Length;
    int i = 0;
    int j = 0;
    while (i < size)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j = j + 1;
        }
        i = i + 1;
    }
}

// Метод, печатающий массив
string PrintArray(string[] array) 
{
    int size = array.Length;
    string print = String.Empty;
    for (int i = 0; i < size; i++)
    {
        print += $"{array[i]} ";
    }
    return print;
}