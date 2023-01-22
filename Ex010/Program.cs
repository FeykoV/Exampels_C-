int[] array = {1, 12, 4, 54, 5, 4, 57, 8};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;  // оператор прерывания работы программы
    }
    index++;
}