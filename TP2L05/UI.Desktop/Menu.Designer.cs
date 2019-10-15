namespace UI.Desktop
{
    partial class Menu
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
            this.lb_Opciones = new System.Windows.Forms.Label();
            this.rb_Uuarios = new System.Windows.Forms.RadioButton();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.rb_Personas = new System.Windows.Forms.RadioButton();
            this.rb_Planes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_Opciones
            // 
            this.lb_Opciones.AutoSize = true;
            this.lb_Opciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Opciones.Location = new System.Drawing.Point(0, 0);
            this.lb_Opciones.Name = "lb_Opciones";
            this.lb_Opciones.Size = new System.Drawing.Size(101, 17);
            this.lb_Opciones.TabIndex = 0;
            this.lb_Opciones.Text = "Opciones ABM";
            this.lb_Opciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Uuarios
            // 
            this.rb_Uuarios.AutoSize = true;
            this.rb_Uuarios.Location = new System.Drawing.Point(15, 26);
            this.rb_Uuarios.Name = "rb_Uuarios";
            this.rb_Uuarios.Size = new System.Drawing.Size(85, 21);
            this.rb_Uuarios.TabIndex = 1;
            this.rb_Uuarios.Text = "Usuarios";
            this.rb_Uuarios.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(121, 131);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // rb_Personas
            // 
            this.rb_Personas.AutoSize = true;
            this.rb_Personas.Location = new System.Drawing.Point(15, 50);
            this.rb_Personas.Name = "rb_Personas";
            this.rb_Personas.Size = new System.Drawing.Size(89, 21);
            this.rb_Personas.TabIndex = 3;
            this.rb_Personas.Text = "Personas";
            this.rb_Personas.UseVisualStyleBackColor = true;
            // 
            // rb_Planes
            // 
            this.rb_Planes.AutoSize = true;
            this.rb_Planes.Location = new System.Drawing.Point(15, 74);
            this.rb_Planes.Name = "rb_Planes";
            this.rb_Planes.Size = new System.Drawing.Size(72, 21);
            this.rb_Planes.TabIndex = 4;
            this.rb_Planes.Text = "Planes";
            this.rb_Planes.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(208, 166);
            this.Controls.Add(this.rb_Planes);
            this.Controls.Add(this.rb_Personas);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.rb_Uuarios);
            this.Controls.Add(this.lb_Opciones);
            this.Name = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Opciones;
        private System.Windows.Forms.RadioButton rb_Uuarios;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.RadioButton rb_Personas;
        private System.Windows.Forms.RadioButton rb_Planes;
    }
}