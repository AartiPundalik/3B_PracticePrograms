using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_PracticePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Default Constructor
            Car car = new Car();
            Console.WriteLine(" Default Construtor: ");
            Console.WriteLine("Name: " + car.Name);
            Console.WriteLine("ModelNo: " + car.ModelNo);
            Console.ReadLine();

            // Parameterized Constructor
            TV tv = new TV("LG", 2244);
            Console.WriteLine("Parameterized Constructor: ");
            Console.WriteLine("Name: " + tv.Name);
            Console.WriteLine("TVID: " + tv.TVID);
            Console.ReadLine();

            //Copy Constructor
            TV2 tv2 = new TV2(tv);
            Console.WriteLine("Copy Constructor:");
            Console.WriteLine("Name: " + tv.Name);
            Console.WriteLine("Age: " + tv.TVID);
            Console.ReadLine();

            // Static Constructor
            Console.WriteLine("Static Constructor:");
            Console.WriteLine("Count: " + Mobile.Count);
            Mobile mobile = new Mobile();
            Console.WriteLine("Count: " + Mobile.Count);
            Console.ReadLine();

            // Private Constructor
            Source source = Source.GetInstance();
            Console.WriteLine("Private Constructor (Source):");
            Console.WriteLine("Instance: " + source);
            Console.ReadLine();

            //Interface
            Lotus lotus = new Lotus();
            lotus.Flower();
            Console.ReadLine();
        }
    }
}
        
    

