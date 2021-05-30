using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    enum eTipoMagia
    {
        agua, //no hace daño, baja la defensa
        fuego, //haga daño ignorando la armadura
        tierra //le hace daño y le saca la armadura

    }

    class Unidades
    {
        //Properties
        public int coeficienteDeDefensa = 0;
        protected int health = 100;
        public int Health
        {
            get { return health; }
            set
            {
                if (value <= 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        protected int mana = 70;
        public string special;

        //Variable para hacer como un trigger de que es <= 0 
        public bool isMoreThan2 = false;
        
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
        public void Attack(Unidades attackedUnit)
        {
             //* Primero, pedimos el dado
            //tirada de dados
            int damage = Tirada.Dados(2, 20);
            //Segundo, tomamos la unidad a atacar y le hacemos daño.
            //llamar recievedmg
            attackedUnit.RecieveDmg(damage);
            //Esto llama a la funcion de reciveDamage de la unidad que decidimos atacar,
            //* que luego tendra que calcular el daño recibido en base a la def.
            //Also:
            //? attackedUnit.RecieveDmg(Tirada.Dados(2,6));
            
        }

        public void Defense()
        {
            Console.WriteLine("Defense");
            //Aca lo que tengo que hacer es, cuando se presiona en defense, se agrega o reinicia
            //en dos el contador de defensa.

            //Seteo el contador en 0, ya que cada vez que se selecione esta accion, se debe reiniciar
            //el contador a 0 y luego desde el 
            contador = 0;
        }

        public void Magic(Unidades attackedUnit, eTipoMagia magic)
        {
            Console.WriteLine("Magic");
            switch (magic)
            {
                case eTipoMagia.agua: //no hace daño, baja la defensa
                    attackedUnit.coeficienteDeDefensa--;
                    mana -= 20;
                    //costo: 20 m
                    break;
                case eTipoMagia.fuego: //haga daño ignorando la armadura
                    int dmg = Tirada.Dados(1, 20);
                    attackedUnit.ImpactHealth(dmg);
                    mana -= 50;
                    //costo: 50 m
                    break;
                case eTipoMagia.tierra: //le hace daño y le saca la armadura
                    int damage = Tirada.Dados(1, 20);
                    attackedUnit.RecieveDmg(damage);
                    
                    mana -= 60;
                    //costo 30 m
                    break;
                default:
                    break;
            }

        }

        public virtual void SpecialAction()
        {

        }

        public void RecieveDmg(int dmg)
        {
            //llamar tirada de dados
            //hacer cuenta dice attack - dice defense(armor)
            //que el jugador reciba el damage
            coeficienteDeDefensa = isMoreThan2 ? 0:2; //esto es como hacer un if utilizando el bool
            //The conditional operator ?:, also known as the ternary conditional operator,
            //evaluates a Boolean expression and returns the result of one of the two expressions,
            //depending on whether the Boolean expression evaluates to true or false
            //syntax: condition ? consequent : alternative
            coeficienteDeDefensa += Tirada.Dados(2, 4);
            dmg -= coeficienteDeDefensa;
            ImpactHealth(dmg);
        }

        public void ImpactHealth(int dmg)
        {
            if (dmg <= 0)
            {
                Console.WriteLine("You don't recieve damage!");
            }
            else
            {
                Health -= dmg;
                Console.WriteLine("You recieve " + dmg + " of damage.");
                Console.WriteLine("Health points: " + health);
            }
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
                        Wizard wizard = new Wizard(120);
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
    