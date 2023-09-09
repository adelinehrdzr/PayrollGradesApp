using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3Nuevo
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        public DataTable llenar_grid()
        {
            using (SqlConnection connection = Conex.Conectar())
            {
                DataTable dt = new DataTable();
                string consulta = "SELECT * FROM Usuarios ORDER BY cod_usu DESC";
                using (SqlCommand cmd = new SqlCommand(consulta, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }
        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            NominaEmpleado nominaForm = new NominaEmpleado();
            nominaForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Calificaciones calificacionesForm = new Calificaciones();
            calificacionesForm.Show();
            this.Hide();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'p3DataSet2.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.p3DataSet2.Usuarios);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txbCodigo.Text== string.Empty)
            {
                MessageBox.Show("El Nombre no puede estar en blanco");
                this.txbCodigo.Focus();
            }

            else 
                if (txbClave.Text== string.Empty)
            {
                MessageBox.Show("La Clave no puede estar en blanco");
                this.txbClave.Focus();
            }
            else
            {
                if (txbClaveConfi.Text == string.Empty)
                {
                    MessageBox.Show("La confirmacion de la clave no puede estar en blanco");
                    this.txbClaveConfi.Focus();
                }
                //validar las claves que no coinciden

                if (txbClave.Text!= txbClaveConfi.Text)
                {
                    MessageBox.Show("Las claves no coinciden");
                    this.txbClave.Text = "";
                    this.txbClaveConfi.Text = "";
                    this.txbClave.Focus() ;

                }
                else
                {
                    //GUARDAR
                    Conex.Conectar();
                    string insertar = "INSERT INTO Usuarios(cod_usu,Nombre,Clave,Cel,Cor)VALUES(@COD_USU,@NOMBRE,@CLAVE,@CEL,@COR)";
                    SqlCommand cmd1= new SqlCommand(insertar,Conex.Conectar());
                    cmd1.Parameters.AddWithValue("@COD_USU",txbCodigo.Text);
                    cmd1.Parameters.AddWithValue("@NOMBRE", txbNombre.Text);
                    cmd1.Parameters.AddWithValue("@CLAVE", txbClave.Text);
                    cmd1.Parameters.AddWithValue("@CEL", txbCelular.Text);
                    cmd1.Parameters.AddWithValue("@COR", txbCorreo.Text);

                    cmd1.ExecuteNonQuery();
                    dataGridView1.DataSource=llenar_grid();
                    MessageBox.Show("Datos guardados satisfactoriamente");
                    this.btnGuardar.Enabled = false;


                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Incrementar
            Conex.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(max(Cast(cod_usu as int)),0)+1 FROM Usuarios", Conex.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txbCodigo.Text = dt.Rows[0][0].ToString();
            this.txbNombre.Focus();
            this.btnGuardar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el registro?", "Message",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conex.Conectar();
                string eliminar = "DELETE FROM Usuarios WHERE cod_usu=@COD_USU";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conex.Conectar());
                cmd3.Parameters.AddWithValue("@COD_USU", txbCodigo.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron borrados satisfactoriamente.");



                dataGridView1.DataSource = llenar_grid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Conex.Conectar();
            string query = "UPDATE Usuarios SET Nombre='" + txbNombre.Text + "',Clave=" + txbClave.Text
                + ",Cel=" + txbCelular.Text + ",Cor=" + txbCorreo.Text + "WHERE cod_usu=" + txbCodigo.Text + "";

            SqlCommand comando = new SqlCommand(query, Conex.Conectar());
            comando.ExecuteNonQuery();
           
            MessageBox.Show("Los datos fueron actualizados satisfactoriamente.");

            dataGridView1.DataSource = llenar_grid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
