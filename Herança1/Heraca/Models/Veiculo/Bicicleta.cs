using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heraca.Models.Veiculo
{
    public class Bicicleta : Veiculo
    {
        public int Quadro { get; set; }
        public double Marcha { get; set; }
        public string Guidao { get; set; }
    }
}
