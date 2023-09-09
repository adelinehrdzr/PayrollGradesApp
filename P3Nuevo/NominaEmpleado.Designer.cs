namespace P3Nuevo
{
    partial class NominaEmpleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NominaEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSalarioBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbAFP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbARS = new System.Windows.Forms.TextBox();
            this.txbISR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbsalneto = new System.Windows.Forms.TextBox();
            this.txbtotdesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbBuscarNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldonetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p3DataSet = new P3Nuevo.P3DataSet();
            this.nominaTableAdapter = new P3Nuevo.P3DataSetTableAdapters.NominaTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 550);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-40, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(303, 443);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(63, 65);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nuevo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(382, 425);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 96);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guardar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(453, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 112);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(534, 422);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 94);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(622, 443);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 65);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(714, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(702, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 71);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Location = new System.Drawing.Point(382, 52);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.Size = new System.Drawing.Size(127, 20);
            this.txbIDEmpleado.TabIndex = 13;
            this.txbIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDEmpleado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Empleado";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(382, 91);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(127, 20);
            this.txbNombre.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre";
            // 
            // txbSalarioBase
            // 
            this.txbSalarioBase.Location = new System.Drawing.Point(382, 130);
            this.txbSalarioBase.Name = "txbSalarioBase";
            this.txbSalarioBase.Size = new System.Drawing.Size(127, 20);
            this.txbSalarioBase.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Salario Base";
            // 
            // txbAFP
            // 
            this.txbAFP.Location = new System.Drawing.Point(382, 166);
            this.txbAFP.Name = "txbAFP";
            this.txbAFP.Size = new System.Drawing.Size(127, 20);
            this.txbAFP.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "AFP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "ARS";
            // 
            // txbARS
            // 
            this.txbARS.Location = new System.Drawing.Point(382, 199);
            this.txbARS.Name = "txbARS";
            this.txbARS.Size = new System.Drawing.Size(127, 20);
            this.txbARS.TabIndex = 22;
            // 
            // txbISR
            // 
            this.txbISR.Location = new System.Drawing.Point(382, 235);
            this.txbISR.Name = "txbISR";
            this.txbISR.Size = new System.Drawing.Size(127, 20);
            this.txbISR.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(338, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "ISR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(297, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Salario Neto";
            // 
            // txbsalneto
            // 
            this.txbsalneto.Location = new System.Drawing.Point(382, 307);
            this.txbsalneto.Name = "txbsalneto";
            this.txbsalneto.Size = new System.Drawing.Size(127, 20);
            this.txbsalneto.TabIndex = 27;
            // 
            // txbtotdesc
            // 
            this.txbtotdesc.Location = new System.Drawing.Point(382, 271);
            this.txbtotdesc.Name = "txbtotdesc";
            this.txbtotdesc.Size = new System.Drawing.Size(127, 20);
            this.txbtotdesc.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(269, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Total Descuentos";
            // 
            // txbBuscarNombre
            // 
            this.txbBuscarNombre.Location = new System.Drawing.Point(933, 34);
            this.txbBuscarNombre.Name = "txbBuscarNombre";
            this.txbBuscarNombre.Size = new System.Drawing.Size(338, 20);
            this.txbBuscarNombre.TabIndex = 29;
            this.txbBuscarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarNombre_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(881, 37);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codempDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.sueldobaseDataGridViewTextBoxColumn,
            this.afpDataGridViewTextBoxColumn,
            this.arsDataGridViewTextBoxColumn,
            this.isrDataGridViewTextBoxColumn,
            this.tdescDataGridViewTextBoxColumn,
            this.sueldonetoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nominaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(608, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(680, 254);
            this.dataGridView1.TabIndex = 31;
            // 
            // codempDataGridViewTextBoxColumn
            // 
            this.codempDataGridViewTextBoxColumn.DataPropertyName = "cod_emp";
            this.codempDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            this.codempDataGridViewTextBoxColumn.Name = "codempDataGridViewTextBoxColumn";
            this.codempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sueldobaseDataGridViewTextBoxColumn
            // 
            this.sueldobaseDataGridViewTextBoxColumn.DataPropertyName = "Sueldo_base";
            this.sueldobaseDataGridViewTextBoxColumn.HeaderText = "Sueldo Base";
            this.sueldobaseDataGridViewTextBoxColumn.Name = "sueldobaseDataGridViewTextBoxColumn";
            this.sueldobaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // afpDataGridViewTextBoxColumn
            // 
            this.afpDataGridViewTextBoxColumn.DataPropertyName = "Afp";
            this.afpDataGridViewTextBoxColumn.HeaderText = "AFP";
            this.afpDataGridViewTextBoxColumn.Name = "afpDataGridViewTextBoxColumn";
            this.afpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arsDataGridViewTextBoxColumn
            // 
            this.arsDataGridViewTextBoxColumn.DataPropertyName = "Ars";
            this.arsDataGridViewTextBoxColumn.HeaderText = "ARS";
            this.arsDataGridViewTextBoxColumn.Name = "arsDataGridViewTextBoxColumn";
            this.arsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isrDataGridViewTextBoxColumn
            // 
            this.isrDataGridViewTextBoxColumn.DataPropertyName = "Isr";
            this.isrDataGridViewTextBoxColumn.HeaderText = "ISR";
            this.isrDataGridViewTextBoxColumn.Name = "isrDataGridViewTextBoxColumn";
            this.isrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tdescDataGridViewTextBoxColumn
            // 
            this.tdescDataGridViewTextBoxColumn.DataPropertyName = "Tdesc";
            this.tdescDataGridViewTextBoxColumn.HeaderText = "T. Descuento";
            this.tdescDataGridViewTextBoxColumn.Name = "tdescDataGridViewTextBoxColumn";
            this.tdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sueldonetoDataGridViewTextBoxColumn
            // 
            this.sueldonetoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo_neto";
            this.sueldonetoDataGridViewTextBoxColumn.HeaderText = "Sueldo Neto";
            this.sueldonetoDataGridViewTextBoxColumn.Name = "sueldonetoDataGridViewTextBoxColumn";
            this.sueldonetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominaBindingSource
            // 
            this.nominaBindingSource.DataMember = "Nomina";
            this.nominaBindingSource.DataSource = this.p3DataSet;
            // 
            // p3DataSet
            // 
            this.p3DataSet.DataSetName = "P3DataSet";
            this.p3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominaTableAdapter
            // 
            this.nominaTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1165, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Imprimir Reporte";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1192, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 65);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NominaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbBuscarNombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbsalneto);
            this.Controls.Add(this.txbtotdesc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbISR);
            this.Controls.Add(this.txbARS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbAFP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbSalarioBase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NominaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.NominaEmpleado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbIDEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSalarioBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbAFP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbARS;
        private System.Windows.Forms.TextBox txbISR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbsalneto;
        private System.Windows.Forms.TextBox txbtotdesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbBuscarNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private P3DataSet p3DataSet;
        private System.Windows.Forms.BindingSource nominaBindingSource;
        private P3DataSetTableAdapters.NominaTableAdapter nominaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldonetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}

