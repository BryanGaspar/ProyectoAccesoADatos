
namespace IUWindowsForm
{
    partial class frmMenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarMat = new System.Windows.Forms.Button();
            this.btnListEstu = new System.Windows.Forms.Button();
            this.btnListMat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presione para ingresar a un formulario";
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(109, 101);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(185, 85);
            this.btnAgregarEstudiante.TabIndex = 1;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // btnAgregarMat
            // 
            this.btnAgregarMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMat.Location = new System.Drawing.Point(362, 101);
            this.btnAgregarMat.Name = "btnAgregarMat";
            this.btnAgregarMat.Size = new System.Drawing.Size(220, 85);
            this.btnAgregarMat.TabIndex = 2;
            this.btnAgregarMat.Text = "Agregar Materia";
            this.btnAgregarMat.UseVisualStyleBackColor = true;
            this.btnAgregarMat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListEstu
            // 
            this.btnListEstu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListEstu.Location = new System.Drawing.Point(109, 241);
            this.btnListEstu.Name = "btnListEstu";
            this.btnListEstu.Size = new System.Drawing.Size(185, 87);
            this.btnListEstu.TabIndex = 3;
            this.btnListEstu.Text = "Listado De Estudiantes";
            this.btnListEstu.UseVisualStyleBackColor = true;
            this.btnListEstu.Click += new System.EventHandler(this.btnListEstu_Click);
            // 
            // btnListMat
            // 
            this.btnListMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListMat.Location = new System.Drawing.Point(362, 241);
            this.btnListMat.Name = "btnListMat";
            this.btnListMat.Size = new System.Drawing.Size(220, 87);
            this.btnListMat.TabIndex = 4;
            this.btnListMat.Text = "Listado De Materias";
            this.btnListMat.UseVisualStyleBackColor = true;
            this.btnListMat.Click += new System.EventHandler(this.btnListMat_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListMat);
            this.Controls.Add(this.btnListEstu);
            this.Controls.Add(this.btnAgregarMat);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Button btnAgregarMat;
        private System.Windows.Forms.Button btnListEstu;
        private System.Windows.Forms.Button btnListMat;
    }
}