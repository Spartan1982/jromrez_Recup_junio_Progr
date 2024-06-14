using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromrez_Recup_Junio.Dtos
{
    internal class VehiculoDto
    { //atributos
        long id;
        string matricula = "aaaaaaa";
        string fchMatriculacion = "dd-MM-yyyy";
        //constructores
        public VehiculoDto(long id, string matricula, string fchMatriculacion)
        {
            this.id = id;
            this.matricula = matricula;
            this.fchMatriculacion = fchMatriculacion;
        }

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }
    }
}
