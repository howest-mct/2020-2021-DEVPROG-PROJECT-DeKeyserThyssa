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
            TestModels();
            LoadCountries();
        }

        private async void LoadCountries()
        {
            lvwCountries.ItemsSource = await CountryRepository.GetAllCountries();
        }

        private async void TestModels()
        {
            Debug.WriteLine("Test models");
            List<Country> countries = await CountryRepository.GetAllCountries();
            Debug.WriteLine("Count Countries: " + countries.Count);
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
    }
}
