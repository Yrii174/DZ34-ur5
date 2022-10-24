// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] CreateArray(int size, int max)  
{ 
System.Console.WriteLine("Задайте длину массива");
size = int.Parse(Console.ReadLine());
int[] array = new int[size];  
for (int i = 0; i < size; i++)   
    { 
    array[i] = new Random().Next(0, max);
    i = i++;   
    }
    return array; 
} 
string GetArray(int[] array)  
{      
string sum = string.Empty;      
for (int i = 0; i < array.Length; i++)      
    {
      sum = sum + $"{array[i]}, ";      
    }                   
    return sum;  
} 
int ArrayChetny(int [] array)  
{
int chetny = 0;          
foreach (int element in array)     
{         
    if (element % 2 == 0) chetny ++;    
}     
return chetny; 
} 
int[] array = CreateArray(8,999);
System.Console.WriteLine(GetArray(array));
System.Console.WriteLine(ArrayChetny(array));