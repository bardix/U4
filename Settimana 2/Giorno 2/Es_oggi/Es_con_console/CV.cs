using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_con_console
{
    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impiego> Impieghi { get; set; }
    }
}
