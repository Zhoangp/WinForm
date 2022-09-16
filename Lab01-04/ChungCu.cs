using System;

namespace Lab01_04
{
    internal class ChungCu : KhuDat
    {

        private int tang;

        public int getTang()
        {
            return this.tang;
        }

        public void setTang(int tang)
        {
            this.tang = tang;
        }


        public override void Input()
        {
            base.Input();
            Console.Write("Nhap tang: ");
            int.TryParse(Console.ReadLine(), out this.tang);


        }
        public override void Ouput()
        {
            base.Ouput();
            Console.Write(" Tang: {0}", this.tang);
        }
    }
}