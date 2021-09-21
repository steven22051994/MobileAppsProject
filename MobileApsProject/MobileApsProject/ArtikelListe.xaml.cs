﻿using System;
using System.Collections.Generic;
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
        public ArtikelListe()
        {
            InitializeComponent();
            ProduktListView.ItemsSource = artikelListe;
        }
    }
}