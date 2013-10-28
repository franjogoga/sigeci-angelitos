namespace sigeci_angelitos
{
    partial class TerapeutaForm
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
            this.txtTerapeuta = new System.Windows.Forms.TextBox();
            this.lblHola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTerapeuta
            // 
            this.txtTerapeuta.Location = new System.Drawing.Point(79, 122);
            this.txtTerapeuta.Name = "txtTerapeuta";
            this.txtTerapeuta.Size = new System.Drawing.Size(100, 20);
            this.txtTerapeuta.TabIndex = 0;
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Location = new System.Drawing.Point(91, 48);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(81, 13);
            this.lblHola.TabIndex = 1;
            this.lblHola.Text = "holaaaaaaaaaa";
            // 
            // TerapeutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.txtTerapeuta);
            this.DoubleBuffered = true;
            this.Name = "TerapeutaForm";
            this.Text = "TerapeutaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTerapeuta;
        private System.Windows.Forms.Label lblHola;
    }
}