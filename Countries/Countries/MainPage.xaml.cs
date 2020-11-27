﻿using Countries.Models;
using Countries.Repositories;
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
            List<Country> countries = await CountryRepository.GetAllCountries(); // als je await gebruik moet je async vanboven zetten
            Debug.WriteLine("Count Countries: " + countries.Count);
        }

        private void lvwCountries_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvwCountries.SelectedItem != null)
            {
                // er is een board geselecteerd
                Country selected = (Country)lvwCountries.SelectedItem;
                // we gaan naar een andere page
                //Navigation.PushAsync(new TrelloListPage(selected));
                //selected item deselecteren
                //lvwBoards.SelectedItem = null;
            }
        }
    }
}
