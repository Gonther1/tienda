using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Pais:BaseEntity
    {
        public string Nombre { get; set;}
        public int IdpaisFk { get; set;}
        public ICollection<Departamento> Departamentos { get; set; }        
    }
}