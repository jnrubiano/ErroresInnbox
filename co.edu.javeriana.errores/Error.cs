using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.edu.javeriana.errores
{


    public class Error
    {
        private int id;
        private string descripcion = "";
        private int codEerror;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CodEerror { get => codEerror; set => codEerror = value; }
    }
   
}