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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btMateriaPrima = new System.Windows.Forms.Button();
            this.btElaborar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meter textbox con datos del administrador";
            // 
            // btMateriaPrima
            // 
            this.btMateriaPrima.Location = new System.Drawing.Point(348, 207);
            this.btMateriaPrima.Name = "btMateriaPrima";
            this.btMateriaPrima.Size = new System.Drawing.Size(112, 41);
            this.btMateriaPrima.TabIndex = 2;
            this.btMateriaPrima.Text = "Comprar M.P.";
            this.btMateriaPrima.UseVisualStyleBackColor = true;
            this.btMateriaPrima.Click += new System.EventHandler(this.button1_Click);
            // 
            // btElaborar
            // 
            this.btElaborar.Location = new System.Drawing.Point(525, 207);
            this.btElaborar.Name = "btElaborar";
            this.btElaborar.Size = new System.Drawing.Size(118, 41);
            this.btElaborar.TabIndex = 3;
            this.btElaborar.Text = "Elaboración";
            this.btElaborar.UseVisualStyleBackColor = true;
            this.btElaborar.Click += new System.EventHandler(this.btElaborar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 636);
            this.Controls.Add(this.btElaborar);
            this.Controls.Add(this.btMateriaPrima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMateriaPrima;
        private System.Windows.Forms.Button btElaborar;
    }
}