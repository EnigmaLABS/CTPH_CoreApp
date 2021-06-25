namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_menumuestra
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
            this.cmdMuestra = new System.Windows.Forms.Button();
            this.cmdSituacion = new System.Windows.Forms.Button();
            this.cmdAll = new System.Windows.Forms.Button();
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
            this.label1.Text = "¿Qué tipo de muestra?";
            // 
            // cmdMuestra
            // 
            this.cmdMuestra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMuestra.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdMuestra.ForeColor = System.Drawing.Color.Coral;
            this.cmdMuestra.Location = new System.Drawing.Point(33, 210);
            this.cmdMuestra.Name = "cmdMuestra";
            this.cmdMuestra.Size = new System.Drawing.Size(533, 103);
            this.cmdMuestra.TabIndex = 1;
            this.cmdMuestra.Text = "Solo muestra";
            this.cmdMuestra.UseVisualStyleBackColor = true;
            this.cmdMuestra.Click += new System.EventHandler(this.cmdMuestra_Click);
            // 
            // cmdSituacion
            // 
            this.cmdSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSituacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSituacion.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSituacion.ForeColor = System.Drawing.Color.Coral;
            this.cmdSituacion.Location = new System.Drawing.Point(33, 346);
            this.cmdSituacion.Name = "cmdSituacion";
            this.cmdSituacion.Size = new System.Drawing.Size(533, 103);
            this.cmdSituacion.TabIndex = 1;
            this.cmdSituacion.Text = "Solo situación ambiente";
            this.cmdSituacion.UseVisualStyleBackColor = true;
            this.cmdSituacion.Click += new System.EventHandler(this.cmdSituacion_Click);
            // 
            // cmdAll
            // 
            this.cmdAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAll.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAll.ForeColor = System.Drawing.Color.Coral;
            this.cmdAll.Location = new System.Drawing.Point(33, 480);
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(533, 103);
            this.cmdAll.TabIndex = 1;
            this.cmdAll.Text = "Muestra y situación ambiente";
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
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
            // ctrl_menumuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.cmdAll);
            this.Controls.Add(this.cmdSituacion);
            this.Controls.Add(this.cmdMuestra);
            this.Controls.Add(this.label1);
            this.Name = "ctrl_menumuestra";
            this.Size = new System.Drawing.Size(601, 747);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdMuestra;
        private System.Windows.Forms.Button cmdSituacion;
        private System.Windows.Forms.Button cmdAll;
        private System.Windows.Forms.LinkLabel lnkAtras;
    }
}
