using Pokedex_OGV.Modelo;
using Pokedex_OGV.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_OGV.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Editarpokemon : ContentPage
    {
        public Editarpokemon(Mpokemon poquimon)
        {
            InitializeComponent();
            BindingContext = new VMeditarpokemon(Navigation, poquimon);
        }
    }
}
