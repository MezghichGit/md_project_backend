using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre_2
{
    public class A

    {
        public virtual void method() {
            Console.WriteLine("A");
        }
    }

    public class B: A
    {
        public override void method()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public new void method()
        {
            Console.WriteLine("C");
        }
    }

    public class Test { 
    public static void Main(String []args) {
        C c = new C();
        c.method();  //C
        B b = c;
        b.method(); // B
        A a = c;
        a.method();  // B
        }
    }
}