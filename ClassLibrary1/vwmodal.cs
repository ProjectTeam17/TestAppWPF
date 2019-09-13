using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace ClassLibrary1
{
    public class Vwmodal
    {

        private ICommand mComm;

        public Vwmodal()
        {
            
        }

        public ICommand MComm { get => mComm; set => mComm = value; }

        public string Hello()
        {
            return "Hello";
        }
    }
}
