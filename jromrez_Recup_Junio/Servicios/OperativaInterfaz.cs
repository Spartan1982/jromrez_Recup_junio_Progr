using jromrez_Recup_Junio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromrez_Recup_Junio.Servicios
{
    internal interface OperativaInterfaz
    {
        void altanuevoPropietario(List<PropietarioDto> listaPropietarios);
        void numeroHistoricos(List<VehiculoDto> listaVehiculos);
    }
}
