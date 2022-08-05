// See https://aka.ms/new-console-template for more information

using DemoDependencyInjection;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection service = new ServiceCollection();

service.AddScoped<IImpimante, Imprimante>();
service.AddScoped<Secretaire>();
service.AddScoped<Comptable>();

ServiceProvider provider = service.BuildServiceProvider();


Secretaire s = provider.GetService<Secretaire>();
s.ImprimerUnBonDeCommande("Bon de commande 42");
s.ImprimerUnBonDeCommande("Bon de commande 55");

Comptable c = provider.GetService<Comptable>();
c.ImprimerFicheDePaie("511234");

