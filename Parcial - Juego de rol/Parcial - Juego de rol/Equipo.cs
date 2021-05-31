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

        /// <summary>
        /// Creates army, adding each kind of unit to one list.
        /// </summary>
        /// <param name="quantityWiz">quantity of wizards chosen</param>
        /// <param name="quantityArch">quantity of archers chosen</param>
        /// <param name="quantityBarba">quantity of barbarians chosen</param>
        public void CreateArmy(int quantityWiz, int quantityArch, int quantityBarba)
        {
            for (int i = 0; i < quantityWiz; i++)
            {
                army.Add(new Wizard(120));

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

        /// <summary>
        /// Remove units when their health is less or equal than 0.
        /// </summary>
        public void RemoveUnit()
        {
            //recorrer la lista
            for (int unit = 0; unit <= army.Count-1; unit++)
            {
                if (army[unit].Health <= 0)
                {
                    army.Remove(army[unit]);
                }
            }
            //cuando recorre, si un soldado tiene 0 de vida o menos, lo remueve de la lista
            //army.Remove(x);

        }

        /// <summary>
        /// Show army: units, class, health, mana.
        /// </summary>
        public void ShowArmy()
        {
            int contador = 1;
            foreach (var unidades in army)
            {
                Console.WriteLine(contador + " Unit " + unidades.ToString() + ". Health: " + unidades.HP + ". Mana: " + unidades.MP + ".\n");
                contador++;
            }

        }

        /// <summary>
        /// Calls units by index.
        /// </summary>
        /// <param name="index">unit's ID</param>
        /// <returns></returns>
        public Unidades GetUnit(int index)
        {
            return army[index];
        }

        /// <summary>
        /// Verification of the units' health.
        /// </summary>
        /// <returns></returns>
        public bool AreUnitsDead()
        {
            foreach (var unit in army)
            {
                if (unit.HP <= 0)
                {
                    return true;
                }
                
            }

            return false;
        }

    }
}
