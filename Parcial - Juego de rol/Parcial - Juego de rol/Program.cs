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
            
            ////Player's names
            //string nameP1;
            //string nameP2;
            //System.Console.WriteLine("Player 1, introduce your name: ");
            //nameP1 = System.Console.ReadLine();
            //System.Console.WriteLine("\n");


            //System.Console.Clear();

            //System.Console.WriteLine("Player 2, introduce your name: ");
            //nameP2 = System.Console.ReadLine();
            //System.Console.WriteLine("\n");

            //System.Console.Clear();
            
            //Equipo army2 = new Equipo(cantUnidades);
            //army2.ShowArmy();

            Console.Clear();
            
            //Player 1's army
            System.Console.WriteLine("\n \n \n" + "-" + jugadores[0].nombre + "'s Army -" + "\n \n \n");

            System.Console.WriteLine("Let's decide your soldiers' classes! \n");
            System.Console.WriteLine("Here is a list of the classes, their abilities and properties.\n");
            System.Console.WriteLine("                     - Wizard -                   \n");
            System.Console.WriteLine("Abilities: \n");
            System.Console.WriteLine("Cast spells: you will be to cast 3 different spells from the grimoire.");
            System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
            System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
            System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
            System.Console.WriteLine("Get Mana: you will be able to get 1D6 for extra mana every two turns.\n \n");

            System.Console.ReadKey();


            System.Console.WriteLine("                     - Archer -                   \n");
            System.Console.WriteLine("Abilities: \n");
            System.Console.WriteLine("Shoot Arrows: you will be to shoot 3 arrows at the same time to 3 different enemies.");
            System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
            System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
            System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
            System.Console.WriteLine("Pick Up Arrows: you will be able to pick up your arrows afeter using them as a bonus action.\n \n");

            System.Console.ReadKey();

            System.Console.WriteLine("                     - Barbarian -                   \n");
            System.Console.WriteLine("Abilities: \n");
            System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
            System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
            System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
            System.Console.WriteLine("Get In Rage: as a bonus action, you will get a 1D4 extra to cause damage, you can use this every two turns.");


            System.Console.ReadKey();
            System.Console.Clear();

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

           
            jugadores[0].CreateArmy(numWiz, numArch, numBarba);


            //Player 2's army
            System.Console.WriteLine("\n \n \n" + "-" + jugadores[1].nombre + "'s Army -" + "\n \n \n");
            System.Console.WriteLine("Do you want to see the list of classes again or are you ready to create your army?");
            System.Console.WriteLine("1) I want to see the list again.             2) Let's create my army.");
            System.Console.WriteLine("Press 1 or 2 to select the option: ");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                System.Console.WriteLine("Let's decide your soldiers' classes! \n");
                System.Console.WriteLine("Here is a list of the classes, their abilities and properties.\n");
                System.Console.WriteLine("                     - Wizard -                   \n");
                System.Console.WriteLine("Abilities: \n");
                System.Console.WriteLine("Cast spells: you will be to cast 3 different spells from the grimoire.");
                System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
                System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
                System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
                System.Console.WriteLine("Get Mana: you will be able to get 1D6 for extra mana every two turns.\n \n");

                System.Console.ReadKey();


                System.Console.WriteLine("                     - Archer -                   \n");
                System.Console.WriteLine("Abilities: \n");
                System.Console.WriteLine("Shoot Arrows: you will be to shoot 3 arrows at the same time to 3 different enemies.");
                System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
                System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
                System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
                System.Console.WriteLine("Pick Up Arrows: you will be able to pick up your arrows afeter using them as a bonus action.\n \n");

                System.Console.ReadKey();

                System.Console.WriteLine("                     - Barbarian -                   \n");
                System.Console.WriteLine("Abilities: \n");
                System.Console.WriteLine("Attack with a weapon: you will be able to attack with your weapon.");
                System.Console.WriteLine("Use Magic: you will be able to use 3 different cantrips.");
                System.Console.WriteLine("Defense: you will get a bonus X2 for your defense dice during two turns.");
                System.Console.WriteLine("Get In Rage: as a bonus action, you will get a 1D4 extra to cause damage, you can use this every two turns.");


                System.Console.ReadKey();
                System.Console.Clear();
            }

            else if (answer == 2)
            {
                System.Console.WriteLine("Great, let's do it! \n \n \n");
            }

            int numWiz2 = 0;
            int numArch2 = 0;
            int numBarba2 = 0;
            while ((numWiz2 + numArch2 + numBarba2) < cantUnidades)
            {
                System.Console.WriteLine("\n \n \n Now, it's time to choose your units. \n \n");
                System.Console.WriteLine("How many Wizards do you want in your army?");
                numWiz2 += int.Parse(Console.ReadLine());
                System.Console.WriteLine("How many Archer do you want in your army?");
                numArch2 += int.Parse(Console.ReadLine());
                System.Console.WriteLine("How many Barbarians do you want in your army?");
                numBarba2 += int.Parse(Console.ReadLine());

                if ((numWiz2 + numArch2 + numBarba2) > cantUnidades)
                {
                    System.Console.WriteLine("The assigned number of units exceeds the maximum allowed, please re - enter the units");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    numWiz2 = 0;
                    numArch2 = 0;
                    numBarba2 = 0;
                    continue;
                }
            }

            jugadores[1].CreateArmy(numWiz, numArch, numBarba);

            System.Console.Clear();

            System.Console.WriteLine(" \n \n \n NOW LET'S PLAY! \n \n \n");

            jugadores[0].army.ShowArmy();
            jugadores[1].army.ShowArmy();
            Console.Clear();
            //hacer que cada uno de los ejércitos vayan uno a la vez hasta que se queden sin ejercito.
            //cuando el jugador A se quede sin ejercito, gana jugador B
            //el jugador A se queda sin ejercito cuando la salud de todos los soldados llegue a 0

            //Sistema de turnos

            while(!jugadores[0].army.AreUnitsDead() || !jugadores[1].army.AreUnitsDead())
            {
                Console.WriteLine("Turno de " + jugadores[0].nombre + "\n");

                jugadores[0].ChooseUnit();
                

                //preguntar qué unidad quiere usar
                //preguntar qué acción quiere hacer
                //preguntar qué unidad quiere atacar/defender/Usar magia en
                //hacer que eso pase - función donde pregunte por el daño de esa currentUnit

                switch (jugadores[0].ChooseAction())
                {
                    case 1:
                        
                        Console.WriteLine("Which unit do you want to attack?");
                        jugadores[1].army.ShowArmy();
                        Console.WriteLine(" \n\n Introduce a number: ");
                        int unitToAttack = int.Parse(Console.ReadLine());
                        jugadores[1].unitToAttack = jugadores[1].army.GetUnit(unitToAttack);
                        jugadores[0].currentUnit.Attack(jugadores[1].unitToAttack);
                        
                        break;

                    case 2:
                        //Durante su turno y hasta el próximo turno el guerrero tiene un bonus de 2x a su tirada de salvación(a su escudo).

                        Console.WriteLine("You obtain x2 in your armor during this turn");


                        break;
                    case 3:
                        Console.WriteLine("Which unit do you want to attack? ");
                        unitToAttack = int.Parse(Console.ReadLine());
                        jugadores[1].unitToAttack = jugadores[1].army.GetUnit(unitToAttack);
                        jugadores[0].currentUnit.Magic(jugadores[1].unitToAttack);


                        break;

                }



            }

            if(jugadores[0].army.AreUnitsDead())
            {
                Console.WriteLine(jugadores[1].nombre + "WINS!");
            }
            else
            {
                Console.WriteLine(jugadores[0].nombre + "WINS!");
            }

            System.Console.ReadKey();

        }
        static public void Menu()
        {
            Console.WriteLine("(1) Attack.  (2) Defense.  (3) Use Magic.  (4) Special Ability. \n");
            

        }
        



    }
}
