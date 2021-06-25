namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_AddValorElemento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_AddValorElemento));
            this.label1 = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            this.panelValorTextBox = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblTipoValor = new System.Windows.Forms.Label();
            this.picOK = new System.Windows.Forms.PictureBox();
            this.panelBooleano = new System.Windows.Forms.Panel();
            this.cmdTrue = new System.Windows.Forms.Button();
            this.cmdFalse = new System.Windows.Forms.Button();
            this.panelValorLista = new System.Windows.Forms.Panel();
            this.lvListaValores = new System.Windows.Forms.ListView();
            this.panelValorTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            this.panelBooleano.SuspendLayout();
            this.panelValorLista.SuspendLayout();
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
            this.label1.Text = "Introduce valor para:";
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.BackColor = System.Drawing.Color.Coral;
            this.lblElemento.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElemento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblElemento.Location = new System.Drawing.Point(92, 66);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(165, 47);
            this.lblElemento.TabIndex = 1;
            this.lblElemento.Text = "Elemento";
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
            // panelValorTextBox
            // 
            this.panelValorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelValorTextBox.Controls.Add(this.txtValor);
            this.panelValorTextBox.Controls.Add(this.lblTipoValor);
            this.panelValorTextBox.Controls.Add(this.picOK);
            this.panelValorTextBox.Location = new System.Drawing.Point(16, 179);
            this.panelValorTextBox.Name = "panelValorTextBox";
            this.panelValorTextBox.Size = new System.Drawing.Size(548, 161);
            this.panelValorTextBox.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Tekton Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(76, 59);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(279, 42);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyUp);
            // 
            // lblTipoValor
            // 
            this.lblTipoValor.AutoSize = true;
            this.lblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoValor.ForeColor = System.Drawing.Color.Coral;
            this.lblTipoValor.Location = new System.Drawing.Point(247, 104);
            this.lblTipoValor.Name = "lblTipoValor";
            this.lblTipoValor.Size = new System.Drawing.Size(108, 18);
            this.lblTipoValor.TabIndex = 4;
            this.lblTipoValor.Text = "Valor numérico";
            // 
            // picOK
            // 
            this.picOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOK.Image = ((System.Drawing.Image)(resources.GetObject("picOK.Image")));
            this.picOK.Location = new System.Drawing.Point(386, 38);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(67, 63);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOK.TabIndex = 3;
            this.picOK.TabStop = false;
            this.picOK.Click += new System.EventHandler(this.picOK_Click);
            // 
            // panelBooleano
            // 
            this.panelBooleano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBooleano.Controls.Add(this.cmdTrue);
            this.panelBooleano.Controls.Add(this.cmdFalse);
            this.panelBooleano.Location = new System.Drawing.Point(16, 346);
            this.panelBooleano.Name = "panelBooleano";
            this.panelBooleano.Size = new System.Drawing.Size(548, 161);
            this.panelBooleano.TabIndex = 5;
            this.panelBooleano.Visible = false;
            // 
            // cmdTrue
            // 
            this.cmdTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTrue.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdTrue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdTrue.Location = new System.Drawing.Point(306, 37);
            this.cmdTrue.Name = "cmdTrue";
            this.cmdTrue.Size = new System.Drawing.Size(220, 103);
            this.cmdTrue.TabIndex = 1;
            this.cmdTrue.Text = "Verdadero";
            this.cmdTrue.UseVisualStyleBackColor = true;
            this.cmdTrue.Click += new System.EventHandler(this.cmdTrue_Click);
            // 
            // cmdFalse
            // 
            this.cmdFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFalse.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdFalse.ForeColor = System.Drawing.Color.Red;
            this.cmdFalse.Location = new System.Drawing.Point(55, 37);
            this.cmdFalse.Name = "cmdFalse";
            this.cmdFalse.Size = new System.Drawing.Size(220, 103);
            this.cmdFalse.TabIndex = 1;
            this.cmdFalse.Text = "Falso";
            this.cmdFalse.UseVisualStyleBackColor = true;
            this.cmdFalse.Click += new System.EventHandler(this.cmdFalse_Click);
            // 
            // panelValorLista
            // 
            this.panelValorLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelValorLista.Controls.Add(this.lvListaValores);
            this.panelValorLista.Location = new System.Drawing.Point(16, 513);
            this.panelValorLista.Name = "panelValorLista";
            this.panelValorLista.Size = new System.Drawing.Size(548, 234);
            this.panelValorLista.TabIndex = 5;
            this.panelValorLista.Visible = false;
            // 
            // lvListaValores
            // 
            this.lvListaValores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvListaValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvListaValores.Font = new System.Drawing.Font("Tekton Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvListaValores.HideSelection = false;
            this.lvListaValores.Location = new System.Drawing.Point(0, 0);
            this.lvListaValores.Name = "lvListaValores";
            this.lvListaValores.Size = new System.Drawing.Size(548, 222);
            this.lvListaValores.TabIndex = 0;
            this.lvListaValores.UseCompatibleStateImageBehavior = false;
            this.lvListaValores.View = System.Windows.Forms.View.List;
            this.lvListaValores.DoubleClick += new System.EventHandler(this.lvListaValores_DoubleClick);
            // 
            // ctrl_AddValorElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelValorLista);
            this.Controls.Add(this.panelBooleano);
            this.Controls.Add(this.panelValorTextBox);
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.label1);
            this.Name = "ctrl_AddValorElemento";
            this.Size = new System.Drawing.Size(601, 747);
            this.Load += new System.EventHandler(this.ctrl_AddValorElemento_Load);
            this.panelValorTextBox.ResumeLayout(false);
            this.panelValorTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            this.panelBooleano.ResumeLayout(false);
            this.panelValorLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.LinkLabel lnkAtras;
        private System.Windows.Forms.Panel panelValorTextBox;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTipoValor;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.Panel panelBooleano;
        private System.Windows.Forms.Button cmdTrue;
        private System.Windows.Forms.Button cmdFalse;
        private System.Windows.Forms.Panel panelValorLista;
        private System.Windows.Forms.ListView lvListaValores;
    }
}
