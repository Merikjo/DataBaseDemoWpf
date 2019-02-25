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

namespace DataBaseDemoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Henkilot teppoTestaaja = new Henkilot();

            teppoTestaaja.HenkiloID = 1000;
            teppoTestaaja.Etunimi = "Teppo";
            teppoTestaaja.Sukunimi = "Testaaja";
            teppoTestaaja.Osoite = "Testitie 1";
            teppoTestaaja.Postinumero = "00001";
            teppoTestaaja.Sahkoposti = "teppo@testi.fi";
            teppoTestaaja.Puhelinnumero = "050123456";
            teppoTestaaja.Paivamaara = DateTime.Now;

            DataGridXAML.Items.Add(teppoTestaaja);
        }

        public class Henkilot
        {

            public int HenkiloID { get; set; }
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string Osoite { get; set; }
            public string Postinumero { get; set; }
            public string Sahkoposti { get; set; }
            public string Puhelinnumero { get; set; }
            public DateTime Paivamaara { get; set; }




        }

        private void BtnLisaa_Henkilo_Click(object sender, RoutedEventArgs e)
        {
            Henkilot henkilot = new Henkilot();
            henkilot.HenkiloID = int.Parse(txtHenkiloID.Text);
            henkilot.Etunimi = txtEtunimi.Text;
            henkilot.Sukunimi = txtSukunimi.Text;
            henkilot.Osoite = txtOsoite.Text;
            henkilot.Postinumero = txtPostinumero.Text;
            henkilot.Sahkoposti = txtSahkoposti.Text;
            henkilot.Puhelinnumero = txtPuhelinnumero.Text;
            henkilot.Paivamaara = DateTime.Now;

            DataGridXAML.Items.Add(henkilot);
        }

        private void BtnTyhjennaTiedot_Click(object sender, RoutedEventArgs e)
        {
            txtHenkiloID.Clear();
            txtEtunimi.Clear();
            txtSukunimi.Clear();
            txtOsoite.Clear();
            txtPostinumero.Clear();
            txtSahkoposti.Clear();
            txtPuhelinnumero.Clear();
            txtDate.Clear();
        }
    }
}
