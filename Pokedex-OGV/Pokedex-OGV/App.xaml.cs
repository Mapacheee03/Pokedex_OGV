using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex_OGV.Vista;
using Pokedex_OGV.Vista.Pokemon;

namespace Pokedex_OGV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Listarpokemon());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
