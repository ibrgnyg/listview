using listview.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace listview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewPage1()
        {
            InitializeComponent();

           var list = new  List<Product>
           {
               new Product {ProductName ="MSI Interceptor DS B1 Oyuncu Mouse", Desctiption="800 DPI", Price=150, Image="https://productimages.hepsiburada.net/s/26/500/10161800314930.jpg" },
               new Product {ProductName ="Asus VG279Q 27 144Hz 1ms (HDMI+Display+DVI-D) FreeSync Full HD IPS Monitör", Desctiption="144 hz", Price=259900, Image="https://productimages.hepsiburada.net/s/25/550/10114887221298.jpg/format:webp" },
               new Product {ProductName ="Corsair 16GB(2x8GB) DDR4 3200MHz CL16 Ram CMW16GX4M2C3200C16", Desctiption="4K 60 FPS", Price=700, Image="https://productimages.hepsiburada.net/s/6/550/9731739779122.jpg/format:webp" },
               new Product {ProductName ="Dijitsu DJT55SH 55 139 Ekran Uydu Alıcılı Android Smart 4K Ultra HD LED TV", Desctiption="4k 150EKRAN", Price=3000, Image="https://productimages.hepsiburada.net/s/39/550/10620919218226.jpg/format:webp" },
               new Product {ProductName ="Pierre Cardin Erkek Spor Pantolon", Desctiption="PierreCardin", Price=80, Image="https://productimages.hepsiburada.net/l/38/1000/10606042939442.jpg" },
               new Product {ProductName ="Xiaomi Redmi Note 9 Pro ", Desctiption="128 GB", Price=2700, Image="https://productimages.hepsiburada.net/s/39/550/10607339405362.jpg/format:webp" },
           };
            productlist.ItemsSource = list;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
