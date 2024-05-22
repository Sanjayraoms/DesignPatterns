using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class LinuxOSCheckBox : ICheckBox
    {
        public void getChecked()
        {
            Console.WriteLine("Linux Checkbox is rendered");
        }
    }
}
