using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApsProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProduktListePage : ContentPage
    {
        public ProduktListePage()
        {


            InitializeComponent();
            List<Artikel> artikellist = new List<Artikel>() { 
            new Artikel()
            {
                Id = 0,
                Name = "Apfel",
                Beschreibung = "52 Kalorien"
            },
             new Artikel()
            {
                Id = 1,
                Name = "Birne",
                Beschreibung = "57 Kalorien"
            },
             new Artikel()
            {
                Id = 2,
                Name = "Banane",
                Beschreibung = "55 Kalorien"
            },
             new Artikel()
            {
                Id = 3,
                Name = "Schinken",
                Beschreibung = "145 Kalorien"
            },
             new Artikel()
            {
                Id = 4,
                Name = "Wurst",
                Beschreibung = "301 Kalorien"
            },
             new Artikel()
            {
                Id = 5,
                Name = "Buch",
                Beschreibung = "0 Kalorien, aber viel Wissen"
            }
            };
        }
    }
}