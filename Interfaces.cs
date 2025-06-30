using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{
    internal class Interfaces
    {
        public interface IframeInterface
        {
            public int Age // this is not a variable but a property (a method like syntax for accessing the Age)
            {
                set;
                get;
            }
            public void method1(); // interface method
        }

        public class DerivedClass : IframeInterface
        {
            public int Age { set; get; }  // must declare the properties of hte interface in the derived class
            public void method1()  // method of the interface implemented here
            {
                Console.WriteLine("Interface method implemented");
            }
        }
    }
}
