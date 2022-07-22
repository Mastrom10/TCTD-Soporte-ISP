namespace BE
{
    public class Dispositivo: Entity
    {
        public string tipo;
        public string macAdress;
        public string nroserie;

        public override string ToString()
        {
            return tipo + " | " + macAdress + " | " + nroserie;
        }
    }
}