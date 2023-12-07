using Pokedex_OGV.VistaModelo.VMpokemon;
using Pokedex_OGV.Vista.Pokemon;

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
    public partial class Listarpokemon : ContentPage
    {


        //activar solo esto para cuando este ejecutando la aplicacion en tiempo real
        /*
            public Listarpokemon()
            { 
                InitializeComponent();
                BindingContext = new VMlistapokemon(Navigation);//activar solo esto para cuando este ejecutando la aplicacion en tiempo real
            }
            */
        VMlistapokemon vM;//esto es para cuando este usando lista
        public Listarpokemon()
        {
            InitializeComponent();
            vM = new VMlistapokemon(Navigation);
            BindingContext = vM;
            this.Appearing += Listapokemon_Appearing;
        }

        //desactivarlo cuando este usando la aplicacion en tiempo real
        private async void Listapokemon_Appearing(object sender, EventArgs e)
        {
            await vM.Mostrarpokemon();
        }
    }
}
