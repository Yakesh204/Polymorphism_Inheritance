using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Proj
{
    class ConfusedMonster:Monster
    {
        public override void Draw()
        {
            Console.WriteLine("????????????");
            DrawMonster("?","?");
            Console.WriteLine("????????????");
            DrawShadow();
        }
    }
}
