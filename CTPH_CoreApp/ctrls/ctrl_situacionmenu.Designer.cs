namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_situacionmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_situacionmenu));
            this.label1 = new System.Windows.Forms.Label();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.picOK = new System.Windows.Forms.PictureBox();
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.picAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
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
            this.label1.Text = "Selecciona los elementos de la muestra";
            // 
            // lvElementos
            // 
            this.lvElementos.BackColor = System.Drawing.Color.White;
            this.lvElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvElementos.CheckBoxes = true;
            this.lvElementos.Font = new System.Drawing.Font("Tekton Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(14, 160);
            this.lvElementos.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(485, 587);
            this.lvElementos.TabIndex = 1;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            this.lvElementos.DoubleClick += new System.EventHandler(this.lvElementos_DoubleClick);
            // 
            // picOK
            // 
            this.picOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOK.Image = ((System.Drawing.Image)(resources.GetObject("picOK.Image")));
            this.picOK.Location = new System.Drawing.Point(519, 170);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(67, 63);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOK.TabIndex = 3;
            this.picOK.TabStop = false;
            this.picOK.Click += new System.EventHandler(this.picOK_Click);
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
            // picPerfil
            // 
            this.picPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
            this.picPerfil.Location = new System.Drawing.Point(519, 239);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(67, 63);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 3;
            this.picPerfil.TabStop = false;
            this.picPerfil.Click += new System.EventHandler(this.picPerfil_Click);
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = ((System.Drawing.Image)(resources.GetObject("picAtras.Image")));
            this.picAtras.Location = new System.Drawing.Point(519, 308);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(67, 63);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 3;
            this.picAtras.TabStop = false;
            this.picAtras.Visible = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // ctrl_situacionmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picAtras);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.label1);
            this.Name = "ctrl_situacionmenu";
            this.Size = new System.Drawing.Size(601, 747);
            this.Load += new System.EventHandler(this.ctrl_situacionmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.LinkLabel lnkAtras;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.PictureBox picAtras;
    }
}
