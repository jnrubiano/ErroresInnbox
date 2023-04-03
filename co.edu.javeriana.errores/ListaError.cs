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
            e.Descripcion = "Error:No fue posible crear el servicio";
            this.Add(e);

            Error e2 = new Error();
            e2.Id = 2;
            e2.CodEerror = 406;
            e2.Descripcion = "Error: El servicio no fue actualizado";
            this.Add(e2);

            Error e3 = new Error();
            e3.Id = 3;
            e3.CodEerror = 407;
            e3.Descripcion = "Error: No fue posible asignar el servicio al usuario";
            this.Add(e3);

            Error e4 = new Error();
            e4.Id = 4;
            e4.CodEerror = 408;
            e4.Descripcion = "Error: Se generó una excepción";
            this.Add(e4);

            Error e5 = new Error();
            e5.Id = 5;
            e5.CodEerror = 200;
            e5.Descripcion = "OK";
            this.Add(e5);

            Error e6 = new Error();
            e6.Id = 6;
            e6.CodEerror = 227;
            e6.Descripcion = "Servicio Creado";
            this.Add(e6);

            Error e7 = new Error();
            e7.Id = 7;
            e7.CodEerror = 228;
            e7.Descripcion = "Servicio Aceptado";
            this.Add(e7);

            Error e8 = new Error();
            e8.Id = 8;
            e8.CodEerror = 229;
            e8.Descripcion = "Servicio Rechazado";
            this.Add(e8);

            Error e9 = new Error();
            e9.Id = 9;
            e9.CodEerror = 230;
            e9.Descripcion = "Servicio Cancelado";
            this.Add(e9);

        } 
    }
}
