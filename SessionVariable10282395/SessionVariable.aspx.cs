using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVariable10282395
{
    public partial class SessionVariable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Session["ddlCategory"] = ddlCategory.Text;
            Session["ddlSupplier"] = ddlSupplier.Text;
            Session["strProduct"] = txtProduct.Text;
            Session["strDescription"] = TextBox1.Text;
            Session["strImage"] = txtImage.Text;
            Session["decPrice"] = txtPrice.Text;
            Session["byNumberInStock"] = txtNumberInStock.Text;
            Session["byNumberOnOrder"] = txtNumberOnOrder.Text;
            Session["byReorderLevel"] = txtRecorderLevel.Text;

            Response.Redirect("Consulta.aspx");
        }
    }
}