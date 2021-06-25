namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_addvalormedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_addvalormedida));
            this.lblPM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.PictureBox();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.BackColor = System.Drawing.Color.Coral;
            this.lblPM.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPM.Location = new System.Drawing.Point(43, 74);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(44, 30);
            this.lblPM.TabIndex = 1;
            this.lblPM.Text = "PM";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 157);
            this.label2.TabIndex = 0;
            this.label2.Text = "Introduce los valores de la medida:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperatura.Font = new System.Drawing.Font("Tekton Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTemperatura.ForeColor = System.Drawing.Color.Black;
            this.txtTemperatura.Location = new System.Drawing.Point(92, 238);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(279, 42);
            this.txtTemperatura.TabIndex = 0;
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(279, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperatura";
            // 
            // cmdOK
            // 
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOK.Image = ((System.Drawing.Image)(resources.GetObject("cmdOK.Image")));
            this.cmdOK.Location = new System.Drawing.Point(441, 197);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(67, 63);
            this.cmdOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdOK.TabIndex = 3;
            this.cmdOK.TabStop = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtHumedad
            // 
            this.txtHumedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHumedad.Font = new System.Drawing.Font("Tekton Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHumedad.ForeColor = System.Drawing.Color.Black;
            this.txtHumedad.Location = new System.Drawing.Point(92, 342);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(279, 42);
            this.txtHumedad.TabIndex = 1;
            this.txtHumedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHumedad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHumedad_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(279, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Humedad";
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
            // ctrl_addvalormedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHumedad);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.label2);
            this.Name = "ctrl_addvalormedida";
            this.Size = new System.Drawing.Size(601, 747);
            this.Load += new System.EventHandler(this.ctrl_addvalormedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cmdOK;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkAtras;
    }
}
