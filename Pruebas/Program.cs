using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClienteDatos datos = new ClienteDatos();
            List<Cliente> lista = datos.Listar();
            foreach(var item in lista)
            {
                Console.WriteLine(item.nombre+""+item.id);
            }
            Console.ReadKey();

        }
    }
}
