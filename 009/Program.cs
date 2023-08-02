int[] array = {1234, 1451, 14515, 253, 63, 11, 66534, 13, 5532, 6667, 33};

int n = array.Length;
int find = 4;
int index = 0;

while(index<n>)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}