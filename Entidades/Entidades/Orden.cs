using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
  public  class Orden
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public int UsuarioId { get; set; }
        public int LocalizacionId { get; set; }
    }
}
