// Создание и заполненнение первоначального массива
string [] arrayOriginal = new string [] {"hello", "2", "world", ":-)"};
string [] arrayResult = new string [FindArrayResultLenght(arrayOriginal)];

int FindArrayResultLenght (string [] array)
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
