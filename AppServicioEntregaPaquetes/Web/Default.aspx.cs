using AppServicioEntregaPaquetes.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppServicioEntregaPaquetes.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Package p = new Package();

            Label1.Text = p.ToString().Replace("\n","<br>");
        }
    }
}