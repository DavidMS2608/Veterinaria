using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaModel.Entities
{
    public class Medico
    {
        public int Id { get; set; } //Campo obligatorio, es la clave primaria por defecto
        public string Nombre { get; set; } = string.Empty;
        public string Especialidad { get; set; } = string.Empty;
        public int Codigo { get; set; }
    }
}
