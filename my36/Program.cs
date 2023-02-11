// Задача 36: Задайте одномерный массив,
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int Sum(int[] A) {
    int s=0;
    for (int i=0; i<A.Length; i++){
        if (i % 2 == 1) {
            s=s+A[i];
        }
    }
    return s;
}

Console.WriteLine("Created array: ");
Console.WriteLine($"[{String.Join(", ", ar)}]");

Console.WriteLine($"The sum is {Sum(ar)}");

