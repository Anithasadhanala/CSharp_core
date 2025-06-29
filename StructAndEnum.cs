using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{

    public enum WeekDays
    {
        MONDAY = 101, TUESDAY, WEDNESDAY, FRIDAY, Saturday // Now index starts from 101, HENCE can assign indexes
    }
    internal class StructAndEnum
    {
        public struct StructExample
        {
            public int i = 0;
            public StructExample(int i)   // if fields are present then, need constructor
            {
                this.i = i;
            }

            public void method1()
            {
                i++;
                Console.WriteLine(i);
            }
        }

    }
}
