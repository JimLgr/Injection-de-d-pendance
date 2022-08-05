using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependencyInjection
{
    internal class Imprimante : IImpimante // service 
    {
        public string Imprimer(string nomDudocument)
        {
            return $"Document {nomDudocument} imprimé le {DateTime.Now}";
        }
    }
}
