namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lId = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.txt_idPlan = new System.Windows.Forms.TextBox();
            this.lid_plan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_idPlan, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lid_plan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHsSemanales, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHsTotales, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bntCancelar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lId.Location = new System.Drawing.Point(2, 0);
            this.lId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(94, 28);
            this.lId.TabIndex = 0;
            this.lId.Text = "ID";
            this.lId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(2, 28);
            this.lDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 1;
            this.lDescripcion.Text = "Descripcion";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(100, 4);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(196, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(100, 30);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 150);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.Text = "";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(2, 269);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(62, 25);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntCancelar.Location = new System.Drawing.Point(275, 269);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(62, 25);
            this.bntCancelar.TabIndex = 3;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // txt_idPlan
            // 
            this.txt_idPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_idPlan.Location = new System.Drawing.Point(100, 242);
            this.txt_idPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_idPlan.Name = "txt_idPlan";
            this.txt_idPlan.Size = new System.Drawing.Size(196, 20);
            this.txt_idPlan.TabIndex = 7;
            // 
            // lid_plan
            // 
            this.lid_plan.AutoSize = true;
            this.lid_plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lid_plan.Location = new System.Drawing.Point(2, 238);
            this.lid_plan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lid_plan.Name = "lid_plan";
            this.lid_plan.Size = new System.Drawing.Size(94, 28);
            this.lid_plan.TabIndex = 6;
            this.lid_plan.Text = "ID Plan";
            this.lid_plan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "HS Semanales:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "HS Totales:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHsSemanales.Location = new System.Drawing.Point(100, 186);
            this.txtHsSemanales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(76, 20);
            this.txtHsSemanales.TabIndex = 10;
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHsTotales.Location = new System.Drawing.Point(100, 214);
            this.txtHsTotales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(76, 20);
            this.txtHsTotales.TabIndex = 11;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 298);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MateriaDesktop";
            this.Text = "EspecialidadDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lid_plan;
        private System.Windows.Forms.TextBox txt_idPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.TextBox txtHsTotales;
    }
}