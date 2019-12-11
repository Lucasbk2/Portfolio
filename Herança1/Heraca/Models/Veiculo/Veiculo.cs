using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heraca.Models.Veiculo
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public double VelocidadeMaxima { get; set; }
        public int QuantidadeRodas { get; set; }
        public bool Buzina { get; set; }
        public string Terreno { get; set; }
    }
}
