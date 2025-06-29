using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{
    abstract class AbstractExample
    {
        public int i;
        public AbstractExample(int i) 
        {
            this.i = i;
        }

        public void method1()
        {
            Console.WriteLine("not abstract method!!!");
        }

        abstract public int method2(); // abstract method
    }
}
