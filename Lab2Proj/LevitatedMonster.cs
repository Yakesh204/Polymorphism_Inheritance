using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Proj
{
    class LevitatedMonster:Monster
    {
        private int hight;
        public LevitatedMonster() : base() { }
        
        public int Hight
        {
            get{
                return this.hight;
            }
            set{
                this.hight = value;
            }
        }

        public override void Draw()
        {
            DrawMonster();
            for (int i = 0; i < this.hight; i++)
            {
                Console.Write("\n");
            }
            DrawShadow();
        }

       
    }
}
