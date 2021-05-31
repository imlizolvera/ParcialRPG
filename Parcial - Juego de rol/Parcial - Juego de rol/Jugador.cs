using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Jugador
    {
        public string nombre
        {
            get; set;
        }

        public Unidades currentUnit { get; set; }
        public Unidades unitToAttack { get; set; }

        public Unidades unitToHeal { get; set; }

        public Equipo army
        {
            get; set;
        }


        //Procedimientos

        /// <summary>
        /// Create Army: create the list of soldiers (units).
        /// </summary>
        /// <param name="cantWiz"></param>
        /// <param name="cantArch"></param>
        /// <param name="cantBarba"></param>
        public void CreateArmy(int cantWiz, int cantArch, int cantBarba)
        {
            army = new Equipo(cantWiz, cantArch, cantBarba);

        }

        /// <summary>
        /// Menu for players to choose the action they want to do.
        /// </summary>
        /// <returns></returns>
        public int ChooseAction()
        {
            Console.WriteLine("What do you want to do? \n");
            Console.WriteLine("(1) Attack.  (2) Defense.  (3) Use Magic. (4) Heal a soldier. \n");
            //switch con case
            Console.WriteLine("Introduce a number: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
            
        }

        /// <summary>
        /// Players can choose the unit they want to use.
        /// </summary>
        public void ChooseUnit()
        {
            army.ShowArmy();
            Console.WriteLine("Which unit do you want to use? ");
            int unit = int.Parse(Console.ReadLine()) -1;
            currentUnit = army.GetUnit(unit);
        }

    }
}
