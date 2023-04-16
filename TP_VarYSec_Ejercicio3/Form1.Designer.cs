namespace TP_VarYSec_Ejercicio3
{
    partial class fRevoque
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bRevoque = new System.Windows.Forms.Button();
            this.lAlto = new System.Windows.Forms.Label();
            this.lAncho = new System.Windows.Forms.Label();
            this.tAlto = new System.Windows.Forms.TextBox();
            this.tAncho = new System.Windows.Forms.TextBox();
            this.lMetrosAl = new System.Windows.Forms.Label();
            this.lMetrosAn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(459, 249);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bRevoque
            // 
            this.bRevoque.Location = new System.Drawing.Point(365, 249);
            this.bRevoque.Name = "bRevoque";
            this.bRevoque.Size = new System.Drawing.Size(75, 23);
            this.bRevoque.TabIndex = 1;
            this.bRevoque.Text = "Revoque";
            this.bRevoque.UseVisualStyleBackColor = true;
            this.bRevoque.Click += new System.EventHandler(this.bRevoque_Click);
            // 
            // lAlto
            // 
            this.lAlto.AutoSize = true;
            this.lAlto.Location = new System.Drawing.Point(121, 70);
            this.lAlto.Name = "lAlto";
            this.lAlto.Size = new System.Drawing.Size(28, 13);
            this.lAlto.TabIndex = 2;
            this.lAlto.Text = "Alto:";
            // 
            // lAncho
            // 
            this.lAncho.AutoSize = true;
            this.lAncho.Location = new System.Drawing.Point(108, 110);
            this.lAncho.Name = "lAncho";
            this.lAncho.Size = new System.Drawing.Size(41, 13);
            this.lAncho.TabIndex = 3;
            this.lAncho.Text = "Ancho:";
            // 
            // tAlto
            // 
            this.tAlto.Location = new System.Drawing.Point(155, 67);
            this.tAlto.Name = "tAlto";
            this.tAlto.Size = new System.Drawing.Size(100, 20);
            this.tAlto.TabIndex = 4;
            // 
            // tAncho
            // 
            this.tAncho.Location = new System.Drawing.Point(155, 107);
            this.tAncho.Name = "tAncho";
            this.tAncho.Size = new System.Drawing.Size(100, 20);
            this.tAncho.TabIndex = 5;
            // 
            // lMetrosAl
            // 
            this.lMetrosAl.AutoSize = true;
            this.lMetrosAl.Location = new System.Drawing.Point(262, 69);
            this.lMetrosAl.Name = "lMetrosAl";
            this.lMetrosAl.Size = new System.Drawing.Size(23, 13);
            this.lMetrosAl.TabIndex = 6;
            this.lMetrosAl.Text = "mts";
            // 
            // lMetrosAn
            // 
            this.lMetrosAn.AutoSize = true;
            this.lMetrosAn.Location = new System.Drawing.Point(261, 110);
            this.lMetrosAn.Name = "lMetrosAn";
            this.lMetrosAn.Size = new System.Drawing.Size(23, 13);
            this.lMetrosAn.TabIndex = 7;
            this.lMetrosAn.Text = "mts";
            // 
            // fRevoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 294);
            this.Controls.Add(this.lMetrosAn);
            this.Controls.Add(this.lMetrosAl);
            this.Controls.Add(this.tAncho);
            this.Controls.Add(this.tAlto);
            this.Controls.Add(this.lAncho);
            this.Controls.Add(this.lAlto);
            this.Controls.Add(this.bRevoque);
            this.Controls.Add(this.bCerrar);
            this.Name = "fRevoque";
            this.Text = "Pared";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bRevoque;
        private System.Windows.Forms.Label lAlto;
        private System.Windows.Forms.Label lAncho;
        private System.Windows.Forms.TextBox tAlto;
        private System.Windows.Forms.TextBox tAncho;
        private System.Windows.Forms.Label lMetrosAl;
        private System.Windows.Forms.Label lMetrosAn;
    }
}

