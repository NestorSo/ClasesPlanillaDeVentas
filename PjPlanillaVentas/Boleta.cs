using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjPlanillaVentas
{
    public  class Boleta
    {
        public  string? Cliente { get; set; }
        public  string? direcccion { get; set; }
        public  double Nboleta { get; set; }
        public  DateTime fechacompra { get; set; }

        public  string? nCedula { get; set; }
        public  string? producto { get; set; }
        public  int cantidad { get; set; }

        //Metodos 
        public  double DeterminarPrecio()
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
        public  double CalcularImporte()
        {

            double importe = 0;
            importe = DeterminarPrecio() * cantidad;

            return importe;
        }
    }
}
