using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        protected string maSo;
        protected string hoTen;

        public string MaSo
        {
            get
            {
                return maSo;
            }

            set
            {
                maSo = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }
        public Person(string maSo, string hoTen)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
        }
        public Person() { }
         public virtual void  Input()
        {
            Console.Write("Nhap ma so: ");
            this.maSo = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
        }
        public virtual void  Show()
        {
            Console.WriteLine("Ma so: {0} Ho ten: {1}", this.maSo, this.hoTen);
        }

    }
}
