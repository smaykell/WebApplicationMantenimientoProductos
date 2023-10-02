using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationMantenimientoProductos.Controllers
{
	public class GestionaDatos
	{
		static SqlConnection conn;
		public static SqlConnection conectar()
		{
			try
			{

				var connStringBuilder = new SqlConnectionStringBuilder();
				connStringBuilder.DataSource = "localhost";
				connStringBuilder.InitialCatalog = "Northwind";
				connStringBuilder.UserID = "sa";
				connStringBuilder.Password = "Password123";	
				

				conn = new SqlConnection();
				conn.ConnectionString = connStringBuilder.ConnectionString;
				conn.Open();
				
				return conn;
			}
			catch (SqlException ex)
			{
				return null;
			}

		}
	}
}