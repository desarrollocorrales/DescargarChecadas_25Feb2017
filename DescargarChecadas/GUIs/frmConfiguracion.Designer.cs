namespace DescargarChecadas.GUIs
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNomChecador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tbNumChec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(167, 510);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumChec);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbNomChecador);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPuerto);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checador";
            // 
            // tbNomChecador
            // 
            this.tbNomChecador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomChecador.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbNomChecador.Location = new System.Drawing.Point(91, 105);
            this.tbNomChecador.MaxLength = 50;
            this.tbNomChecador.Name = "tbNomChecador";
            this.tbNomChecador.Size = new System.Drawing.Size(147, 24);
            this.tbNomChecador.TabIndex = 5;
            this.tbNomChecador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label7.Location = new System.Drawing.Point(19, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Checador:";
            // 
            // tbPuerto
            // 
            this.tbPuerto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbPuerto.Location = new System.Drawing.Point(91, 60);
            this.tbPuerto.MaxLength = 10;
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(147, 24);
            this.tbPuerto.TabIndex = 3;
            this.tbPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbIP.Location = new System.Drawing.Point(91, 30);
            this.tbIP.MaxLength = 20;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(147, 24);
            this.tbIP.TabIndex = 2;
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbServidor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbBaseDeDatos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTestConn);
            this.groupBox2.Controls.Add(this.tbContrasenia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbUsuario);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(15, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 267);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de datos";
            // 
            // tbServidor
            // 
            this.tbServidor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbServidor.Location = new System.Drawing.Point(13, 42);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(235, 24);
            this.tbServidor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Servidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario";
            // 
            // tbBaseDeDatos
            // 
            this.tbBaseDeDatos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbBaseDeDatos.Location = new System.Drawing.Point(13, 189);
            this.tbBaseDeDatos.Name = "tbBaseDeDatos";
            this.tbBaseDeDatos.Size = new System.Drawing.Size(235, 24);
            this.tbBaseDeDatos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label5.Location = new System.Drawing.Point(10, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // btnTestConn
            // 
            this.btnTestConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTestConn.Location = new System.Drawing.Point(75, 225);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(106, 23);
            this.btnTestConn.TabIndex = 14;
            this.btnTestConn.Text = "Probar Conexión";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbContrasenia.Location = new System.Drawing.Point(13, 141);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(235, 24);
            this.tbContrasenia.TabIndex = 9;
            this.tbContrasenia.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label6.Location = new System.Drawing.Point(10, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Base de Datos";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbUsuario.Location = new System.Drawing.Point(13, 90);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(235, 24);
            this.tbUsuario.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label8.Location = new System.Drawing.Point(46, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "BlackWhite",
            "TFT"});
            this.cmbTipo.Location = new System.Drawing.Point(91, 135);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(147, 24);
            this.cmbTipo.TabIndex = 7;
            // 
            // tbNumChec
            // 
            this.tbNumChec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumChec.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbNumChec.Location = new System.Drawing.Point(91, 165);
            this.tbNumChec.MaxLength = 50;
            this.tbNumChec.Name = "tbNumChec";
            this.tbNumChec.Size = new System.Drawing.Size(147, 24);
            this.tbNumChec.TabIndex = 9;
            this.tbNumChec.Text = "1";
            this.tbNumChec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label9.Location = new System.Drawing.Point(6, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Núm. Chec.:";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBaseDeDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbNomChecador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumChec;
        private System.Windows.Forms.Label label9;
    }
}