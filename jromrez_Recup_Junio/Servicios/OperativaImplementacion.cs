using jromrez_Recup_Junio.Controladores;
using jromrez_Recup_Junio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromrez_Recup_Junio.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        //creacion metodo de historicos
        public void numeroHistoricos(List<PropietarioDto> listaVehiculos)
        {
            foreach(PropietarioDto esHistorico in listaVehiculos)
            {

                if(esHistorico.FchCompra > esHistorico.FchCompra + 25)
                {
                    Console.WriteLine("Su coche es historico");
                }
                else
                {
                    Console.WriteLine("Su coche no es historico");
                }
            }



        }

        //creacion alta nuevo usuario
        public void altanuevoPropietario(List<PropietarioDto> listaPropietarios)
        {

            PropietarioDto nuevoPropietario = new PropietarioDto();
            Console.WriteLine("Introduzca su dni");
            nuevoPropietario.Dni = Console.ReadLine();
            nuevoPropietario.autoincrementarID = Console.ReadLine();
            listaPropietarios.Add(nuevoPropietario);



        }

        //metodo para incrementar la id del propietario
        private static long autoincrementarID(List<PropietarioDto> propietario)
        {
            long nuevoId;
            int tamanioLista = propietario.Count;
            if (tamanioLista > 0)
            {
                nuevoId = propietario[tamanioLista - 1].Id + 1;

            }
            else
            {
                nuevoId = 0;
            }
            return nuevoId;


        }

        public void numeroHistoricos(List<VehiculoDto> listaVehiculos)
        {
            throw new NotImplementedException();
        }
    }   
}
