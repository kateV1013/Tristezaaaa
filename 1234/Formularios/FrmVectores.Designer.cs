namespace _1234.Formularios
{
    partial class FrmVectores
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
            this.tbNumeros = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.pgbPromedio = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar numeros";
            // 
            // tbNumeros
            // 
            this.tbNumeros.Location = new System.Drawing.Point(77, 80);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(100, 20);
            this.tbNumeros.TabIndex = 1;
            this.tbNumeros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumeros_KeyDown);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(74, 159);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(74, 122);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Numero:";
            // 
            // pgbPromedio
            // 
            this.pgbPromedio.Location = new System.Drawing.Point(276, 77);
            this.pgbPromedio.Name = "pgbPromedio";
            this.pgbPromedio.Size = new System.Drawing.Size(373, 23);
            this.pgbPromedio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solo puedes agregar 10 numeros";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(639, 112);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(10, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = ":";
            // 
            // FrmVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pgbPromedio);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.tbNumeros);
            this.Controls.Add(this.label1);
            this.Name = "FrmVectores";
            this.Text = "FrmVectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumeros;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ProgressBar pgbPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumero;
    }
}