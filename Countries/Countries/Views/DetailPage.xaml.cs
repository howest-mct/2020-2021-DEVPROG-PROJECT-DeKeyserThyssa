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
        public Country DetailCountry { get; set; }

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
            lblLating.Text = String.Join(" / ", DetailCountry.Lating);
            lblTimezones.Text = String.Join(", ", DetailCountry.Timezones);
            lblBorders.Text = String.Join(", ", DetailCountry.Borders);
        }
    }
}