// Первый пример
// int [] array = {1,12,31,4,4,16,17,18};
// int n = array.Length;
// int find = 4;
// int index = 0;
// 
// while (index<n)
// {
//    if(array[index] == find)
//     {
//         Console.WriteLine(index);
//        break;
//    }
//     index++;
// }

// Пример с использованием генератора случайнх чисел 
void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
 collection[index] = new Random().Next(1, 10);
 index ++;    
}
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = -1; // position = index, по умолчанию index = 0; -1 - означает, что если будет искаться несуществующее число массива (например 444), то оно будет выводиться под индексом -1
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);