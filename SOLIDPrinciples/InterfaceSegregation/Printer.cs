using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregation
{
    public interface IMachinePrinter
    {
        void Scan(Document d);
        public void Print(Document d);

        void Fax(Document d);
    }
    public class Printer : IMachinePrinter
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public struct MultiFunctionPrinter  : IMultifunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionPrinter(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public interface IFax
    {
        void Fax(Document d);
    }

    public interface IMultifunctionDevice : IPrinter,IScanner
    {

    }
}
