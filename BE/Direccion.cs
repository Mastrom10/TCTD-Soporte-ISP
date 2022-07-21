namespace BE
{
    public class Direccion : Entity
    {
        //Calle, Altura, Codigo Postal, Localidad, Provincia, Piso, Depto

        public string calle { get; set; }
        public string altura { get; set; }
        public string codigoPostal { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
        public string piso { get; set; }
        public string depto { get; set; }

        public NodoRed nodoRed { get; set; }
    }
}