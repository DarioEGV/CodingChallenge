namespace CodingChallenge.Data
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.labelImprimir = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImprimir
            // 
            this.labelImprimir.AutoSize = true;
            this.labelImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImprimir.ForeColor = System.Drawing.Color.White;
            this.labelImprimir.Location = new System.Drawing.Point(151, 108);
            this.labelImprimir.Name = "labelImprimir";
            this.labelImprimir.Size = new System.Drawing.Size(51, 21);
            this.labelImprimir.TabIndex = 0;
            this.labelImprimir.Text = "label1";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(946, 5);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(946, 5);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelImprimir);
            this.Name = "Lista";
            this.Size = new System.Drawing.Size(925, 396);
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImprimir;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
