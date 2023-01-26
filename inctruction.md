# Инструкция решения задачи
## План решения задачи 
* вводим массив 

* запалняем массив

* ищем размер нового массива 

* создаем новый массив 

* выводим массив

 1. *Запрашиваем у пользователя ввести элемменты массива*
        
         string[] CreateArray(int n)
        {  //созлаем новый массив 

        string[] array = new string[n];

        // заполняем через цикл

        for (int i = 0; i < n; i++)

        {  // элементы массива заполняем  через ввод клавиатуры 

        Console.Write("Please enter  array element  : ");

        array[i] = Console.ReadLine();
        }
        return array;        


    



## Теперь нам нужно найти размер нового массива
     int SortingArray(string[] array)
    { //с помощью счетчика узнаем размер нового массива
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {  // пpовереям размер элементов
        if (array[i].Length <= 3)
        {  //присваем еденицу каждый раз когда условия истина
            count++;
        }
    }
    
    return count;
}
# Заполняем новый массив 

    string[] NewArray(int count, string[] array)
    {
    string[] arr = new string[count];
    // создаем новый массив прогоняем через цикл
    for (int i = 0, j = 0; i < array.Length; i++)
    {
       // с помощью условия проверяем  размер элемента массива
        if (array[i].Length <= 3)
        {
           // присваем те эелдменты которые меньше 3 на новый массив
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
    }