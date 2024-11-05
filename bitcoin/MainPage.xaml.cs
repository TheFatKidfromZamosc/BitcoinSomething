using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Text.Json;

namespace bitcoin
{
    public partial class MainPage : ContentPage
    {
        public class Bitcoint
        {
            public Bpi bpi { get; set; }
        }
        public class Bpi
        {
            public  USD USD { get; set; }
            public  EUR EUR { get; set; }
            public  GBP GBP { get; set; }
            public PLN PLN { get; set; }
        }
        public class USD
        {
                public string? code { get; set; }
                public string? rate { get; set; }
                public string? description { get; set; }
                public double rate_float { get; set; }
            }
        public class EUR
        {
                public string? code { get; set; }
                public string? rate { get; set; }
                public string? description { get; set; }
                public double rate_float { get; set; }
            }
        public class GBP
        {
            public string? code { get; set; }
            public string? rate { get; set; }
            public string? description { get; set; }
            public double rate_float { get; set; }
        }
        public class PLN
        {
            public string? code { get; set; }
            public string? rate { get; set; }
            public string? description { get; set; }
            public double rate_float { get; set; }
        }


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int ilosc = int.Parse(Ilosc.Text);
            int index = wybierzWalute.SelectedIndex;
            if (index == 0)
            {
                string url1 = "https://api.coindesk.com/v1/bpi/currentprice/USD.json";
                string json1;

                using (var webClient = new WebClient())
                {
                    json1 = webClient.DownloadString(url1);
                }

                Bitcoint bitcoin = JsonSerializer.Deserialize<Bitcoint>(json1);

                string s = "Wartosc bitcoina w " + bitcoin.bpi.USD.code + " w ilosci " + ilosc + " to : " + bitcoin.bpi.USD.rate_float * ilosc;
                WyswietlKurs.Text = s;

            }
            if (index == 1)
            {
                string url2 = "https://api.coindesk.com/v1/bpi/currentprice/GBP.json";
                string json2;

                using (var webClient = new WebClient())
                {
                    json2 = webClient.DownloadString(url2);
                }

                Bitcoint bitcoin = JsonSerializer.Deserialize<Bitcoint>(json2);

                string s = "Wartosc bitcoina w " + bitcoin.bpi.GBP.code + " w ilosci " + ilosc + " to : " + bitcoin.bpi.GBP.rate_float * ilosc;
                WyswietlKurs.Text = s;

            }
            if (index == 2)
            {
                string url3 = "https://api.coindesk.com/v1/bpi/currentprice/EUR.json";
                string json3;

                using (var webClient = new WebClient())
                {
                    json3 = webClient.DownloadString(url3);
                }

                Bitcoint bitcoin = JsonSerializer.Deserialize<Bitcoint>(json3);

                string s = "Wartosc bitcoina w " + bitcoin.bpi.EUR.code + " w ilosci " + ilosc + " to : " + bitcoin.bpi.EUR.rate_float * ilosc;
                WyswietlKurs.Text = s;

            }
            if (index == 3)
            {
                string url4 = "https://api.coindesk.com/v1/bpi/currentprice/PLN.json";
                string json4;

                using (var webClient = new WebClient())
                {
                    json4 = webClient.DownloadString(url4);
                }

                Bitcoint bitcoin = JsonSerializer.Deserialize<Bitcoint>(json4);
                    string s = "Wartosc bitcoina w " + bitcoin.bpi.PLN.code + " w ilosci " + ilosc + " to : " + bitcoin.bpi.PLN.rate_float *ilosc;
                  WyswietlKurs.Text = s;

            }
        }
    }

}
