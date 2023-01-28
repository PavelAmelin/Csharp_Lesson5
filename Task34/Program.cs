int[] GetArray()
{
    int q = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int[q];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.WriteLine($"{arr[i]}");
    }
    return arr;
}

int CntEvenArray(int[] nums)
{
    int cnt = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
            cnt += 1;   
    }
    return cnt;
}

Console.WriteLine(CntEvenArray(GetArray()));