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
            this.nombreResiduo = new System.Windows.Forms.Label();
            this.textoBote = new System.Windows.Forms.Label();
            this.nombreMaterial = new System.Windows.Forms.Label();
            this.textoOrganica = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imagenResiduo = new System.Windows.Forms.PictureBox();
            this.adelanteResiduo = new System.Windows.Forms.Button();
            this.adelanteMaterial = new System.Windows.Forms.Button();
            this.atrasResiduo = new System.Windows.Forms.Button();
            this.atrasMaterial = new System.Windows.Forms.Button();
            this.imagenMaterial = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imagenBote = new System.Windows.Forms.PictureBox();
            this.imagenOrganica = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reciclar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenResiduo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMaterial)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOrganica)).BeginInit();
            this.panel4.SuspendLayout();
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
            // nombreResiduo
            // 
            this.nombreResiduo.AutoSize = true;
            this.nombreResiduo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreResiduo.Location = new System.Drawing.Point(78, 265);
            this.nombreResiduo.Name = "nombreResiduo";
            this.nombreResiduo.Size = new System.Drawing.Size(0, 24);
            this.nombreResiduo.TabIndex = 3;
            this.nombreResiduo.Click += new System.EventHandler(this.nombreResiduo_Click);
            // 
            // textoBote
            // 
            this.textoBote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textoBote.AutoSize = true;
            this.textoBote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBote.ForeColor = System.Drawing.Color.Silver;
            this.textoBote.Location = new System.Drawing.Point(49, 254);
            this.textoBote.Name = "textoBote";
            this.textoBote.Size = new System.Drawing.Size(0, 24);
            this.textoBote.TabIndex = 9;
            this.textoBote.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreMaterial
            // 
            this.nombreMaterial.AutoSize = true;
            this.nombreMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMaterial.Location = new System.Drawing.Point(78, 548);
            this.nombreMaterial.Name = "nombreMaterial";
            this.nombreMaterial.Size = new System.Drawing.Size(0, 24);
            this.nombreMaterial.TabIndex = 13;
            // 
            // textoOrganica
            // 
            this.textoOrganica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textoOrganica.AutoSize = true;
            this.textoOrganica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoOrganica.ForeColor = System.Drawing.Color.Silver;
            this.textoOrganica.Location = new System.Drawing.Point(31, 548);
            this.textoOrganica.Name = "textoOrganica";
            this.textoOrganica.Size = new System.Drawing.Size(0, 24);
            this.textoOrganica.TabIndex = 15;
            this.textoOrganica.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imagenResiduo);
            this.panel1.Controls.Add(this.nombreMaterial);
            this.panel1.Controls.Add(this.adelanteResiduo);
            this.panel1.Controls.Add(this.adelanteMaterial);
            this.panel1.Controls.Add(this.atrasResiduo);
            this.panel1.Controls.Add(this.atrasMaterial);
            this.panel1.Controls.Add(this.imagenMaterial);
            this.panel1.Controls.Add(this.nombreResiduo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 622);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione el tipo de material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione el residuo";
            // 
            // imagenResiduo
            // 
            this.imagenResiduo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenResiduo.Location = new System.Drawing.Point(82, 81);
            this.imagenResiduo.Name = "imagenResiduo";
            this.imagenResiduo.Size = new System.Drawing.Size(170, 170);
            this.imagenResiduo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenResiduo.TabIndex = 2;
            this.imagenResiduo.TabStop = false;
            // 
            // adelanteResiduo
            // 
            this.adelanteResiduo.BackColor = System.Drawing.Color.Transparent;
            this.adelanteResiduo.BackgroundImage = global::Reciclaje.Properties.Resources.right;
            this.adelanteResiduo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adelanteResiduo.FlatAppearance.BorderSize = 0;
            this.adelanteResiduo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adelanteResiduo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(207)))), ((int)(((byte)(69)))));
            this.adelanteResiduo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adelanteResiduo.Location = new System.Drawing.Point(258, 148);
            this.adelanteResiduo.Name = "adelanteResiduo";
            this.adelanteResiduo.Size = new System.Drawing.Size(40, 40);
            this.adelanteResiduo.TabIndex = 5;
            this.adelanteResiduo.UseVisualStyleBackColor = false;
            this.adelanteResiduo.Click += new System.EventHandler(this.adelante_Click);
            // 
            // adelanteMaterial
            // 
            this.adelanteMaterial.BackColor = System.Drawing.Color.Transparent;
            this.adelanteMaterial.BackgroundImage = global::Reciclaje.Properties.Resources.right;
            this.adelanteMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adelanteMaterial.FlatAppearance.BorderSize = 0;
            this.adelanteMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adelanteMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(207)))), ((int)(((byte)(69)))));
            this.adelanteMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adelanteMaterial.Location = new System.Drawing.Point(258, 431);
            this.adelanteMaterial.Name = "adelanteMaterial";
            this.adelanteMaterial.Size = new System.Drawing.Size(40, 40);
            this.adelanteMaterial.TabIndex = 12;
            this.adelanteMaterial.UseVisualStyleBackColor = false;
            this.adelanteMaterial.Click += new System.EventHandler(this.adelanteMaterial_Click);
            // 
            // atrasResiduo
            // 
            this.atrasResiduo.BackColor = System.Drawing.Color.Transparent;
            this.atrasResiduo.BackgroundImage = global::Reciclaje.Properties.Resources.left;
            this.atrasResiduo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atrasResiduo.FlatAppearance.BorderSize = 0;
            this.atrasResiduo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.atrasResiduo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(207)))), ((int)(((byte)(69)))));
            this.atrasResiduo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atrasResiduo.Location = new System.Drawing.Point(36, 148);
            this.atrasResiduo.Name = "atrasResiduo";
            this.atrasResiduo.Size = new System.Drawing.Size(40, 40);
            this.atrasResiduo.TabIndex = 6;
            this.atrasResiduo.UseVisualStyleBackColor = false;
            this.atrasResiduo.Click += new System.EventHandler(this.atras_Click);
            // 
            // atrasMaterial
            // 
            this.atrasMaterial.BackColor = System.Drawing.Color.Transparent;
            this.atrasMaterial.BackgroundImage = global::Reciclaje.Properties.Resources.left;
            this.atrasMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atrasMaterial.FlatAppearance.BorderSize = 0;
            this.atrasMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.atrasMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(207)))), ((int)(((byte)(69)))));
            this.atrasMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atrasMaterial.Location = new System.Drawing.Point(36, 431);
            this.atrasMaterial.Name = "atrasMaterial";
            this.atrasMaterial.Size = new System.Drawing.Size(40, 40);
            this.atrasMaterial.TabIndex = 11;
            this.atrasMaterial.UseVisualStyleBackColor = false;
            this.atrasMaterial.Click += new System.EventHandler(this.atrasMaterial_Click);
            // 
            // imagenMaterial
            // 
            this.imagenMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenMaterial.Location = new System.Drawing.Point(82, 364);
            this.imagenMaterial.Name = "imagenMaterial";
            this.imagenMaterial.Size = new System.Drawing.Size(170, 170);
            this.imagenMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenMaterial.TabIndex = 10;
            this.imagenMaterial.TabStop = false;
            this.imagenMaterial.Click += new System.EventHandler(this.imagenMaterial_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 53);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reciclaje.Properties.Resources.Tecnologico_de_el_Mante;
            this.pictureBox2.Location = new System.Drawing.Point(658, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reciclaje.Properties.Resources.Yo_reciclo;
            this.pictureBox1.Location = new System.Drawing.Point(3, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imagenBote);
            this.panel3.Controls.Add(this.imagenOrganica);
            this.panel3.Controls.Add(this.textoOrganica);
            this.panel3.Controls.Add(this.textoBote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(523, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 622);
            this.panel3.TabIndex = 16;
            // 
            // imagenBote
            // 
            this.imagenBote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenBote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenBote.Location = new System.Drawing.Point(53, 81);
            this.imagenBote.Name = "imagenBote";
            this.imagenBote.Size = new System.Drawing.Size(170, 170);
            this.imagenBote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenBote.TabIndex = 8;
            this.imagenBote.TabStop = false;
            // 
            // imagenOrganica
            // 
            this.imagenOrganica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenOrganica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenOrganica.Location = new System.Drawing.Point(53, 364);
            this.imagenOrganica.Name = "imagenOrganica";
            this.imagenOrganica.Size = new System.Drawing.Size(170, 170);
            this.imagenOrganica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenOrganica.TabIndex = 14;
            this.imagenOrganica.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reciclar";
            // 
            // reciclar
            // 
            this.reciclar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reciclar.BackColor = System.Drawing.Color.Transparent;
            this.reciclar.BackgroundImage = global::Reciclaje.Properties.Resources._1706198;
            this.reciclar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reciclar.FlatAppearance.BorderSize = 0;
            this.reciclar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.reciclar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reciclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciclar.Location = new System.Drawing.Point(34, 17);
            this.reciclar.Name = "reciclar";
            this.reciclar.Size = new System.Drawing.Size(136, 588);
            this.reciclar.TabIndex = 4;
            this.reciclar.UseVisualStyleBackColor = false;
            this.reciclar.Click += new System.EventHandler(this.reciclar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Reciclaje.Properties.Resources.cardboard_546867;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.reciclar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(321, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 622);
            this.panel4.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(795, 675);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoReciclo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenResiduo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMaterial)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOrganica)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
    }
}

