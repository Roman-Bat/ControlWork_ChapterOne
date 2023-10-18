/*/////////////////////////////////////////////////////////////////////////////////////////////////
                                                                                                 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,         
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,    
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться            
коллекциями, лучше обойтись исключительно массивами.                                             
                                                                                                 
/////////////////////////////////////////////////////////////////////////////////////////////////*/

// Метод вывода массива
void PrintArray(string[] array, string message)
{
Console.WriteLine("\n" + message + "");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"\"{array[i]}\"");
       if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        
    }
Console.Write("]\n");
}

// Метод формирования нового массива из строк, длина которых меньше, либо равна 3 символам
string[] NewArrayThreeSym(string[] array)
{
int count = 0;    
string[] arrayNew = new string[array.Length];

for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            arrayNew[count] = array[i];
            count ++;     
        }
        
    }
if (arrayNew.Length > count + 1) {Array.Resize(ref arrayNew, count);}
return arrayNew;  
}



string[] arrayFirst = {"Hello", "2", "world", ":-)"};
string[] arraySecond = {"1234", "1567", "-2", "computer science"};
string[] arrayThird = {"Russia", "Denmark", "Kazan"};

PrintArray(arrayFirst, "Первый массив:");
PrintArray(NewArrayThreeSym(arrayFirst), "Новый массив:");

PrintArray(arraySecond, "Второй массив:");
PrintArray(NewArrayThreeSym(arraySecond), "Новый массив:");

PrintArray(arrayThird, "Третий массив:");
PrintArray(NewArrayThreeSym(arrayThird), "Новый массив:");
Console.ReadKey();