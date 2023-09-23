using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public string RealizarAccionAntiHeroe(string accion)
        {
            return $"El antiheroe{Nombre} ha realizado la accion{accion}";
        }
    }
}
