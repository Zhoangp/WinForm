using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011064288_NguyenHoangPhuc_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("----===Nhap Danh Sach Sinh Vien===----");
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());

            //Dung mang
            //SinhVien[] dsSinhVien = new SinhVien[n];
            //for (int i = 0; i < dsSinhVien.Length; i++)
            //{
            //    Console.WriteLine("Nhap thong tin sinh vien thu:{0} ", i + 1);
            //    dsSinhVien[i] = new SinhVien();
            //    dsSinhVien[i].Input();

            //}
            //foreach (SinhVien sinhVien in dsSinhVien)
            //{
            //    sinhVien.Show();
            //    Console.WriteLine();
            //}

            //Dung List
            List<SinhVien> dsSinhVien2 = new List<SinhVien>();
            for(int i = 0; i < n; i++)
            {
                SinhVien a = new SinhVien();
                a.Input();
                dsSinhVien2.Add(a);
            }
            Console.WriteLine("----===Danh Sach Sinh Vien===----");
            xuatDssv(dsSinhVien2);
     
            Console.WriteLine("\n----===Danh Sach Sinh Vien CNTT===----");
            xuatDssv(dssvCNTT(dsSinhVien2));

            Console.WriteLine("\n----===Danh Sach Sinh Vien DTb Lon Hon 5===----");
            xuatDssv(dssvDTBHon5(dsSinhVien2));


            Console.WriteLine("\n----===Danh Sach Sinh Vien CNTT DTB Lon Hon 5===----");
            xuatDssv(dssvCNTTTbHon5(dsSinhVien2));


            Console.WriteLine("\n----===Danh Sach Sinh Vien Theo Thu Tu Diem DTB===----");
            xuatDssv(sortDssv(dsSinhVien2));
            Console.WriteLine("\n----===Danh Sach Sinh Vien CNTT  Diem DTB Lon Nhat===----");
           dssvCNTTTbLonNhat(dsSinhVien2)[0].Show();

            Console.ReadLine();
        }
        public static void xuatDssv(List<SinhVien> a)
        {
            int i = 1;
            foreach (SinhVien sinhVien in a)
            {
                Console.Write("{0}. ", i);
                sinhVien.Show();
                i++;
                Console.WriteLine();
            }
        }
        public static List<SinhVien> dssvCNTT(List<SinhVien> dssv)
        {
            List<SinhVien> result = (from s in dssv
                                     where s.Faculty == "CNTT"
                                     select s).ToList();
            return result;
        }
        public static List<SinhVien> dssvDTBHon5(List<SinhVien> dssv)
        {
            List<SinhVien> result = (from s in dssv
                                     where s.AvgScore >= 5
                                     select s).ToList();
            return result;
        }
        public static List<SinhVien> sortDssv(List<SinhVien> dssv)
        {
            return dssv.OrderBy(s => s.AvgScore).ToList();
        }
        public static List<SinhVien> dssvCNTTTbHon5(List<SinhVien> dssv)
        {
            return dssv.Where(s => s.Faculty == "CNTT" && s.AvgScore >= 5).ToList();
        }
        public static List<SinhVien> dssvCNTTTbLonNhat(List<SinhVien> dssv)
        {
            return dssvCNTT(dssv).OrderByDescending(s => s.AvgScore).ToList();
        }
    }
}
