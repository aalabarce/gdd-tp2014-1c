namespace FrbaCommerce.Abm_Empresa
{
    partial class Baja
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMPRAZONSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EMP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet1 = new FrbaCommerce.GD1C2014DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.empresaTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.EMPRESATableAdapter();
            this.usuarioTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razón Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPRAZONSOCIALDataGridViewTextBoxColumn,
            this.EMP_CUIT,
            this.EMP_MAIL,
            this.Eliminar,
            this.EMP_ID});
            this.dataGridView1.DataSource = this.eMPRESABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(460, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eMPRAZONSOCIALDataGridViewTextBoxColumn
            // 
            this.eMPRAZONSOCIALDataGridViewTextBoxColumn.DataPropertyName = "EMP_RAZON_SOCIAL";
            this.eMPRAZONSOCIALDataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.eMPRAZONSOCIALDataGridViewTextBoxColumn.Name = "eMPRAZONSOCIALDataGridViewTextBoxColumn";
            this.eMPRAZONSOCIALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EMP_CUIT
            // 
            this.EMP_CUIT.DataPropertyName = "EMP_CUIT";
            this.EMP_CUIT.HeaderText = "CUIT";
            this.EMP_CUIT.Name = "EMP_CUIT";
            this.EMP_CUIT.ReadOnly = true;
            // 
            // EMP_MAIL
            // 
            this.EMP_MAIL.DataPropertyName = "EMP_MAIL";
            this.EMP_MAIL.HeaderText = "Email";
            this.EMP_MAIL.Name = "EMP_MAIL";
            this.EMP_MAIL.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Seleccione";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // EMP_ID
            // 
            this.EMP_ID.DataPropertyName = "EMP_ID";
            this.EMP_ID.HeaderText = "EMP_ID";
            this.EMP_ID.Name = "EMP_ID";
            this.EMP_ID.ReadOnly = true;
            this.EMP_ID.Visible = false;
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // gD1C2014DataSet1
            // 
            this.gD1C2014DataSet1.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // empresaTableAdapter1
            // 
            this.empresaTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Baja";
            this.Text = "Frba Commerce";
            this.Load += new System.EventHandler(this.Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.EMPRESATableAdapter empresaTableAdapter1;
        private GD1C2014DataSet gD1C2014DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPRAZONSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_MAIL;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_ID;
        private System.Windows.Forms.Button button2;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter1;
    }
}