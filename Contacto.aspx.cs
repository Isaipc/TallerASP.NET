using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerASP.NET
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnviarButton_Click(object sender, EventArgs e)
        {
            MailMessage correo = new MailMessage();
            SmtpClient client = new SmtpClient();
            string direccion = "isaipolito6052@gmail.com";

            string cuerpo = File.ReadAllText(MapPath("/Email.html"));
            cuerpo = cuerpo.Replace("[nombre]", nombreBox.Text);
            cuerpo = cuerpo.Replace("[comentario]", comentarioBox.Text);

            //configuracion correo
            correo.From = new MailAddress(direccion, "Isai Polito Cansino");
            correo.Subject = "Taller ASP.NET";
            correo.Body = cuerpo;
            correo.IsBodyHtml = true;
            correo.To.Add(correoBox.Text.Trim());

            //configuracion cliente smtp
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;

            //client.Credentials = new NetworkCredential(direccion, "TuContraseña");
            #region Contraseña
            client.Credentials = new NetworkCredential(direccion, "ExoHaNd9428565");

            #endregion
            client.Send(correo);
        }
    }
}