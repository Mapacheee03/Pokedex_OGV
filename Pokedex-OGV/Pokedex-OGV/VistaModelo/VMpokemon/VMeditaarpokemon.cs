using Pokedex_OGV.Datos;
using Pokedex_OGV.Modelo;
using Pokedex_OGV.Vista.Pokemon;
using Pokedex_OGV.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Pokedex_OGV.VistaModelo.VMpokemon
{
    public class VMeditarpokemon : BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES
        string _TxtColorFondo;
        string _TxtColorPoder;
        string _TxtNombre;
        string _TxtNro;
        string _TxtPoder;
        string _TxtIcono;
        public Mpokemon _Pokemon { get; set; }
        #endregion
        #region Contructor
        public VMeditarpokemon(INavigation navigation, Mpokemon pokemon)
        {
            Navigation = navigation;
            _Pokemon = pokemon;
        }
        #endregion
        #region Objetivo;
        public string TxtColorFondo
        {
            get { return _Pokemon.Colorfondo; }
            set { SetValue(ref _TxtColorFondo, value); }
        }
        public string TxtColorPoder
        {
            get { return _Pokemon.ColorPoder; }
            set { SetValue(ref _TxtColorPoder, value); }
        }
        public string TxtNombre
        {
            get { return _Pokemon.Nombre; }
            set { SetValue(ref _TxtNombre, value); }
        }

        public string TxtNro
        {
            get { return _Pokemon.NroOrden; }
            set { SetValue(ref _TxtNro, value); }
        }
        public string TxtPoder
        {
            get { return _Pokemon.Poder; }
            set { SetValue(ref _TxtPoder, value); }
        }
        public string TxtIcono
        {
            get { return _Pokemon.Icono; }
            set { SetValue(ref _TxtIcono, value); }
        }

        #endregion
        #region PROCESOS
       
        public async Task Editar()
        {
            var funcion = new DPokemon();
            var parametros = new Mpokemon();
            parametros.Idpokemon = _Pokemon.Idpokemon;
            parametros.Colorfondo = TxtColorFondo;
            parametros.ColorPoder = TxtColorPoder;
            parametros.Icono = TxtIcono;
            parametros.Nombre = TxtNombre;
            parametros.NroOrden = TxtNro;
            parametros.Poder = TxtPoder;

            await funcion.Actualizar(parametros);
            await Volver();
        }

        public async Task Eliminar()
        {

            var funcion = new DPokemon();
            await funcion.Eliminarpokemon(_Pokemon);
            await Volver(); ;
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }



        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        public ICommand Editarcommand => new Command(async () => await Editar());
        public ICommand Eliminarcommand => new Command(async () => await Eliminar());

        public ICommand Volvercommand => new Command(async () => await Volver());

        #endregion







        ///////////////////////////


    }
}
