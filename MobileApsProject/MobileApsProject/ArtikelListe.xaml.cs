using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApsProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtikelListe : ContentPage
    {
        public static ObservableCollection<Artikel> artikelListe = new ObservableCollection<Artikel>()
        {
            new Artikel()
            {
                Id = 1,
                Name = "Apfel",
                Beschreibung = "50 Cal",
                 ImgLink = "Product1.jpg"

            }
        };
        public ArtikelListe()
        {
            InitializeComponent();
            ProduktListView.ItemsSource = artikelListe;
        }

        private void ProduktListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var m = ((Artikel)e.SelectedItem);
            MobileApsProject.MainPage.artikelListeEinkaufsliste.Add((Artikel)m);
            
        }
    }
}