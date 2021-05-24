using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Unidades
    {
        //Properties
        protected int health = 100;
        protected int mana = 70;
        public string special;

        //Variable para hacer como un trigger de que es <= 0 
        public bool isMoreThan2 = false;
        // hola
        private int _contador;

        public int contador
        {
            set
            {
                //Cuando le pongo valor: Fijarme que el valor no sea menor a 0
                if (value >= 2)
                {
                    //Si el valor es menor a 0, avisame! wacho
                     isMoreThan2 = true;
                    _contador = 1;
                }
                else
                {
                    //Si es mayor, asignale el valor a la variable privada. 
                    _contador = value;
                    isMoreThan2 = false;
                }

            }
            get
            {
                //cuando estoy leyendo el valor, devolver la variable privada
                return _contador;

            }
        }

        //Methods
        public int Attack(Unidades attackedUnit)
        {
            Tirada.Dados();
            Console.WriteLine("Attack");
            return 5;
        }

        public void Defense()
        {
            Console.WriteLine("Defense");
        }

        public int Magic(Unidades attackedUnit)
        {
            Console.WriteLine("Magic");

            return 5;
        }

        public virtual void SpecialAction()
        {

        }

        public void RecieveDmg(int dmg)
        {
            health-= dmg;
            Console.WriteLine("You recieve " + dmg + " of damage.");
            Console.WriteLine("Health points: " + health);
        }

        



        //Getters
        public float HP
        {
            get
            {
                return health;
            }
        }
        public float MP
        {

            get
            {
                return mana;
            }
        }

        

        static public void SelectClass(int contadorUnits)
        {
            for ( int i = 0; i < contadorUnits; i++)
            {
                System.Console.WriteLine("How many Wizards do you want in your army?");
                int numWiz = int.Parse(Console.ReadLine());
                if (numWiz > contadorUnits || i == contadorUnits)
                {
                    
                }
                else //esto es para crear las units con clases, vos qué decís?
                {
                    for(int n = 0; n < numWiz; n++)
                    {
                        Wizard wizard = new Wizard();
                    }
                }
                System.Console.WriteLine("How many Archer do you want in your army?");
                int numArch = int.Parse(Console.ReadLine());
                System.Console.WriteLine("How many Barbarians do you want in your army?");
                int numBarba = int.Parse(Console.ReadLine());

            }
        }
    }
}
    