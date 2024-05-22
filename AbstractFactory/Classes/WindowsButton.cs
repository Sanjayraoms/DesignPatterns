﻿using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class WindowsButton : IButton
    {
        public void getClicked()
        {
            Console.WriteLine("Windows button is rendered");
        }
    }
}
