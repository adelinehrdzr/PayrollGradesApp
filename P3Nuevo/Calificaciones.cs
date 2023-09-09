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
    public partial class Calificaciones : Form
    {
        public Calificaciones()
        {
            InitializeComponent();
        }

        public DataTable llenar_grid()
        {
            using (SqlConnection connection = Conex.Conectar())
            {
                DataTable dt = new DataTable();
                string consulta = "SELECT * FROM Calificaciones ORDER BY mat_est DESC";
                using (SqlCommand cmd = new SqlCommand(consulta, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }
        }
            private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NominaEmpleado nominaForm = new NominaEmpleado();
            nominaForm.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int poe, pf, ap, va, pef, nf;
            poe = int.Parse(txbPOE.Text);
            pf = int.Parse(txbPF.Text);
            ap = int.Parse(txbAP.Text);
            va = int.Parse(txbVA.Text);
            pef = int.Parse(txbPEF.Text);
            nf = poe + pf + ap + va + pef;

            if (nf >= 90)
            {
                txbNFinal.Text = nf.ToString();
                txbLiteral.Text = ("A");
                txbCondicion.Text = ("Aprobado");
            }
            else if (nf >= 80)
            {
                txbNFinal.Text = nf.ToString();
                txbLiteral.Text = ("B");
                txbCondicion.Text = ("Aprobado");
            }
            else if (nf >= 70)
            {
                txbNFinal.Text = nf.ToString();
                txbLiteral.Text = ("C");
                txbCondicion.Text = ("Aprobado");
            }
            else if (nf <= 60)
            {
                txbNFinal.Text = nf.ToString();
                txbLiteral.Text = ("F");
                txbCondicion.Text = ("Reprobado");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Incrementar
            Conex.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(max(Cast(mat_est as int)),0)+1 FROM Calificaciones", Conex.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txbIDEstudiante.Text = dt.Rows[0][0].ToString();
            this.txbNombre.Focus();
            this.btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conex.Conectar();
            string insertar = "INSERT INTO Calificaciones(mat_est, Nombre, Poe, Pf, Ap, Va, Pef, L, C,NFinal)VALUES(@IDESTUDIANTE,@NOMBRE,@POE,@PF,@AP,@VA,@PEF,@L,@C,@NFINAL)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conex.Conectar());
            cmd1.Parameters.AddWithValue("@IDESTUDIANTE", txbIDEstudiante.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txbNombre.Text);
            cmd1.Parameters.AddWithValue("@POE", txbPOE.Text);
            cmd1.Parameters.AddWithValue("@PF", txbPF.Text);
            cmd1.Parameters.AddWithValue("@AP", txbAP.Text);
            cmd1.Parameters.AddWithValue("@VA", txbVA.Text);
            cmd1.Parameters.AddWithValue("@PEF", txbPEF.Text);
            cmd1.Parameters.AddWithValue("@L", txbLiteral.Text);
            cmd1.Parameters.AddWithValue("@C", txbCondicion.Text);
            cmd1.Parameters.AddWithValue("@NFINAL", txbNFinal.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron guardados satisfactoriamente");

            dataGridView1.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el registro?", "Message",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conex.Conectar();
                string eliminar = "DELETE FROM Calificaciones WHERE mat_est=@IDESTUDIANTE";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conex.Conectar());
                cmd3.Parameters.AddWithValue("@IDESTUDIANTE", txbIDEstudiante.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron borrados satisfactoriamente.");



                dataGridView1.DataSource = llenar_grid();
            }
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'p3DataSet1.Calificaciones' Puede moverla o quitarla según sea necesario.
            this.calificacionesTableAdapter.Fill(this.p3DataSet1.Calificaciones);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Conex.Conectar();
            string query = "UPDATE Calificaciones SET Nombre='" + txbNombre.Text + "',Poe=" + txbPOE.Text
                + ",Pf=" + txbPF.Text + ",Ap=" + txbAP.Text + ", Va=" + txbVA.Text + ",Pef=" + txbPEF.Text +
                ",L=" + txbLiteral.Text + ",C=" + txbLiteral.Text + ",NFinal=" + txbNFinal.Text + "WHERE mat_est=" + txbIDEstudiante.Text + "";

            SqlCommand comando = new SqlCommand(query, Conex.Conectar());
            comando.ExecuteNonQuery();
            //mat_est, Nombre, Poe, Pf, Ap, Va, Pef, L, C,NFinal
            MessageBox.Show("Los datos fueron actualizados satisfactoriamente.");

            dataGridView1.DataSource = llenar_grid();
        }

        private void txbIDEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conex.Conectar();
                string cadsql = "SELECT * FROM Calificaciones WHERE mat_est=" + txbIDEstudiante.Text + "";
                SqlCommand comando = new SqlCommand(cadsql, Conex.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txbNombre.Text = leer["Nombre"].ToString();
                    txbNFinal.Text = leer["NFinal"].ToString();
                    txbLiteral.Text = leer["L"].ToString();
                    txbCondicion.Text = leer["C"].ToString();
                    txbPOE.Text = leer["Poe"].ToString();
                    txbPF.Text = leer["Pf"].ToString();
                    txbAP.Text = leer["Ap"].ToString();
                    txbVA.Text = leer["Va"].ToString();
                    txbPEF.Text = leer["Pef"].ToString();

                }
            }
        }

        private void txbBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conex.Conectar();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM Calificaciones WHERE Nombre LIKE('" + txbBuscarNombre.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultar, Conex.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Usuarios usuariosForm = new Usuarios();
            usuariosForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporteCalificaciones calificaciones = new FormReporteCalificaciones();
            calificaciones.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
