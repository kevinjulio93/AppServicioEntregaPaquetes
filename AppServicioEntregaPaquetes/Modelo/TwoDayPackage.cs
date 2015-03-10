using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    public class TwoDayPackage : Package
    {
        private int cuotaFijaCargoEnvio;

        public TwoDayPackage(string codigo, string nombre, string direccion, string ciudad, string departamento, string cp_remitente, string cp_destinatario, int peso, int costo_gramo, int valor_envio)
            : base(codigo, nombre, direccion, ciudad, departamento, cp_remitente, cp_destinatario,peso, costo_gramo, valor_envio)
       
        {
            this.cuotaFijaCargoEnvio = valor_envio;
        }


        public int calculateCost()
        {
            return base.calculatecost()+ this.cuotaFijaCargoEnvio;
        }
    


    }
}