namespace co.edu.javeriana.errores
{
    
    public class Usuario
    {
        public enum TipoError
        {
            UsuarioNoEncontrado = 1,
            ErrorNoIdentificado = 2,
            NoInsertar = 3,
            ErrorConexion = 4
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