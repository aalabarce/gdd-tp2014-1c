namespace FrbaCommerce.Editar_Publicacion
{
    partial class Publicaciones
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
            this.pUBLICACIONCOMPLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.pUBLICACION_COMPLETATableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_COMPLETATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pUBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBTIPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBESTADOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBFECHAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBFECHAFINALIZACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBVISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBUSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISCODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISPORCENTAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISDURACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISBAJADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tIPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONCOMPLETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.pUBIDDataGridViewTextBoxColumn,
            this.pUBTIPOIDDataGridViewTextBoxColumn,
            this.pUBSTOCKDataGridViewTextBoxColumn,
            this.pUBPRECIODataGridViewTextBoxColumn,
            this.pUBESTADOIDDataGridViewTextBoxColumn,
            this.pUBFECHAINICIODataGridViewTextBoxColumn,
            this.pUBFECHAFINALIZACIONDataGridViewTextBoxColumn,
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn,
            this.pUBVISIDDataGridViewTextBoxColumn,
            this.pUBUSUIDDataGridViewTextBoxColumn,
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn,
            this.vISIDDataGridViewTextBoxColumn,
            this.vISCODIGODataGridViewTextBoxColumn,
            this.vISDESCRIPCIONDataGridViewTextBoxColumn,
            this.vISPRECIODataGridViewTextBoxColumn,
            this.vISPORCENTAJEDataGridViewTextBoxColumn,
            this.vISDURACIONDataGridViewTextBoxColumn,
            this.vISBAJADataGridViewCheckBoxColumn,
            this.tIPOIDDataGridViewTextBoxColumn,
            this.tIPODESCRIPCIONDataGridViewTextBoxColumn,
            this.eSTADOIDDataGridViewTextBoxColumn,
            this.eSTADODESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pUBLICACIONCOMPLETABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pUBLICACIONCOMPLETABindingSource
            // 
            this.pUBLICACIONCOMPLETABindingSource.DataMember = "PUBLICACION_COMPLETA";
            this.pUBLICACIONCOMPLETABindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLICACION_COMPLETATableAdapter
            // 
            this.pUBLICACION_COMPLETATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mis Publicaciones";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            // 
            // pUBIDDataGridViewTextBoxColumn
            // 
            this.pUBIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_ID";
            this.pUBIDDataGridViewTextBoxColumn.HeaderText = "Código";
            this.pUBIDDataGridViewTextBoxColumn.Name = "pUBIDDataGridViewTextBoxColumn";
            // 
            // pUBTIPOIDDataGridViewTextBoxColumn
            // 
            this.pUBTIPOIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_TIPO_ID";
            this.pUBTIPOIDDataGridViewTextBoxColumn.HeaderText = "PUB_TIPO_ID";
            this.pUBTIPOIDDataGridViewTextBoxColumn.Name = "pUBTIPOIDDataGridViewTextBoxColumn";
            this.pUBTIPOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pUBSTOCKDataGridViewTextBoxColumn
            // 
            this.pUBSTOCKDataGridViewTextBoxColumn.DataPropertyName = "PUB_STOCK";
            this.pUBSTOCKDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.pUBSTOCKDataGridViewTextBoxColumn.Name = "pUBSTOCKDataGridViewTextBoxColumn";
            // 
            // pUBPRECIODataGridViewTextBoxColumn
            // 
            this.pUBPRECIODataGridViewTextBoxColumn.DataPropertyName = "PUB_PRECIO";
            this.pUBPRECIODataGridViewTextBoxColumn.HeaderText = "Precio";
            this.pUBPRECIODataGridViewTextBoxColumn.Name = "pUBPRECIODataGridViewTextBoxColumn";
            // 
            // pUBESTADOIDDataGridViewTextBoxColumn
            // 
            this.pUBESTADOIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_ESTADO_ID";
            this.pUBESTADOIDDataGridViewTextBoxColumn.HeaderText = "PUB_ESTADO_ID";
            this.pUBESTADOIDDataGridViewTextBoxColumn.Name = "pUBESTADOIDDataGridViewTextBoxColumn";
            this.pUBESTADOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pUBFECHAINICIODataGridViewTextBoxColumn
            // 
            this.pUBFECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "PUB_FECHA_INICIO";
            this.pUBFECHAINICIODataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.pUBFECHAINICIODataGridViewTextBoxColumn.Name = "pUBFECHAINICIODataGridViewTextBoxColumn";
            // 
            // pUBFECHAFINALIZACIONDataGridViewTextBoxColumn
            // 
            this.pUBFECHAFINALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "PUB_FECHA_FINALIZACION";
            this.pUBFECHAFINALIZACIONDataGridViewTextBoxColumn.HeaderText = "Fecha Finalización";
            this.pUBFECHAFINALIZACIONDataGridViewTextBoxColumn.Name = "pUBFECHAFINALIZACIONDataGridViewTextBoxColumn";
            // 
            // pUBDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "PUB_DESCRIPCION";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.pUBDESCRIPCIONDataGridViewTextBoxColumn.Name = "pUBDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // pUBVISIDDataGridViewTextBoxColumn
            // 
            this.pUBVISIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_VIS_ID";
            this.pUBVISIDDataGridViewTextBoxColumn.HeaderText = "PUB_VIS_ID";
            this.pUBVISIDDataGridViewTextBoxColumn.Name = "pUBVISIDDataGridViewTextBoxColumn";
            this.pUBVISIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pUBUSUIDDataGridViewTextBoxColumn
            // 
            this.pUBUSUIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_USU_ID";
            this.pUBUSUIDDataGridViewTextBoxColumn.HeaderText = "PUB_USU_ID";
            this.pUBUSUIDDataGridViewTextBoxColumn.Name = "pUBUSUIDDataGridViewTextBoxColumn";
            this.pUBUSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn
            // 
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn.DataPropertyName = "PUB_PERMITIR_PREGUNTAS";
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn.HeaderText = "Permitir Preguntas?";
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn.Name = "pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn";
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vISIDDataGridViewTextBoxColumn
            // 
            this.vISIDDataGridViewTextBoxColumn.DataPropertyName = "VIS_ID";
            this.vISIDDataGridViewTextBoxColumn.HeaderText = "VIS_ID";
            this.vISIDDataGridViewTextBoxColumn.Name = "vISIDDataGridViewTextBoxColumn";
            this.vISIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vISCODIGODataGridViewTextBoxColumn
            // 
            this.vISCODIGODataGridViewTextBoxColumn.DataPropertyName = "VIS_CODIGO";
            this.vISCODIGODataGridViewTextBoxColumn.HeaderText = "VIS_CODIGO";
            this.vISCODIGODataGridViewTextBoxColumn.Name = "vISCODIGODataGridViewTextBoxColumn";
            this.vISCODIGODataGridViewTextBoxColumn.Visible = false;
            // 
            // vISDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.vISDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "VIS_DESCRIPCION";
            this.vISDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Visibilidad";
            this.vISDESCRIPCIONDataGridViewTextBoxColumn.Name = "vISDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // vISPRECIODataGridViewTextBoxColumn
            // 
            this.vISPRECIODataGridViewTextBoxColumn.DataPropertyName = "VIS_PRECIO";
            this.vISPRECIODataGridViewTextBoxColumn.HeaderText = "VIS_PRECIO";
            this.vISPRECIODataGridViewTextBoxColumn.Name = "vISPRECIODataGridViewTextBoxColumn";
            this.vISPRECIODataGridViewTextBoxColumn.Visible = false;
            // 
            // vISPORCENTAJEDataGridViewTextBoxColumn
            // 
            this.vISPORCENTAJEDataGridViewTextBoxColumn.DataPropertyName = "VIS_PORCENTAJE";
            this.vISPORCENTAJEDataGridViewTextBoxColumn.HeaderText = "VIS_PORCENTAJE";
            this.vISPORCENTAJEDataGridViewTextBoxColumn.Name = "vISPORCENTAJEDataGridViewTextBoxColumn";
            this.vISPORCENTAJEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vISDURACIONDataGridViewTextBoxColumn
            // 
            this.vISDURACIONDataGridViewTextBoxColumn.DataPropertyName = "VIS_DURACION";
            this.vISDURACIONDataGridViewTextBoxColumn.HeaderText = "VIS_DURACION";
            this.vISDURACIONDataGridViewTextBoxColumn.Name = "vISDURACIONDataGridViewTextBoxColumn";
            this.vISDURACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // vISBAJADataGridViewCheckBoxColumn
            // 
            this.vISBAJADataGridViewCheckBoxColumn.DataPropertyName = "VIS_BAJA";
            this.vISBAJADataGridViewCheckBoxColumn.HeaderText = "VIS_BAJA";
            this.vISBAJADataGridViewCheckBoxColumn.Name = "vISBAJADataGridViewCheckBoxColumn";
            this.vISBAJADataGridViewCheckBoxColumn.Visible = false;
            // 
            // tIPOIDDataGridViewTextBoxColumn
            // 
            this.tIPOIDDataGridViewTextBoxColumn.DataPropertyName = "TIPO_ID";
            this.tIPOIDDataGridViewTextBoxColumn.HeaderText = "TIPO_ID";
            this.tIPOIDDataGridViewTextBoxColumn.Name = "tIPOIDDataGridViewTextBoxColumn";
            this.tIPOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIPODESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.tIPODESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "TIPO_DESCRIPCION";
            this.tIPODESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tIPODESCRIPCIONDataGridViewTextBoxColumn.Name = "tIPODESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // eSTADOIDDataGridViewTextBoxColumn
            // 
            this.eSTADOIDDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_ID";
            this.eSTADOIDDataGridViewTextBoxColumn.HeaderText = "ESTADO_ID";
            this.eSTADOIDDataGridViewTextBoxColumn.Name = "eSTADOIDDataGridViewTextBoxColumn";
            this.eSTADOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADODESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.eSTADODESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_DESCRIPCION";
            this.eSTADODESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.eSTADODESCRIPCIONDataGridViewTextBoxColumn.Name = "eSTADODESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Publicaciones";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONCOMPLETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource pUBLICACIONCOMPLETABindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_COMPLETATableAdapter pUBLICACION_COMPLETATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBTIPOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBESTADOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBFECHAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBFECHAFINALIZACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBVISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBUSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBPERMITIRPREGUNTASDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISCODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISPORCENTAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISDURACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vISBAJADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODESCRIPCIONDataGridViewTextBoxColumn;

    }
}