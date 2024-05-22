using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class LinuxOS : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new LinusOSButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new LinuxOSCheckBox();
        }
    }
}
