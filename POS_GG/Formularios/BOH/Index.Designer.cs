using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_GG.Formularios.BOH
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.Botonera = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finanzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor_opciones = new System.Windows.Forms.Panel();
            this.Contendedor_central = new System.Windows.Forms.Panel();
            this.Cabezera_contendedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizar_button = new System.Windows.Forms.Button();
            this.cambiartamaño_button = new System.Windows.Forms.Button();
            this.cerrar_button = new System.Windows.Forms.Button();
            this.Botonera.SuspendLayout();
            this.contenedor_opciones.SuspendLayout();
            this.Cabezera_contendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Botonera
            // 
            this.Botonera.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Botonera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Botonera.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Botonera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.vistasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.finanzasToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.Botonera.Location = new System.Drawing.Point(0, 0);
            this.Botonera.Name = "Botonera";
            this.Botonera.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Botonera.Size = new System.Drawing.Size(696, 42);
            this.Botonera.TabIndex = 0;
            this.Botonera.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.modificadoresToolStripMenuItem,
            this.recetasToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // modificadoresToolStripMenuItem
            // 
            this.modificadoresToolStripMenuItem.Name = "modificadoresToolStripMenuItem";
            this.modificadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificadoresToolStripMenuItem.Text = "Modificadores";
            this.modificadoresToolStripMenuItem.Click += new System.EventHandler(this.modificadoresToolStripMenuItem_Click);
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // vistasToolStripMenuItem
            // 
            this.vistasToolStripMenuItem.Name = "vistasToolStripMenuItem";
            this.vistasToolStripMenuItem.Size = new System.Drawing.Size(49, 38);
            this.vistasToolStripMenuItem.Text = "Vistas";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.permisosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 38);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // finanzasToolStripMenuItem
            // 
            this.finanzasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeCuentasToolStripMenuItem,
            this.informesVentasToolStripMenuItem,
            this.informesGastosToolStripMenuItem,
            this.informesProductosToolStripMenuItem});
            this.finanzasToolStripMenuItem.Name = "finanzasToolStripMenuItem";
            this.finanzasToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.finanzasToolStripMenuItem.Text = "Finanzas";
            // 
            // informeCuentasToolStripMenuItem
            // 
            this.informeCuentasToolStripMenuItem.Name = "informeCuentasToolStripMenuItem";
            this.informeCuentasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informeCuentasToolStripMenuItem.Text = "Informes Cuentas";
            this.informeCuentasToolStripMenuItem.Click += new System.EventHandler(this.InformeCuentasToolStripMenuItem_Click);
            // 
            // informesVentasToolStripMenuItem
            // 
            this.informesVentasToolStripMenuItem.Name = "informesVentasToolStripMenuItem";
            this.informesVentasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informesVentasToolStripMenuItem.Text = "Informes Ventas";
            // 
            // informesGastosToolStripMenuItem
            // 
            this.informesGastosToolStripMenuItem.Name = "informesGastosToolStripMenuItem";
            this.informesGastosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informesGastosToolStripMenuItem.Text = "Informes Gastos";
            // 
            // informesProductosToolStripMenuItem
            // 
            this.informesProductosToolStripMenuItem.Name = "informesProductosToolStripMenuItem";
            this.informesProductosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.informesProductosToolStripMenuItem.Text = "Informes Productos";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 38);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // contenedor_opciones
            // 
            this.contenedor_opciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor_opciones.Controls.Add(this.Botonera);
            this.contenedor_opciones.Location = new System.Drawing.Point(0, 35);
            this.contenedor_opciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contenedor_opciones.Name = "contenedor_opciones";
            this.contenedor_opciones.Size = new System.Drawing.Size(698, 44);
            this.contenedor_opciones.TabIndex = 1;
            // 
            // Contendedor_central
            // 
            this.Contendedor_central.BackColor = System.Drawing.Color.White;
            this.Contendedor_central.BackgroundImage = global::POS_GG.Properties.Resources.fondo_contenedor;
            this.Contendedor_central.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Contendedor_central.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contendedor_central.Location = new System.Drawing.Point(1, 82);
            this.Contendedor_central.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Contendedor_central.Name = "Contendedor_central";
            this.Contendedor_central.Size = new System.Drawing.Size(691, 360);
            this.Contendedor_central.TabIndex = 2;
            // 
            // Cabezera_contendedor
            // 
            this.Cabezera_contendedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cabezera_contendedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cabezera_contendedor.BackgroundImage")));
            this.Cabezera_contendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cabezera_contendedor.Controls.Add(this.label1);
            this.Cabezera_contendedor.Controls.Add(this.pictureBox1);
            this.Cabezera_contendedor.Controls.Add(this.minimizar_button);
            this.Cabezera_contendedor.Controls.Add(this.cambiartamaño_button);
            this.Cabezera_contendedor.Controls.Add(this.cerrar_button);
            this.Cabezera_contendedor.Location = new System.Drawing.Point(0, 0);
            this.Cabezera_contendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cabezera_contendedor.Name = "Cabezera_contendedor";
            this.Cabezera_contendedor.Size = new System.Drawing.Size(698, 35);
            this.Cabezera_contendedor.TabIndex = 0;
            this.Cabezera_contendedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cabezera_contendedor_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ERP Gema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::POS_GG.Properties.Resources.main_icon;
            this.pictureBox1.Image = global::POS_GG.Properties.Resources.main_icon;
            this.pictureBox1.InitialImage = global::POS_GG.Properties.Resources.main_icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // minimizar_button
            // 
            this.minimizar_button.BackColor = System.Drawing.Color.Transparent;
            this.minimizar_button.FlatAppearance.BorderSize = 0;
            this.minimizar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar_button.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.minimizar_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizar_button.Location = new System.Drawing.Point(599, -1);
            this.minimizar_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizar_button.Name = "minimizar_button";
            this.minimizar_button.Size = new System.Drawing.Size(31, 34);
            this.minimizar_button.TabIndex = 2;
            this.minimizar_button.TabStop = false;
            this.minimizar_button.Text = "0";
            this.minimizar_button.UseVisualStyleBackColor = false;
            // 
            // cambiartamaño_button
            // 
            this.cambiartamaño_button.BackColor = System.Drawing.Color.Transparent;
            this.cambiartamaño_button.FlatAppearance.BorderSize = 0;
            this.cambiartamaño_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiartamaño_button.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cambiartamaño_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cambiartamaño_button.Location = new System.Drawing.Point(630, -1);
            this.cambiartamaño_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cambiartamaño_button.Name = "cambiartamaño_button";
            this.cambiartamaño_button.Size = new System.Drawing.Size(31, 34);
            this.cambiartamaño_button.TabIndex = 1;
            this.cambiartamaño_button.TabStop = false;
            this.cambiartamaño_button.Text = "1";
            this.cambiartamaño_button.UseVisualStyleBackColor = false;
            this.cambiartamaño_button.Click += new System.EventHandler(this.cambiartamaño_button_Click);
            // 
            // cerrar_button
            // 
            this.cerrar_button.BackColor = System.Drawing.Color.Transparent;
            this.cerrar_button.FlatAppearance.BorderSize = 0;
            this.cerrar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar_button.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cerrar_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrar_button.Location = new System.Drawing.Point(661, -1);
            this.cerrar_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cerrar_button.Name = "cerrar_button";
            this.cerrar_button.Size = new System.Drawing.Size(31, 34);
            this.cerrar_button.TabIndex = 0;
            this.cerrar_button.TabStop = false;
            this.cerrar_button.Text = "r";
            this.cerrar_button.UseVisualStyleBackColor = false;
            this.cerrar_button.Click += new System.EventHandler(this.cerrar_button_Click);
            this.cerrar_button.MouseLeave += new System.EventHandler(this.cerrar_button_MouseLeave);
            this.cerrar_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cerrar_button_MouseMove);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 444);
            this.Controls.Add(this.Contendedor_central);
            this.Controls.Add(this.contenedor_opciones);
            this.Controls.Add(this.Cabezera_contendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Botonera;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Index";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Index_FormClosed);
            this.Load += new System.EventHandler(this.Index_Load);
            this.Shown += new System.EventHandler(this.Index_Shown);
            this.Botonera.ResumeLayout(false);
            this.Botonera.PerformLayout();
            this.contenedor_opciones.ResumeLayout(false);
            this.contenedor_opciones.PerformLayout();
            this.Cabezera_contendedor.ResumeLayout(false);
            this.Cabezera_contendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        #region Comportamiento formulario
        private void cerrar_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrar_button_MouseMove(object sender, MouseEventArgs e)
        {
            cerrar_button.BackColor = Color.Red;
        }

        private void cerrar_button_MouseLeave(object sender, EventArgs e)
        {
            cerrar_button.BackColor = Color.Transparent;
        }

        private void cambiartamaño_button_Click(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                //cuando el formulario cubra toda la pantalla ajustamos a tamaño original
                this.Size = new Size(923, 546);
                this.Location = new Point(50, 59);
                cambiartamaño_button.Text = "1";
            }
            else
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
                cambiartamaño_button.Text = "2";
            }

            //ajustamos tamaño de contenedores
            Cabezera_contendedor.Width = this.Width;
            contenedor_opciones.Width = this.Width;
            Contendedor_central.Width = this.Width - 2;
            Contendedor_central.Height = this.Height - Cabezera_contendedor.Height - contenedor_opciones.Height - 2;
            //Ajustamos los controladores de cada contendedor
            //Cabezera
            cerrar_button.Location = new Point(this.Width - cerrar_button.Width, cerrar_button.Location.Y);
            cambiartamaño_button.Location = new Point(this.Width - cerrar_button.Width - cambiartamaño_button.Width, cambiartamaño_button.Location.Y);
            minimizar_button.Location = new Point(this.Width - cerrar_button.Width - cambiartamaño_button.Width - minimizar_button.Width, minimizar_button.Location.Y);
            //Ajustamos el formulario que este mostrado en el contenedor central
            AjustaFormulario();
        }

        private void AjustaFormulario()
        {
            foreach (Form item in Contendedor_central.Controls)
            {
                item.WindowState = FormWindowState.Minimized;
                item.WindowState = FormWindowState.Maximized;
            }
        }

        public int xClick = 0;
        public int yClick = 0;
        /// <summary>
        /// Funcion para mover el formulario cuando presionan la cebezera y mueven el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cabezera_contendedor_MouseMove(object sender, MouseEventArgs e)
        {
            //Si al detectarse movimiento del raton pero no se tiene el boton izquierdo presionado, solo se registra el valor x y
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else //Pero si se encuentra presionado el boton izquierdo se pasan los valores x y del raton al formulario para que se mueva con el
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
        #endregion
        private System.Windows.Forms.Button cerrar_button;
        private System.Windows.Forms.Button cambiartamaño_button;
        private System.Windows.Forms.Button minimizar_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Cabezera_contendedor;
        private System.Windows.Forms.MenuStrip Botonera;
        private System.Windows.Forms.Panel contenedor_opciones;
        private System.Windows.Forms.Panel Contendedor_central;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesProductosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}