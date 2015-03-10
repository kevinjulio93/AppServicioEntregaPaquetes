using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquetes.Modelo
{
    public class Package
    {

        #region "Atributos"
        private string codigo;
        private string nombre;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string cp_remitente;
        private string cp_destinatrario;
        public int peso;
        private int costo_gramos;
        private int valor_envio;
        #endregion
        
        #region "Propiedades"
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public String Departamento { get; set; }
        public String Cp_remitente { get; set; }
        public String Cp_destinatario { get; set; }
        public int Peso { get; set; }
        public int Costo_gramos { get; set; }
        public int Valor_envio { get; set; }
        #endregion   

        #region "Contructores"
        public Package()
        {

            this.codigo = "12345";
            this.nombre = "kevin julio";
            this.direccion = "universidad tecnologica de bolivar, km q via turbaco";
            this.ciudad= "cartagena";
            this.departamento= "bolivar";
            this.cp_remitente = "4-72";
            this.cp_destinatrario = "7-42";
            this.peso = 10;
            this.costo_gramos = 100;
            this.valor_envio = 0;
                

        }

        public Package(String codigo, String nombre, String direccion, String ciudad, String departamento, String cp_remitente, String cp_destinatario, int peso, int costo_gramos, int valor_envio)
        {

            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.departamento = departamento;
            this.cp_remitente = cp_remitente;
            this.cp_destinatrario = cp_destinatario;
            this.peso = peso;
            this.costo_gramos = costo_gramos;
            this.valor_envio = valor_envio;


        }
        #endregion

        #region "metodos"
        public int calculatecost()
        {

            valor_envio = (peso * 1000) * costo_gramos;
            return valor_envio;
        }
        #endregion

        #region "ToString"

        public override string ToString()
        {
            return "Codigo : " + codigo +
                    "\nNombre : " + nombre +
                    "\nDireccion : " + direccion +
                    "\nCiudad : " + ciudad +
                    "\nDepartamento : " + departamento +
                    "\nCodigo postal remitente : " + cp_remitente +
                    "\nCodigo postal destinatario : " + cp_destinatrario +
                    "\nPeso Paquete : " + peso +
                    "\nCosto por gramo : " + costo_gramos +
                    "\nValor total envio : " + calculatecost() + " \nse llevo e kilogramos a gramos para hallar el valor en gramos";
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion


    }

}