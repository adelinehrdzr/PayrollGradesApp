using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace P3Nuevo
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "USUARIO")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if(txbUsuario.Text == "")
            {
                txbUsuario.Text = "USUARIO";
                txbUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txbClave_Enter(object sender, EventArgs e)
        {
            if (txbClave.Text == "CONTRASEÑA")
            {
                txbClave.Text = "";
                txbClave.ForeColor = Color.LightGray;
                txbClave.UseSystemPasswordChar= true;
            }
        }

        private void txbClave_Leave(object sender, EventArgs e)
        {
            if (txbClave.Text == "")
            {
                txbClave.Text = "CONTRASEÑA";
                txbClave.ForeColor = Color.DimGray;
                txbClave.UseSystemPasswordChar = false;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
           btnAcceder.Focus();

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Conex.Conectar();
            String consulta = "SELECT * FROM Usuarios WHERE Nombre= '" + txbUsuario.Text + "' AND Clave='" + txbClave.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, Conex.Conectar());
            SqlDataReader lector;
            lector= comando.ExecuteReader();
            if (lector.HasRows== true)
            {
                MessageBox.Show("Bienvenido al sistema");
                NominaEmpleado frm= new NominaEmpleado();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrecta");
                this.txbUsuario.Text = "USUARIO";
                this.txbClave.Text = "CONTRASEÑA";
                this.txbUsuario.Focus();


            }
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
