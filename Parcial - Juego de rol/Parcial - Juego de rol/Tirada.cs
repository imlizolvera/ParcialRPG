using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    static class Tirada
    {
        static public int Dados(int cantDados, int carasDados)
        {
            Random rnd = new Random();
            int dado = 0;
            for (int cantTiradas = 0; cantTiradas < cantDados; cantTiradas++)
            {
                dado = rnd.Next(1, carasDados + 1);
                
                
            }
            return dado;

        }

        
    }
}
