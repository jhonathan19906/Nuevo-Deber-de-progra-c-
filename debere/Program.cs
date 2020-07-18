using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace DeberDelViernes
{
    class Program : GeneradorAutomaticoIdentificacion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pelota = new Pelota
            {
                Marca = "Adidas",
                Modelo = "Brasuca",
                Precio = 150
            };
            
            
            
            var empresa = new Empresa();

            var estudiante = new Persona
            {
                Nombre = "jhonta",
                Celular = empresa.ConstruirCeluler("nokia")
            };

            estudiante.Moto = empresa.ConstruirMoto("kahuasaki");
            estudiante.Pelota = empresa.ConstruirPeota( "Adidas","Brasuca",150);
            
            Console.WriteLine(estudiante.Saludar());
            Console.WriteLine(estudiante.Productos());
            Console.WriteLine(estudiante.Pelota.Nueva());
            
            Console.ReadKey();
        }
    }
}
