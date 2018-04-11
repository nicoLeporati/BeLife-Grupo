using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelEntities;

namespace BusinessLayer
{
    public class BcCliente
    {
        /* Prueba GitHub
         * Buscar un cliente por su rut, solo si el rut no es nulo y no esta en blanco
         */
        public Cliente BuscarPorRut(string rut = null)
        {
            if (rut != null && rut != "") //mejorar verificacion
            {
                return new DcCliente().BuscarPorRut(rut);
            }
            else
            {
                return null;
            }
        }

        /* 
         * Registrar cliente si los datos son validos
         */
        public bool Registrar(Cliente cliente)
        {
            if (cliente.RutCliente != null && cliente.RutCliente != "") //mejorar verificacion
            {
                if (new DcCliente().Registrar(cliente))
                {
                    return true;
                }                
            }

            return false;
        }

        /* 
         * Actualizar datos de un cliente si estos son validos
         */
        public bool Actualizar(Cliente cliente)
        {
            if (cliente.RutCliente != null && cliente.RutCliente != "") //mejorar verificacion
            {
                if (new DcCliente().Actualizar(cliente))
                {
                    return true;
                }                
            }

            return false;
        }

        /*
         * Elimina un cliente usando su rut y verificandolo
         */
        public bool EliminarPorRut(string rut=null)
        {
            if (rut != null && rut != "") //mejorar verificacion
            { 
                if (new DcCliente().EliminarPorRut(rut)) //eliminacion
                {
                    return true; // retorna verdadero si se logra eliminar
                }
            }
            return false;
        }
    }
}
