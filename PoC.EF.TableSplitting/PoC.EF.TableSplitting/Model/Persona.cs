using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.EF.TableSplitting.Model {

    [Table("Entes")]

    public class Persona {

        public Int64 Id { get; set; }
       
        public String DscPersona { get; set; }

        [ForeignKey("Id")]
        public virtual Ente Ente { get; set; }
    }
}
