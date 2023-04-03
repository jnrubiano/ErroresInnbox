namespace co.edu.javeriana.errores
{
    
    public class Usuario
    {
        public enum TipoError
        {
            NoCrearServicio = 1,
            NoActualizadoServicio = 2,
            NoAsignarServicio = 3,
            GeneroExcepcion = 4,
            OK = 5,
            ServicioCreado = 6,
            ServicioAceptado = 7,
            ServicioRechazado = 8,
            ServicioCancelado = 9
        }
        public Error RecuperarError(TipoError tipo)
        {
            int indice = (int)tipo;
            ListaError listE = new ListaError();
            Error e = listE.Where(z => z.Id == indice).FirstOrDefault();
            if (e == null)
            {
                return null;
            }
            else
            {
                return e;
            }
        }
    }
}