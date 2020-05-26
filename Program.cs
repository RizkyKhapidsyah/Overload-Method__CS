using System;

namespace Overload_Method__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Siswa Siswa1 = new Siswa();

            Siswa1.Cetak("7832468726", "Abdur Rahman");
            Siswa1.Cetak(70);
            Siswa1.Cetak(3.33);
            Console.Read();
        }
    }
}
