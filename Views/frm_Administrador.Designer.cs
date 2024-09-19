namespace Galeria_Arte.Views
{
    partial class frm_Administrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expocicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIsitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarExposicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaVisitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistasToolStripMenuItem,
            this.expocicionesToolStripMenuItem,
            this.obrasToolStripMenuItem,
            this.vIsitantesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artistasToolStripMenuItem
            // 
            this.artistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArtistaToolStripMenuItem});
            this.artistasToolStripMenuItem.Name = "artistasToolStripMenuItem";
            this.artistasToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.artistasToolStripMenuItem.Text = "Artistas";
            // 
            // expocicionesToolStripMenuItem
            // 
            this.expocicionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarExposicionToolStripMenuItem});
            this.expocicionesToolStripMenuItem.Name = "expocicionesToolStripMenuItem";
            this.expocicionesToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.expocicionesToolStripMenuItem.Text = "Exposiciones";
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarObraToolStripMenuItem});
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.obrasToolStripMenuItem.Text = "Obras";
            // 
            // vIsitantesToolStripMenuItem
            // 
            this.vIsitantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaVisitantesToolStripMenuItem});
            this.vIsitantesToolStripMenuItem.Name = "vIsitantesToolStripMenuItem";
            this.vIsitantesToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.vIsitantesToolStripMenuItem.Text = "Visitantes";
            // 
            // agregarArtistaToolStripMenuItem
            // 
            this.agregarArtistaToolStripMenuItem.Name = "agregarArtistaToolStripMenuItem";
            this.agregarArtistaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarArtistaToolStripMenuItem.Text = "Agregar Artista";
            this.agregarArtistaToolStripMenuItem.Click += new System.EventHandler(this.agregarArtistaToolStripMenuItem_Click);
            // 
            // agregarExposicionToolStripMenuItem
            // 
            this.agregarExposicionToolStripMenuItem.Name = "agregarExposicionToolStripMenuItem";
            this.agregarExposicionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarExposicionToolStripMenuItem.Text = "Agregar Exposicion";
            // 
            // agregarObraToolStripMenuItem
            // 
            this.agregarObraToolStripMenuItem.Name = "agregarObraToolStripMenuItem";
            this.agregarObraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarObraToolStripMenuItem.Text = "Agregar Obra";
            this.agregarObraToolStripMenuItem.Click += new System.EventHandler(this.agregarObraToolStripMenuItem_Click);
            // 
            // listaVisitantesToolStripMenuItem
            // 
            this.listaVisitantesToolStripMenuItem.Name = "listaVisitantesToolStripMenuItem";
            this.listaVisitantesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listaVisitantesToolStripMenuItem.Text = "Lista Visitantes ";
            // 
            // frm_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Administrador";
            this.Text = "frm_Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expocicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarExposicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIsitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaVisitantesToolStripMenuItem;
    }
}