namespace gnosis.Views.Proveedores
{
    partial class ProveedoresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.ContextDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Actualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.ContextDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgregar
            // 
            this.lblAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.ForeColor = System.Drawing.Color.Black;
            this.lblAgregar.Location = new System.Drawing.Point(82, 57);
            this.lblAgregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(196, 37);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "Proveedores";
            this.lblAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(515, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscar.Location = new System.Drawing.Point(593, 72);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(286, 24);
            this.txtbuscar.TabIndex = 2;
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.ContextMenuStrip = this.ContextDgv;
            this.DgvProveedores.Location = new System.Drawing.Point(89, 195);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            this.DgvProveedores.Size = new System.Drawing.Size(955, 341);
            this.DgvProveedores.TabIndex = 3;
            // 
            // ContextDgv
            // 
            this.ContextDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Actualizar,
            this.Eliminar});
            this.ContextDgv.Name = "ContextDgv";
            this.ContextDgv.Size = new System.Drawing.Size(127, 48);
            // 
            // Actualizar
            // 
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(126, 22);
            this.Actualizar.Text = "Actualizar";
            // 
            // Eliminar
            // 
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(126, 22);
            this.Eliminar.Text = "Eliminar";
            // 
            // Agregar
            // 
            this.Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Agregar.Location = new System.Drawing.Point(904, 72);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(140, 24);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // ProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1103, 585);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.DgvProveedores);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgregar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProveedoresForm";
            this.Text = "ProveedoresForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ContextDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAgregar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ContextDgv;
        public System.Windows.Forms.DataGridView DgvProveedores;
        public System.Windows.Forms.ToolStripMenuItem Eliminar;
        public System.Windows.Forms.Button Agregar;
        public System.Windows.Forms.ToolStripMenuItem Actualizar;
        public System.Windows.Forms.TextBox txtbuscar;
    }
}