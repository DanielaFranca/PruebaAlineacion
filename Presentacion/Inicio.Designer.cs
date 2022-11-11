
namespace Prueba_técnica
{
    partial class Inicio
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
            this.ingresarJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarAlineacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarJugadoresToolStripMenuItem,
            this.ingresarAlineacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarJugadoresToolStripMenuItem
            // 
            this.ingresarJugadoresToolStripMenuItem.Name = "ingresarJugadoresToolStripMenuItem";
            this.ingresarJugadoresToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.ingresarJugadoresToolStripMenuItem.Text = "Ingresar jugadores";
            this.ingresarJugadoresToolStripMenuItem.Click += new System.EventHandler(this.ingresarJugadoresToolStripMenuItem_Click);
            // 
            // ingresarAlineacionesToolStripMenuItem
            // 
            this.ingresarAlineacionesToolStripMenuItem.Name = "ingresarAlineacionesToolStripMenuItem";
            this.ingresarAlineacionesToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.ingresarAlineacionesToolStripMenuItem.Text = "Ingresar alineaciones";
            this.ingresarAlineacionesToolStripMenuItem.Click += new System.EventHandler(this.ingresarAlineacionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarAlineacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

