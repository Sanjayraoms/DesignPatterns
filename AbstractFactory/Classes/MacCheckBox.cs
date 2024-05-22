using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class MacCheckBox : ICheckBox
    {
        public void getChecked()
        {
            Console.WriteLine("Checked Mac CheckBox");
        }
    }
}
