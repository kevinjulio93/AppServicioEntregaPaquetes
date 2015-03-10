using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    public class OvernightPackage : Package
    {

        private double costoNoche;

        public OvernightPackage(string codigo, string nombre, string direccion, string ciudad, string departamento, string cp_remitente, string cp_destinatario, int peso, int costo_gramo, int valor_envio, int costoNoche)
            : base(codigo, nombre, direccion, ciudad, departamento, cp_remitente, cp_destinatario,peso, costo_gramo, valor_envio)
        {
            this.costoNoche = costoNoche;
        }


        public int calculatecost()
        {
            return this.costoNoche * base.peso;
        }



    }
}