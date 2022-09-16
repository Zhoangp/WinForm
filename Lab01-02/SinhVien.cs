using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class SinhVien : Person 
    {
        private float avgScore;
        private string faculty;

        public SinhVien() {
        }

        public SinhVien(float avgScore, string faculty, string maSo, string hoTen)
        {
            this.AvgScore = avgScore;
            this.Faculty = faculty;
        }

        public float AvgScore
        {
            get
            {
                return avgScore;
            }

            set
            {
                avgScore = value;
            }
        }

        public string Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem trung binh: ");
            this.AvgScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            this.Faculty = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine("MSSV: {0} Ho ten: {1} Khoa: {2} Diem trung binh: {3}", base.maSo, base.hoTen, this.Faculty, this.AvgScore);
        }
    }

}
