using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab01_03
{
    class KhuDat
    {
        private string diaDiem = "";
        private double giaBan = 0.0;
        private float dienTich = 0.0f;

        public string getDiaDiem()
        {
            return this.diaDiem;
        }

        public void setDiaDiem(string diaDiem)
        {
            this.diaDiem = diaDiem;
        }

        public double getGiaBan()
        {
            return this.giaBan;
        }

        public void setGiaBan(double giaBan)
        {
            this.giaBan = giaBan;
        }

        public float getDienTich()
        {
            return this.dienTich;
        }

        public void setDienTich(float dienTich)
        {
            this.dienTich = dienTich;
        }
        public virtual void Input()
        {
            Console.Write("Nhap dia diem: ");
            this.diaDiem = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            double.TryParse(Console.ReadLine(), out this.giaBan);
            Console.Write("Nhap dien tich: ");
            float.TryParse(Console.ReadLine(), out this.dienTich);
        }
        public virtual void Ouput()
        {
            Console.Write("Dia diem: {0} Gia ban: {1} Dien tich: {2}", this.diaDiem, this.giaBan, this.dienTich);


        }

    }
}