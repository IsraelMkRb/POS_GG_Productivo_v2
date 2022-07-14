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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificadoresForm));
            this.indice = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.FormularioArticulos = new System.Windows.Forms.TabControl();
            this.General_pag = new System.Windows.Forms.TabPage();
            this.ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PrecioModificable = new System.Windows.Forms.CheckBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mod_pag = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.Modificador5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Modificador4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Modificador3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Modificador2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Modificador1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.indice)).BeginInit();
            this.FormularioArticulos.SuspendLayout();
            this.General_pag.SuspendLayout();
            this.Mod_pag.SuspendLayout();
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
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.Location = new System.Drawing.Point(686, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(110, 32);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "  Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.White;
            this.Borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrar.Location = new System.Drawing.Point(338, 12);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(110, 32);
            this.Borrar.TabIndex = 8;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.White;
            this.Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo.Location = new System.Drawing.Point(570, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(110, 32);
            this.Nuevo.TabIndex = 10;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cerrar.Location = new System.Drawing.Point(802, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(110, 32);
            this.Cerrar.TabIndex = 11;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click_1);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.White;
            this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(454, 12);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(110, 32);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            // 
            // FormularioArticulos
            // 
            this.FormularioArticulos.Controls.Add(this.General_pag);
            this.FormularioArticulos.Controls.Add(this.Mod_pag);
            this.FormularioArticulos.Controls.Add(this.tabPage1);
            this.FormularioArticulos.Location = new System.Drawing.Point(338, 49);
            this.FormularioArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.FormularioArticulos.Multiline = true;
            this.FormularioArticulos.Name = "FormularioArticulos";
            this.FormularioArticulos.SelectedIndex = 0;
            this.FormularioArticulos.Size = new System.Drawing.Size(574, 306);
            this.FormularioArticulos.TabIndex = 13;
            // 
            // General_pag
            // 
            this.General_pag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.General_pag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.General_pag.Controls.Add(this.ID);
            this.General_pag.Controls.Add(this.label12);
            this.General_pag.Controls.Add(this.PrecioModificable);
            this.General_pag.Controls.Add(this.precio);
            this.General_pag.Controls.Add(this.label4);
            this.General_pag.Controls.Add(this.display);
            this.General_pag.Controls.Add(this.label3);
            this.General_pag.Controls.Add(this.nombre);
            this.General_pag.Controls.Add(this.label2);
            this.General_pag.Controls.Add(this.label1);
            this.General_pag.Controls.Add(this.label5);
            this.General_pag.Location = new System.Drawing.Point(4, 22);
            this.General_pag.Margin = new System.Windows.Forms.Padding(2);
            this.General_pag.Name = "General_pag";
            this.General_pag.Padding = new System.Windows.Forms.Padding(2);
            this.General_pag.Size = new System.Drawing.Size(566, 280);
            this.General_pag.TabIndex = 0;
            this.General_pag.Text = "General";
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Location = new System.Drawing.Point(10, 74);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.MaxLength = 25;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(275, 20);
            this.ID.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(8, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "ID(*)";
            // 
            // PrecioModificable
            // 
            this.PrecioModificable.AutoSize = true;
            this.PrecioModificable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrecioModificable.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PrecioModificable.FlatAppearance.BorderSize = 9;
            this.PrecioModificable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrecioModificable.Location = new System.Drawing.Point(10, 219);
            this.PrecioModificable.Margin = new System.Windows.Forms.Padding(2);
            this.PrecioModificable.Name = "PrecioModificable";
            this.PrecioModificable.Size = new System.Drawing.Size(119, 18);
            this.PrecioModificable.TabIndex = 6;
            this.PrecioModificable.Text = "Precio Modificable";
            this.PrecioModificable.UseVisualStyleBackColor = true;
            // 
            // precio
            // 
            this.precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precio.Location = new System.Drawing.Point(8, 196);
            this.precio.Margin = new System.Windows.Forms.Padding(2);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(275, 20);
            this.precio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio(*)";
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Location = new System.Drawing.Point(8, 151);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.MaxLength = 15;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(275, 20);
            this.display.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display(*)";
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(8, 112);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.MaxLength = 25;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(275, 20);
            this.nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "General";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "___________";
            // 
            // Mod_pag
            // 
            this.Mod_pag.BackColor = System.Drawing.Color.White;
            this.Mod_pag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Mod_pag.Controls.Add(this.label11);
            this.Mod_pag.Controls.Add(this.Modificador5);
            this.Mod_pag.Controls.Add(this.label10);
            this.Mod_pag.Controls.Add(this.Modificador4);
            this.Mod_pag.Controls.Add(this.label9);
            this.Mod_pag.Controls.Add(this.Modificador3);
            this.Mod_pag.Controls.Add(this.label8);
            this.Mod_pag.Controls.Add(this.Modificador2);
            this.Mod_pag.Controls.Add(this.label7);
            this.Mod_pag.Controls.Add(this.label6);
            this.Mod_pag.Controls.Add(this.Modificador1);
            this.Mod_pag.Location = new System.Drawing.Point(4, 22);
            this.Mod_pag.Margin = new System.Windows.Forms.Padding(2);
            this.Mod_pag.Name = "Mod_pag";
            this.Mod_pag.Padding = new System.Windows.Forms.Padding(2);
            this.Mod_pag.Size = new System.Drawing.Size(375, 280);
            this.Mod_pag.TabIndex = 1;
            this.Mod_pag.Text = "Modificadores";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Modificador 5";
            // 
            // Modificador5
            // 
            this.Modificador5.FormattingEnabled = true;
            this.Modificador5.Location = new System.Drawing.Point(13, 255);
            this.Modificador5.Margin = new System.Windows.Forms.Padding(2);
            this.Modificador5.Name = "Modificador5";
            this.Modificador5.Size = new System.Drawing.Size(163, 21);
            this.Modificador5.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Modificador 4";
            // 
            // Modificador4
            // 
            this.Modificador4.FormattingEnabled = true;
            this.Modificador4.Location = new System.Drawing.Point(11, 207);
            this.Modificador4.Margin = new System.Windows.Forms.Padding(2);
            this.Modificador4.Name = "Modificador4";
            this.Modificador4.Size = new System.Drawing.Size(163, 21);
            this.Modificador4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Modificador 3";
            // 
            // Modificador3
            // 
            this.Modificador3.FormattingEnabled = true;
            this.Modificador3.Location = new System.Drawing.Point(10, 158);
            this.Modificador3.Margin = new System.Windows.Forms.Padding(2);
            this.Modificador3.Name = "Modificador3";
            this.Modificador3.Size = new System.Drawing.Size(163, 21);
            this.Modificador3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Modificador 2";
            // 
            // Modificador2
            // 
            this.Modificador2.FormattingEnabled = true;
            this.Modificador2.Location = new System.Drawing.Point(8, 110);
            this.Modificador2.Margin = new System.Windows.Forms.Padding(2);
            this.Modificador2.Name = "Modificador2";
            this.Modificador2.Size = new System.Drawing.Size(163, 21);
            this.Modificador2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Modificador 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Modificadores";
            // 
            // Modificador1
            // 
            this.Modificador1.FormattingEnabled = true;
            this.Modificador1.Location = new System.Drawing.Point(8, 63);
            this.Modificador1.Margin = new System.Windows.Forms.Padding(2);
            this.Modificador1.Name = "Modificador1";
            this.Modificador1.Size = new System.Drawing.Size(163, 21);
            this.Modificador1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(375, 280);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Receta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ModificadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 550);
            this.Controls.Add(this.FormularioArticulos);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.indice);
            this.Name = "ModificadoresForm";
            this.Text = "ModificadoresForm";
            this.Load += new System.EventHandler(this.ModificadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indice)).EndInit();
            this.FormularioArticulos.ResumeLayout(false);
            this.General_pag.ResumeLayout(false);
            this.General_pag.PerformLayout();
            this.Mod_pag.ResumeLayout(false);
            this.Mod_pag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Column;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TabControl FormularioArticulos;
        private System.Windows.Forms.TabPage General_pag;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox PrecioModificable;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Mod_pag;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Modificador5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Modificador4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Modificador3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Modificador2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Modificador1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}