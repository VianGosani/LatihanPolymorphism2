using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2324";
            mhs.nama = "Fieancheiza I zaaz Gosani";
            mhs.email = "fieancheiza.go@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data :");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (nomorPrinter == 1)        
                convert = new ConvertToJson();            
            else if (nomorPrinter == 2)            
                convert = new ConvertToXml();          
            else
                convert = new ConvertToCsv();

            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
