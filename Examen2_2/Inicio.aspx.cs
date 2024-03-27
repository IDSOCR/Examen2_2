using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Examen2_2
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Inicia el Botón de enviar
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EncuestasDBConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Encuestas (Nombre, Apellido, FechaNacimiento, Edad, Email, PoseeAutomovil) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Edad, @Email, @PoseeAutomovil)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre.Value);
                        cmd.Parameters.AddWithValue("@Apellido", apellido.Value);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Edad", Convert.ToInt32(edad.Value));
                        cmd.Parameters.AddWithValue("@Email", email.Value);
                        cmd.Parameters.AddWithValue("@PoseeAutomovil", poseeAutomovil.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    } // Cierra el bloque using de SqlCommand
                } // Cierra el bloque using de SqlConnection

                lblMensaje.Visible = true;
                lblMensaje.Text = "Los datos se han cargado correctamente.";
            } // Cierra el bloque try
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Ocurrió un error al cargar los datos: " + ex.Message;
            } // Cierra el bloque catch
        } // Cierra el método Button1_Click

        // Botón de Modificar
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EncuestasDBConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Accede directamente al valor del control numeroEncuesta
                    int numEncuesta = Convert.ToInt32(numeroEncuesta.Value);

                    string query = "UPDATE Encuestas SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, Edad = @Edad, Email = @Email, PoseeAutomovil = @PoseeAutomovil WHERE NumeroEncuesta = @NumeroEncuesta";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre.Value);
                        cmd.Parameters.AddWithValue("@Apellido", apellido.Value);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Edad", Convert.ToInt32(edad.Value));
                        cmd.Parameters.AddWithValue("@Email", email.Value);
                        cmd.Parameters.AddWithValue("@PoseeAutomovil", poseeAutomovil.Value);
                        cmd.Parameters.AddWithValue("@NumeroEncuesta", numEncuesta);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "La encuesta ha sido modificada correctamente.";
                        }
                        else
                        {
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "No se encontró la encuesta con el ID proporcionado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Ocurrió un error al modificar los datos: " + ex.Message;
            }

        } // Cierra el botón Modificar

        // Botón de Eliminar
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EncuestasDBConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Convertir el valor a int directamente desde el control
                    int numEncuesta = Convert.ToInt32(numeroEncuesta.Value);

                    string query = "DELETE FROM Encuestas WHERE NumeroEncuesta = @NumeroEncuesta";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NumeroEncuesta", numeroEncuesta);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "La encuesta ha sido eliminada correctamente.";
                        }
                        else
                        {
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "No se encontró la encuesta con el ID proporcionado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Ocurrió un error al eliminar los datos: " + ex.Message;
            }
        } // Cierra el botón eliminar



    } // Cierra la clase Inicio
} // Cierra el namespace Examen2_2
