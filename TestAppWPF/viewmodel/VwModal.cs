using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.Commands;
using TestAppWPF.Model;


namespace TestAppWPF.viewmodel
{
   
    public class VwModal
    {
        private ICommand _meuOpen;
        private ICommand _popOpen;

        //public PowerPlantDbEntities1 db = null;
        //ComponentPowerPlant obj = new ComponentPowerPlant();

        static List<String> myList = new List<string>(new String[] { "Hello", "Hi", "Ciao", "Adios" });

        public VwModal()
        {
            MyList = new List<string>(new String[] { "Hello", "Hi", "Ciao", "Adios" });

        }

        public string[] arr = { "Hello", "Hi", "Ciao", "Adios" };

        public List<string> MyList { get => myList; set => myList = value; }


        public ICommand MeuOpen { get => _meuOpen ?? (_meuOpen = new RelayCommand(x => Dostuff1())); set => _meuOpen = value; }

        public ICommand PopOpen { get => _popOpen ?? (_popOpen = new RelayCommand(x => Dostuff())); set => _popOpen = value; }

        private static void Dostuff()
        {
            PowerPlantDbEntities1 db = new PowerPlantDbEntities1();
            MainWindow d = (MainWindow)Application.Current.MainWindow;
            //d.item1.Header = "Hello";
            //d.item2.Header = "Hi";
            //d.item3.Header = "ciao";
            //d.item4.Header = "Adios";
            //d.myPop.IsOpen = true;
           var arr = from components in db.ComponentPowerPlants
                     where components.ComponentID==1
                      select components;
           
            foreach (var item in arr)
            {

                d.item1.Header = "Name: "+item.ComponentName;
                d.item2.Header ="Power: "+item.Power;
                d.item3.Header = "Pressure: "+item.Pressure;
                d.item4.Header = "Speed: "+item.Speed;
                
            }
            d.myPop.IsOpen = true;

        }
        public static void Dostuff1()
        {
            PowerPlantDbEntities1 db = new PowerPlantDbEntities1();
            MainWindow d = (MainWindow)Application.Current.MainWindow;

            var arr = from components in db.ComponentPowerPlants
                      where components.ComponentID == 2
                      select components;

            foreach (var item in arr)
            {

                d.item11.Header = "Name: " + item.ComponentName;
                d.item21.Header = "Power: " + item.Power;
                d.item31.Header = "Pressure: " + item.Pressure;
                d.item41.Header = "Speed: " + item.Speed;
                
            }
            d.myPop1.IsOpen = true;
        }
    }
}
