using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhuDat> listKd = new List<KhuDat>();
            int n;
            Console.Write("Nhap so luong khu dat: ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap khu dat thu {0}", i + 1);
                KhuDat a = new KhuDat();
                a.Input();
                listKd.Add(a);
            }
            //Ds tang dan theo dien tich
            Console.WriteLine("-----=====Danh Sach Tang Dan Theo Dien Tich=====-----");
            inDsKd(listKd.OrderBy(p => p.getDienTich()).ToList());

            //gia < 1ty && dien tich > 60m2
            Console.WriteLine("-----=====Danh Sach Khu Dat Gia < 1 Ty Va Dien Tich >= 60m2=====-----");
            inDsKd(listKd.Where(kd => kd.getGiaBan() < 1000000000.00 && kd.getDienTich() > 60f).ToList());

            //Trung binh gia dat tren mot met vuong
            Console.WriteLine("-----=====Danh Sach Gia Trung Binh Tung Khu Dat=====-----");
            foreach (KhuDat kd in listKd)
            {
                if (kd.getDienTich() > 1000)
                {
                    kd.Ouput();
                    Console.WriteLine("Gia trung binh => {0}", kd.getGiaBan() / kd.getDienTich());
                }
            }
        }
        public static void inDsKd(List<KhuDat> a)
        {
            if (a.Count() == 0)
            {
                Console.WriteLine("Khong co!");
                return;
            }
            foreach (KhuDat kd in a)
            {
                kd.Ouput();
            }
        }
    }
}
