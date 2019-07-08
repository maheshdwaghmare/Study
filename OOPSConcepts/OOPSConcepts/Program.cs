using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    // 1. Always execute static constructor first 
    // 2. We can create child class object and assigning to base class

    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor
            //A a = new A(); // Static A Public A
            //B b = new A(); // Compile time error
            //A c = new B(); // Static B Static A Public A Public B
            //B d = new B(); // Static B Static A Public A Public B

            //a.Method(); // In A method
            //b.Method(); // Compile time error
            //c.Method(); // In A method
            //d.Method(); // In B method
            #endregion
            #region Runtime Polymorphism
            //A objA = new A();
            //objA.method(); // A

            //B objB = new B();
            //objB.method();  // B

            //C objC = new C();
            //objC.method();  // C 

            // A super class reference variable can hold reference of sub-class object without casting but not vice versa.
            // new keyword will not effect in case of assinging instance of one object to object of different class                
            //A objAB = new B();
            //objAB.method(); // B

            //B objBC = new C();
            //objBC.method(); // B

            //A objAC = new C();
            //objAC.method(); // B             
            #endregion
            #region Compile time Polimorphism
            //A objA = new A();
            //int resultA = objA.add(2,3);
            //Console.WriteLine(resultA);

            //int resultB = objA.add(2, 3, 4);
            //Console.WriteLine(resultB);
            #endregion            
            Console.ReadLine();
        }
    }

    #region Constructor
    //public class A
    //{
    //    public A()
    //    {
    //        Console.WriteLine("Public A");
    //    }

    //    static A()
    //    {
    //        Console.WriteLine("Static A");
    //    }

    //    public void Method() { Console.WriteLine("In A method"); }
    //}

    //public class B : A
    //{
    //    public B()
    //    {
    //        Console.WriteLine("Public B");
    //    }

    //    static B()
    //    {
    //        Console.WriteLine("Static B");
    //    }

    //    public void Method() { Console.WriteLine("In B method"); }
    //}
    #endregion
    #region Runtime Polymorphism
    //class A
    //{
    //    public virtual void method()
    //    {
    //        Console.WriteLine("A");
    //    }
    //}
    //class B : A
    //{
    //    public override void method()
    //    {
    //        Console.WriteLine("B");
    //    }
    //}
    //class C : B
    //{
    //    public new void method()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}
    #endregion
    #region Compile time Polimorphism
    //public class A
    //{
    //    public int add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public int add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //    // Compile time error :- Call is ambigious between method with same input parameters with different return types.
    //    // Compile Time Polymorphism is methods having diffrent signatures
    //    // Method Signature = Method Name + Method Parameters (Not consider Return Types for Signature so No Return types)
    //    //public string add(int a, int b)
    //    //{
    //    //    return (a + b).ToString();
    //    //}
    //}
    #endregion
}
