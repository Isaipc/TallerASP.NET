using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerASP.NET.AccesoDatos;
using TallerASP.NET.Entidades;

namespace TallerASP.NET
{
    public partial class CatalogoProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                fillProductosGrid();
            }
        }
        public void fillProductosGrid()
        {
            ProductoAccesoDatos productoAD = new ProductoAccesoDatos();
            ProductoEntidad productoE = new ProductoEntidad();
            productoE.id = "";
            
            ProductosGrid.DataSource = productoAD.selectProducto(productoE).Tables[0];
            ProductosGrid.DataBind();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            ProductoEntidad productoE = new ProductoEntidad();
            productoE.nombre = NombreBox.Text;
            productoE.precio = float.Parse(PrecioBox.Text);
            productoE.stock = int.Parse(StockBox.Text);
            productoE.id = IdProducto.Value;

            ProductoAccesoDatos productoAD = new ProductoAccesoDatos();

            if (productoE.id == "")
                productoAD.insertProducto(productoE);
            else
                productoAD.updateProducto(productoE);

            limpiar();
        }
        
        private void limpiar()
        {
            NombreBox.Text = "";
            PrecioBox.Text = "";
            StockBox.Text = "";
            IdProducto.Value = "";
            fillProductosGrid();
        }

        protected void LimpiarButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void ProductosGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Seleccionar")
            {
                int indice = int.Parse(e.CommandArgument.ToString());

                NombreBox.Text = ProductosGrid.DataKeys[indice]["nombre"].ToString();
                PrecioBox.Text = ProductosGrid.DataKeys[indice]["precio"].ToString();
                StockBox.Text = ProductosGrid.DataKeys[indice]["stock"].ToString();
                IdProducto.Value = ProductosGrid.DataKeys[indice]["id"].ToString();
            }
            else if(e.CommandName == "Eliminar")
            {
                int indice = int.Parse(e.CommandArgument.ToString());
                
                IdProducto.Value = ProductosGrid.DataKeys[indice]["id"].ToString();

                ProductoEntidad productoE = new ProductoEntidad();

                productoE.id = IdProducto.Value;

                ProductoAccesoDatos productoAD = new ProductoAccesoDatos();
                productoAD.deleteProducto(productoE);
                fillProductosGrid();
            }   
        }
    }
}