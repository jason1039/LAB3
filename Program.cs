// See https://aka.ms/new-console-template for more information
int baseSize = 1000;
for (int i = 0; i < 7; i++)
{
    int size = baseSize * (int)Math.Pow(2, i);
    int[] data = CreateData(size);
    // Console.WriteLine($"Start:{size}");
    Console.Write($"size:{size}\t\t");
    Bubble(data);
    Selection(data);
    Insertion(data);
    Ms(data);
    Console.WriteLine("\r");
}
// Bubble();

static void Bubble(int[] data)
{
    DateTime StartTime = DateTime.Now;
    for (int i = 0; i < data.Length - 1; i++)
    {
        for (int j = 0; j < data.Length - 1 - i; j++)
        {
            if (data[i] < data[j + 1])
            {
                int temp = data[i];
                data[i] = data[j + 1];
                data[j + 1] = temp;
            }
        }
    }
    DateTime EndTime = DateTime.Now;
    Console.Write($"Bubble:{EndTime.Subtract(StartTime).Milliseconds}\t\t");
}
static void Selection(int[] data)
{
    DateTime StartTime = DateTime.Now;

    for (int i = 0; i < data.Length; i++)
    {
        int min = data[i];
        for (int j = i + 1; j < data.Length; j++)
        {
            if (data[j] < data[min])
            {
                min = data[j];
            }
        }
        if (min < i)
        {
            int temp = data[min];
            data[min] = data[i];
            data[i] = temp;
        }
    }
    DateTime EndTime = DateTime.Now;
    Console.Write($"Selection:{EndTime.Subtract(StartTime).Milliseconds}\t\t");
}
static void Insertion(int[] data)
{
    DateTime StartTime = DateTime.Now;

    for (int i = 1; i < data.Length; i++)
    {
        int min = data[i];
        int j = i - 1;
        while (j >= 0 && data[j] > min)
        {
            data[j + 1] = data[j];
            j--;
        }
        data[j + 1] = min;
    }
    DateTime EndTime = DateTime.Now;
    Console.Write($"Insertion:{EndTime.Subtract(StartTime).Milliseconds}\t\t");
}
static void Ms(int[] data)
{
    DateTime StartTime = DateTime.Now;
    Array.Sort(data);

    DateTime EndTime = DateTime.Now;
    Console.Write($"Ms:{EndTime.Subtract(StartTime).Milliseconds}\t\t");
}
static int[] CreateData(int _size)
{
    List<int> result = new();
    Random rnd = new();
    while (result.Count() < _size)
    {
        int temp = rnd.Next(0, _size);
        if (!result.Contains(temp))
            result.Add(temp);
    }
    return result.ToArray();
}