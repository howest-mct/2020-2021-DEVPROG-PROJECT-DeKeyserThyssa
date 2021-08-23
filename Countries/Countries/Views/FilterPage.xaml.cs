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
            //TestModels();
            LoadRegions();

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            frmAllCountries.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private async void LoadRegions()
        {
            lvwRegions.ItemsSource = await CountryRepository.GetRegions();
        }

        private void lvwRegions_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvwRegions.SelectedItem != null)
            {
                Country selected = (Country)lvwRegions.SelectedItem;
                Navigation.PushAsync(new ResultPage(selected));
                lvwRegions.SelectedItem = null;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

    }
}