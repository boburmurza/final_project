//
// создаем метод для заполнения массива с клавиатуры 

string[] CreateArray(int n )
{
    string[] array = new string [ n];
    for(int i = 0; i < n; i++){
        
            array[i] = Console.ReadLine();
        
    }
    return array;
}


void PrintArray(string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        
            Console.Write($"{array[i]} ");
       }
    Console.WriteLine();
}



Console.Write("Please enter the number of columns in your array: ");
int n = Convert.ToInt32(Console.ReadLine());


string[] array= CreateArray(n);

PrintArray(array);




