namespace POS_GG.Formularios.BOH.Catalogos
{
    partial class ModificadoresForm
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
            this.indice = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.indice)).BeginInit();
            this.SuspendLayout();
            // 
            // indice
            // 
            this.indice.AllowUserToAddRows = false;
            this.indice.AllowUserToDeleteRows = false;
            this.indice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.indice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.indice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Nombre_Column});
            this.indice.Location = new System.Drawing.Point(12, 12);
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(281, 426);
            this.indice.TabIndex = 0;
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            // 
            // Nombre_Column
            // 
            this.Nombre_Column.HeaderText = "Nombre";
            this.Nombre_Column.Name = "Nombre_Column";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(314, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(90, 43);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ModificadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 550);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.indice);
            this.Name = "ModificadoresForm";
            this.Text = "ModificadoresForm";
            this.Load += new System.EventHandler(this.ModificadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Column;
        private System.Windows.Forms.Button Cerrar;
    }
}