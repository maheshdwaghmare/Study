using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSScenarios
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Scenario1
            //A obj = new B();
            //obj.Show(); // A.Show()
            //// Warning :- 'Program.B.Show()' hides inherited member 'Program.A.Show()'.To make the current member override that implementation, add the override keyword.Otherwise add the new keyword.OOPSScenarios
            #endregion
            #region Scenario2
            //A obj = new B();
            //obj.Show(); // A.Show()
            #endregion
            #region Scenario3
            //C c = new C();
            //A a = new A();
            //a = c;
            //a.Show();
            //c.Show();
            //// A.Show() C.Show()
            #endregion
            #region Scenario4
            //C c = new C();
            //A a = new A();
            //a = c;
            //a.Show();
            //c.Show();
            //// B.Show() C.Show()
            #endregion
            #region Scenario5
            //C c = new C();
            //A a = new A();
            //a = c;
            //a.Show();
            //c.Show();
            //// C.Show() C.Show()
            #endregion
            #region Scenario6
            //B b = new B(10);
            //Console.ReadLine();
            //// Error 'ConsoleApplication.A' does not contain a constructor that takes 0 arguments 
            #endregion
            #region Scenario7
            //B b = new B(10);
            //Console.ReadLine();
            //// Base Derived
            #endregion
            #region Scenario8
            Program program = new Program();
            int i = program.absorbeTheValue();
            Console.WriteLine(i);
            Console.ReadLine();

            #endregion
            Console.ReadLine();
        }

        #region Scenario1
        //class A
        //{
        //    public virtual void Show()
        //    {
        //        Console.WriteLine("A.Show()");
        //    }
        //}
        //class B : A
        //{
        //    public void Show()
        //    {
        //        Console.WriteLine("B.Show()");
        //    }
        //}
        #endregion
        #region Scenario2
        //class A
        //{
        //    public virtual void Show()
        //    {
        //        Console.WriteLine("A.Show()");
        //    }
        //}
        //class B : A
        //{
        //    public new void Show()
        //    {
        //        Console.WriteLine("B.Show()");
        //    }
        //}
        #endregion
        #region Scenario3
        //class A
        //{
        //    public virtual void Show()
        //    {
        //        Console.WriteLine("A.Show()");
        //    }
        //}
        //class B : A
        //{
        //    public new void Show()
        //    {
        //        Console.WriteLine("B.Show()");
        //    }
        //}
        //class C : B
        //{
        //    public new void Show()
        //    {
        //        Console.WriteLine("C.Show()");
        //    }
        //}
        #endregion
        #region Scenario4
        //class A
        //{
        //    public virtual void Show()
        //    {
        //        Console.WriteLine("A.Show()");
        //    }
        //}

        //class B : A
        //{
        //    public override void Show()
        //    {
        //        Console.WriteLine("B.Show()");
        //    }
        //}
        //class C : B
        //{
        //    public new void Show()
        //    {
        //        Console.WriteLine("C.Show()");
        //    }
        //}
        #endregion
        #region Scenario5
        //class A
        //{
        //    public virtual void Show()
        //    {
        //        Console.WriteLine("A.Show()");
        //    }
        //}
        //class B : A
        //{
        //    public override void Show()
        //    {
        //        Console.WriteLine("B.Show()");
        //    }
        //}
        //class C : B
        //{
        //    public override void Show()
        //    {
        //        Console.WriteLine("C.Show()");
        //    }
        //}
        #endregion
        #region Scenario6
        //class A
        //{
        //    int i;
        //    public A(int j)
        //    {
        //        i = j;
        //        Console.WriteLine("Base");
        //    }
        //}
        //class B : A
        //{
        //    public B(int j)
        //    {
        //        Console.WriteLine("Derived");
        //    }
        //}
        #endregion
        #region Scenario7
        //class A
        //{
        //    int i;
        //    public A(int j)
        //    {
        //        i = j;
        //        Console.WriteLine("Base");
        //    }
        //}
        //class B : A
        //{
        //    public B(int j)
        //        : base(j)
        //    {
        //        Console.WriteLine("Derived");
        //    }
        //}
        #endregion
        #region Scenario8
        public int absorbeTheValue()
        {
            int a = 0;
            try
            {   
                a = 4;
                
            }
            catch (Exception e)
            {
                a = 5;                
            }
            finally
            {
                a = 8;
            }

            return a;
        }
        #endregion
    }
}