


using System.Text;
using SuperHero.Models;


var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear el el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneration = new SuperPoder();
regeneration.Nombre = "regeneration";
regeneration.Nivel = NivelPoder.NivelDos;

var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;




List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;//Propiedad para asignar
superman.UsarSuperPoderes();//metodo pa ejecutar
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.salvarElMundo();
Console.WriteLine(resultSalvarMundo);


var wolverine = new AntiHeroe();
wolverine.Id = 3;
wolverine.Nombre = "wolvey";
wolverine.IdentidadSecreta = "logan";
wolverine.PuedeVolar = true;


List<SuperPoder> poderesWolvire = new List<SuperPoder>();
poderesWolvire.Add(regeneration);
poderesWolvire.Add(superFuerza);
wolverine.SuperPoderes = poderesWolvire;
//wolverine.UsarSuperPoderes();//metodo pa ejecutar
string resultWolverinePoders = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoders);

string accionAntiHeroe = wolverine.RealizarAccionAntiHeroe("ataca la policia");
Console.WriteLine(accionAntiHeroe);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}