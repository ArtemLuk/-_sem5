// Задан массив a[1..n] из n неотрицательных целых чисел. Необходимо реализовать следующие операции над ним:

//get(i) – извлечение элемента с номером i;
//update(l,r,x) – присвоение значения x всем элементам подмассива a[l..r];
//add(l,r,x) – увеличение всех элементов a[l..r] на x;
//rsq(l,r) – вычисление суммы всех элементов a[l..r], т.е. значения a[l]+a[l+1]+…+a[r];
//rmq(l,r) – вычисление минимального элемента среди всех значений a[l..r].

Console.Clear();
Console.WriteLine("Please enter array: ");
string str_ar = Console.ReadLine();
int[] ar = GetArrayFromString(str_ar);
Console.Write("Which element should be extract: ");
int index = int.Parse(Console.ReadLine());
Console.WriteLine($"{index} element is {Get(ar,index)}");
Console.WriteLine("Array after update: ");
Console.WriteLine($"[{String.Join(", ", Update(ar, 4, 7, 0))}]");
Console.WriteLine("Array after add: ");
Console.WriteLine($"[{String.Join(", ", Add(ar, 2, 5, 1))}]");
Console.WriteLine($"Sum between 2 and 4 is {Rsq(ar,2,4)}");
Console.WriteLine($"Min between 2 and 8 is {Rmq(ar,2,8)}");

int[] GetArrayFromString(string stringArray){
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++){
        res[i] = int.Parse(nums[i]);
        }
    return res;
}

int Get(int[] A, int ind){
    int G=A[ind];
    return G;
}

int[] Update(int[] A, int l, int r, int x){
    for (int i=l; i<=r; i++)
        A[i]=x;
    return A;
}

int[] Add(int[] A, int l, int r, int x){
    for (int i=l; i<=r; i++)
        A[i]+=x;
    return A;
}

int Rsq(int[] A, int l, int r){
    int Sum=0;
    for (int i=l; i<=r; i++)
        Sum+=A[i];
    return Sum;
}

int Rmq(int[] A, int l, int r){
    int min=A[l];
    for (int i=l+1; i<=r; i++){
        if (A[i]<min)
        min=A[i];
    }
    return min;
}
