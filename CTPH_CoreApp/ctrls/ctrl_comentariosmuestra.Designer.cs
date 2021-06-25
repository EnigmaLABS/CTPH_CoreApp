namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_comentariosmuestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_comentariosmuestra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.picOK = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
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
            this.label1.Text = "¡ Muy bien !\r\nFinalmente grabaremos la muestra\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Tekton Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtObservaciones.Location = new System.Drawing.Point(69, 223);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(357, 188);
            this.txtObservaciones.TabIndex = 2;
            this.txtObservaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtObservaciones_KeyUp);
            // 
            // picOK
            // 
            this.picOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOK.Image = ((System.Drawing.Image)(resources.GetObject("picOK.Image")));
            this.picOK.Location = new System.Drawing.Point(452, 202);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(67, 63);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOK.TabIndex = 3;
            this.picOK.TabStop = false;
            this.picOK.Click += new System.EventHandler(this.picOK_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(567, 732);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Atrás";
            // 
            // ctrl_comentariosmuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ctrl_comentariosmuestra";
            this.Size = new System.Drawing.Size(601, 747);
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
