using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependencyInjection
{
    internal class Secretaire
    {
        public string Nom { get; set; }

        private IImpimante _imprimante;

        public Secretaire(IImpimante imprimante)
        {
            Nom = "Simone";
            _imprimante = imprimante;
        }

        public void ImprimerUnBonDeCommande(string reference)
        {
            
            string document = _imprimante.Imprimer(reference);
            Console.WriteLine($"{Nom} a imprimer {document}");
        } 
        
    }
}
