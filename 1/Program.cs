Console.WriteLine(" Введите пятизначное число: ");
string number = Console.ReadLine();
Zadacha19(number);
void Zadacha19(string curnumber)
{
    if (curnumber[0] == curnumber[4] && curnumber[1] == curnumber[3])

    Console.WriteLine(" Число является полиндромом ");
    else Console.WriteLine(" Простое пятизначное число");
}
