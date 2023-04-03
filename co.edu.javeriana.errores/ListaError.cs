using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.edu.javeriana.errores
{
    internal class ListaError:List<Error>
    {
        public ListaError() { 
            Error e = new Error();
            e.Id = 1;
            e.CodEerror = 405;
            e.Descripcion = "Usuario no encontrado";
            this.Add(e);

            Error e2 = new Error();
            e2.Id = 2;
            e2.CodEerror = 406;
            e2.Descripcion = "Error no identificado";
            this.Add(e);

            Error e3 = new Error();
            e3.Id = 3;
            e3.CodEerror = 407;
            e3.Descripcion = "No se pudo insertar usuario";
            this.Add(e);

            Error e4 = new Error();
            e4.Id = 4;
            e4.CodEerror = 408;
            e4.Descripcion = "Error en la conexión a la base de datos";
            this.Add(e);
        } 
    }
}
