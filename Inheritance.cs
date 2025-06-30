using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{
    internal class Inheritance
    {
        public class Coordianate
        {
            public int x;
            public int y;

            public Coordianate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void GetCoordinates()
            {
                Console.WriteLine(this.x + " " + this.y);
            }
        }

        public class PointMapping : Coordianate
        {
            public int z;
            public PointMapping(int x, int y, int z) : base(x, y)
            {
                this.z = z;
            }

            public virtual void PointACoordinate() // this means, method can be overridden 
            {
                //GetCoordinates();
                Console.WriteLine("coordinate pointed in the map!");
            }
            public void GetCoordinates(int i)
            {
                Console.WriteLine("bnm,");
            }

        }

        public class Correctness : PointMapping
        {
            private const int correct_x = 1;
            private const int correct_y = 3;
            private const int correct_z = 4;

            public Correctness(int x, int y, int z) : base(x, y, z)
            {

            }

            public void CorrectAnswer()
            {
                if (x == correct_x && y == correct_y && z == correct_z)
                {
                    Console.WriteLine("You pointed to correct coordinates");
                }
                else
                {
                    Console.WriteLine("You pointed to wrong coordinates");
                }
            }

            public override void PointACoordinate() // if u override a method use keyword override

            {
                base.PointACoordinate();
                Console.WriteLine("This function is overridden!!");
            }

        }
    }
}
