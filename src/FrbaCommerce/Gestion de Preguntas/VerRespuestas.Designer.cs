namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class VerRespuestas
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
            this.label1 = new System.Windows.Forms.Label();
            this.pREGUNTASRESPUESTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.pREGUNTAS_RESPUESTASTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PREGUNTAS_RESPUESTASTableAdapter();
            this.publicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preguntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREUSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGUNTASRESPUESTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publicacionDataGridViewTextBoxColumn,
            this.preguntaDataGridViewTextBoxColumn,
            this.respuestaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.pREUSUIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pREGUNTASRESPUESTASBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Respuestas";
            // 
            // pREGUNTASRESPUESTASBindingSource
            // 
            this.pREGUNTASRESPUESTASBindingSource.DataMember = "PREGUNTAS_RESPUESTAS";
            this.pREGUNTASRESPUESTASBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pREGUNTAS_RESPUESTASTableAdapter
            // 
            this.pREGUNTAS_RESPUESTASTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionDataGridViewTextBoxColumn
            // 
            this.publicacionDataGridViewTextBoxColumn.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.Name = "publicacionDataGridViewTextBoxColumn";
            this.publicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionDataGridViewTextBoxColumn.Width = 170;
            // 
            // preguntaDataGridViewTextBoxColumn
            // 
            this.preguntaDataGridViewTextBoxColumn.DataPropertyName = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.HeaderText = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.Name = "preguntaDataGridViewTextBoxColumn";
            this.preguntaDataGridViewTextBoxColumn.ReadOnly = true;
            this.preguntaDataGridViewTextBoxColumn.Width = 200;
            // 
            // respuestaDataGridViewTextBoxColumn
            // 
            this.respuestaDataGridViewTextBoxColumn.DataPropertyName = "Respuesta";
            this.respuestaDataGridViewTextBoxColumn.HeaderText = "Respuesta";
            this.respuestaDataGridViewTextBoxColumn.Name = "respuestaDataGridViewTextBoxColumn";
            this.respuestaDataGridViewTextBoxColumn.ReadOnly = true;
            this.respuestaDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pREUSUIDDataGridViewTextBoxColumn
            // 
            this.pREUSUIDDataGridViewTextBoxColumn.DataPropertyName = "PRE_USU_ID";
            this.pREUSUIDDataGridViewTextBoxColumn.HeaderText = "PRE_USU_ID";
            this.pREUSUIDDataGridViewTextBoxColumn.Name = "pREUSUIDDataGridViewTextBoxColumn";
            this.pREUSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pREUSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // VerRespuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerRespuestas";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.VerRespuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGUNTASRESPUESTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource pREGUNTASRESPUESTASBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PREGUNTAS_RESPUESTASTableAdapter pREGUNTAS_RESPUESTASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREUSUIDDataGridViewTextBoxColumn;
    }
}