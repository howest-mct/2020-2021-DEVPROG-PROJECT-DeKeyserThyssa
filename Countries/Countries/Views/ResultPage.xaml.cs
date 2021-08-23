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
    public partial class ResultPage : ContentPage
    {
        public Country DetailRegion { get; set; }

        public ResultPage(Country regionName)
        {
            InitializeComponent();
            this.DetailRegion = regionName;
            ShowCountriesFromRegion();
        }

        private async void ShowCountriesFromRegion()
        {
            lblRegion.Text = DetailRegion.Region;
            lblName.Text = DetailRegion.Name;
        }
    }
}