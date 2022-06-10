//массив info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют количество бит чисел из массива data.

// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

// Example:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// output: 1, 7, 0, 1

void TwoArrays(int[] arr1, int[] arr2 ) 
{
    int index = 0;
    int ind = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        int num = arr2[i] - 1;
        double sum = 0;
        for (int j = index; j < index + arr2[i]; j++)
        {
            sum += Math.Pow(2, num) * arr1[j];
            num--;
            ind++;
        }
        Console.Write($"{sum}, ");
        index = ind;
    }
}
Console.Clear();
int[] bit = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] number = {2, 3, 3, 1 };
TwoArrays(bit, number);


// Вероятна ошибка на этапе ввода данных: количество элементов в массиве data 
// может не совпадать с суммой элементов в массиве info. 