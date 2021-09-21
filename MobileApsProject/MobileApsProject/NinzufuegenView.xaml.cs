using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApsProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NinzufuegenView : ContentPage
    {
        public NinzufuegenView()
        {

            InitializeComponent();


        }

        async private void CreateArtikelButton_Clicked(object sender, EventArgs e)
        {

          
            MobileApsProject.ArtikelListe.artikelListe.Add(new Artikel()
            {
                Id = MobileApsProject.ArtikelListe.artikelListe.Count(),
                Name = EntryName.Text,
                Beschreibung = EntryBesch.Text,
                ImgLink = EntryImageLink.Text
            }) ;
            string JsonString = JsonConvert.SerializeObject(ArtikelListe.artikelListe);
            //Speichert im Arbeitsspeicher
         

            await Application.Current.SavePropertiesAsync();
            Navigation.PopToRootAsync();
        }
    }
}