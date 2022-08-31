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

// Второй пример, с помощью генератора случайных чисел
void FillArray(int[] collection)
{
    int length = collection.Lenght;
    int Index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
    index ++;    
    }
}


int [] array = new int [10];