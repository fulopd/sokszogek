using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Views
{
    public interface ISokszog
    {
        string oldalA { get; set; }
        string oldalB { get; set; }
        string Kerulet { get; set; }
        string Terulet { get; set; }
        IList<string> SokszogLista{ get; set; }

        




    }
}
