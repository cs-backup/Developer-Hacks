using System;
namespace SOLID.Classes
{
    //HACK Question: With this current implementation, we want to introduce new type of printer, how you going to refactor this design and which SOLID principle you going to use?
    public class PrintingSystem
    {
        private InvoicePrinter _invoicePrinter;

        public PrintingSystem(InvoicePrinter invoicePrinter)
        {
            _invoicePrinter = invoicePrinter;
        }

        public void Print(Invoice invoice)
        {
            _invoicePrinter.Print(invoice);
        }
    }

    public class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {

        }
    }

    public class Invoice
    {

    }


}
