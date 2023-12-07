using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex_OGV.Conexion
{
    internal class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmogv-default-rtdb.firebaseio.com/");
    }
}
