using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Equipo
    {
        int cantMax;

        //creo las tres listas

        public List<Unidades> army = new List<Unidades>();
        

        /// <summary>
        /// constructor de Unidades de Equipo
        /// </summary>
        /// <param name="maxQuantity"> cant max de unidades </param>
        /// <param name="quantityWiz"> cant Wizard</param>
        /// <param name="quantityArch"> cant Archer </param>
        /// <param name="quantityBarba"> cant Barbarian </param>
        public Equipo(int quantityWiz, int quantityArch, int quantityBarba)
        {

            CreateArmy(quantityWiz, quantityArch, quantityBarba);

        }

        public void CreateArmy(int quantityWiz, int quantityArch, int quantityBarba)
        {
            for (int i = 0; i < quantityWiz; i++)
            {
                army.Add(new Wizard());

            }

            for (int i = 0; i < quantityArch; i++)
            {
                army.Add(new Archer());

            }

            for (int i = 0; i < quantityBarba; i++)
            {
                army.Add(new Barbarian());

            }
        }


        public void ShowArmy()
        {
            int contador = 1;
            foreach (var unidades in army)
            {
                Console.WriteLine(contador + " Unit " + unidades.ToString() + " Health: " + unidades.HP);
                contador++;
            }

        }

        public Unidades GetUnit(int index)
        {
            return army[index];
        }

        public bool AreUnitsDead()
        {
            foreach (var unit in army)
            {
                if (unit.HP > 0)
                {
                    return true;
                }
                
            }

            return false;
        }

        public void Turno()
        {
            Console.WriteLine("Unidad");
            Program.Menu();
        }

        static public void GetList()
        {


        }


    }
}
