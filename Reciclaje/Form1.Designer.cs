namespace Reciclaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tx1 = new System.Windows.Forms.Label();
            this.imagenResiduo = new System.Windows.Forms.PictureBox();
            this.nombreResiduo = new System.Windows.Forms.Label();
            this.reciclar = new System.Windows.Forms.Button();
            this.adelanteResiduo = new System.Windows.Forms.Button();
            this.atrasResiduo = new System.Windows.Forms.Button();
            this.imagenBote = new System.Windows.Forms.PictureBox();
            this.textoBote = new System.Windows.Forms.Label();
            this.imagenMaterial = new System.Windows.Forms.PictureBox();
            this.atrasMaterial = new System.Windows.Forms.Button();
            this.adelanteMaterial = new System.Windows.Forms.Button();
            this.nombreMaterial = new System.Windows.Forms.Label();
            this.imagenOrganica = new System.Windows.Forms.PictureBox();
            this.textoOrganica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenResiduo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOrganica)).BeginInit();
            this.SuspendLayout();
            // 
            // tx1
            // 
            this.tx1.AutoSize = true;
            this.tx1.Location = new System.Drawing.Point(27, 125);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(0, 13);
            this.tx1.TabIndex = 0;
            // 
            // imagenResiduo
            // 
            this.imagenResiduo.Location = new System.Drawing.Point(77, 37);
            this.imagenResiduo.Name = "imagenResiduo";
            this.imagenResiduo.Size = new System.Drawing.Size(167, 242);
            this.imagenResiduo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenResiduo.TabIndex = 2;
            this.imagenResiduo.TabStop = false;
            // 
            // nombreResiduo
            // 
            this.nombreResiduo.AutoSize = true;
            this.nombreResiduo.Location = new System.Drawing.Point(142, 294);
            this.nombreResiduo.Name = "nombreResiduo";
            this.nombreResiduo.Size = new System.Drawing.Size(35, 13);
            this.nombreResiduo.TabIndex = 3;
            this.nombreResiduo.Text = "label1";
            this.nombreResiduo.Click += new System.EventHandler(this.nombreResiduo_Click);
            // 
            // reciclar
            // 
            this.reciclar.Location = new System.Drawing.Point(349, 301);
            this.reciclar.Name = "reciclar";
            this.reciclar.Size = new System.Drawing.Size(75, 23);
            this.reciclar.TabIndex = 4;
            this.reciclar.Text = "Reciclar";
            this.reciclar.UseVisualStyleBackColor = true;
            this.reciclar.Click += new System.EventHandler(this.reciclar_Click);
            // 
            // adelanteResiduo
            // 
            this.adelanteResiduo.Image = ((System.Drawing.Image)(resources.GetObject("adelanteResiduo.Image")));
            this.adelanteResiduo.Location = new System.Drawing.Point(250, 108);
            this.adelanteResiduo.Name = "adelanteResiduo";
            this.adelanteResiduo.Size = new System.Drawing.Size(56, 47);
            this.adelanteResiduo.TabIndex = 5;
            this.adelanteResiduo.UseVisualStyleBackColor = true;
            this.adelanteResiduo.Click += new System.EventHandler(this.adelante_Click);
            // 
            // atrasResiduo
            // 
            this.atrasResiduo.Image = ((System.Drawing.Image)(resources.GetObject("atrasResiduo.Image")));
            this.atrasResiduo.Location = new System.Drawing.Point(18, 108);
            this.atrasResiduo.Name = "atrasResiduo";
            this.atrasResiduo.Size = new System.Drawing.Size(53, 47);
            this.atrasResiduo.TabIndex = 6;
            this.atrasResiduo.UseVisualStyleBackColor = true;
            this.atrasResiduo.Click += new System.EventHandler(this.atras_Click);
            // 
            // imagenBote
            // 
            this.imagenBote.Location = new System.Drawing.Point(562, 28);
            this.imagenBote.Name = "imagenBote";
            this.imagenBote.Size = new System.Drawing.Size(206, 251);
            this.imagenBote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenBote.TabIndex = 8;
            this.imagenBote.TabStop = false;
            // 
            // textoBote
            // 
            this.textoBote.AutoSize = true;
            this.textoBote.Location = new System.Drawing.Point(508, 311);
            this.textoBote.Name = "textoBote";
            this.textoBote.Size = new System.Drawing.Size(35, 13);
            this.textoBote.TabIndex = 9;
            this.textoBote.Text = "label1";
            this.textoBote.Click += new System.EventHandler(this.label1_Click);
            // 
            // imagenMaterial
            // 
            this.imagenMaterial.Location = new System.Drawing.Point(77, 376);
            this.imagenMaterial.Name = "imagenMaterial";
            this.imagenMaterial.Size = new System.Drawing.Size(167, 242);
            this.imagenMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenMaterial.TabIndex = 10;
            this.imagenMaterial.TabStop = false;
            this.imagenMaterial.Click += new System.EventHandler(this.imagenMaterial_Click);
            // 
            // atrasMaterial
            // 
            this.atrasMaterial.Image = ((System.Drawing.Image)(resources.GetObject("atrasMaterial.Image")));
            this.atrasMaterial.Location = new System.Drawing.Point(18, 438);
            this.atrasMaterial.Name = "atrasMaterial";
            this.atrasMaterial.Size = new System.Drawing.Size(53, 47);
            this.atrasMaterial.TabIndex = 11;
            this.atrasMaterial.UseVisualStyleBackColor = true;
            this.atrasMaterial.Click += new System.EventHandler(this.atrasMaterial_Click);
            // 
            // adelanteMaterial
            // 
            this.adelanteMaterial.Image = ((System.Drawing.Image)(resources.GetObject("adelanteMaterial.Image")));
            this.adelanteMaterial.Location = new System.Drawing.Point(253, 438);
            this.adelanteMaterial.Name = "adelanteMaterial";
            this.adelanteMaterial.Size = new System.Drawing.Size(53, 47);
            this.adelanteMaterial.TabIndex = 12;
            this.adelanteMaterial.UseVisualStyleBackColor = true;
            this.adelanteMaterial.Click += new System.EventHandler(this.adelanteMaterial_Click);
            // 
            // nombreMaterial
            // 
            this.nombreMaterial.AutoSize = true;
            this.nombreMaterial.Location = new System.Drawing.Point(142, 640);
            this.nombreMaterial.Name = "nombreMaterial";
            this.nombreMaterial.Size = new System.Drawing.Size(35, 13);
            this.nombreMaterial.TabIndex = 13;
            this.nombreMaterial.Text = "label1";
            // 
            // imagenOrganica
            // 
            this.imagenOrganica.Location = new System.Drawing.Point(562, 358);
            this.imagenOrganica.Name = "imagenOrganica";
            this.imagenOrganica.Size = new System.Drawing.Size(206, 251);
            this.imagenOrganica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenOrganica.TabIndex = 14;
            this.imagenOrganica.TabStop = false;
            // 
            // textoOrganica
            // 
            this.textoOrganica.AutoSize = true;
            this.textoOrganica.Location = new System.Drawing.Point(508, 640);
            this.textoOrganica.Name = "textoOrganica";
            this.textoOrganica.Size = new System.Drawing.Size(35, 13);
            this.textoOrganica.TabIndex = 15;
            this.textoOrganica.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(881, 686);
            this.Controls.Add(this.textoOrganica);
            this.Controls.Add(this.imagenOrganica);
            this.Controls.Add(this.nombreMaterial);
            this.Controls.Add(this.adelanteMaterial);
            this.Controls.Add(this.atrasMaterial);
            this.Controls.Add(this.imagenMaterial);
            this.Controls.Add(this.textoBote);
            this.Controls.Add(this.imagenBote);
            this.Controls.Add(this.atrasResiduo);
            this.Controls.Add(this.adelanteResiduo);
            this.Controls.Add(this.reciclar);
            this.Controls.Add(this.nombreResiduo);
            this.Controls.Add(this.imagenResiduo);
            this.Controls.Add(this.tx1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenResiduo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOrganica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tx1;
        private System.Windows.Forms.PictureBox imagenResiduo;
        private System.Windows.Forms.Label nombreResiduo;
        private System.Windows.Forms.Button reciclar;
        private System.Windows.Forms.Button adelanteResiduo;
        private System.Windows.Forms.Button atrasResiduo;
        private System.Windows.Forms.PictureBox imagenBote;
        private System.Windows.Forms.Label textoBote;
        private System.Windows.Forms.PictureBox imagenMaterial;
        private System.Windows.Forms.Button atrasMaterial;
        private System.Windows.Forms.Button adelanteMaterial;
        private System.Windows.Forms.Label nombreMaterial;
        private System.Windows.Forms.PictureBox imagenOrganica;
        private System.Windows.Forms.Label textoOrganica;
    }
}

