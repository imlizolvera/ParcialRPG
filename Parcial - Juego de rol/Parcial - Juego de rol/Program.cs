using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>()
            {
                new Jugador(),
                new Jugador()
            };


            System.Console.WriteLine("Press START to continue..." + "\n");

            System.Console.WriteLine("\n \n \n                    START                   \n ");
            System.Console.ReadKey();
            
            

            for (int i = 0; i < 2; i++) //to do: int i = 1; i <= 2; i++
            {
                int aux = (i + 1);
                System.Console.WriteLine("Player " + aux +  ", introduce your name: "); // delete aux, replace with i
                jugadores[i].nombre = System.Console.ReadLine();
                System.Console.WriteLine("\n");
                

                System.Console.Clear();
            }


            //Creating Armies

            System.Console.WriteLine("\n \n \n                   GENERATING YOUR ARMIES                      \n \n \n");

            System.Console.WriteLine("How many units do you want in your armies?" + "\n");
            int cantUnidades = 0;
            System.Console.WriteLine("Introduce a number: " + "\n");
            cantUnidades = int.Parse(Console.ReadLine());

            System.Console.Clear();

            GenerateArmy(jugadores[0], cantUnidades);
            GenerateArmy(jugadores[1], cantUnidades);

            

            System.Console.Clear();

            System.Console.WriteLine(" \n \n \n NOW LET'S PLAY! \n \n \n");

            jugadores[0].army.ShowArmy();
            jugadores[1].army.ShowArmy();
            Console.Clear();
            //hacer que cada uno de los ejércitos vayan uno a la vez hasta que se queden sin ejercito.
            //cuando el jugador A se quede sin ejercito, gana jugador B
            //el jugador A se queda sin ejercito cuando la salud de todos los soldados llegue a 0

            //Sistema de turnos

            while(!jugadores[0].army.AreUnitsDead() | !jugadores[1].army.AreUnitsDead())
            {
                Turno(jugadores[0], jugadores[1]);
                Turno(jugadores[1], jugadores[0]);
                



            }

            if(jugadores[0].army.AreUnitsDead())
            {
                Console.WriteLine(jugadores[1].nombre + " WINS!");
            }
            else
            {
                Console.WriteLine(jugadores[0].nombre + " WINS!");
            }

            System.Console.ReadKey();

        }

        /// <summary>
        /// Generate Army asking for each class.
        /// </summary>
        /// <param name="jugador">Objeto que tiene equipo</param>
        /// <param name="cantUnidades">cantidad de unidades máx</param>
        private static void GenerateArmy(Jugador jugador, int cantUnidades)
        {
            //Player 1's army
            System.Console.WriteLine("\n \n \n" + "-" + jugador.nombre + "'s Army -" + "\n \n \n");

            ShowClass();


            int numWiz = 0;
            int numArch = 0;
            int numBarba = 0;
            while ((numWiz + numArch + numBarba) < cantUnidades)
            {
                System.Console.WriteLine("\n \n \n Now, it's time to choose your units. \n \n");
                System.Console.WriteLine("How many Wizards do you want in your army?");
                numWiz += int.Parse(Console.ReadLine());
                System.Console.WriteLine("How many Archer do you want in your army?");
                numArch += int.Parse(Console.ReadLine());
                System.Console.WriteLine("How many Barbarians do you want in your army?");
                numBarba += int.Parse(Console.ReadLine());

                if ((numWiz + numArch + numBarba) > cantUnidades)
                {
                    System.Console.WriteLine("The assigned number of units exceeds the maximum allowed, please re - enter the units");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    numWiz = 0;
                    numArch = 0;
                    numBarba = 0;
                    continue; //es redundante, cuando el if se termina, salta directamente al bucle.
                }
            }


            jugador.CreateArmy(numWiz, numArch, numBarba);
        }

        /// <summary>
        /// It shows classes' info
        /// </summary>
        private static void ShowClass()
        {
            System.Console.WriteLine("Let's decide your soldiers' classes! \n");
            System.Console.WriteLine("Here is a list of the classes, their abilities and properties.\n");
            System.Console.WriteLine("                     - Wizard -                   \n");
            System.Console.WriteLine("Abilities: \n");
            //System.Console.WriteLine("Cast spells: you will be to cast 3 different spells from the grimoire.");
            System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
            System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
            System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
            System.Console.WriteLine("Heal: you will get 1D6 to heal a soldier of your army.");
            //System.Console.WriteLine("Get Mana: you will be able to get 1D6 for extra mana every two turns.\n \n");

            System.Console.ReadKey();


            System.Console.WriteLine("                     - Archer -                   \n");
            System.Console.WriteLine("Abilities: \n");
            //System.Console.WriteLine("Shoot Arrows: you will be to shoot 3 arrows at the same time to 3 different enemies.");
            System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
            System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
            System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
            System.Console.WriteLine("Heal: you will get 1D6 to heal a soldier of your army.");
            //System.Console.WriteLine("Pick Up Arrows: you will be able to pick up your arrows afeter using them as a bonus action.\n \n");

            System.Console.ReadKey();

            System.Console.WriteLine("                     - Barbarian -                   \n");
            System.Console.WriteLine("Abilities: \n");
            System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
            System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
            System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
            System.Console.WriteLine("Heal: you will get 1D6 to heal a soldier of your army.");
            //System.Console.WriteLine("Get In Rage: as a bonus action, you will get a 1D4 extra to cause damage, you can use this every two turns.");


            System.Console.ReadKey();
            System.Console.Clear();
        }

        /// <summary>
        /// system of turns, calls a player and then another during the process of choosing attacked units and attacker units.
        /// </summary>
        /// <param name="jugador1">player playing its turn</param>
        /// <param name="jugador2">the enemy</param>
        private static void Turno(Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine("Turno de " + jugador1.nombre + "\n");
            jugador1.army.RemoveUnit();
            jugador2.army.RemoveUnit();
            jugador1.ChooseUnit();


            //preguntar qué unidad quiere usar
            //preguntar qué acción quiere hacer
            //preguntar qué unidad quiere atacar/defender/Usar magia en
            //hacer que eso pase - función donde pregunte por el daño de esa currentUnit


            switch (jugador1.ChooseAction())
            {
                case 1:
                    //falta trabajar en el método y dado
                    Console.WriteLine("Which unit do you want to attack?");
                    jugador2.army.ShowArmy();
                    Console.WriteLine(" \n\n Introduce a number: ");
                    int unitToAttack = int.Parse(Console.ReadLine());
                    jugador2.unitToAttack = jugador2.army.GetUnit(unitToAttack - 1);
                    jugador1.currentUnit.Attack(jugador2.unitToAttack);
                    
                    break;

                case 2:
                    //Durante su turno y hasta el próximo turno el guerrero tiene un bonus de 2x a su tirada de salvación(a su escudo).

                    Console.WriteLine("You obtain x2 in your armor during this turn");
                    jugador1.currentUnit.Defense();

                    break;
                
                case 3:
                    //falta trabajar en los hechizos y el método
                    //agregar para elegir un hechizo o bien meterlo en el mismo método
                    Console.WriteLine("Which unit do you want to attack? ");
                    jugador2.army.ShowArmy();
                    unitToAttack = int.Parse(Console.ReadLine());
                    jugador2.unitToAttack = jugador2.army.GetUnit(unitToAttack -1);
                    Console.WriteLine("Which spell do you want to use?");
                    MenuMagic();
                    Console.WriteLine("Introduce a number: ");
                    int magicType = int.Parse(Console.ReadLine());
                    jugador1.currentUnit.Magic(jugador2.unitToAttack, (eTipoMagia)magicType-1);


                    break;

                case 4:
                    Console.WriteLine("Which unit do you want to heal?");
                    jugador1.army.ShowArmy();
                    int unitToHeal = int.Parse(Console.ReadLine());
                    jugador1.unitToHeal = jugador1.army.GetUnit(unitToHeal - 1);
                    jugador1.currentUnit.Heal(jugador1.unitToHeal);

                    break;

                    //bonus action acá abajo
            }
            
            Console.WriteLine("\n \n Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

            
        }

        /// <summary>
        /// Menu of magic spells
        /// </summary>
        static public void MenuMagic()
        {
            Console.WriteLine("(1) Water: no damage, reduce defense (-1) forever. Cost: 20M. ");
            Console.WriteLine("(2) Fire: 1D20 of damage ignoring defense. Cost: 50M.");
            Console.WriteLine("(3) Earth: 1D20 of damage, reduce damage to 0 forever. Cost: 60M.\n");
        }


    }
}
