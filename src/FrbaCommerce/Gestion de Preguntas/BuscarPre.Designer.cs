namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class BuscarPre
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
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.pREGUNTASARESPONDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREGUNTAS_A_RESPONDERTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PREGUNTAS_A_RESPONDERTableAdapter();
            this.publicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preguntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PRE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUB_USU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGUNTASARESPONDERBindingSource)).BeginInit();
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
            this.Responder,
            this.PRE_ID,
            this.PUB_USU_ID});
            this.dataGridView1.DataSource = this.pREGUNTASARESPONDERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(676, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la pregunta que desea responder.";
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pREGUNTASARESPONDERBindingSource
            // 
            this.pREGUNTASARESPONDERBindingSource.DataMember = "PREGUNTAS_A_RESPONDER";
            this.pREGUNTASARESPONDERBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // pREGUNTAS_A_RESPONDERTableAdapter
            // 
            this.pREGUNTAS_A_RESPONDERTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionDataGridViewTextBoxColumn
            // 
            this.publicacionDataGridViewTextBoxColumn.DataPropertyName = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.HeaderText = "Publicacion";
            this.publicacionDataGridViewTextBoxColumn.Name = "publicacionDataGridViewTextBoxColumn";
            this.publicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicacionDataGridViewTextBoxColumn.Width = 180;
            // 
            // preguntaDataGridViewTextBoxColumn
            // 
            this.preguntaDataGridViewTextBoxColumn.DataPropertyName = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.HeaderText = "Pregunta";
            this.preguntaDataGridViewTextBoxColumn.Name = "preguntaDataGridViewTextBoxColumn";
            this.preguntaDataGridViewTextBoxColumn.ReadOnly = true;
            this.preguntaDataGridViewTextBoxColumn.Width = 330;
            // 
            // Responder
            // 
            this.Responder.HeaderText = "Seleccionar";
            this.Responder.Name = "Responder";
            this.Responder.ReadOnly = true;
            // 
            // PRE_ID
            // 
            this.PRE_ID.DataPropertyName = "PRE_ID";
            this.PRE_ID.HeaderText = "PRE_ID";
            this.PRE_ID.Name = "PRE_ID";
            this.PRE_ID.ReadOnly = true;
            this.PRE_ID.Visible = false;
            // 
            // PUB_USU_ID
            // 
            this.PUB_USU_ID.DataPropertyName = "PUB_USU_ID";
            this.PUB_USU_ID.HeaderText = "PUB_USU_ID";
            this.PUB_USU_ID.Name = "PUB_USU_ID";
            this.PUB_USU_ID.ReadOnly = true;
            this.PUB_USU_ID.Visible = false;
            // 
            // ResponderPre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ResponderPre";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.ResponderPre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGUNTASARESPONDERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource pREGUNTASARESPONDERBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PREGUNTAS_A_RESPONDERTableAdapter pREGUNTAS_A_RESPONDERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Responder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_USU_ID;
    }
}