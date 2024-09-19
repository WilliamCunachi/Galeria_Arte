namespace Galeria_Arte.Views
{
    partial class FormObras
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDObra = new System.Windows.Forms.TextBox();
            this.txtNombreObra = new System.Windows.Forms.TextBox();
            this.txtIDArtista = new System.Windows.Forms.TextBox();
            this.listBoxObras = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(105, 293);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 74);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(309, 293);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(166, 74);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(505, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 74);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la Obra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Artista";
            // 
            // txtIDObra
            // 
            this.txtIDObra.Location = new System.Drawing.Point(201, 76);
            this.txtIDObra.Name = "txtIDObra";
            this.txtIDObra.Size = new System.Drawing.Size(100, 26);
            this.txtIDObra.TabIndex = 6;
            // 
            // txtNombreObra
            // 
            this.txtNombreObra.Location = new System.Drawing.Point(201, 131);
            this.txtNombreObra.Name = "txtNombreObra";
            this.txtNombreObra.Size = new System.Drawing.Size(100, 26);
            this.txtNombreObra.TabIndex = 7;
            // 
            // txtIDArtista
            // 
            this.txtIDArtista.Location = new System.Drawing.Point(201, 184);
            this.txtIDArtista.Name = "txtIDArtista";
            this.txtIDArtista.Size = new System.Drawing.Size(100, 26);
            this.txtIDArtista.TabIndex = 8;
            // 
            // listBoxObras
            // 
            this.listBoxObras.FormattingEnabled = true;
            this.listBoxObras.ItemHeight = 20;
            this.listBoxObras.Location = new System.Drawing.Point(435, 52);
            this.listBoxObras.Name = "listBoxObras";
            this.listBoxObras.Size = new System.Drawing.Size(224, 164);
            this.listBoxObras.TabIndex = 9;
            this.listBoxObras.SelectedIndexChanged += new System.EventHandler(this.listBoxObras_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Agregar Obras";
            // 
            // FormObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxObras);
            this.Controls.Add(this.txtIDArtista);
            this.Controls.Add(this.txtNombreObra);
            this.Controls.Add(this.txtIDObra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormObras";
            this.Text = "FormObras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDObra;
        private System.Windows.Forms.TextBox txtNombreObra;
        private System.Windows.Forms.TextBox txtIDArtista;
        private System.Windows.Forms.ListBox listBoxObras;
        private System.Windows.Forms.Label label4;
    }
}