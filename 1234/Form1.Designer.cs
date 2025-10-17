namespace _1234
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadenaTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.arregloToolStripMenuItem,
            this.variosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // arregloToolStripMenuItem
            // 
            this.arregloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vectoresToolStripMenuItem,
            this.matricesToolStripMenuItem});
            this.arregloToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arregloToolStripMenuItem.Name = "arregloToolStripMenuItem";
            this.arregloToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.arregloToolStripMenuItem.Text = "Arreglo";
            // 
            // vectoresToolStripMenuItem
            // 
            this.vectoresToolStripMenuItem.Name = "vectoresToolStripMenuItem";
            this.vectoresToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.vectoresToolStripMenuItem.Text = "Vectores";
            this.vectoresToolStripMenuItem.Click += new System.EventHandler(this.vectoresToolStripMenuItem_Click);
            // 
            // matricesToolStripMenuItem
            // 
            this.matricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem});
            this.matricesToolStripMenuItem.Name = "matricesToolStripMenuItem";
            this.matricesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.matricesToolStripMenuItem.Text = "Matrices";
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.x2ToolStripMenuItem.Text = "2X2";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.x3ToolStripMenuItem.Text = "3X3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // variosToolStripMenuItem
            // 
            this.variosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edadesToolStripMenuItem,
            this.cadenaTextoToolStripMenuItem});
            this.variosToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variosToolStripMenuItem.Name = "variosToolStripMenuItem";
            this.variosToolStripMenuItem.Size = new System.Drawing.Size(63, 30);
            this.variosToolStripMenuItem.Text = "Varios";
            // 
            // edadesToolStripMenuItem
            // 
            this.edadesToolStripMenuItem.Name = "edadesToolStripMenuItem";
            this.edadesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.edadesToolStripMenuItem.Text = "Edades";
            this.edadesToolStripMenuItem.Click += new System.EventHandler(this.edadesToolStripMenuItem_Click);
            // 
            // cadenaTextoToolStripMenuItem
            // 
            this.cadenaTextoToolStripMenuItem.Name = "cadenaTextoToolStripMenuItem";
            this.cadenaTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cadenaTextoToolStripMenuItem.Text = "Cadena Texto";
            this.cadenaTextoToolStripMenuItem.Click += new System.EventHandler(this.cadenaTextoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadenaTextoToolStripMenuItem;
    }
}

