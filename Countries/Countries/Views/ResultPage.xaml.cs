using Countries.Models;
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
    public partial class ResultPage : ContentPage
    {
        public Country DetailRegion { get; set; }

        public ResultPage(Country countryRegion)
        {
            InitializeComponent();
            this.DetailRegion = countryRegion;
            ShowCountries();
        }



        private void ShowCountries()
        {
            lblRegionName.Text = DetailRegion.Name;
            lblCountryName.Text = DetailRegion.Name;

        }
    }
}