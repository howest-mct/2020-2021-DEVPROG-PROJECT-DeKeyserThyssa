using Countries.Models;
using Countries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Countries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        //property aanmaken waar het object van de klasse gaan bijhouden
        //public Country DetailCountry { get; set; }

        public Country MyCountry { get; set; }
        public DetailPage(Models.Country selected)
        {
            InitializeComponent();
            //bijhouden
            MyCountry = selected;
            //lists van het doorgegeven board gaan ophalen & tonen
            ShowSelectedCountry();
        }

        private async void ShowSelectedCountry()
        {
            List<Country> country = await CountryRepository.GetCountry(MyCountry.Name);
            //weergeven in de juiste listview
            lvwCountry.ItemsSource = country;
        }

        //private void ShowDetails()
        //{
        //    lblName.Text = DetailCountry.Name;
        //    lblCapital.Text = DetailCountry.Capital;
        //    lblRegion.Text = DetailCountry.Region;
        //    lblSubregion.Text = DetailCountry.Subregion;
        //    lblPopulation.Text = DetailCountry.Population.ToString();
        //    lblLating.Text = DetailCountry.Lating.ToString();
        //    lblTimezones.Text = DetailCountry.Timezones;
        //    lblBorders.Text = DetailCountry.Borders;
        //    lblCurrencies.Text = DetailCountry.Currencies;
        //    lblLanguages.Text = DetailCountry.Languages;
        //}
    }
}