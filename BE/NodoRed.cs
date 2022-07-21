namespace BE
{
    public class NodoRed : Entity
    {
        public string nombre;
        public EstadoNodo estado;

        public override string ToString()
        {
            return nombre + " - " + estado.ToString();
        }

    }
}