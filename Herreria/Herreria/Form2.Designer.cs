namespace Herreria
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btMateriaPrima = new System.Windows.Forms.Button();
            this.btElaborar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMateriaPrima
            // 
            this.btMateriaPrima.BackColor = System.Drawing.Color.Firebrick;
            this.btMateriaPrima.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMateriaPrima.ForeColor = System.Drawing.Color.White;
            this.btMateriaPrima.Location = new System.Drawing.Point(277, 157);
            this.btMateriaPrima.Name = "btMateriaPrima";
            this.btMateriaPrima.Size = new System.Drawing.Size(171, 41);
            this.btMateriaPrima.TabIndex = 2;
            this.btMateriaPrima.Text = "Comprar M.P.";
            this.btMateriaPrima.UseVisualStyleBackColor = false;
            this.btMateriaPrima.Click += new System.EventHandler(this.button1_Click);
            // 
            // btElaborar
            // 
            this.btElaborar.BackColor = System.Drawing.Color.Firebrick;
            this.btElaborar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btElaborar.ForeColor = System.Drawing.Color.White;
            this.btElaborar.Location = new System.Drawing.Point(611, 157);
            this.btElaborar.Name = "btElaborar";
            this.btElaborar.Size = new System.Drawing.Size(138, 41);
            this.btElaborar.TabIndex = 3;
            this.btElaborar.Text = "FABRICAR";
            this.btElaborar.UseVisualStyleBackColor = false;
            this.btElaborar.Click += new System.EventHandler(this.btElaborar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMINISTRADOR:";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.Location = new System.Drawing.Point(385, 129);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(0, 25);
            this.lbAdmin.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(492, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btElaborar);
            this.Controls.Add(this.btMateriaPrima);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btMateriaPrima;
        private System.Windows.Forms.Button btElaborar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.Button button1;
    }
}