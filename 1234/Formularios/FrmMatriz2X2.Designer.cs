namespace _1234.Formularios
{
    partial class FrmMatriz2X2
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
            this.lblMatriz1 = new System.Windows.Forms.Label();
            this.lblMatriz2 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrega numero para matrices";
            // 
            // lblMatriz1
            // 
            this.lblMatriz1.AutoSize = true;
            this.lblMatriz1.Location = new System.Drawing.Point(173, 120);
            this.lblMatriz1.Name = "lblMatriz1";
            this.lblMatriz1.Size = new System.Drawing.Size(0, 13);
            this.lblMatriz1.TabIndex = 3;
            // 
            // lblMatriz2
            // 
            this.lblMatriz2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz2.Location = new System.Drawing.Point(67, 107);
            this.lblMatriz2.Name = "lblMatriz2";
            this.lblMatriz2.Size = new System.Drawing.Size(193, 171);
            this.lblMatriz2.TabIndex = 4;
            this.lblMatriz2.Text = ":";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(369, 62);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 5;
            this.tbNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNum_KeyDown);
            // 
            // FrmMatriz2X2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lblMatriz2);
            this.Controls.Add(this.lblMatriz1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMatriz2X2";
            this.Text = "FrmMatriz2X2";
            this.Load += new System.EventHandler(this.FrmMatriz2X2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatriz1;
        private System.Windows.Forms.Label lblMatriz2;
        private System.Windows.Forms.TextBox tbNum;
    }
}