using Bertozzi.Mattia._4H.XamAzure.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bertozzi.Mattia._4H.XamAzure
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List<Studente> elenco = new List<Studente>();

            try
            {
                HttpClient client = new HttpClient();
                //string response = await client.GetStringAsync("https://flr.azurewebsites.net/studenti");
                string response = await client.GetStringAsync("https://bertozzi-mattia-4h-xamazureapi-gg2.conveyor.cloud/Studenti");
                elenco = JsonConvert.DeserializeObject<List<Studente>>(response);
            }
            catch (Exception err)
            {
                await DisplayAlert("Ocio!!", err.Message, "Ok");
            }

            lvStudenti.ItemsSource = elenco;
        }
    }
}
