using jromrez_Recup_Junio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromrez_Recup_Junio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        
        //metodo de seleccion usuario
        public int mostrarMenuSeleccion()
        {
            int opcionUsuario;

            Console.WriteLine("0.cerrar aplicación");
            Console.WriteLine("1.número de históricos");
            Console.WriteLine("2.alta nuevo propietario");
            Console.WriteLine("No escogio opcion correcta");
            opcionUsuario=Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        
    }
}
