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
            // Factory Pattern :- Creational
            // Defines Interface for creating an object
            //int invoiceType = 0;
            //IInvoice ObjInvoice;
            //Console.WriteLine("Enter the Invoice Type: ");
            //invoiceType = Convert.ToInt16(Console.ReadLine());
            //ObjInvoice = FactoryInvoice.GetInvoice(invoiceType);
            //ObjInvoice.Print();
            //Console.ReadLine();


            // Abstract Factory Pattern :- Creational
            // Defines Interface for creating families of diff/similar objects
            //IComputer pc = ComputerFactory.createComputer(new PCFactory("2 GB", "500 GB", "2.4 GHz"));
            //IComputer server = ComputerFactory.createComputer(new ServerFactory("4 GB", "1 TB", "2.4 GHz"));
            //IComputer laptop = ComputerFactory.createComputer(new LaptopFactory("8 GB", "2 TB"));

            // Facade Pattern :- Structural
            // Defines a high level interface that makes the subsystem easier to use.
            //Applicant applicant = new Applicant { Name = "Onkar Nene" };
            //ApplicationFacade applicationFacade = new ApplicationFacade(applicant);
            //Console.WriteLine(applicant.Name + "'s application is " + (applicationFacade.IsValidationDone() ? "accepted" : "rejected"));
            //Console.ReadLine();

            // Strategy Pattern :- Behavioral
            // Encapsulates an algorithm inside a class
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
            // Implement IOC :- Make classes loosely coupled.

            // Template Method Pattern :- Behavioral
            // Redefine certain steps of an algorithm without changing the algorithm's structure.
            //Pizza pizza = new NonVegPizza();
            //pizza.MakePizza();
            //pizza = new VegPizza();
            //pizza.MakePizza();
            //Console.ReadLine();

            // Adapter Pattern :- Structural
            // Match interfaces of different classes
            //USBAdapter usb = new USBAdapter();
            //usb.ConnectA();
            //Console.WriteLine("Got the signal!");
            //Console.ReadLine();

            // Builder Pattern :- Creational
            // Separates object construction from its representation
            //var director = new Director(new ScheduledReportBuilder());
            //director.CreateReport();
            //var report = director.GetReport();
            //director = new Director(new GeneratedReportBuilder());
            //director.CreateReport();
            //report = director.GetReport();
        }
    }
}
