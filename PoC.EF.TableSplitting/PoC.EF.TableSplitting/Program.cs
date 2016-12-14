using PoC.EF.TableSplitting.Model;
using System.Linq;

namespace PoC.EF.TableSplitting {
    class Program {
        static void Main(string[] args) {
            var ctx = new GeneralDbContext();

            var entes = ctx.Entes.ToList();

            var choferes = ctx.Choferes.ToList();

            var personas = ctx.Personas.ToList();            
        }
    }
}
