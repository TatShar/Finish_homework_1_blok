﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] array = new string [] {"fghdh", "rtr", "34", "abrr", "123r"};
string []arr= new string[array.Length];
int count = 0;
int size=3;
for (int i = 0; i<array.Length; i++)
{
    if (array[i].Length <=size)
    {
        arr[count]=array[i];  
        count++;   
    }
}
Console.Write("Новый массив из строк: [");
for (int j=0; j< arr.Length; j++)
{
    Console.Write(arr[j]+ " ");
}
Console.Write("]");


       
    

 