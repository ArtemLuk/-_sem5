// Задача 34: Задайте массив заполненный
//случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();

int[] Create(int N, int min, int max) {  
      int[] A = new int[N];
    for (int i = 0; i < N; i++)
        A[i] = new Random().Next(min,max);
    return A;
    }

int EvenNum(int[] A){
    int count=0;
    for (int i=0; i<(A.Length-1); i++) {
        if (A[i]%2==0) 
            count+=1;
        }
    return count;
    }
Console.WriteLine("Please enter the quantity: "); 
int N= int.Parse(Console.ReadLine());
Console.WriteLine("Created array: ");

int[] Arr = Create(N,100,1000);
Console.WriteLine($"[{String.Join(", ", Arr)}]");

Console.WriteLine($"The quantity of Even numbers is: {EvenNum(Arr)}");
