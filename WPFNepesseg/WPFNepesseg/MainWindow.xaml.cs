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

namespace WPFNepesseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
            public class Telepules
        {
            String megye;
            String telepulesNev;
            String telepulesTipus; //község, nagyközség, város, ...
            int ferfiLakosokSzama;
            int noiLakosokSzama;

            //Konstruktor
            public Telepules(string megye, string telepulesNev, string telepulesTipus, int ferfiLakosokSzama, int noiLakosokSzama)
            {
                this.Megye = megye;
                this.TelepulesNev = telepulesNev;
                this.TelepulesTipus = telepulesTipus;
                this.FerfiLakosokSzama = ferfiLakosokSzama;
                this.NoiLakosokSzama = noiLakosokSzama;
            }

            public string Megye { get => megye; set => megye = value; }
            public string TelepulesNev { get => telepulesNev; set => telepulesNev = value; }
            public string TelepulesTipus { get => telepulesTipus; set => telepulesTipus = value; }
            public int FerfiLakosokSzama { get => ferfiLakosokSzama; set => ferfiLakosokSzama = value; }
            public int NoiLakosokSzama { get => noiLakosokSzama; set => noiLakosokSzama = value; }

            public int LakosokSzamaEgyutt { get => noiLakosokSzama + this.ferfiLakosokSzama; }
        }
        }
    }

