namespace POS_GG.Formularios.BOH
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuario_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mensajedecarga = new System.Windows.Forms.Label();
            this.Cerrar_Button = new System.Windows.Forms.Button();
            this.ingresar_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.BackColor = System.Drawing.Color.Transparent;
            this.usuario_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_label.Location = new System.Drawing.Point(130, 8);
            this.usuario_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(64, 20);
            this.usuario_label.TabIndex = 0;
            this.usuario_label.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña";
            // 
            // user_textbox
            // 
            this.user_textbox.Location = new System.Drawing.Point(40, 31);
            this.user_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(261, 20);
            this.user_textbox.TabIndex = 2;
            this.user_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_textbox_KeyPress);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(46, 87);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(261, 20);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textbox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Mensajedecarga);
            this.panel1.Controls.Add(this.Cerrar_Button);
            this.panel1.Controls.Add(this.ingresar_button);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.usuario_label);
            this.panel1.Controls.Add(this.user_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 162);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Mensajedecarga
            // 
            this.Mensajedecarga.AutoSize = true;
            this.Mensajedecarga.Location = new System.Drawing.Point(44, 123);
            this.Mensajedecarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mensajedecarga.Name = "Mensajedecarga";
            this.Mensajedecarga.Size = new System.Drawing.Size(0, 13);
            this.Mensajedecarga.TabIndex = 6;
            // 
            // Cerrar_Button
            // 
            this.Cerrar_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cerrar_Button.BackgroundImage")));
            this.Cerrar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrar_Button.Location = new System.Drawing.Point(159, 118);
            this.Cerrar_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cerrar_Button.Name = "Cerrar_Button";
            this.Cerrar_Button.Size = new System.Drawing.Size(68, 24);
            this.Cerrar_Button.TabIndex = 5;
            this.Cerrar_Button.Text = "Cerrar";
            this.Cerrar_Button.UseVisualStyleBackColor = true;
            this.Cerrar_Button.Click += new System.EventHandler(this.Cerrar_Button_Click);
            // 
            // ingresar_button
            // 
            this.ingresar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingresar_button.Location = new System.Drawing.Point(232, 118);
            this.ingresar_button.Margin = new System.Windows.Forms.Padding(2);
            this.ingresar_button.Name = "ingresar_button";
            this.ingresar_button.Size = new System.Drawing.Size(68, 24);
            this.ingresar_button.TabIndex = 4;
            this.ingresar_button.Text = "Ingresar";
            this.ingresar_button.UseVisualStyleBackColor = true;
            this.ingresar_button.Click += new System.EventHandler(this.Ingresar_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::POS_GG.Properties.Resources.fondo_header;
            this.ClientSize = new System.Drawing.Size(339, 171);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox user_textbox;
        public System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ingresar_button;
        private System.Windows.Forms.Button Cerrar_Button;
        private System.Windows.Forms.Label Mensajedecarga;
    }
}