using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Barbarian : Unidades
    {
        public void GetInRage()
        {

            Tirada.Dados(1, 4);

        }

        public override string ToString()
        {
            return "Barbarian";
        }
    }
}
