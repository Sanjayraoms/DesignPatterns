using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class Client
    {
        private IGuiFactory guiFactory;
        private IButton button;
        private ICheckBox checkBox;

        public Client(IGuiFactory factory)
        {
            guiFactory = factory;
            button = factory.CreateButton();
            checkBox = factory.CreateCheckBox();
        }
        public void Render()
        {
            button.getClicked();
            checkBox.getChecked();
        }
        
    }
}
