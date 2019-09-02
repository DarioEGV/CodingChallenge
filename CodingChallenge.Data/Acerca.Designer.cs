namespace CodingChallenge.Data
{
    partial class Acerca
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acerca));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acerca De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(125, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.White;
            this.buttonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtras.BackgroundImage")));
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAtras.FlatAppearance.BorderSize = 2;
            this.buttonAtras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.Location = new System.Drawing.Point(854, 3);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(68, 36);
            this.buttonAtras.TabIndex = 26;
            this.buttonAtras.Text = "                 ";
            this.buttonAtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // Acerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Acerca";
            this.Size = new System.Drawing.Size(925, 396);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAtras;
    }
}
