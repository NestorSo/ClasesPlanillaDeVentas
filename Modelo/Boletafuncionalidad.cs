using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    partial class Boleta
    {
        //Metodos 
        public double DeterminarPrecio()
        {
            double precio = 0;
            switch (producto)
            {
                case "PS5 + 1 Mando": return precio = 500;

                case "PS4 + 1 Mando": return precio = 619;

                case "Mando PS5": return precio = 69;

                case "Mando PS4": return precio = 60;


            }
            return precio;

        }
        public double CalcularImporte()
        {

            double importe = 0;
            importe = DeterminarPrecio() * cantidad;

            return importe;
        }
    }
}
