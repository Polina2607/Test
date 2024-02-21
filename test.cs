// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array1 = new string[6] {"1234", "156", "hello", "world", "2", "Kazan"};
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for(int i=0; i<array1.Length; i++)
    {
        array2[count] = array1[i];
        count++;
    }
}
SecondArray(array1, array2);