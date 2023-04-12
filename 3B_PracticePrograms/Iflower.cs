using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_PracticePrograms
{
    public interface Iflower
    { 
        void Flower();
    }

    class Lotus : Iflower
    {
        public void Flower()
        {
            Console.WriteLine("Lotus Smells So Refreshing");
        }
    }

}
    

