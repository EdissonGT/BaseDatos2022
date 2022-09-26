namespace BaseMundial
{
    partial class FormEstadisJuga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisJuga));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodjuga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgolAnota = new System.Windows.Forms.TextBox();
            this.txttirosmarco = new System.Windows.Forms.TextBox();
            this.txttirosdes = new System.Windows.Forms.TextBox();
            this.txttarama = new System.Windows.Forms.TextBox();
            this.txttarroja = new System.Windows.Forms.TextBox();
            this.txtminjug = new System.Windows.Forms.TextBox();
            this.txtasistencias = new System.Windows.Forms.TextBox();
            this.btbmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgEstadJug = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadJug)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(1151, 693);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 38);
            this.btnCerrar.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estadisticas de los Jugadores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 41);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tarjetas Amarrillas :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 41);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tiros Desviados :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 41);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tiros al Marco :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 41);
            this.label3.TabIndex = 37;
            this.label3.Text = "Goles Anotados :";
            // 
            // txtcodjuga
            // 
            this.txtcodjuga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodjuga.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodjuga.Location = new System.Drawing.Point(343, 105);
            this.txtcodjuga.Name = "txtcodjuga";
            this.txtcodjuga.Size = new System.Drawing.Size(609, 39);
            this.txtcodjuga.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Código del Jugador :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 41);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tarjetas Rojas :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 41);
            this.label8.TabIndex = 46;
            this.label8.Text = "Minutos Jugados :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 41);
            this.label9.TabIndex = 47;
            this.label9.Text = "Total Asistencias :";
            // 
            // txtgolAnota
            // 
            this.txtgolAnota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgolAnota.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgolAnota.Location = new System.Drawing.Point(343, 158);
            this.txtgolAnota.Name = "txtgolAnota";
            this.txtgolAnota.Size = new System.Drawing.Size(609, 39);
            this.txtgolAnota.TabIndex = 48;
            // 
            // txttirosmarco
            // 
            this.txttirosmarco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttirosmarco.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttirosmarco.Location = new System.Drawing.Point(343, 210);
            this.txttirosmarco.Name = "txttirosmarco";
            this.txttirosmarco.Size = new System.Drawing.Size(609, 39);
            this.txttirosmarco.TabIndex = 49;
            // 
            // txttirosdes
            // 
            this.txttirosdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttirosdes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttirosdes.Location = new System.Drawing.Point(343, 260);
            this.txttirosdes.Name = "txttirosdes";
            this.txttirosdes.Size = new System.Drawing.Size(609, 39);
            this.txttirosdes.TabIndex = 50;
            // 
            // txttarama
            // 
            this.txttarama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttarama.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarama.Location = new System.Drawing.Point(343, 311);
            this.txttarama.Name = "txttarama";
            this.txttarama.Size = new System.Drawing.Size(609, 39);
            this.txttarama.TabIndex = 51;
            // 
            // txttarroja
            // 
            this.txttarroja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttarroja.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarroja.Location = new System.Drawing.Point(343, 358);
            this.txttarroja.Name = "txttarroja";
            this.txttarroja.Size = new System.Drawing.Size(609, 39);
            this.txttarroja.TabIndex = 52;
            // 
            // txtminjug
            // 
            this.txtminjug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtminjug.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminjug.Location = new System.Drawing.Point(343, 410);
            this.txtminjug.Name = "txtminjug";
            this.txtminjug.Size = new System.Drawing.Size(609, 39);
            this.txtminjug.TabIndex = 53;
            // 
            // txtasistencias
            // 
            this.txtasistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtasistencias.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasistencias.Location = new System.Drawing.Point(343, 462);
            this.txtasistencias.Name = "txtasistencias";
            this.txtasistencias.Size = new System.Drawing.Size(609, 39);
            this.txtasistencias.TabIndex = 54;
            // 
            // btbmodificar
            // 
            this.btbmodificar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbmodificar.Location = new System.Drawing.Point(1015, 308);
            this.btbmodificar.Name = "btbmodificar";
            this.btbmodificar.Size = new System.Drawing.Size(198, 73);
            this.btbmodificar.TabIndex = 58;
            this.btbmodificar.Text = "Editar";
            this.btbmodificar.UseVisualStyleBackColor = true;
            this.btbmodificar.Click += new System.EventHandler(this.btbmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(1015, 394);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(198, 73);
            this.btneliminar.TabIndex = 57;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1015, 224);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 73);
            this.btnagregar.TabIndex = 56;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1015, 138);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(198, 73);
            this.btnbuscar.TabIndex = 55;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // dgEstadJug
            // 
            this.dgEstadJug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstadJug.Location = new System.Drawing.Point(33, 529);
            this.dgEstadJug.Name = "dgEstadJug";
            this.dgEstadJug.RowHeadersWidth = 51;
            this.dgEstadJug.RowTemplate.Height = 24;
            this.dgEstadJug.Size = new System.Drawing.Size(933, 202);
            this.dgEstadJug.TabIndex = 60;
            // 
            // FormEstadisJuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 743);
            this.Controls.Add(this.dgEstadJug);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtasistencias);
            this.Controls.Add(this.txtminjug);
            this.Controls.Add(this.txttarroja);
            this.Controls.Add(this.txttarama);
            this.Controls.Add(this.txttirosdes);
            this.Controls.Add(this.txttirosmarco);
            this.Controls.Add(this.txtgolAnota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodjuga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisJuga";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormEstadisJuga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadJug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodjuga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgolAnota;
        private System.Windows.Forms.TextBox txttirosmarco;
        private System.Windows.Forms.TextBox txttirosdes;
        private System.Windows.Forms.TextBox txttarama;
        private System.Windows.Forms.TextBox txttarroja;
        private System.Windows.Forms.TextBox txtminjug;
        private System.Windows.Forms.TextBox txtasistencias;
        private System.Windows.Forms.Button btbmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgEstadJug;
    }
}