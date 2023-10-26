using System.Net.Mail;

namespace TouristBay_MVC.Models
{
    public class Pasajero
    {
        private string _Nombre;
        private string _Apellido;
        private DateOnly _FNacimiento;
        private bool _Genero; // True para hombre; False para mujer
        private MailAddress? _Mail;
        private string _Telefono;

        public string Nombre { get => _Nombre; set => Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateOnly FNacimiento{ get => _FNacimiento; set => _FNacimiento = value; }
        public bool Genero { get => _Genero; set => _Genero = value; }
        public MailAddress Mail { get => _Mail; set => _Mail = value; }
        public string Telefono { get => _Apellido; set => _Apellido = value; }



        public Pasajero()
        {
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _FNacimiento = new DateOnly();
            _Genero = true;
            _Mail = null;
            _Telefono = string.Empty;
        }
    }
}
