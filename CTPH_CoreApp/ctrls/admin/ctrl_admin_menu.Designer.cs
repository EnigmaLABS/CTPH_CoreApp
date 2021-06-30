namespace CTPH_CoreApp.ctrls.admin
{
    partial class ctrl_admin_menu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdElementos = new System.Windows.Forms.Button();
            this.cmdPuntosDeMedida = new System.Windows.Forms.Button();
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 157);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige qué elementos quieres administrar";
            // 
            // cmdElementos
            // 
            this.cmdElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdElementos.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdElementos.ForeColor = System.Drawing.Color.Coral;
            this.cmdElementos.Location = new System.Drawing.Point(35, 211);
            this.cmdElementos.Name = "cmdElementos";
            this.cmdElementos.Size = new System.Drawing.Size(533, 103);
            this.cmdElementos.TabIndex = 1;
            this.cmdElementos.Text = "1. Situación ambiente - Elementos";
            this.cmdElementos.UseVisualStyleBackColor = true;
            // 
            // cmdPuntosDeMedida
            // 
            this.cmdPuntosDeMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPuntosDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPuntosDeMedida.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPuntosDeMedida.ForeColor = System.Drawing.Color.Coral;
            this.cmdPuntosDeMedida.Location = new System.Drawing.Point(35, 345);
            this.cmdPuntosDeMedida.Name = "cmdPuntosDeMedida";
            this.cmdPuntosDeMedida.Size = new System.Drawing.Size(533, 103);
            this.cmdPuntosDeMedida.TabIndex = 1;
            this.cmdPuntosDeMedida.Text = "2. Puntos de medida";
            this.cmdPuntosDeMedida.UseVisualStyleBackColor = true;
            // 
            // lnkAtras
            // 
            this.lnkAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAtras.AutoSize = true;
            this.lnkAtras.BackColor = System.Drawing.Color.Transparent;
            this.lnkAtras.Location = new System.Drawing.Point(567, 732);
            this.lnkAtras.Name = "lnkAtras";
            this.lnkAtras.Size = new System.Drawing.Size(34, 15);
            this.lnkAtras.TabIndex = 2;
            this.lnkAtras.TabStop = true;
            this.lnkAtras.Text = "Atrás";
            this.lnkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAtras_LinkClicked);
            // 
            // ctrl_admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.cmdPuntosDeMedida);
            this.Controls.Add(this.cmdElementos);
            this.Controls.Add(this.label1);
            this.Name = "ctrl_admin_menu";
            this.Size = new System.Drawing.Size(601, 747);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdElementos;
        private System.Windows.Forms.Button cmdPuntosDeMedida;
        private System.Windows.Forms.LinkLabel lnkAtras;
    }
}
