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
    public partial class MainPage : ContentPage
    {

        public static List<Artikel> artikelListeEinkaufsliste = new List<Artikel>();
       
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