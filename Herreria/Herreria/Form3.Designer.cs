namespace Herreria
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eQUIPAMIENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipamientoDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equipamientoDataSet1 = new Herreria.EquipamientoDataSet1();
            this.equipamientoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPAMIENTOTableAdapter = new Herreria.EquipamientoDataSet1TableAdapters.EQUIPAMIENTOTableAdapter();
            this.label = new System.Windows.Forms.Label();
            this.cbEquipamiento = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbUsur = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMIENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioventaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eQUIPAMIENTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(415, 174);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 80;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 50;
            // 
            // precioventaDataGridViewTextBoxColumn
            // 
            this.precioventaDataGridViewTextBoxColumn.DataPropertyName = "precio_venta";
            this.precioventaDataGridViewTextBoxColumn.HeaderText = "precio_venta";
            this.precioventaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioventaDataGridViewTextBoxColumn.Name = "precioventaDataGridViewTextBoxColumn";
            this.precioventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioventaDataGridViewTextBoxColumn.Width = 50;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 80;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn.Width = 50;
            // 
            // eQUIPAMIENTOBindingSource
            // 
            this.eQUIPAMIENTOBindingSource.DataMember = "EQUIPAMIENTO";
            this.eQUIPAMIENTOBindingSource.DataSource = this.equipamientoDataSet1BindingSource1;
            // 
            // equipamientoDataSet1BindingSource1
            // 
            this.equipamientoDataSet1BindingSource1.DataSource = this.equipamientoDataSet1;
            this.equipamientoDataSet1BindingSource1.Position = 0;
            // 
            // equipamientoDataSet1
            // 
            this.equipamientoDataSet1.DataSetName = "EquipamientoDataSet1";
            this.equipamientoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipamientoDataSet1BindingSource
            // 
            this.equipamientoDataSet1BindingSource.DataSource = this.equipamientoDataSet1;
            this.equipamientoDataSet1BindingSource.Position = 0;
            // 
            // eQUIPAMIENTOTableAdapter
            // 
            this.eQUIPAMIENTOTableAdapter.ClearBeforeFill = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(694, 193);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 19);
            this.label.TabIndex = 4;
            this.label.Text = "Equipamiento:";
            // 
            // cbEquipamiento
            // 
            this.cbEquipamiento.FormattingEnabled = true;
            this.cbEquipamiento.Items.AddRange(new object[] {
            "Armadura ligera",
            "Armadura intermedia",
            "Armadura pesada",
            "Arma a distancia",
            "Arma cuerpo a cuerpo",
            "Escudos"});
            this.cbEquipamiento.Location = new System.Drawing.Point(698, 216);
            this.cbEquipamiento.Name = "cbEquipamiento";
            this.cbEquipamiento.Size = new System.Drawing.Size(121, 24);
            this.cbEquipamiento.TabIndex = 5;
            this.cbEquipamiento.SelectedIndexChanged += new System.EventHandler(this.cbEquipamiento_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(711, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "COMPRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(711, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "FACTURA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbUsur
            // 
            this.lbUsur.AutoSize = true;
            this.lbUsur.BackColor = System.Drawing.Color.Transparent;
            this.lbUsur.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsur.Location = new System.Drawing.Point(524, 131);
            this.lbUsur.Name = "lbUsur";
            this.lbUsur.Size = new System.Drawing.Size(0, 41);
            this.lbUsur.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(711, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "CERRAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 662);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbUsur);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEquipamiento);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMIENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource equipamientoDataSet1BindingSource;
        private EquipamientoDataSet1 equipamientoDataSet1;
        private System.Windows.Forms.BindingSource equipamientoDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource eQUIPAMIENTOBindingSource;
        private EquipamientoDataSet1TableAdapters.EQUIPAMIENTOTableAdapter eQUIPAMIENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbEquipamiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbUsur;
        private System.Windows.Forms.Button button3;
    }
}