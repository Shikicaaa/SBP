using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class OsiguravajucaKuca
    {
        public virtual int BrojKuce { get; set; }
        public virtual string Naziv {  get; set; }
        public virtual IList<Osiguranje> Polise { get; set; }
        
        public OsiguravajucaKuca()
        {
            Polise = new List<Osiguranje>();
        }
    }
}
