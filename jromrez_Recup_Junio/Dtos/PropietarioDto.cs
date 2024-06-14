using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromrez_Recup_Junio.Dtos
{
    internal class PropietarioDto
    {
        //atributos 
        internal string? autoincrementarID;
        long id;
        string dni = "aaaaaaaaa";
        string fchCompra = "dd-MM-yyyy";
        string matricula = "aaaaaaa";
        bool esHistorico = false;

        public PropietarioDto()
        {
        }
        //constructores
        public PropietarioDto(long id, string dni, string fchCompra, string matricula, bool esHistorico)
        {
            this.id = id;
            this.dni = dni;
            this.fchCompra = fchCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
        }

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }
    }
}
