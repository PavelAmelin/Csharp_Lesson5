int[] GetArray()
{
    int q = Convert.ToInt32(Console.ReadLine());
    int N = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int[q];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-N, N);
        Console.WriteLine($"{arr[i]}");
    }
    return arr;
}

int SumUnevenPos(int[] nums)
{
    int sum  = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i % 2 == 0)
            sum += nums[i];   
    }
    return sum;
}

Console.WriteLine(SumUnevenPos(GetArray()));
