using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_GG.Formularios.BOH.Catalogos
{
    partial class ArticulosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticulosForm));
            this.Indice = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Indice)).BeginInit();
            this.FormularioArticulos.SuspendLayout();
            this.General_pag.SuspendLayout();
            this.Mod_pag.SuspendLayout();
            this.SuspendLayout();
            // 
            // Indice
            // 
            this.Indice.AllowUserToAddRows = false;
            this.Indice.AllowUserToDeleteRows = false;
            this.Indice.AllowUserToResizeRows = false;
            this.Indice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Indice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Indice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Indice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Name_Column});
            this.Indice.Location = new System.Drawing.Point(9, 8);
            this.Indice.Margin = new System.Windows.Forms.Padding(2);
            this.Indice.MultiSelect = false;
            this.Indice.Name = "Indice";
            this.Indice.RowTemplate.Height = 24;
            this.Indice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Indice.Size = new System.Drawing.Size(188, 301);
            this.Indice.TabIndex = 1;
            this.Indice.CurrentCellChanged += new System.EventHandler(this.Indice_CurrentCellChanged);
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            this.ID_Column.ReadOnly = true;
            this.ID_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Name";
            this.Name_Column.Name = "Name_Column";
            this.Name_Column.ReadOnly = true;
            this.Name_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormularioArticulos
            // 
            this.FormularioArticulos.Controls.Add(this.General_pag);
            this.FormularioArticulos.Controls.Add(this.Mod_pag);
            this.FormularioArticulos.Controls.Add(this.tabPage1);
            this.FormularioArticulos.Location = new System.Drawing.Point(206, 49);
            this.FormularioArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.FormularioArticulos.Multiline = true;
            this.FormularioArticulos.Name = "FormularioArticulos";
            this.FormularioArticulos.SelectedIndex = 0;
            this.FormularioArticulos.Size = new System.Drawing.Size(768, 354);
            this.FormularioArticulos.TabIndex = 6;
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
            this.General_pag.Size = new System.Drawing.Size(760, 328);
            this.General_pag.TabIndex = 0;
            this.General_pag.Text = "General";
            this.General_pag.Paint += new System.Windows.Forms.PaintEventHandler(this.General_pag_Paint);
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
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
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
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
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
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.White;
            this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(322, 12);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(110, 32);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.White;
            this.Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo.Location = new System.Drawing.Point(438, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(110, 32);
            this.Nuevo.TabIndex = 4;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cerrar.Location = new System.Drawing.Point(670, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(110, 32);
            this.Cerrar.TabIndex = 5;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.White;
            this.Borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrar.Location = new System.Drawing.Point(206, 12);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(110, 32);
            this.Borrar.TabIndex = 2;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.Location = new System.Drawing.Point(554, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(110, 32);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "  Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1023, 457);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.FormularioArticulos);
            this.Controls.Add(this.Indice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArticulosForm";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Articulos_Paint);
            this.Resize += new System.EventHandler(this.Articulos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Indice)).EndInit();
            this.FormularioArticulos.ResumeLayout(false);
            this.General_pag.ResumeLayout(false);
            this.General_pag.PerformLayout();
            this.Mod_pag.ResumeLayout(false);
            this.Mod_pag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        #region Comportamiento Formulario

        private void Articulos_Resize(object sender, EventArgs e)
        {
            //Ajustamos tamaño del indice donde aparecen todos los articulos
            Indice.Height = this.Height - (Indice.Location.Y - this.Location.Y) * 2;
            //Ajustamos el tamaño del formulario
            FormularioArticulos.Location = new Point(Indice.Width + 30, FormularioArticulos.Location.Y);
            FormularioArticulos.Height = this.Height - (FormularioArticulos.Location.Y - this.Location.Y) * 2;
            FormularioArticulos.Width = this.Width - Indice.Width - 50;
            //Ajustamos general
            foreach (Control control in FormularioArticulos.SelectedTab.Controls)
            {

            }
        }

        private void General_pag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Indice_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Articulos_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle,
                                                                                        Color.White, Color.Gray, 90);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        #endregion
        private System.Windows.Forms.DataGridView Indice;
        private System.Windows.Forms.TabControl FormularioArticulos;
        private System.Windows.Forms.TabPage General_pag;
        private System.Windows.Forms.TabPage Mod_pag;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox PrecioModificable;
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
        private TextBox ID;
        private Label label12;
        private Button Guardar;
        private Button Cerrar;
        private Button Nuevo;
        private Button Borrar;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Name_Column;
        private Button Cancelar;
    }
}