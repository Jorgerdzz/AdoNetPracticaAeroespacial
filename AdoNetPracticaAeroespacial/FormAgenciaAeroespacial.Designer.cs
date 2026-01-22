namespace AdoNetPracticaAeroespacial
{
    partial class FormAgenciaAeroespacial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbNaves = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNaveId = new TextBox();
            txtModelo = new TextBox();
            txtCapacidad = new TextBox();
            txtEstado = new TextBox();
            btnInsertar = new Button();
            label6 = new Label();
            lstAstronautas = new ListBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            txtRango = new TextBox();
            label9 = new Label();
            txtFechaIngreso = new TextBox();
            label10 = new Label();
            txtSalario = new TextBox();
            label11 = new Label();
            txtBono = new TextBox();
            btnUpdate = new Button();
            label12 = new Label();
            txtNombre = new TextBox();
            label13 = new Label();
            txtPresupuesto = new TextBox();
            label14 = new Label();
            txtId = new TextBox();
            btnInsertarAstro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Naves";
            // 
            // cmbNaves
            // 
            cmbNaves.FormattingEnabled = true;
            cmbNaves.Location = new Point(51, 67);
            cmbNaves.Name = "cmbNaves";
            cmbNaves.Size = new Size(138, 28);
            cmbNaves.TabIndex = 1;
            cmbNaves.SelectedIndexChanged += cmbNaves_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 123);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Nave ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 240);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 304);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Capacidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 377);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Estado";
            // 
            // txtNaveId
            // 
            txtNaveId.Location = new Point(54, 146);
            txtNaveId.Name = "txtNaveId";
            txtNaveId.Size = new Size(125, 27);
            txtNaveId.TabIndex = 6;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(55, 263);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 7;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(55, 337);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(125, 27);
            txtCapacidad.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(55, 409);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 9;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(48, 465);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(142, 57);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar nave";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 33);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 11;
            label6.Text = "Astronautas";
            // 
            // lstAstronautas
            // 
            lstAstronautas.FormattingEnabled = true;
            lstAstronautas.Location = new Point(284, 67);
            lstAstronautas.Name = "lstAstronautas";
            lstAstronautas.Size = new Size(243, 344);
            lstAstronautas.TabIndex = 12;
            lstAstronautas.SelectedIndexChanged += lstAstronautas_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 36);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 13;
            label7.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(612, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(166, 27);
            txtApellido.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(612, 117);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 15;
            label8.Text = "Rango";
            // 
            // txtRango
            // 
            txtRango.Location = new Point(615, 149);
            txtRango.Name = "txtRango";
            txtRango.Size = new Size(163, 27);
            txtRango.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(615, 201);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 17;
            label9.Text = "Fecha ingreso";
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.Location = new Point(619, 233);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(158, 27);
            txtFechaIngreso.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(619, 282);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 19;
            label10.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(619, 312);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(158, 27);
            txtSalario.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(614, 361);
            label11.Name = "label11";
            label11.Size = new Size(119, 20);
            label11.TabIndex = 21;
            label11.Text = "Bono por mision";
            // 
            // txtBono
            // 
            txtBono.Location = new Point(620, 391);
            txtBono.Name = "txtBono";
            txtBono.Size = new Size(158, 27);
            txtBono.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(797, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 56);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Modificar astronauta";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 182);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 24;
            label12.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(55, 205);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(286, 435);
            label13.Name = "label13";
            label13.Size = new Size(202, 20);
            label13.TabIndex = 26;
            label13.Text = "Presupuesto total acumulado";
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(291, 468);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(197, 27);
            txtPresupuesto.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(615, 435);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 28;
            label14.Text = "Nave ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(620, 465);
            txtId.Name = "txtId";
            txtId.Size = new Size(158, 27);
            txtId.TabIndex = 29;
            // 
            // btnInsertarAstro
            // 
            btnInsertarAstro.Location = new Point(797, 287);
            btnInsertarAstro.Name = "btnInsertarAstro";
            btnInsertarAstro.Size = new Size(141, 52);
            btnInsertarAstro.TabIndex = 30;
            btnInsertarAstro.Text = "Insertar astronauta";
            btnInsertarAstro.UseVisualStyleBackColor = true;
            btnInsertarAstro.Click += btnInsertarAstro_Click;
            // 
            // FormAgenciaAeroespacial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 541);
            Controls.Add(btnInsertarAstro);
            Controls.Add(txtId);
            Controls.Add(label14);
            Controls.Add(txtPresupuesto);
            Controls.Add(label13);
            Controls.Add(txtNombre);
            Controls.Add(label12);
            Controls.Add(btnUpdate);
            Controls.Add(txtBono);
            Controls.Add(label11);
            Controls.Add(txtSalario);
            Controls.Add(label10);
            Controls.Add(txtFechaIngreso);
            Controls.Add(label9);
            Controls.Add(txtRango);
            Controls.Add(label8);
            Controls.Add(txtApellido);
            Controls.Add(label7);
            Controls.Add(lstAstronautas);
            Controls.Add(label6);
            Controls.Add(btnInsertar);
            Controls.Add(txtEstado);
            Controls.Add(txtCapacidad);
            Controls.Add(txtModelo);
            Controls.Add(txtNaveId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbNaves);
            Controls.Add(label1);
            Name = "FormAgenciaAeroespacial";
            Text = "FormAgenciaAeroespacial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbNaves;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNaveId;
        private TextBox txtModelo;
        private TextBox txtCapacidad;
        private TextBox txtEstado;
        private Button btnInsertar;
        private Label label6;
        private ListBox lstAstronautas;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private TextBox txtRango;
        private Label label9;
        private TextBox txtFechaIngreso;
        private Label label10;
        private TextBox txtSalario;
        private Label label11;
        private TextBox txtBono;
        private Button btnUpdate;
        private Label label12;
        private TextBox txtNombre;
        private Label label13;
        private TextBox txtPresupuesto;
        private Label label14;
        private TextBox txtId;
        private Button btnInsertarAstro;
    }
}