namespace BE
{
    public class NodoRed : Entity
    {
        public string nombre { get; set; }
        public EstadoNodo estado { get; set; }

        public override string ToString()
        {
            return nombre + " - " + estado.ToString();
        }

    }
}