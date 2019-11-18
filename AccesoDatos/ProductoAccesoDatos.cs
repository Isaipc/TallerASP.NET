using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TallerASP.NET.Entidades;

namespace TallerASP.NET.AccesoDatos
{
    public class ProductoAccesoDatos
    {
        public string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Productos.BD"].ConnectionString;
        }


        /// <summary>
        /// Realiza el insert del producto
        /// </summary>
        /// <param name="producto"></param>
        public void insertProducto(ProductoEntidad producto)
        {
            DataSet productosDS = new DataSet();

            SqlConnection conexion = new SqlConnection(getConnectionString());
            SqlCommand comando;
            SqlDataAdapter sqlDataAdapter;
            SqlParameter parametro;

            try
            {
                comando = new SqlCommand("InsertProduct", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                parametro = new SqlParameter("nombre", SqlDbType.VarChar);
                parametro.Value = producto.nombre;
                comando.Parameters.Add(parametro);

                parametro = new SqlParameter("precio", SqlDbType.Float);
                parametro.Value = producto.precio;
                comando.Parameters.Add(parametro);

                parametro = new SqlParameter("stock", SqlDbType.Int);
                parametro.Value = producto.stock;
                comando.Parameters.Add(parametro);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch(SqlException sqle)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                    
            }
        }

        /// <summary>
        /// Realiza la edición de un producto
        /// </summary>
        /// <param name="producto"></param>
        public void updateProducto(ProductoEntidad producto)
        {
            DataSet productosDS = new DataSet();

            SqlConnection conexion = new SqlConnection(getConnectionString());
            SqlCommand comando;
            SqlDataAdapter sqlDataAdapter;
            SqlParameter parametro;

            try
            {
                comando = new SqlCommand("UpdateProduct", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                parametro = new SqlParameter("id", SqlDbType.VarChar);
                parametro.Value = producto.id;
                comando.Parameters.Add(parametro);

                parametro = new SqlParameter("nombre", SqlDbType.VarChar);
                parametro.Value = producto.nombre;
                comando.Parameters.Add(parametro);

                parametro = new SqlParameter("precio", SqlDbType.Float);
                parametro.Value = producto.precio;
                comando.Parameters.Add(parametro);

                parametro = new SqlParameter("stock", SqlDbType.Int);
                parametro.Value = producto.stock;
                comando.Parameters.Add(parametro);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch(SqlException sqle)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }


        /// <summary>
        /// Elimina un producto
        /// </summary>
        /// <param name="producto"></param>
        public void deleteProducto(ProductoEntidad producto)
        {
            DataSet productosDS = new DataSet();

            SqlConnection conexion = new SqlConnection(getConnectionString());
            SqlCommand comando;
            SqlDataAdapter sqlDataAdapter;
            SqlParameter parametro;


            try
            {
                comando = new SqlCommand("DeleteProduct", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                parametro = new SqlParameter("id", SqlDbType.VarChar);
                parametro.Value = producto.id;
                comando.Parameters.Add(parametro);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch(SqlException sqle)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        /// <summary>
        /// Obtener los productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public DataSet selectProducto(ProductoEntidad producto)
        {
            DataSet productosDS = new DataSet();

            SqlConnection conexion = new SqlConnection(getConnectionString());
            SqlCommand comando;
            SqlDataAdapter sqlDataAdapter;
            SqlParameter parametro;


            try
            {
                comando = new SqlCommand("SelectProduct", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                parametro = new SqlParameter("id", SqlDbType.VarChar);
                parametro.Value = producto.id;
                comando.Parameters.Add(parametro);

                sqlDataAdapter = new SqlDataAdapter(comando);
                conexion.Open();
                sqlDataAdapter.Fill(productosDS);


                conexion.Close();
            }
            catch (SqlException sqle)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return productosDS;
        }



    }
}