using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.Entiteti
{
    public class Osiguranje
    {
        public virtual int brojPolice { get; set; }
        public virtual DateTime DatumIsteka { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual OsiguravajucaKuca Kuca { get; set; }
    }
}
