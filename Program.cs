# 11-05-2017-2


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphic2D;

namespace Graphic3D { 
class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Sefer");
            int a = 7;
            System.Int32 b = 2;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b + 48);

            MyNameSpaces.TestClass t = new MyNameSpaces.TestClass(5, 6);
            System.Console.WriteLine("T1 -> First value : {0} Second value : {1}", t.Test1, t.Test2);

            MyNameSpaces.TestClass2 t2 = new MyNameSpaces.TestClass2(11, 0);
            System.Console.WriteLine("T2 -> First value : {0} Second value : {1}", t2.Test1, t2.Test2);

            Graphic2D.Point p1 = new Graphic2D.Point();
            Graphic3D.Point p2 = new Graphic3D.Point();
            Point p3 = new Point();

            System.Collections.ArrayList arrList = new System.Collections.ArrayList();

            NameSpaces.UsingTest ut = new NameSpaces.UsingTest();
            using (ut)
            {
                System.Console.WriteLine("using block");
            } // calles the Dispose() methods
            System.Console.WriteLine("using block outside");


                System.Console.ReadKey();
        }
    }

}
