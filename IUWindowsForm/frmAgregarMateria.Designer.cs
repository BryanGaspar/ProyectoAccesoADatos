
namespace IUWindowsForm
{
    partial class frmAgregarMateria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNiv = new System.Windows.Forms.Label();
            this.lblNomMat = new System.Windows.Forms.Label();
            this.lblCodMat = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtCodMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbNiveles = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNiveles);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblCarrera);
            this.groupBox1.Controls.Add(this.lblNiv);
            this.groupBox1.Controls.Add(this.lblNomMat);
            this.groupBox1.Controls.Add(this.lblCodMat);
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Controls.Add(this.txtNombreMateria);
            this.groupBox1.Controls.Add(this.txtCodMateria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(36, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa los datos de la materia";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(560, 180);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(560, 133);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 34);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar Listado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(560, 87);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.ForeColor = System.Drawing.Color.Red;
            this.lblCarrera.Location = new System.Drawing.Point(263, 180);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(0, 13);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Visible = false;
            // 
            // lblNiv
            // 
            this.lblNiv.AutoSize = true;
            this.lblNiv.ForeColor = System.Drawing.Color.Red;
            this.lblNiv.Location = new System.Drawing.Point(263, 136);
            this.lblNiv.Name = "lblNiv";
            this.lblNiv.Size = new System.Drawing.Size(0, 13);
            this.lblNiv.TabIndex = 11;
            this.lblNiv.Visible = false;
            // 
            // lblNomMat
            // 
            this.lblNomMat.AutoSize = true;
            this.lblNomMat.ForeColor = System.Drawing.Color.Red;
            this.lblNomMat.Location = new System.Drawing.Point(263, 87);
            this.lblNomMat.Name = "lblNomMat";
            this.lblNomMat.Size = new System.Drawing.Size(0, 13);
            this.lblNomMat.TabIndex = 10;
            this.lblNomMat.Visible = false;
            // 
            // lblCodMat
            // 
            this.lblCodMat.AutoSize = true;
            this.lblCodMat.ForeColor = System.Drawing.Color.Red;
            this.lblCodMat.Location = new System.Drawing.Point(263, 53);
            this.lblCodMat.Name = "lblCodMat";
            this.lblCodMat.Size = new System.Drawing.Size(0, 13);
            this.lblCodMat.TabIndex = 9;
            this.lblCodMat.Visible = false;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(156, 173);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 8;
            this.txtCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrera_KeyPress);
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(156, 84);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMateria.TabIndex = 6;
            this.txtNombreMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMateria_KeyPress);
            // 
            // txtCodMateria
            // 
            this.txtCodMateria.Location = new System.Drawing.Point(156, 46);
            this.txtCodMateria.Name = "txtCodMateria";
            this.txtCodMateria.Size = new System.Drawing.Size(100, 20);
            this.txtCodMateria.TabIndex = 5;
            this.txtCodMateria.TextChanged += new System.EventHandler(this.txtCodMateria_TextChanged);
            this.txtCodMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodMateria_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nivel de la Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de la Materia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(560, 53);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbNiveles
            // 
            this.cmbNiveles.FormattingEnabled = true;
            this.cmbNiveles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNiveles.Location = new System.Drawing.Point(156, 136);
            this.cmbNiveles.Name = "cmbNiveles";
            this.cmbNiveles.Size = new System.Drawing.Size(100, 21);
            this.cmbNiveles.TabIndex = 16;
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgregarMateria";
            this.Text = "Menú Para Agregar Materia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtCodMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNiv;
        private System.Windows.Forms.Label lblNomMat;
        private System.Windows.Forms.Label lblCodMat;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbNiveles;
    }
}