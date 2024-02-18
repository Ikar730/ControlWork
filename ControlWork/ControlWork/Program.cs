//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решениибойтись исключительно массивами. не рекомендуется пользоваться коллекциями, лучше о

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

using System.Collections.Specialized;

string[] words = ["Hello", "2", "world", ":-)"];


int count = 0;
for (int i = 0; i < words.Length; i++)
{
    string word = words[i];
    if (word.Length <= 3) 
    count++;
}

string[] words2 = new string[count];
int j = 0;
for (int i = 0;i < words.Length; i++) 
{
    string word = words[i];
    if (word.Length <= 3)
    {
        words2[j] = word;
        j++;
    }
       
}