using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Wizard : Unidades
    {
        public Wizard(int mana)
        {
            mana = 120;
        }
        

        //Methods
        public void GetMana()
        {
            Console.WriteLine("You get a 1d6 for extra mana!");
            int manaExtra;
            Random rnd = new Random();
            manaExtra = rnd.Next(1, 7);
            
            
        }

        public void CastSpell()
        {

        }

        public override string ToString()
        {
            return "Wizard";
        }

        //hechizos



    }

}
