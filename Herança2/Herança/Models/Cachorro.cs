using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Models
{
    public class Cachorro : Animal
    {
        public string Raca { get; set; }
        public string CorPelagem { get; set; }
        public int MyProperty { get; set; }
    }
}
