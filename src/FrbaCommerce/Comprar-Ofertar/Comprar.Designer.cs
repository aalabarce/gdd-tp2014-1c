﻿namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Comprar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comprasLIMIT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet1 = new FrbaCommerce.GD1C2014DataSet();
            this.pUBLICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter();
            this.usuarioTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter();
            this.comprasLIMIT1TableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.ComprasLIMIT1TableAdapter();
            this.PUB_STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUB_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUB_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PUB_USU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUB_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasLIMIT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PUB_STOCK,
            this.PUB_PRECIO,
            this.PUB_DESCRIPCION,
            this.Compra,
            this.PUB_USU_ID,
            this.PUB_ID});
            this.dataGridView1.DataSource = this.comprasLIMIT1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comprasLIMIT1BindingSource
            // 
            this.comprasLIMIT1BindingSource.DataMember = "ComprasLIMIT1";
            this.comprasLIMIT1BindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // gD1C2014DataSet1
            // 
            this.gD1C2014DataSet1.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLICACIONBindingSource
            // 
            this.pUBLICACIONBindingSource.DataMember = "PUBLICACION";
            this.pUBLICACIONBindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // publicacionTableAdapter1
            // 
            this.publicacionTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // comprasLIMIT1TableAdapter
            // 
            this.comprasLIMIT1TableAdapter.ClearBeforeFill = true;
            // 
            // PUB_STOCK
            // 
            this.PUB_STOCK.DataPropertyName = "PUB_STOCK";
            this.PUB_STOCK.HeaderText = "PUB_STOCK";
            this.PUB_STOCK.Name = "PUB_STOCK";
            this.PUB_STOCK.ReadOnly = true;
            // 
            // PUB_PRECIO
            // 
            this.PUB_PRECIO.DataPropertyName = "PUB_PRECIO";
            this.PUB_PRECIO.HeaderText = "PUB_PRECIO";
            this.PUB_PRECIO.Name = "PUB_PRECIO";
            this.PUB_PRECIO.ReadOnly = true;
            // 
            // PUB_DESCRIPCION
            // 
            this.PUB_DESCRIPCION.DataPropertyName = "PUB_DESCRIPCION";
            this.PUB_DESCRIPCION.HeaderText = "PUB_DESCRIPCION";
            this.PUB_DESCRIPCION.Name = "PUB_DESCRIPCION";
            this.PUB_DESCRIPCION.ReadOnly = true;
            // 
            // Compra
            // 
            this.Compra.HeaderText = "Compra";
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            this.Compra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Compra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PUB_USU_ID
            // 
            this.PUB_USU_ID.DataPropertyName = "PUB_USU_ID";
            this.PUB_USU_ID.HeaderText = "PUB_USU_ID";
            this.PUB_USU_ID.Name = "PUB_USU_ID";
            this.PUB_USU_ID.ReadOnly = true;
            this.PUB_USU_ID.Visible = false;
            // 
            // PUB_ID
            // 
            this.PUB_ID.DataPropertyName = "PUB_ID";
            this.PUB_ID.HeaderText = "PUB_ID";
            this.PUB_ID.Name = "PUB_ID";
            this.PUB_ID.ReadOnly = true;
            this.PUB_ID.Visible = false;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 430);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasLIMIT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter publicacionTableAdapter1;
        private GD1C2014DataSet gD1C2014DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pUBLICACIONBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource comprasLIMIT1BindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.ComprasLIMIT1TableAdapter comprasLIMIT1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_STOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_DESCRIPCION;
        private System.Windows.Forms.DataGridViewButtonColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_USU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_ID;
    }
}