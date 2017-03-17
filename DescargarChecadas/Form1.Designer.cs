namespace DescargarChecadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbChecador = new System.Windows.Forms.Label();
            this.tbResultados = new System.Windows.Forms.TextBox();
            this.btnDescargarChecadas = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descargar Registros del Checador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChecador
            // 
            this.lbChecador.AutoSize = true;
            this.lbChecador.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbChecador.Location = new System.Drawing.Point(451, 54);
            this.lbChecador.Name = "lbChecador";
            this.lbChecador.Size = new System.Drawing.Size(96, 23);
            this.lbChecador.TabIndex = 1;
            this.lbChecador.Text = "Checador:";
            // 
            // tbResultados
            // 
            this.tbResultados.BackColor = System.Drawing.Color.White;
            this.tbResultados.Font = new System.Drawing.Font("Consolas", 12F);
            this.tbResultados.Location = new System.Drawing.Point(12, 83);
            this.tbResultados.Multiline = true;
            this.tbResultados.Name = "tbResultados";
            this.tbResultados.ReadOnly = true;
            this.tbResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultados.Size = new System.Drawing.Size(971, 428);
            this.tbResultados.TabIndex = 2;
            // 
            // btnDescargarChecadas
            // 
            this.btnDescargarChecadas.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarChecadas.Image")));
            this.btnDescargarChecadas.Location = new System.Drawing.Point(837, 12);
            this.btnDescargarChecadas.Name = "btnDescargarChecadas";
            this.btnDescargarChecadas.Size = new System.Drawing.Size(65, 65);
            this.btnDescargarChecadas.TabIndex = 3;
            this.btnDescargarChecadas.UseVisualStyleBackColor = true;
            this.btnDescargarChecadas.Click += new System.EventHandler(this.btnDescargarChecadas_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(92, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(65, 65);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCerrar.Location = new System.Drawing.Point(837, 522);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 44);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 579);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnDescargarChecadas);
            this.Controls.Add(this.tbResultados);
            this.Controls.Add(this.lbChecador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descargar Checadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChecador;
        private System.Windows.Forms.TextBox tbResultados;
        private System.Windows.Forms.Button btnDescargarChecadas;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnCerrar;
    }
}

