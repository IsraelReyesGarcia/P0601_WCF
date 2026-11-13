using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteWCF.ServiceReference1;

namespace ClienteWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia del cliente
            Service1Client cliente = new Service1Client();
            try
            {
                // Llamar al método ObtenerUsuarios
                string[] usuarios = cliente.ObtenerUsuarios();

                Console.WriteLine("Usuarios en la base de datos");
                foreach(string usuario in usuarios)
                {
                    Console.WriteLine("- " + usuario);
                }

                // Cerrar la conexión
                cliente.Close();    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
