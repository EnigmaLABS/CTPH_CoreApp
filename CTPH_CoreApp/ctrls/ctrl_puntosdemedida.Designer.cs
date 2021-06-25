namespace CTPH_CoreApp.ctrls
{
    partial class ctrl_puntosdemedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_puntosdemedida));
            this.label1 = new System.Windows.Forms.Label();
            this.lvPuntosDeMedida = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cmdOK = new System.Windows.Forms.PictureBox();
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            this.lnkTodos = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOK)).BeginInit();
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
            this.label1.Text = "Selecciona los puntos de medida de la muestra";
            // 
            // lvPuntosDeMedida
            // 
            this.lvPuntosDeMedida.BackColor = System.Drawing.Color.White;
            this.lvPuntosDeMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPuntosDeMedida.CheckBoxes = true;
            this.lvPuntosDeMedida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPuntosDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvPuntosDeMedida.HideSelection = false;
            this.lvPuntosDeMedida.Location = new System.Drawing.Point(17, 212);
            this.lvPuntosDeMedida.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.lvPuntosDeMedida.Name = "lvPuntosDeMedida";
            this.lvPuntosDeMedida.Size = new System.Drawing.Size(502, 527);
            this.lvPuntosDeMedida.TabIndex = 1;
            this.lvPuntosDeMedida.UseCompatibleStateImageBehavior = false;
            this.lvPuntosDeMedida.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Punto de medida";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 300;
            // 
            // cmdOK
            // 
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOK.Image = ((System.Drawing.Image)(resources.GetObject("cmdOK.Image")));
            this.cmdOK.Location = new System.Drawing.Point(525, 175);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(67, 63);
            this.cmdOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdOK.TabIndex = 3;
            this.cmdOK.TabStop = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
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
            // lnkTodos
            // 
            this.lnkTodos.AutoSize = true;
            this.lnkTodos.Location = new System.Drawing.Point(19, 175);
            this.lnkTodos.Name = "lnkTodos";
            this.lnkTodos.Size = new System.Drawing.Size(96, 15);
            this.lnkTodos.TabIndex = 4;
            this.lnkTodos.TabStop = true;
            this.lnkTodos.Text = "Selecciona todos";
            this.lnkTodos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTodos_LinkClicked);
            // 
            // ctrl_puntosdemedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lnkTodos);
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lvPuntosDeMedida);
            this.Controls.Add(this.label1);
            this.Name = "ctrl_puntosdemedida";
            this.Size = new System.Drawing.Size(601, 747);
            this.Load += new System.EventHandler(this.ctrl_puntosdemedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPuntosDeMedida;
        private System.Windows.Forms.PictureBox cmdOK;
        private System.Windows.Forms.LinkLabel lnkAtras;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.LinkLabel lnkTodos;
    }
}
