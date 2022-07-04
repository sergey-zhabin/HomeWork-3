Console.WriteLine("Введите координаты первой точки: ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());
Zadacha21(Ax,Ay,Az,Bx,By,Bz);
void Zadacha21(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double Length = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
    Console.WriteLine(Length);
}