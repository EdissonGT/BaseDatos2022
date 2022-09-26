namespace BaseMundial
{
    partial class FormEstadisPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisPais));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgEstadPais = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txttarroja = new System.Windows.Forms.TextBox();
            this.txttaramari = new System.Windows.Forms.TextBox();
            this.txttirosdes = new System.Windows.Forms.TextBox();
            this.txttirosmarco = new System.Windows.Forms.TextBox();
            this.txtgolanota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodselec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(1162, 709);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 38);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(-137, -136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadisticas de los Jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(175, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(895, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estadisticas de las Selecciones";
            // 
            // dgEstadPais
            // 
            this.dgEstadPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstadPais.Location = new System.Drawing.Point(25, 449);
            this.dgEstadPais.Name = "dgEstadPais";
            this.dgEstadPais.RowHeadersWidth = 51;
            this.dgEstadPais.RowTemplate.Height = 24;
            this.dgEstadPais.Size = new System.Drawing.Size(942, 284);
            this.dgEstadPais.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1012, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btbmodificar
            // 
            this.btbmodificar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbmodificar.Location = new System.Drawing.Point(1022, 274);
            this.btbmodificar.Name = "btbmodificar";
            this.btbmodificar.Size = new System.Drawing.Size(198, 73);
            this.btbmodificar.TabIndex = 80;
            this.btbmodificar.Text = "Editar";
            this.btbmodificar.UseVisualStyleBackColor = true;
            this.btbmodificar.Click += new System.EventHandler(this.btbmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(1022, 360);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(198, 73);
            this.btneliminar.TabIndex = 79;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1022, 190);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 73);
            this.btnagregar.TabIndex = 78;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1022, 104);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(198, 73);
            this.btnbuscar.TabIndex = 77;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txttarroja
            // 
            this.txttarroja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttarroja.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarroja.Location = new System.Drawing.Point(350, 360);
            this.txttarroja.Name = "txttarroja";
            this.txttarroja.Size = new System.Drawing.Size(609, 39);
            this.txttarroja.TabIndex = 74;
            // 
            // txttaramari
            // 
            this.txttaramari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttaramari.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaramari.Location = new System.Drawing.Point(350, 313);
            this.txttaramari.Name = "txttaramari";
            this.txttaramari.Size = new System.Drawing.Size(609, 39);
            this.txttaramari.TabIndex = 73;
            // 
            // txttirosdes
            // 
            this.txttirosdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttirosdes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttirosdes.Location = new System.Drawing.Point(350, 262);
            this.txttirosdes.Name = "txttirosdes";
            this.txttirosdes.Size = new System.Drawing.Size(609, 39);
            this.txttirosdes.TabIndex = 72;
            // 
            // txttirosmarco
            // 
            this.txttirosmarco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttirosmarco.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttirosmarco.Location = new System.Drawing.Point(350, 212);
            this.txttirosmarco.Name = "txttirosmarco";
            this.txttirosmarco.Size = new System.Drawing.Size(609, 39);
            this.txttirosmarco.TabIndex = 71;
            // 
            // txtgolanota
            // 
            this.txtgolanota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgolanota.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgolanota.Location = new System.Drawing.Point(350, 160);
            this.txtgolanota.Name = "txtgolanota";
            this.txtgolanota.Size = new System.Drawing.Size(609, 39);
            this.txtgolanota.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 41);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tarjetas Rojas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 41);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tarjetas Amarrillas :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 41);
            this.label5.TabIndex = 65;
            this.label5.Text = "Tiros Desviados :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 41);
            this.label4.TabIndex = 64;
            this.label4.Text = "Tiros al Marco :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 41);
            this.label3.TabIndex = 63;
            this.label3.Text = "Total Goles Anotados :";
            // 
            // txtcodselec
            // 
            this.txtcodselec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodselec.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodselec.Location = new System.Drawing.Point(350, 107);
            this.txtcodselec.Name = "txtcodselec";
            this.txtcodselec.Size = new System.Drawing.Size(609, 39);
            this.txtcodselec.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 41);
            this.label10.TabIndex = 61;
            this.label10.Text = "Código de Selección :";
            // 
            // FormEstadisPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 754);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgEstadPais);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txttarroja);
            this.Controls.Add(this.txttaramari);
            this.Controls.Add(this.txttirosdes);
            this.Controls.Add(this.txttirosmarco);
            this.Controls.Add(this.txtgolanota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodselec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisPais";
            this.Text = "FormEstadisPais";
            this.Load += new System.EventHandler(this.FormEstadisPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEstadPais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txttarroja;
        private System.Windows.Forms.TextBox txttaramari;
        private System.Windows.Forms.TextBox txttirosdes;
        private System.Windows.Forms.TextBox txttirosmarco;
        private System.Windows.Forms.TextBox txtgolanota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodselec;
        private System.Windows.Forms.Label label10;
    }
}