using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApsProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<Artikel> artikelListe = new List<Artikel>()
        {
            new Artikel()
            {
                Id = 1,
                Name = "Apfel",
                Beschreibung = "50 Cal",
                 ImgLink = "Product1.jpg"

            }
        };
        public MainPage()
        {
            InitializeComponent();
           
        }



        private void Button_Clicked_To_Einkaufsliste(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EinkaufsListeView());

        }  
        private void Button_Clicked_To_Produktliste(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtikelListe());
        }  
        private void Button_Clicked_To_Hinzufuegen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NinzufuegenView());
        }
    }
}
