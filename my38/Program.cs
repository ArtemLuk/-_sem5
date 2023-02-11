// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Please enter array: ");
string str_A = Console.ReadLine();
double[] A = GetArrayFromString(str_A);
Console.WriteLine("Created array: ");
Console.WriteLine($"[{String.Join(", ", A)}]");
Console.WriteLine($"between max and min: {Diff(A)}");

double[] GetArrayFromString(string stringArray){
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];
    for (int i = 0; i < nums.Length; i++){
        res[i] = double.Parse(nums[i]);
        }
    return res;
}

double Diff(double[] nums){
    double min=nums[0], max=nums[0];
    for (int i=1; i<nums.Length; i++) {
        if (nums[i]>max) {
            max=nums[i];
        }
        if (nums[i]<min) {
            min=nums[i];
        }
    }
return (max - min);
}
