namespace BE
{
    public class Dispositivo: Entity
    {
        public string tipo { get; set; }
        public string macAdress { get; set; }
        public string nroserie { get; set; }

        public override string ToString()
        {
            return tipo + " | " + macAdress + " | " + nroserie;
        }
    }
}