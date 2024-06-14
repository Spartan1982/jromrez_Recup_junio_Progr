using jromrez_Recup_Junio.Dtos;
using jromrez_Recup_Junio.Servicios;

namespace jromrez_Recup_Junio.Controladores
{

    class program
    {
        public static string rutaCarpetaLog = "C:\\Users\\Jaime\\Desktop\\Progamacion\\jromrez_Recup_Junio\\jromrez_Recup_Junio\\bin\\Debug\\Log\\";
        public static void Main(string[] args)
        {


            List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
            List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            int opcionUsuario;
            bool cerrarMenu=false;

            do
            {
                try
                {
                    opcionUsuario = mi.mostrarMenuSeleccion();
                    //creacion del menu
                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("cerrar aplicación");
                            break;
                        case 1:
                            Console.WriteLine("número de históricos");
                            oi.numeroHistoricos(listaVehiculos);
                            break;
                        case 2:
                            Console.WriteLine("alta nuevo propietario");
                            oi.altanuevoPropietario(listaPropietarios);
                            break;
                        default:
                            Console.WriteLine("No escogio opcion correcta");
                            break;

                    }


                }
                catch
                {

                } 





            } while (cerrarMenu);
        }
    }
}