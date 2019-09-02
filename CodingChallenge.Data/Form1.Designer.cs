namespace CodingChallenge.Data
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonLimpiarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 396);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-21, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(946, 5);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(795, 25);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(130, 23);
            this.buttonCerrar.TabIndex = 30;
            this.buttonCerrar.Text = "Cerrar Sistema";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizar.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizar.Location = new System.Drawing.Point(666, 25);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(130, 23);
            this.buttonMinimizar.TabIndex = 31;
            this.buttonMinimizar.Text = "Minimizar Sistema";
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonLimpiarLista
            // 
            this.buttonLimpiarLista.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpiarLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarLista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarLista.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiarLista.Location = new System.Drawing.Point(535, 25);
            this.buttonLimpiarLista.Name = "buttonLimpiarLista";
            this.buttonLimpiarLista.Size = new System.Drawing.Size(130, 23);
            this.buttonLimpiarLista.TabIndex = 32;
            this.buttonLimpiarLista.Text = "Limmpiar Lista";
            this.buttonLimpiarLista.UseVisualStyleBackColor = false;
            this.buttonLimpiarLista.Click += new System.EventHandler(this.buttonLimpìarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 477);
            this.Controls.Add(this.buttonLimpiarLista);
            this.Controls.Add(this.buttonMinimizar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button buttonCerrar;
        public System.Windows.Forms.Button buttonMinimizar;
        public System.Windows.Forms.Button buttonLimpiarLista;
    }
}