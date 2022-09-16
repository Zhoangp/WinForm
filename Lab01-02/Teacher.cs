using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        private string diaChi;

        public Teacher(string diaChi)
        {
            this.DiaChi = diaChi;
        }
        public Teacher() { }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap dia chi: ");
            this.diaChi = Console.ReadLine();
        }
        public override void Show()
        {
            Console.WriteLine("Ma so: {0} Ho ten: {1} Dia chi: {2}", base.maSo, base.hoTen, this.diaChi);
        }
    }
}
