namespace Voto_Electronico
{
    partial class FormInforme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolverRepo = new System.Windows.Forms.Button();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votoElectronico_V2DataSet1 = new Voto_Electronico.VotoElectronico_V2DataSet();
            this.ciudadanosTableAdapter = new Voto_Electronico.VotoElectronico_V2DataSetTableAdapters.CiudadanosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronico_V2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.sexoDataGridViewCheckBoxColumn,
            this.idBarrioDataGridViewTextBoxColumn,
            this.iddeptoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ciudadanosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 545);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVolverRepo
            // 
            this.btnVolverRepo.Location = new System.Drawing.Point(292, 581);
            this.btnVolverRepo.Name = "btnVolverRepo";
            this.btnVolverRepo.Size = new System.Drawing.Size(94, 29);
            this.btnVolverRepo.TabIndex = 1;
            this.btnVolverRepo.Text = "Volver";
            this.btnVolverRepo.UseVisualStyleBackColor = true;
            this.btnVolverRepo.Click += new System.EventHandler(this.btnVolverRepo_Click);
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewCheckBoxColumn
            // 
            this.sexoDataGridViewCheckBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewCheckBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewCheckBoxColumn.Name = "sexoDataGridViewCheckBoxColumn";
            // 
            // idBarrioDataGridViewTextBoxColumn
            // 
            this.idBarrioDataGridViewTextBoxColumn.DataPropertyName = "Id_Barrio";
            this.idBarrioDataGridViewTextBoxColumn.HeaderText = "Id_Barrio";
            this.idBarrioDataGridViewTextBoxColumn.Name = "idBarrioDataGridViewTextBoxColumn";
            // 
            // iddeptoDataGridViewTextBoxColumn
            // 
            this.iddeptoDataGridViewTextBoxColumn.DataPropertyName = "Id_depto";
            this.iddeptoDataGridViewTextBoxColumn.HeaderText = "Id_depto";
            this.iddeptoDataGridViewTextBoxColumn.Name = "iddeptoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // ciudadanosBindingSource
            // 
            this.ciudadanosBindingSource.DataMember = "Ciudadanos";
            this.ciudadanosBindingSource.DataSource = this.votoElectronico_V2DataSet1;
            // 
            // votoElectronico_V2DataSet1
            // 
            this.votoElectronico_V2DataSet1.DataSetName = "VotoElectronico_V2DataSet";
            this.votoElectronico_V2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadanosTableAdapter
            // 
            this.ciudadanosTableAdapter.ClearBeforeFill = true;
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voto_Electronico.Properties.Resources.FondoVE;
            this.ClientSize = new System.Drawing.Size(776, 622);
            this.Controls.Add(this.btnVolverRepo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormInforme";
            this.Text = "Informe De Ciudadanos";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronico_V2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VotoElectronico_V2DataSet votoElectronico_V2DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverRepo;
        private System.Windows.Forms.BindingSource ciudadanosBindingSource;
        private VotoElectronico_V2DataSetTableAdapters.CiudadanosTableAdapter ciudadanosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sexoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}