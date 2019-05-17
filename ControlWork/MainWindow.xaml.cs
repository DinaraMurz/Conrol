using System;
using System.Collections.Generic;
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
using FixerSharp;



namespace ControlWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            Fixer.SetApiKey("ff3340ef6706308913308472e0fc7382");

            double current1 = Fixer.Convert(Symbols.USD, Symbols.KZT, 1);
            double current2 = Fixer.Convert(Symbols.EUR, Symbols.KZT, 1);
            double current3 = Fixer.Convert(Symbols.KWD, Symbols.KZT, 1);
            double current4 = Fixer.Convert(Symbols.AUD, Symbols.KZT, 1);
            double current5 = Fixer.Convert(Symbols.ALL, Symbols.KZT, 1);
            double current6 = Fixer.Convert(Symbols.JPY, Symbols.KZT, 1);
            double current7 = Fixer.Convert(Symbols.KPW, Symbols.KZT, 1);
            double current8 = Fixer.Convert(Symbols.JOD, Symbols.KZT, 1);
            double current9 = Fixer.Convert(Symbols.RUB, Symbols.KZT, 1);
            double current10 = Fixer.Convert(Symbols.PKR, Symbols.KZT, 1);


           
            //List<CurrentInKzt> currents = new List<CurrentInKzt>()
            //{
            //    new CurrentInKzt()
            //    {
            //        Name="USD",
            //        QuantityOfKzt = Fixer.Convert(Symbols.USD, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="EUR",
            //        QuantityOfKzt = Fixer.Convert(Symbols.EUR, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="KWD",
            //        QuantityOfKzt = Fixer.Convert(Symbols.KWD, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="AUD",
            //        QuantityOfKzt = Fixer.Convert(Symbols.AUD, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="ALL",
            //        QuantityOfKzt = Fixer.Convert(Symbols.ALL, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="JPY",
            //        QuantityOfKzt = Fixer.Convert(Symbols.JPY, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="KPW",
            //        QuantityOfKzt = Fixer.Convert(Symbols.KPW, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="JOD",
            //        QuantityOfKzt = Fixer.Convert(Symbols.JOD, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="RUB",
            //        QuantityOfKzt = Fixer.Convert(Symbols.RUB, Symbols.KZT, 1)
            //    },
            //    new CurrentInKzt()
            //    {
            //        Name="PKR",
            //        QuantityOfKzt = Fixer.Convert(Symbols.PKR, Symbols.KZT, 1)
            //    }
            //};


            InitializeComponent();
        }
    }
}
