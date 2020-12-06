using Countries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Countries.Repositories;

namespace Countries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        //property aanmaken waar het object van de klasse gaan bijhouden
        public Country DetailCountry { get; set; }

        //public LanguageCountry DetailLanguage { get; set; }
        //via de ctor geven de guest door 

        public DetailPage(Country countryName)
        {
            InitializeComponent();
            this.DetailCountry = countryName;

            ShowDetails();
        }

        private async void ShowDetails()
        {
            lblName.Text = DetailCountry.Name;
            lblCapital.Text = DetailCountry.Capital;
            lblRegion.Text = DetailCountry.Region;
            lblSubregion.Text = DetailCountry.Subregion;
            lblPopulation.Text = DetailCountry.Population.ToString();
            lblLating.Text = DetailCountry.Lating.ToString();
            lblTimezones.Text = String.Join(",", DetailCountry.Timezones);
            lblBorders.Text = String.Join(",", DetailCountry.Borders);
            //lblCurrencies.Text = DetailCountry.Currencies;
            LanguageCountry languages = await CountryRepository.GetLanguages(DetailCountry.Name);
            lblLanguages.Text = languages.Name;
            var flag_url = "https://restcountries.eu/data/" + DetailCountry.ImgCode.ToLower() + ".svg";
            Debug.WriteLine(flag_url);

            ImageFlag.Source = flag_url;

        }
    }
}