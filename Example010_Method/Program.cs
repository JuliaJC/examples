int[] array = {12, 32, 83, 54, 56, 76, 47, 83 };

int n = array.Length;
int find = 83;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}