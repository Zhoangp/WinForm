using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong doi tuong muon them: ");
            int.TryParse(Console.ReadLine(), out n);
            List<KhuDat> list = new List<KhuDat>();
            for (int i = 0; i < n; i++)
            {
                int chose;
                Console.Write("1. Nhap Khu Dat\n2. Nhap Nha Pho\n3. Nhap Chung Cu\nLua chon: ");
                int.TryParse(Console.ReadLine(), out chose);
                KhuDat a;
                if (chose == 1)
                {
                    a = new KhuDat();
                }
                else if (chose == 2)
                {
                    a = new NhaPho();
                }
                else
                {
                    a = new ChungCu();
                }
                a.Input();
                list.Add(a);
            }
            //Tong gia ban cho 3 loai 
            double giaDat = 0, giaPho = 0, giaChungCu = 0;
            foreach (KhuDat item in list)
            {
                if (item is ChungCu)
                {
                    giaChungCu += item.getGiaBan();
                }
                else
                    if (item is NhaPho)
                {
                    giaPho += item.getGiaBan();
                }
                else
                {
                    giaDat += item.getGiaBan();

                }
            }
            Console.WriteLine("-----=====Tong Gia Ban Cua Ba Loai=====-----");
            Console.WriteLine("Khu Dat: {0}", giaDat);
            Console.WriteLine("Nha Pho: {0}", giaPho);
            Console.WriteLine("Chung Cu: {0}", giaChungCu);


            //Danh Sach Khu Dat dien tich > 100m2 hoac nha pho co dien tich > 60m2 va nam xay dung >= 2020
            inDsKd(list.Where(item =>
            (!(item is NhaPho || item is ChungCu) && item.getDienTich() > 100) ||
            (item is NhaPho && item.getDienTich() > 60 && ((NhaPho)item).getNamXd() >= 2020)).ToList());

            Console.ReadLine();
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
                Console.WriteLine();
            }
        }
    }
}
