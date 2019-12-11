using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heraca.Models.Conta
{
    class ContaCorrente : Conta
    {
        public int Rendimento { get; set; }
        public int QuantidadeCheques { get; set; }
    }
}
