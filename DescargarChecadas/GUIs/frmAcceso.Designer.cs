namespace DescargarChecadas.GUIs
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPCancelar = new System.Windows.Forms.Button();
            this.btnPAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPCveAnt = new System.Windows.Forms.TextBox();
            this.tbPConfirmCve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPCveNueva = new System.Windows.Forms.TextBox();
            this.btnCambCve = new System.Windows.Forms.Button();
            this.tbAccess = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPCancelar);
            this.panel1.Controls.Add(this.btnPAceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPCveAnt);
            this.panel1.Controls.Add(this.tbPConfirmCve);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPCveNueva);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 331);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cambiar Clave";
            // 
            // btnPCancelar
            // 
            this.btnPCancelar.Location = new System.Drawing.Point(138, 282);
            this.btnPCancelar.Name = "btnPCancelar";
            this.btnPCancelar.Size = new System.Drawing.Size(124, 38);
            this.btnPCancelar.TabIndex = 12;
            this.btnPCancelar.Text = "Cancelar";
            this.btnPCancelar.UseVisualStyleBackColor = true;
            this.btnPCancelar.Click += new System.EventHandler(this.btnPCancelar_Click);
            // 
            // btnPAceptar
            // 
            this.btnPAceptar.Location = new System.Drawing.Point(8, 282);
            this.btnPAceptar.Name = "btnPAceptar";
            this.btnPAceptar.Size = new System.Drawing.Size(124, 38);
            this.btnPAceptar.TabIndex = 11;
            this.btnPAceptar.Text = "Aceptar";
            this.btnPAceptar.UseVisualStyleBackColor = true;
            this.btnPAceptar.Click += new System.EventHandler(this.btnPAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave anterior";
            // 
            // tbPCveAnt
            // 
            this.tbPCveAnt.Location = new System.Drawing.Point(11, 94);
            this.tbPCveAnt.Name = "tbPCveAnt";
            this.tbPCveAnt.PasswordChar = '*';
            this.tbPCveAnt.Size = new System.Drawing.Size(251, 30);
            this.tbPCveAnt.TabIndex = 6;
            // 
            // tbPConfirmCve
            // 
            this.tbPConfirmCve.Location = new System.Drawing.Point(11, 233);
            this.tbPConfirmCve.Name = "tbPConfirmCve";
            this.tbPConfirmCve.PasswordChar = '*';
            this.tbPConfirmCve.Size = new System.Drawing.Size(251, 30);
            this.tbPConfirmCve.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clave nueva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Clave";
            // 
            // tbPCveNueva
            // 
            this.tbPCveNueva.Location = new System.Drawing.Point(11, 162);
            this.tbPCveNueva.Name = "tbPCveNueva";
            this.tbPCveNueva.PasswordChar = '*';
            this.tbPCveNueva.Size = new System.Drawing.Size(251, 30);
            this.tbPCveNueva.TabIndex = 8;
            // 
            // btnCambCve
            // 
            this.btnCambCve.Location = new System.Drawing.Point(13, 116);
            this.btnCambCve.Name = "btnCambCve";
            this.btnCambCve.Size = new System.Drawing.Size(272, 38);
            this.btnCambCve.TabIndex = 18;
            this.btnCambCve.Text = "Cambiar Clave";
            this.btnCambCve.UseVisualStyleBackColor = true;
            this.btnCambCve.Click += new System.EventHandler(this.btnCambCve_Click);
            // 
            // tbAccess
            // 
            this.tbAccess.Location = new System.Drawing.Point(13, 36);
            this.tbAccess.Name = "tbAccess";
            this.tbAccess.PasswordChar = '*';
            this.tbAccess.Size = new System.Drawing.Size(272, 30);
            this.tbAccess.TabIndex = 17;
            this.tbAccess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccess_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 72);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 38);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Introduzca la clave de acceso";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 72);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 38);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCambCve);
            this.Controls.Add(this.tbAccess);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPCancelar;
        private System.Windows.Forms.Button btnPAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPCveAnt;
        private System.Windows.Forms.TextBox tbPConfirmCve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPCveNueva;
        private System.Windows.Forms.Button btnCambCve;
        private System.Windows.Forms.TextBox tbAccess;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}