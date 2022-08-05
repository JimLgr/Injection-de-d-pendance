using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependencyInjection
{
    internal class ImprimanteLaserColor : IImpimante
    {
        public string Imprimer(string document)
        {
            return $"Impression du {document} en couleur avec une super haute résolution";
        }
    }

 
}
