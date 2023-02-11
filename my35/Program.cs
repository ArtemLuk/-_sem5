// **Задача 35:**Задайте одномерный массив из 123 случайных чисел [0: 1000]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5

Console.Clear();

int[] Create(int N, int min, int max) {  
      int[] A = new int[N];
    for (int i = 0; i < N; i++)
        A[i] = new Random().Next(min,max);
    return A;
    }

int QuantFavorite(int[] A, int min, int max){
int ind = 0;
for (int i = 0; i < A.Length; i++)
    if (A[i]>=min && A[i]<=max)
    ind +=1;
return ind;
}
int[] A= Create(123, 0, 1001);
Console.WriteLine("Created array: ");
Console.WriteLine($"[{String.Join(", ", A)}]");
Console.WriteLine($"The quantity of favorite values: {QuantFavorite(A,10,99)}"); 
