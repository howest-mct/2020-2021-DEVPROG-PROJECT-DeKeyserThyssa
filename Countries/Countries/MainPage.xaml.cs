using Countries.Models;
using Countries.Repositories;
using Countries.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Countries
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadCountries();

            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            frmFilter.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private async void LoadCountries()
        {
            lvwCountries.ItemsSource = await CountryRepository.GetAllCountries();
        }

        private void lvwCountries_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvwCountries.SelectedItem != null)
            {
                Country selected = (Country)lvwCountries.SelectedItem;
                Navigation.PushAsync(new DetailPage(selected));
                lvwCountries.SelectedItem = null;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilterPage());
        }
    }
}
