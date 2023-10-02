using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationMantenimientoProductos.Controllers;

namespace WebApplicationMantenimientoProductos
{
	public partial class MantenimientoProducto : System.Web.UI.Page
	{

		SqlConnection conn;
		
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void Btn_Consultar_Click(object sender, EventArgs e)
		{
			
			try
			{
				var productoId = int.Parse(Txt_ProductoId.Text);
				
				conn = GestionaDatos.conectar();

				
				var cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandText = "SELECT * FROM Products WHERE ProductID = @productoId";

				var param = new SqlParameter();
				param.ParameterName = "@productoId";
				param.Value = productoId;
				cmd.Parameters.Add(param);

				var reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					Txt_Nombre.Text = reader["ProductName"].ToString();
					Txt_Precio.Text = reader["UnitPrice"].ToString();
					Lbl_Mensaje.Text = "Producto encontrado";

					var discontinued = bool.Parse(reader["Discontinued"].ToString());

					if (discontinued)
					{
						Btn_Descontinuar.Visible = false;
						Btn_Modificar.Visible = false;
						Btn_Grabar.Visible = false;
					}
					else
					{
						Btn_Descontinuar.Visible = true;
						Btn_Modificar.Visible = true;
						Btn_Grabar.Visible = true;
					}
				}
				else
				{
					Txt_Nombre.Text = "";
					Txt_Precio.Text = "";
					Lbl_Mensaje.Text = "No se encontró el producto";
				}

			}
			catch (SqlException ex)
			{
				Lbl_Mensaje.Text = "Error al consultar el producto " + ex.Message;
			}

		}

		protected void Btn_Agregar_Click(object sender, EventArgs e)
		{
			Txt_ProductoId.Text = "";
			Txt_ProductoId.Enabled = false;
			Txt_Nombre.Text = "";
			Txt_Precio.Text = "";
			Lbl_Mensaje.Text = "";
			Btn_Descontinuar.Visible = false;
			Btn_Modificar.Visible = false;
			Btn_Grabar.Visible = true;
		}

		protected void Btn_Grabar_Click(object sender, EventArgs e)
		{
			var productName = Txt_Nombre.Text;
			var unitPrice = decimal.Parse(Txt_Precio.Text);

			try
			{
				conn = GestionaDatos.conectar();

				var cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandText = "INSERT INTO Products (ProductName, UnitPrice) VALUES (@productName, @unitPrice)";

				var param = new SqlParameter();
				param.ParameterName = "@productName";
				param.Value = productName;
				cmd.Parameters.Add(param);

				param = new SqlParameter();
				param.ParameterName = "@unitPrice";
				param.Value = unitPrice;
				cmd.Parameters.Add(param);

				cmd.ExecuteNonQuery();

				Lbl_Mensaje.Text = "Producto agregado";

				Txt_ProductoId.Enabled = true;
				
			}
			catch (SqlException ex)
			{
				Lbl_Mensaje.Text = "Error al agregar el producto " + ex.Message;
			}
		}
	}
}