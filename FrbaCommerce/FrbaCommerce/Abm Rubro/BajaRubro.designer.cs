﻿namespace FrbaCommerce.Abm_Rubro
{
    partial class BajaRubro
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.rUBROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUBROTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter();
            this.rUBROIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUBRODESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rUBROIDDataGridViewTextBoxColumn,
            this.rUBRODESCRIPCIONDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dataGridView1.DataSource = this.rUBROBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 149);
            this.dataGridView1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inserte codigo para realizar la busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Tag = "codigo";
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rUBROBindingSource
            // 
            this.rUBROBindingSource.DataMember = "RUBRO";
            this.rUBROBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // rUBROTableAdapter
            // 
            this.rUBROTableAdapter.ClearBeforeFill = true;
            // 
            // rUBROIDDataGridViewTextBoxColumn
            // 
            this.rUBROIDDataGridViewTextBoxColumn.DataPropertyName = "RUBRO_ID";
            this.rUBROIDDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.rUBROIDDataGridViewTextBoxColumn.Name = "rUBROIDDataGridViewTextBoxColumn";
            this.rUBROIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rUBRODESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.rUBRODESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "RUBRO_DESCRIPCION";
            this.rUBRODESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.rUBRODESCRIPCIONDataGridViewTextBoxColumn.Name = "rUBRODESCRIPCIONDataGridViewTextBoxColumn";
            this.rUBRODESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Eliminar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BajaRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 306);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "BajaRubro";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.BajaRubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource rUBROBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter rUBROTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUBROIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUBRODESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}