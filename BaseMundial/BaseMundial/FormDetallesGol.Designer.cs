namespace BaseMundial
{
    partial class FormDetallesGol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallesGol));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgGol = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtjugaasisten = new System.Windows.Forms.TextBox();
            this.txtjugagol = new System.Windows.Forms.TextBox();
            this.txtselecc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodgol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttipogol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(1149, 707);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 38);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "DETALLES DE LOS GOLES ANOTADOS";
            // 
            // dgGol
            // 
            this.dgGol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGol.Location = new System.Drawing.Point(28, 392);
            this.dgGol.Name = "dgGol";
            this.dgGol.RowHeadersWidth = 51;
            this.dgGol.RowTemplate.Height = 24;
            this.dgGol.Size = new System.Drawing.Size(942, 340);
            this.dgGol.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(992, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // btbmodificar
            // 
            this.btbmodificar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbmodificar.Location = new System.Drawing.Point(1018, 253);
            this.btbmodificar.Name = "btbmodificar";
            this.btbmodificar.Size = new System.Drawing.Size(198, 73);
            this.btbmodificar.TabIndex = 98;
            this.btbmodificar.Text = "Editar";
            this.btbmodificar.UseVisualStyleBackColor = true;
            this.btbmodificar.Click += new System.EventHandler(this.btbmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(1018, 339);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(198, 73);
            this.btneliminar.TabIndex = 97;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(1018, 169);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 73);
            this.btnagregar.TabIndex = 96;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1018, 83);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(198, 73);
            this.btnbuscar.TabIndex = 95;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtjugaasisten
            // 
            this.txtjugaasisten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtjugaasisten.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjugaasisten.Location = new System.Drawing.Point(320, 241);
            this.txtjugaasisten.Name = "txtjugaasisten";
            this.txtjugaasisten.Size = new System.Drawing.Size(609, 39);
            this.txtjugaasisten.TabIndex = 92;
            // 
            // txtjugagol
            // 
            this.txtjugagol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtjugagol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjugagol.Location = new System.Drawing.Point(320, 191);
            this.txtjugagol.Name = "txtjugagol";
            this.txtjugagol.Size = new System.Drawing.Size(609, 39);
            this.txtjugagol.TabIndex = 91;
            // 
            // txtselecc
            // 
            this.txtselecc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtselecc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtselecc.Location = new System.Drawing.Point(320, 139);
            this.txtselecc.Name = "txtselecc";
            this.txtselecc.Size = new System.Drawing.Size(609, 39);
            this.txtselecc.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 41);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tipo de Gol :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 41);
            this.label5.TabIndex = 87;
            this.label5.Text = "Jugador Asistente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 41);
            this.label4.TabIndex = 86;
            this.label4.Text = "Jugador Gol :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 41);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nombre Seleccion :";
            // 
            // txtcodgol
            // 
            this.txtcodgol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodgol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodgol.Location = new System.Drawing.Point(320, 86);
            this.txtcodgol.Name = "txtcodgol";
            this.txtcodgol.Size = new System.Drawing.Size(609, 39);
            this.txtcodgol.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 41);
            this.label10.TabIndex = 83;
            this.label10.Text = "Código del Gol :";
            // 
            // txttipogol
            // 
            this.txttipogol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipogol.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipogol.Location = new System.Drawing.Point(320, 292);
            this.txttipogol.Name = "txttipogol";
            this.txttipogol.Size = new System.Drawing.Size(609, 39);
            this.txttipogol.TabIndex = 93;
            // 
            // FormDetallesGol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1265, 752);
            this.Controls.Add(this.dgGol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txttipogol);
            this.Controls.Add(this.txtjugaasisten);
            this.Controls.Add(this.txtjugagol);
            this.Controls.Add(this.txtselecc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodgol);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormDetallesGol";
            this.Text = "FormDetallesGol";
            this.Load += new System.EventHandler(this.FormDetallesGol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgGol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtjugaasisten;
        private System.Windows.Forms.TextBox txtjugagol;
        private System.Windows.Forms.TextBox txtselecc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodgol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttipogol;
    }
}