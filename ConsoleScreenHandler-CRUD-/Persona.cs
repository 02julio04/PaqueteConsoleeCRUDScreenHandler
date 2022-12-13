using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackConsoleeCRUDScreenHandler
{
    public class Persona
    {
        public string Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public Persona()
        {

        }
        public Persona(string pid, string pnombre, string papellido, int pedad)
        {
            this.Id = pid;
            this.nombre = pnombre;
            this.apellido = papellido;
            this.edad = pedad;
        }

        
    }
}
