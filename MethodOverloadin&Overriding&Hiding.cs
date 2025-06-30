using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{
    internal class MethodOverloadin_Overriding_Hiding
    {
        public class Parent
        {
            public void method1(int i) // here method 1 , method are two methods so it is method overloading
            {
                Console.WriteLine("parent class method1() with param 1");
            }
            public void method1(int i,int j)
            {
                Console.WriteLine("parent class method1() with param 2");
            }
            public virtual void method2() // here virtual given, so this method can be overriden by derived class
            {
                Console.WriteLine("parent class method2()");
            }
        }

        public class Child : Parent
        {
            public new void method1(int i) // here new is used that, I am not overriding but just hiding hte method1 because i cannot modify the parent to virtual method1, based on the reference,this method is called not by the type of abject given to this refrence variable
            {
                Console.WriteLine("child class method1() with param 1");
            }
            public override void method2() // use override that shows i am overriding some method  from base class
            {
                Console.WriteLine("child class method2()");
            }

        }
    }
}
