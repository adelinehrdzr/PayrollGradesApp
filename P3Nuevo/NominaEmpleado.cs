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
    public partial class NominaEmpleado : Form
    {
        public NominaEmpleado()
        {
            InitializeComponent();
        }

        public DataTable llenar_grid()
        {
            using (SqlConnection connection = Conex.Conectar())
            {
                DataTable dt = new DataTable();
                string consulta = "SELECT * FROM Nomina ORDER BY cod_emp DESC";
                using (SqlCommand cmd = new SqlCommand(consulta, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Calificaciones calificacionesForm = new Calificaciones();
            calificacionesForm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal afp, ars, sb;
            decimal afpd = (decimal)(0.0291);
            decimal arsd = (decimal)(0.0304);
            sb = Convert.ToDecimal(txbSalarioBase.Text);

            afp = sb * afpd;
            ars = sb * arsd;
            txbAFP.Text = afp.ToString();
            txbARS.Text = ars.ToString();

            decimal pa = (decimal)(33384);
            decimal po = (decimal)(0.15);
            decimal isrd, tdd, sn, isr;
            if (sb > pa)
            {
                isrd = (sb - pa) * po;
            }
            else
            {
                isrd = 0;
            }
            tdd = afp + ars + isrd;
            sn = sb - tdd;

            txbISR.Text = isrd.ToString();
            txbtotdesc.Text = tdd.ToString();
            txbsalneto.Text = sn.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Incrementar
            Conex.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(max(Cast(cod_emp as int)),0)+1 FROM Nomina", Conex.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txbIDEmpleado.Text = dt.Rows[0][0].ToString();
            this.txbNombre.Focus();
            this.btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conex.Conectar();
            string insertar = "INSERT INTO Nomina (cod_emp, Nombre, Sueldo_base, Afp, Ars, Isr, Tdesc, Sueldo_neto)VALUES(@CODIGO,@NOMBRE,@SUELDOBASE,@AFP,@ARS,@ISR,@TDESC,@SUELDONETO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conex.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txbIDEmpleado.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txbNombre.Text);
            cmd1.Parameters.AddWithValue("@SUELDOBASE", txbSalarioBase.Text);
            cmd1.Parameters.AddWithValue("@AFP", txbAFP.Text);
            cmd1.Parameters.AddWithValue("@ARS", txbARS.Text);
            cmd1.Parameters.AddWithValue("@ISR", txbISR.Text);
            cmd1.Parameters.AddWithValue("@TDESC", txbtotdesc.Text);
            cmd1.Parameters.AddWithValue("@SUELDONETO", txbsalneto.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron guardados satisfactoriamente");
            dataGridView1.DataSource = llenar_grid();
        }

        private void NominaEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'p3DataSet.Nomina' Puede moverla o quitarla según sea necesario.
            this.nominaTableAdapter.Fill(this.p3DataSet.Nomina);

        }

        private void txbBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conex.Conectar();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM Nomina WHERE Nombre LIKE('" + txbBuscarNombre.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultar, Conex.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txbIDEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conex.Conectar();
                string cadsql = "SELECT * FROM Nomina WHERE cod_emp=" + txbIDEmpleado.Text + "";
                SqlCommand comando = new SqlCommand(cadsql, Conex.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txbNombre.Text = leer["Nombre"].ToString();
                    txbSalarioBase.Text = leer["Sueldo_base"].ToString();
                    txbAFP.Text = leer["Afp"].ToString();
                    txbARS.Text = leer["Ars"].ToString();
                    txbISR.Text = leer["Isr"].ToString();
                    txbtotdesc.Text = leer["Tdesc"].ToString();
                    txbsalneto.Text = leer["Sueldo_neto"].ToString();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Conex.Conectar();
            string query = "UPDATE Nomina SET Nombre='" + txbNombre.Text + "',Sueldo_base=" + txbSalarioBase.Text
                + ",Afp=" + txbAFP.Text + ",Ars=" + txbARS.Text + ", Isr=" + txbISR.Text + ",Tdesc=" + txbtotdesc.Text +
                ",Sueldo_neto=" + txbsalneto.Text + "WHERE cod_emp=" + txbIDEmpleado.Text + "";
            SqlCommand comando = new SqlCommand(query, Conex.Conectar());
            comando.ExecuteNonQuery();
            //datagridview1.DataSource=llenar_grid();
            MessageBox.Show("Los datos fueron actualizados satisfactoriamente.");

            dataGridView1.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea borrar el registro?", "Message",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conex.Conectar();
                string eliminar = "DELETE FROM Nomina WHERE cod_emp=@COD_EMP";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conex.Conectar());
                cmd3.Parameters.AddWithValue("@COD_EMP", txbIDEmpleado.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron borrados satisfactoriamente.");



                dataGridView1.DataSource = llenar_grid();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Usuarios usuariosForm = new Usuarios();
            usuariosForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteNominaForm reporte = new ReporteNominaForm();
            reporte.ShowDialog();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
