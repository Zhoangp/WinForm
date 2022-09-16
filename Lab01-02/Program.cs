using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong doi tuong muon them: ");
            n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for(int i = 0; i < n; i++)
            {
                int chose;
                Console.Write("1. Nhap sinh vien\n2. Nhap giao vien\nLua chon: ");
                chose = int.Parse(Console.ReadLine());
                Person a;
                if(chose == 1)
                {
                    a = new SinhVien();
                }
                else
                {
                    a = new Teacher();
                }
                a.Input();
                list.Add(a);
            }
            //Cau 2.1 
            Console.WriteLine("-----=====Sinh Vien CNTT=====-----");
            inDs(list.Where(s => s.GetType().Name.CompareTo("SinhVien") == 0 && ((SinhVien)s).Faculty == "CNTT").ToList());

            //Cau 2.2
            Console.WriteLine("-----=====Sinh Vien CNTT DTB < 5=====-----");
            inDs(list.Where(s => s.GetType().Name.CompareTo("SinhVien") == 0 && ((SinhVien)s).Faculty == "CNTT" && ((SinhVien)s).AvgScore<5).ToList());

            //Cau 2.3 
            Console.WriteLine("-----=====Giao Vien O Quan 9=====-----");
            inDs(list.Where(p => p.GetType().Name.CompareTo("Teacher") == 0 && ((Teacher)p).DiaChi.Contains("Quan 9")).ToList());
            //Cau 2.4
            Console.WriteLine("-----=====Giao Vien Co Ma CHN060286=====-----");
            inDs(list.Where(p => p.GetType().Name.CompareTo("Teacher") == 0 && ((Teacher)p).MaSo == "CHN060286").ToList());

            //Cau 2.5
            Console.WriteLine("-----=====Danh Sach Sinh Vien Co DTB KHoa CNTT Cao Nhat=====-----");
            float max = 0;
            foreach(SinhVien s in list)
            { 
               if(((SinhVien)s).Faculty == "CNTT")
                  max = Math.Max(max, ((SinhVien)s).AvgScore);
            }
            inDs(list.Where(s => s.GetType().Name.CompareTo("SinhVien") == 0 && ((SinhVien)s).Faculty == "CNTT" && ((SinhVien)s).AvgScore == max).ToList());          
           
            


            Console.ReadLine();
        }
        public static void inDs(List<Person> list)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Khong co");
                return;
            }
            foreach(Person a in list) 
            { 
                a.Show();
            }
        }
    }
}
