double[] GetArray()
{
    int q = Convert.ToInt32(Console.ReadLine());
    int N = Convert.ToInt32(Console.ReadLine());
    double [] arr = new double[q];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * N, 2);
        Console.WriteLine($"{arr[i]}");
    }
    return arr;
}

double MinMaxDiffer(double[] nums)
{
    double min = nums[0];
    double max = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > max)  
            max = nums[i];
        else if (nums[i] < min)  
            min = nums[i];
    }
    double dif = max - min;
    return dif;
}

Console.WriteLine(MinMaxDiffer(GetArray()));
