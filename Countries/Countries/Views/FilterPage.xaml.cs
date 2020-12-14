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
    public partial class FilterPage : ContentPage
    {
        public FilterPage()
        {
            InitializeComponent();
            Filter();

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            frmAllCountries.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private async Task Filter()
        {
            RegionGroup regionGroup = await CountryRepository.GetRegion();
            regionGroup.RegionFilter.Sort();
            pkrRegions.ItemsSource = regionGroup.RegionFilter;
        }
        private async void Button_OnPressed(object sender, EventArgs e)
        {
            if (pkrRegions.SelectedItem != null)
            {
                await Navigation.PushAsync(new ResultPage((Country)pkrRegions.ItemsSource[pkrRegions.SelectedIndex]));
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}