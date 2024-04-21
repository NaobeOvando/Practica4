using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteLogica
    {
        public List<Cliente> ListarClientes()
        {
            ClienteDatos datos = new ClienteDatos();
            List<Cliente> lista = datos.Listar();
            return lista;
        }
        public Cliente ListarClientesXID(int id )
        {
            ClienteDatos datos = new ClienteDatos();
            Cliente cli = datos.Listar().Where(c => c.id == id).SingleOrDefault();
            return cli;
        }
    }
}
