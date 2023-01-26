//
// создаем метод для заполнения массива с клавиатуры 

string[] CreateArray(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Please enter  array element  : ");
        array[i] = Console.ReadLine();
    }
    return array;
}


int SortingArray(string[] array)
{   //с помощью счетчика узнаем размер нового массива
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    // пpовереям размер элементов
        if (array[i].Length <= 3)
        {
            count++;//присваем еденицу каждый раз когда условия истина
        }
    }
    
    return count;
}
string[] NewArray(int count, string[] array)
{// создаем новый массив прогоняем через цикл
    string[] arr = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)  // с помощью условия проверяем  размер элемента массива
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}
Console.Write("введите  массива ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(n);
int number = SortingArray(array);
string[] newArr = NewArray(number, array);
for (int i = 0; i < newArr.Length; i++)
    Console.Write(newArr[i] + " ");