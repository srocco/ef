using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.EF.TableSplitting.Model {

    [Table("Entes")]
    public class Ente {

        public Int64 Id { get; set; }

        public String Name { get; set; }

        public String DscEnte { get; set; }
        
        public int TipoEnte { get; set; }
               
        public virtual Persona Persona{ get; set; }

        public virtual Chofer Chofer { get; set; }
    }
}
