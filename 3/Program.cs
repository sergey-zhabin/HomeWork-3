Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Zadacha23(N);

void Zadacha23(int cN)
{
    int count = 1;
    while (count <= cN)
    {
        Console.Write(count*count*count +" ");
        count++;
    }
}
