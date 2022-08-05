using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependencyInjection
{
    internal class Comptable : IImpimante
    {
        public string Nom { get; set; }
        private IImpimante _imprimante;

        // Injection de dépendances par constructeur

        public Comptable( IImpimante imp)
        {
            Nom = "Simon";
            _imprimante = imp; 
        }

        public void ImprimerFicheDePaie(string reference)
        {
            string document = _imprimante.Imprimer(reference);
            Console.WriteLine($"{Nom} a imprimé la fiche de paie {document}");
        }

        public string Imprimer(string document)
        {
            throw new NotImplementedException();
        }
    }
}
