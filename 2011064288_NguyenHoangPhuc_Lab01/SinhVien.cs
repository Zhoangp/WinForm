using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011064288_NguyenHoangPhuc_Lab
{
    class SinhVien
    {
        private string studentId;
        private string fullName;
        private float avgScore;
        private string faculty;

        public SinhVien(string studentId, string fullName, float avgScore, string faculty)
        {
            this.studentId = studentId;
            this.fullName = fullName;
            this.avgScore = avgScore;
            this.faculty = faculty;
        }
        public SinhVien()
        {

        }

        public string StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
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
        public void Input()
        {
            Console.Write("Nhap ma so sinh vien: ");
            this.StudentId = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            this.fullName = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            this.avgScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            this.faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.Write("MSSV: {0} Ho ten: {1} Khoa: {2} Diem trung binh: {3}", this.studentId, this.fullName, this.faculty, this.avgScore);
        }
    }

}
