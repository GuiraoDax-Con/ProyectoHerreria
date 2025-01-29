namespace Herreria
{
    partial class Elaboracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elaboracion));
            this.label1 = new System.Windows.Forms.Label();
            this.equipamientoDataSet = new Herreria.EquipamientoDataSet();
            this.equipamientoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPAMIENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPAMIENTOTableAdapter = new Herreria.EquipamientoDataSetTableAdapters.EQUIPAMIENTOTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipamientoDataSet1 = new Herreria.EquipamientoDataSet1();
            this.equipamientoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPAMIENTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPAMIENTOTableAdapter1 = new Herreria.EquipamientoDataSet1TableAdapters.EQUIPAMIENTOTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMIENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMIENTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELABORACIÓN EQUIPO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // equipamientoDataSet
            // 
            this.equipamientoDataSet.DataSetName = "EquipamientoDataSet";
            this.equipamientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipamientoDataSetBindingSource
            // 
            this.equipamientoDataSetBindingSource.DataSource = this.equipamientoDataSet;
            this.equipamientoDataSetBindingSource.Position = 0;
            // 
            // eQUIPAMIENTOBindingSource
            // 
            this.eQUIPAMIENTOBindingSource.DataMember = "EQUIPAMIENTO";
            this.eQUIPAMIENTOBindingSource.DataSource = this.equipamientoDataSetBindingSource;
            // 
            // eQUIPAMIENTOTableAdapter
            // 
            this.eQUIPAMIENTOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioventaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eQUIPAMIENTOBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(81, 501);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 1;
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
            // eQUIPAMIENTOBindingSource1
            // 
            this.eQUIPAMIENTOBindingSource1.DataMember = "EQUIPAMIENTO";
            this.eQUIPAMIENTOBindingSource1.DataSource = this.equipamientoDataSet1BindingSource;
            // 
            // eQUIPAMIENTOTableAdapter1
            // 
            this.eQUIPAMIENTOTableAdapter1.ClearBeforeFill = true;
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
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 70;
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
            // Elaboracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 780);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Elaboracion";
            this.Text = "Elaboracion";
            this.Load += new System.EventHandler(this.Elaboracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMIENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMIENTOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource equipamientoDataSetBindingSource;
        private EquipamientoDataSet equipamientoDataSet;
        private System.Windows.Forms.BindingSource eQUIPAMIENTOBindingSource;
        private EquipamientoDataSetTableAdapters.EQUIPAMIENTOTableAdapter eQUIPAMIENTOTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource equipamientoDataSet1BindingSource;
        private EquipamientoDataSet1 equipamientoDataSet1;
        private System.Windows.Forms.BindingSource eQUIPAMIENTOBindingSource1;
        private EquipamientoDataSet1TableAdapters.EQUIPAMIENTOTableAdapter eQUIPAMIENTOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
    }
}