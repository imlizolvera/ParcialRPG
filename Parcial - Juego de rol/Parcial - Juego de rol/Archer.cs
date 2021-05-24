using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial___Juego_de_rol
{
    class Archer : Unidades
    {
        //Propiedades
        private int cantidadFlechas = 50;
        private int cantidadFlechasInicial = 50;

        //Methods
        public void ShootArrows()
        {
            cantidadFlechas--;
        }
        public void PickUpArrows()
        {
            cantidadFlechas += cantidadFlechasInicial;
            Console.WriteLine(cantidadFlechas);
        }

        public void MenuArch()
        {
            Console.WriteLine("(1) Shoot Arrows. \n");


        }

        public override string ToString()
        {
            return "Archer";
        }
    }
}

