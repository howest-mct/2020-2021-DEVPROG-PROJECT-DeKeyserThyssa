using Countries.Models;
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
        }

        private async void TestModels()
        {
            Debug.WriteLine("Test models");
            List<Country> countries = await CountryRepository.GetAllCountries(); // als je await gebruik moet je async vanboven zetten
            Debug.WriteLine("Count Countries: " + countries.Count);
        }
    }
}
