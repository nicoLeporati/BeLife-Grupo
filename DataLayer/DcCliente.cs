using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntities;

namespace DataLayer
{
    public class DcCliente
    {
        /* 
         * Buscar un cliente por su rut
         */         
        public Cliente BuscarPorRut(string rut = null)
        {
            using (BeLifeEntities context = new BeLifeEntities())
            {
                return context.Cliente.Find(rut);
            }
        }

        /*
         * Registrar un cliente con todos sus datos
         */
        public bool Registrar(Cliente cliente)
        {
            using (BeLifeEntities context = new BeLifeEntities())
            {
                // Agregar cliente y guardar cambios
                context.Cliente.Add(cliente);
                context.SaveChanges();

                return true;
            }
        }

        /*
         * Actualizar los datos de un cliente mediante su rut
         */
        public bool Actualizar(Cliente cliente)
        {
            using (BeLifeEntities context = new BeLifeEntities())
            {
                // Buscar cliente
                Cliente cli = context.Cliente.Find(cliente.RutCliente);                

                // Si se encuentra se procede y retorna verdadero
                if (cli is Cliente)
                {
                    cli.Nombres = cliente.Nombres;
                    cli.Apellidos = cliente.Apellidos;
                    cli.FechaNacimiento = cliente.FechaNacimiento;
                    cli.IdSexo = cliente.IdSexo;
                    cli.IdEstadoCivil = cliente.IdEstadoCivil;

                    // Guardar cambios
                    context.SaveChanges();

                    return true;
                }

                return false;
            }
        }

        /*
         * Elimina un cliente usando su rut
         */
        public bool EliminarPorRut(string rut)
        {
            using (BeLifeEntities context = new BeLifeEntities())
            {
                // Buscar cliente
                Cliente cliente = context.Cliente.Find(rut);

                // Si se encuentra se elimina, se guarda y se retorna verdadero
                if (cliente is Cliente)
                {
                    context.Cliente.Remove(cliente);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
