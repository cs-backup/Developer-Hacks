using System;
namespace SOLID.Classes
{
    //HACK Question: With this current implementation, we want to introduce new type of printer, how you going to refactor this design and which SOLID principle you going to use?
    // Answer: Dependency Inversion Principle
    public class PrintingSystem
    {
        private IIvoicePrinter _invoicePrinter;

        public PrintingSystem(IIvoicePrinter invoicePrinter)
        {
            _invoicePrinter = invoicePrinter;
        }

        public void Print(Invoice invoice)
        {
            _invoicePrinter.Print(invoice);
        }
    }

    public interface IIvoicePrinter
    {
        void Print(Invoice invoice);
    }

    public class InvoicePrinter : IIvoicePrinter
    {
        public void Print(Invoice invoice)
        {

        }
    }

    public class Invoice
    {

    }


}
