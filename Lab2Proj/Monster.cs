using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Proj
{
    internal class Monster
    {
        private string name;
        
        public string Name { get { return name; } 
            set { name = value; }
        }
        

        public virtual void Draw()
        {
            DrawMonster();
            DrawShadow();
        }

        public void DrawMonster(string prefix="", string sufix = "")
        {
            Console.WriteLine(prefix + "  \\     /" + sufix);
            Console.WriteLine(prefix + "   .---." + sufix);
            Console.WriteLine(prefix + "  |o   o|" + sufix);
            Console.WriteLine(prefix + "  | \\_/ |" + sufix); 
        }


        public void DrawShadow()
        {
            Console.WriteLine(" ===========");
        }

        //  overrid the ToString method inherited from the 'Object' parent
        //  so that it would return the header message that looks like this:

        /*
        ''''''''''''''''''''''''''''''''''''''''''''''''''
        <Name of the monster> 
        ''''''''''''''''''''''''''''''''''''''''''''''''''
        */

        public override string ToString()
        {
            return string.Format("\n''''''''''''''''''''''''''''''''''''''''''''''''''\n{0}\n''''''''''''''''''''''''''''''''''''''''''''''''''\n", this.name);
        }


    }
}
