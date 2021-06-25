namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_bienvenida
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
            this.cmdTomarMuestra = new System.Windows.Forms.Button();
            this.cmdConfigurar = new System.Windows.Forms.Button();
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
            this.label1.Text = "Bienvenido a la App para el control de temperatura de tu hogar. \r\n¿Qué quieres ha" +
    "cer ?";
            // 
            // cmdTomarMuestra
            // 
            this.cmdTomarMuestra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTomarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTomarMuestra.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdTomarMuestra.Location = new System.Drawing.Point(33, 210);
            this.cmdTomarMuestra.Name = "cmdTomarMuestra";
            this.cmdTomarMuestra.Size = new System.Drawing.Size(533, 103);
            this.cmdTomarMuestra.TabIndex = 1;
            this.cmdTomarMuestra.Text = "Tomar una muestra";
            this.cmdTomarMuestra.UseVisualStyleBackColor = true;
            this.cmdTomarMuestra.Click += new System.EventHandler(this.cmdTomarMuestra_Click);
            // 
            // cmdConfigurar
            // 
            this.cmdConfigurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfigurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfigurar.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdConfigurar.Location = new System.Drawing.Point(33, 344);
            this.cmdConfigurar.Name = "cmdConfigurar";
            this.cmdConfigurar.Size = new System.Drawing.Size(533, 103);
            this.cmdConfigurar.TabIndex = 1;
            this.cmdConfigurar.Text = "Configurar la App";
            this.cmdConfigurar.UseVisualStyleBackColor = true;
            this.cmdConfigurar.Click += new System.EventHandler(this.cmdConfigurar_Click);
            // 
            // ctrl_bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmdConfigurar);
            this.Controls.Add(this.cmdTomarMuestra);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "ctrl_bienvenida";
            this.Size = new System.Drawing.Size(601, 747);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdTomarMuestra;
        private System.Windows.Forms.Button cmdConfigurar;
    }
}
