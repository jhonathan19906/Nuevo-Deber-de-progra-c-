using System;

namespace DeberDelViernes
{
    class Persona : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }
        Celular celular;
        public Celular Celular 
        {
            get
            {
                return celular;
            }
            set 
            {
                celular = value;
                celular.Propietario = this;
            } 
        }
        public Moto Moto 
        { 
            get 
            {
                return Moto;
            }
            set
            {
                Moto = value;
                Moto.Propietario = this;
            }
        }
        public Pelota Pelota { get; set; }
        public Persona() : base()
        {

        }

        public string Saludar()
        {
            return $"Hola me llamo{this.Nombre}";
        }

        public string Productos()
        {
            if (celular != null)
                   return $"tengo celular{celular.Modelo}";
                 else
                   return "No tengo celular";
        }

        
    }
}
