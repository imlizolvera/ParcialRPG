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

        //public Jugador(string nombre, int cantWiz, int cantArch, int cantBarba)
        //{
        //   this.nombre = nombre;
        //   army = new Equipo(cantWiz, cantArch, cantBarba);

        //}


        public Equipo army
        {
            get; set;
        }


        //Procedimientos
        public void CreateArmy(int cantWiz, int cantArch, int cantBarba)
        {
            army = new Equipo(cantWiz, cantArch, cantBarba);


        }

        public int ChooseAction()
        {
            Console.WriteLine("What do you want to do? \n");
            Console.WriteLine("(1) Attack.  (2) Defense.  (3) Use Magic. \n");
            //switch con case
            Console.WriteLine("Introduce a number: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
            
        }

        public void ChooseUnit()
        {
            army.ShowArmy();
            Console.WriteLine("Which unit do you want to use? ");
            int unit = int.Parse(Console.ReadLine()) -1;
            currentUnit = army.GetUnit(unit);
        }
        

        public void BonusAction()
        {

        }
    }
}
