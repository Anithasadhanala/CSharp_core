using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore
{
    internal class Generics
    {
        public class BoxGeneric<T>   // <> this says it is a generic  **** Do not use the generics if runtime type based logic happens
        {
            public T value;  // dtype is T here

            public BoxGeneric(T value)
            {
                this.value = value;
            }
            public void method1()
            {
                Console.WriteLine("generics from the method1()" + " " + value);
            }
        }


        public class SubBoxGeneric<U,T> : BoxGeneric<T>   // Inheriting Generic to generic
        {

            public U value2;
            public SubBoxGeneric(T value, U value2) : base(value) // have to write the constructor as parent class has parametirised constructor
            {
                this.value2 = value2;
            }

            public void method2()
            {
                Console.WriteLine("generic from Derived geniric class");
            }

        }

        public class SubClass : BoxGeneric<string> // a normal derived class can inherit the generic class with default datatype
        {
            public int k;
            public SubClass(string value,int k) : base(value)
            {
                this.k = k;
            }
        }


        public class DemoClass
        {

        }
    }
}
