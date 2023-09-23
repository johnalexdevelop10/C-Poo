using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Models
{
class SuperHeroe : Heroe
{
    private string _Nombre;
    public int Id =1;
    public override string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreEIdentidaSecreta
        {
            get
            {
                return $"{Nombre}({IdentidadSecreta})";
            }
        }
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    public SuperHeroe()
    {
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach(var item in SuperPoderes)
        {
            sb.AppendLine($"{NombreEIdentidaSecreta} ESTA USANDO EL SUPER PODER {item.Nombre}");
        }
        return sb.ToString();
    }
        public override string salvarElMundo()
        {
            return $"{NombreEIdentidaSecreta} HA SALVADO EL MUNDO";
        }
    }

}
