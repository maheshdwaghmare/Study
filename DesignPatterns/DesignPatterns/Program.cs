using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Classes;
using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Factory Pattern :- Creational
            //int invoiceType = 0;
            //IInvoice ObjInvoice;
            //Console.WriteLine("Enter the Invoice Type: ");
            //invoiceType = Convert.ToInt16(Console.ReadLine());
            //ObjInvoice = FactoryInvoice.GetInvoice(invoiceType);
            //ObjInvoice.Print();
            //Console.ReadLine();


            // Abstract Factory Pattern :- Creational
            //IComputer pc = ComputerFactory.createComputer(new PCFactory("2 GB", "500 GB", "2.4 GHz"));
            //IComputer server = ComputerFactory.createComputer(new ServerFactory("4 GB", "1 TB", "2.4 GHz"));
            //IComputer laptop = ComputerFactory.createComputer(new LaptopFactory("8 GB", "2 TB"));

            // Facade Pattern :- Structural
            //Applicant applicant = new Applicant { Name = "Onkar Nene" };
            //ApplicationFacade applicationFacade = new ApplicationFacade(applicant);
            //Console.WriteLine(applicant.Name + "'s application is " + (applicationFacade.IsValidationDone() ? "accepted" : "rejected"));
            //Console.ReadLine();

            // Strategy Pattern :- Behavioral
            //ShoppingMall objShoppingMall = new ShoppingMall(new LowDiscountStrategy());
            //objShoppingMall.CustomerName = "Monday Customer";
            //objShoppingMall.BillAmount = 1000;
            //Console.WriteLine("Low Discount Final Bill: " + objShoppingMall.GetFinalBill());
            //objShoppingMall = new ShoppingMall(new HighDiscountStrategy());
            //objShoppingMall.CustomerName = "Thursday Customer";
            //objShoppingMall.BillAmount = 1000;
            //Console.WriteLine("High Discount Final Bill: " + objShoppingMall.GetFinalBill());
            //objShoppingMall = new ShoppingMall(new NoDiscountStrategy());
            //objShoppingMall.CustomerName = "Sunday Customer";
            //objShoppingMall.BillAmount = 1000;
            //Console.WriteLine("No Discount Final Bill: " + objShoppingMall.GetFinalBill());
            //Console.ReadLine();

            // Depedency Injection :- Implement IOC

            // Template Method Pattern :- Behavioral
            //Pizza pizza = new NonVegPizza();
            //pizza.MakePizza();
            //pizza = new VegPizza();
            //pizza.MakePizza();
            //Console.ReadLine();

            // Adapter Pattern :- Structural
            //USBAdapter usb = new USBAdapter();
            //usb.ConnectA();
            //Console.WriteLine("Got the signal!");
            //Console.ReadLine();
        }
    }
}
