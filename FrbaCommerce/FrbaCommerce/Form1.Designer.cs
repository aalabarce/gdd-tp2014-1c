﻿namespace FrbaCommerce
{
    partial class Form1
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
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.ROLTableAdapter();
            this.rOLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLBAJADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOLIDDataGridViewTextBoxColumn,
            this.rOLNOMBREDataGridViewTextBoxColumn,
            this.rOLBAJADataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.rOLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // rOLIDDataGridViewTextBoxColumn
            // 
            this.rOLIDDataGridViewTextBoxColumn.DataPropertyName = "ROL_ID";
            this.rOLIDDataGridViewTextBoxColumn.HeaderText = "ROL_ID";
            this.rOLIDDataGridViewTextBoxColumn.Name = "rOLIDDataGridViewTextBoxColumn";
            this.rOLIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOLNOMBREDataGridViewTextBoxColumn
            // 
            this.rOLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "ROL_NOMBRE";
            this.rOLNOMBREDataGridViewTextBoxColumn.HeaderText = "ROL_NOMBRE";
            this.rOLNOMBREDataGridViewTextBoxColumn.Name = "rOLNOMBREDataGridViewTextBoxColumn";
            // 
            // rOLBAJADataGridViewCheckBoxColumn
            // 
            this.rOLBAJADataGridViewCheckBoxColumn.DataPropertyName = "ROL_BAJA";
            this.rOLBAJADataGridViewCheckBoxColumn.HeaderText = "ROL_BAJA";
            this.rOLBAJADataGridViewCheckBoxColumn.Name = "rOLBAJADataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 420);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.ROLTableAdapter rOLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rOLBAJADataGridViewCheckBoxColumn;
    }
}

