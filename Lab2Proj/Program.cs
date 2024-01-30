using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster m = new Monster();
            m.Name = "Normal Mon"; 
            Console.WriteLine(m.ToString());
            m.Draw();

           
            LevitatedMonster levitated = new LevitatedMonster();
            levitated.Name = "Levitated Mon";
            levitated.Hight = 5;
            Console.WriteLine(levitated.ToString());
            levitated.Draw();

            
            ConfusedMonster confused = new ConfusedMonster();
            confused.Name = "Confiused Mon";
            Console.WriteLine(confused.ToString());
            confused.Draw();

        }

    }


}
