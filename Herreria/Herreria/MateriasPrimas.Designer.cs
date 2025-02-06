namespace Herreria
{
    partial class MateriasPrimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriasPrimas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbMateriasPrimas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btCompraMateriaPrima = new System.Windows.Forms.Button();
            this.BtVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIASPRIMASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materiasPrimasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasPrimasDataSet = new Herreria.MateriasPrimasDataSet();
            this.mATERIASPRIMASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mATERIAS_PRIMASTableAdapter = new Herreria.MateriasPrimasDataSetTableAdapters.MATERIAS_PRIMASTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASPRIMASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasPrimasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasPrimasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASPRIMASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMateriasPrimas
            // 
            this.cbMateriasPrimas.BackColor = System.Drawing.Color.White;
            this.cbMateriasPrimas.FormattingEnabled = true;
            this.cbMateriasPrimas.Items.AddRange(new object[] {
            "Madera",
            "Piedra",
            "Cuero",
            "Tela",
            "Pieles",
            "Bronce",
            "Hierro",
            "Acero",
            "Mitrhil",
            "Adamantina",
            "Plata",
            "Oro",
            "Hueso"});
            this.cbMateriasPrimas.Location = new System.Drawing.Point(698, 262);
            this.cbMateriasPrimas.Name = "cbMateriasPrimas";
            this.cbMateriasPrimas.Size = new System.Drawing.Size(121, 24);
            this.cbMateriasPrimas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPRA DE MATERIAS PRIMAS";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(698, 212);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // btCompraMateriaPrima
            // 
            this.btCompraMateriaPrima.BackColor = System.Drawing.Color.Firebrick;
            this.btCompraMateriaPrima.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompraMateriaPrima.ForeColor = System.Drawing.Color.White;
            this.btCompraMateriaPrima.Location = new System.Drawing.Point(698, 292);
            this.btCompraMateriaPrima.Name = "btCompraMateriaPrima";
            this.btCompraMateriaPrima.Size = new System.Drawing.Size(121, 33);
            this.btCompraMateriaPrima.TabIndex = 3;
            this.btCompraMateriaPrima.Text = "COMPRAR";
            this.btCompraMateriaPrima.UseVisualStyleBackColor = false;
            this.btCompraMateriaPrima.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtVolver
            // 
            this.BtVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtVolver.BackgroundImage")));
            this.BtVolver.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVolver.ForeColor = System.Drawing.Color.White;
            this.BtVolver.Location = new System.Drawing.Point(698, 373);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(121, 31);
            this.BtVolver.TabIndex = 4;
            this.BtVolver.Text = "VOLVER";
            this.BtVolver.UseVisualStyleBackColor = true;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.pesoDataGridViewTextBoxColumn,
            this.preciocompraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mATERIASPRIMASBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(192, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 164);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.nombreDataGridViewTextBoxColumn.Width = 125;
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
            // preciocompraDataGridViewTextBoxColumn
            // 
            this.preciocompraDataGridViewTextBoxColumn.DataPropertyName = "precio_compra";
            this.preciocompraDataGridViewTextBoxColumn.HeaderText = "precio_compra";
            this.preciocompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciocompraDataGridViewTextBoxColumn.Name = "preciocompraDataGridViewTextBoxColumn";
            this.preciocompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.preciocompraDataGridViewTextBoxColumn.Width = 50;
            // 
            // mATERIASPRIMASBindingSource1
            // 
            this.mATERIASPRIMASBindingSource1.DataMember = "MATERIAS_PRIMAS";
            this.mATERIASPRIMASBindingSource1.DataSource = this.materiasPrimasDataSetBindingSource;
            // 
            // materiasPrimasDataSetBindingSource
            // 
            this.materiasPrimasDataSetBindingSource.DataSource = this.materiasPrimasDataSet;
            this.materiasPrimasDataSetBindingSource.Position = 0;
            // 
            // materiasPrimasDataSet
            // 
            this.materiasPrimasDataSet.DataSetName = "MateriasPrimasDataSet";
            this.materiasPrimasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERIASPRIMASBindingSource
            // 
            this.mATERIASPRIMASBindingSource.DataMember = "MATERIAS_PRIMAS";
            this.mATERIASPRIMASBindingSource.DataSource = this.materiasPrimasDataSetBindingSource;
            // 
            // mATERIAS_PRIMASTableAdapter
            // 
            this.mATERIAS_PRIMASTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "INVENTARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(694, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "CANTIDAD(kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(694, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "MATERIALES";
            // 
            // btFactura
            // 
            this.btFactura.BackColor = System.Drawing.Color.Firebrick;
            this.btFactura.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFactura.ForeColor = System.Drawing.Color.White;
            this.btFactura.Location = new System.Drawing.Point(698, 331);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(121, 36);
            this.btFactura.TabIndex = 9;
            this.btFactura.Text = "FACTURA";
            this.btFactura.UseVisualStyleBackColor = false;
            this.btFactura.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MateriasPrimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 694);
            this.Controls.Add(this.btFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtVolver);
            this.Controls.Add(this.btCompraMateriaPrima);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMateriasPrimas);
            this.Name = "MateriasPrimas";
            this.Text = "MateriasPrimas";
            this.Load += new System.EventHandler(this.MateriasPrimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASPRIMASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasPrimasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasPrimasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIASPRIMASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMateriasPrimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btCompraMateriaPrima;
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource materiasPrimasDataSetBindingSource;
        private MateriasPrimasDataSet materiasPrimasDataSet;
        private System.Windows.Forms.BindingSource mATERIASPRIMASBindingSource;
        private MateriasPrimasDataSetTableAdapters.MATERIAS_PRIMASTableAdapter mATERIAS_PRIMASTableAdapter;
        private System.Windows.Forms.BindingSource mATERIASPRIMASBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFactura;
    }
}