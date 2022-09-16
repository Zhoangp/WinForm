using System;

namespace Lab01_04
{
    internal class NhaPho : KhuDat
    {
        private int namXd;
        private int soTang;

        public int getNamXd()
        {
            return this.namXd;
        }

        public void setNamXd(int namXd)
        {
            this.namXd = namXd;
        }

        public int getSoTang()
        {
            return this.soTang;
        }

        public void setSoTang(int soTang)
        {
            this.soTang = soTang;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap nam xay dung: ");
            int.TryParse(Console.ReadLine(), out this.namXd);
            Console.Write("Nhap so tang: ");
            int.TryParse(Console.ReadLine(), out this.soTang);


        }
        public override void Ouput()
        {
            base.Ouput();
            Console.Write(" Nam Xay Dung: {0} So Tang: {1} ", this.namXd, this.soTang);
        }
    }
}