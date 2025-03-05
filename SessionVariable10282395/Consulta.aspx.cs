using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVariable10282395
{
    public partial class Consulta : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLookup_Click(object sender, EventArgs e)
        {
            ddlCategory.Text = Session["ddlCategory"].ToString();
            ddlSupplier.Text = Session["ddlSupplier"].ToString();
            txtProduct.Text = Session["strProduct"].ToString();
            Label10.Text = Session["strDescription"].ToString();
            lblImage.Text = Session["strImage"].ToString();
            Decimal decPrice =
                Convert.ToDecimal(Session["decPrice"]);
            lblPrice.Text = decPrice.ToString("C");
            lblNumberInStock.Text = Session["byNumberInStock"].ToString();
            lblNumberOnOrder.Text = Session["byNumberOnOrder"].ToString();
            lblReorderLevel.Text = Session["byReorderLevel"].ToString();
            //Compute and display the value in stock and the value on order.
            Byte byNumberInStock =
                Convert.ToByte(Session["byNumberInStock"]);
            Byte byNumberOnOrder =
                Convert.ToByte(Session["byNumberOnOrder"]);
            Decimal decValueInStock = decPrice * byNumberInStock;
            Decimal devValueOnOrder = decPrice * byNumberOnOrder;
            lblValueInStock.Text = decValueInStock.ToString("C");
            lblValueOnOrder.Text = decValueInStock.ToString("C");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}