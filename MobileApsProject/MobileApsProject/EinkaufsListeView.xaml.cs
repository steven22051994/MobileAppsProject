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
    public partial class EinkaufsListeView : ContentPage
    {
        
        public EinkaufsListeView()
        {
            InitializeComponent();
            EinkaufsListView.ItemsSource = MainPage.artikelListeEinkaufsliste;
        }

        private void EinkaufsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {


            var m = MainPage.artikelListeEinkaufsliste.Where(x => e.SelectedItem.Equals(x)).FirstOrDefault();
            MainPage.artikelListeEinkaufsliste.Remove(m);
        }
    }
}