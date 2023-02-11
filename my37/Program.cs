// Задача 37:Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6]-> 36 21

Console.Clear();
Console.WriteLine("Please enter array: ");
string str_ar = Console.ReadLine();
int[] ar = GetArrayFromString(str_ar);

int[] GetArrayFromString(string stringArray){
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++){
        res[i] = int.Parse(nums[i]);
        }
    return res;
}

int[] NewArray(int[] A){
    int C=(A.Length+1)/2;
        int[] B = new int[C];
    for (int i=0; i<A.Length/2; i++) {
        B[i] = A[i] * A[A.Length-i-1];
        }
    if (A.Length%2==1) {
    B[C-1]=A[A.Length/2];}
    return B;
}
Console.WriteLine("Created array: ");
Console.WriteLine($"[{String.Join(", ", ar)}]");
Console.WriteLine("New array: ");
Console.WriteLine($"[{String.Join(", ", NewArray(ar))}]");
