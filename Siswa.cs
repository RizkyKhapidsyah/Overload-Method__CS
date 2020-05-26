using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_Method__CS
{
    class Siswa
    {
        public string NIM;
        public string Nama;
        public int Nilai_UTS;
        public double IPK;

        public void Cetak(String NIM_Siswa, String NamaSiswa)
        {
            this.NIM = NIM_Siswa;
            this.Nama = NamaSiswa;
            Console.WriteLine("NIM nya Adalah            : {0} ", this.NIM);
            Console.WriteLine("Namanya Adalah            : {0} ", this.Nama);
        }

        public void Cetak(int NilaiUTS)
        {
            this.Nilai_UTS = Nilai_UTS;
            Console.WriteLine("Nilai UTS Adalah          : {0} ", this.Nilai_UTS);
        }

        public void Cetak(double IPK)
        {
            this.IPK = IPK;
            Console.WriteLine("IPK {0} adalah   : {1} ", this.Nama, this.IPK);
        }

    }

    
}
