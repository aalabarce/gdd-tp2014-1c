namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class verFactura
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
            this.facturaTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.FACTURATableAdapter();
            this.gD1C2014DataSet1 = new FrbaCommerce.GD1C2014DataSet();
            this.iteM_FACTURATableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.ITEM_FACTURATableAdapter();
            this.iTEM_FACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager();
            this.iTEM_FACTURADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fACTURACIONES_VENDEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURACIONES_VENDEDORESTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.FACTURACIONES_VENDEDORESTableAdapter();
            this.formA_PAGOTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.FORMA_PAGOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEM_FACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEM_FACTURADataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONES_VENDEDORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // facturaTableAdapter1
            // 
            this.facturaTableAdapter1.ClearBeforeFill = true;
            // 
            // gD1C2014DataSet1
            // 
            this.gD1C2014DataSet1.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iteM_FACTURATableAdapter1
            // 
            this.iteM_FACTURATableAdapter1.ClearBeforeFill = true;
            // 
            // iTEM_FACTURABindingSource
            // 
            this.iTEM_FACTURABindingSource.DataMember = "ITEM_FACTURA";
            this.iTEM_FACTURABindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CALIFICACIONTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = null;
            this.tableAdapterManager.EMPRESATableAdapter = null;
            this.tableAdapterManager.ESTADOTableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = this.facturaTableAdapter1;
            this.tableAdapterManager.FORMA_PAGOTableAdapter = null;
            this.tableAdapterManager.FUNCIONALIDADTableAdapter = null;
            this.tableAdapterManager.ITEM_FACTURATableAdapter = this.iteM_FACTURATableAdapter1;
            this.tableAdapterManager.MaestraTableAdapter = null;
            this.tableAdapterManager.OFERTATableAdapter = null;
            this.tableAdapterManager.PREGUNTATableAdapter = null;
            this.tableAdapterManager.PUBLICACION_RUBROTableAdapter = null;
            this.tableAdapterManager.PUBLICACIONTableAdapter = null;
            this.tableAdapterManager.RESPUESTATableAdapter = null;
            this.tableAdapterManager.ROL_FUNCIONALIDADTableAdapter = null;
            this.tableAdapterManager.ROLTableAdapter = null;
            this.tableAdapterManager.RUBROTableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIO_ROLTableAdapter = null;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VISIBILIDADTableAdapter = null;
            // 
            // iTEM_FACTURADataGridView
            // 
            this.iTEM_FACTURADataGridView.AutoGenerateColumns = false;
            this.iTEM_FACTURADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTEM_FACTURADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.iTEM_FACTURADataGridView.DataSource = this.iTEM_FACTURABindingSource;
            this.iTEM_FACTURADataGridView.Location = new System.Drawing.Point(119, 205);
            this.iTEM_FACTURADataGridView.Name = "iTEM_FACTURADataGridView";
            this.iTEM_FACTURADataGridView.Size = new System.Drawing.Size(395, 255);
            this.iTEM_FACTURADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ITEM_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ITEM_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ITEM_PUB_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código Publicación";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ITEM_MONTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ITEM_CANTIDAD";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ITEM_FAC_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ITEM_FAC_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblForma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iTEM_FACTURADataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 492);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Items:";
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.Location = new System.Drawing.Point(181, 162);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(84, 24);
            this.lblForma.TabIndex = 9;
            this.lblForma.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Forma de pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(181, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 24);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Numero:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(181, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 24);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(181, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 24);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fACTURACIONES_VENDEDORESBindingSource
            // 
            this.fACTURACIONES_VENDEDORESBindingSource.DataMember = "FACTURACIONES_VENDEDORES";
            this.fACTURACIONES_VENDEDORESBindingSource.DataSource = this.gD1C2014DataSet1;
            // 
            // fACTURACIONES_VENDEDORESTableAdapter
            // 
            this.fACTURACIONES_VENDEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // formA_PAGOTableAdapter1
            // 
            this.formA_PAGOTableAdapter1.ClearBeforeFill = true;
            // 
            // verFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "verFactura";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEM_FACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEM_FACTURADataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONES_VENDEDORESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FrbaCommerce.GD1C2014DataSetTableAdapters.FACTURATableAdapter facturaTableAdapter1;
        private GD1C2014DataSet gD1C2014DataSet1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.ITEM_FACTURATableAdapter iteM_FACTURATableAdapter1;
        private System.Windows.Forms.BindingSource iTEM_FACTURABindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView iTEM_FACTURADataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource fACTURACIONES_VENDEDORESBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.FACTURACIONES_VENDEDORESTableAdapter fACTURACIONES_VENDEDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.FORMA_PAGOTableAdapter formA_PAGOTableAdapter1;
    }
}