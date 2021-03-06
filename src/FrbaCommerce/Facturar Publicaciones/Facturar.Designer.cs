﻿namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class Facturar
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
            this.cODIGOPUBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINEASFACTURACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2014DataSet = new FrbaCommerce.GD1C2014DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lINEAS_FACTURACIONTableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.LINEAS_FACTURACIONTableAdapter();
            this.formA_PAGOTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.FORMA_PAGOTableAdapter();
            this.iteM_FACTURATableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.ITEM_FACTURATableAdapter();
            this.facturaTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.FACTURATableAdapter();
            this.lblCantFacturaciones = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtCodSeguridad = new System.Windows.Forms.TextBox();
            this.grDatosTarjeta = new System.Windows.Forms.GroupBox();
            this.tarjetaTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.TARJETATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEASFACTURACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGOPUBDataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.fECHAFINDataGridViewTextBoxColumn,
            this.uSUARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lINEASFACTURACIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(498, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // cODIGOPUBDataGridViewTextBoxColumn
            // 
            this.cODIGOPUBDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_PUB";
            this.cODIGOPUBDataGridViewTextBoxColumn.HeaderText = "CODIGO_PUB";
            this.cODIGOPUBDataGridViewTextBoxColumn.Name = "cODIGOPUBDataGridViewTextBoxColumn";
            this.cODIGOPUBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            this.pRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            this.xDataGridViewTextBoxColumn.Visible = false;
            // 
            // fECHAFINDataGridViewTextBoxColumn
            // 
            this.fECHAFINDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN";
            this.fECHAFINDataGridViewTextBoxColumn.HeaderText = "FECHA_FIN";
            this.fECHAFINDataGridViewTextBoxColumn.Name = "fECHAFINDataGridViewTextBoxColumn";
            this.fECHAFINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            this.uSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.uSUARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // lINEASFACTURACIONBindingSource
            // 
            this.lINEASFACTURACIONBindingSource.DataMember = "LINEAS_FACTURACION";
            this.lINEASFACTURACIONBindingSource.DataSource = this.gD1C2014DataSet;
            // 
            // gD1C2014DataSet
            // 
            this.gD1C2014DataSet.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de publicaciones a facturar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Medio de pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(302, 420);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cmbFormaPago.TabIndex = 20;
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(484, 410);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 31);
            this.btnPagar.TabIndex = 22;
            this.btnPagar.Text = "Facturar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lINEAS_FACTURACIONTableAdapter
            // 
            this.lINEAS_FACTURACIONTableAdapter.ClearBeforeFill = true;
            // 
            // formA_PAGOTableAdapter1
            // 
            this.formA_PAGOTableAdapter1.ClearBeforeFill = true;
            // 
            // iteM_FACTURATableAdapter1
            // 
            this.iteM_FACTURATableAdapter1.ClearBeforeFill = true;
            // 
            // facturaTableAdapter1
            // 
            this.facturaTableAdapter1.ClearBeforeFill = true;
            // 
            // lblCantFacturaciones
            // 
            this.lblCantFacturaciones.AutoSize = true;
            this.lblCantFacturaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantFacturaciones.Location = new System.Drawing.Point(14, 80);
            this.lblCantFacturaciones.Name = "lblCantFacturaciones";
            this.lblCantFacturaciones.Size = new System.Drawing.Size(51, 20);
            this.lblCantFacturaciones.TabIndex = 23;
            this.lblCantFacturaciones.Text = "label4";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(302, 375);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 20);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Código de Seguridad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fecha de Vencimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(241, 465);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(181, 26);
            this.txtNumero.TabIndex = 30;
            this.txtNumero.Tag = "Número";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(241, 497);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(51, 26);
            this.txtMes.TabIndex = 31;
            this.txtMes.Tag = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "/";
            // 
            // txtAnio
            // 
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(317, 497);
            this.txtAnio.MaxLength = 2;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(51, 26);
            this.txtAnio.TabIndex = 33;
            this.txtAnio.Tag = "Año";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguridad.Location = new System.Drawing.Point(241, 526);
            this.txtCodSeguridad.MaxLength = 3;
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(51, 26);
            this.txtCodSeguridad.TabIndex = 34;
            this.txtCodSeguridad.Tag = "Código de Seguridad";
            // 
            // grDatosTarjeta
            // 
            this.grDatosTarjeta.Location = new System.Drawing.Point(18, 447);
            this.grDatosTarjeta.Name = "grDatosTarjeta";
            this.grDatosTarjeta.Size = new System.Drawing.Size(429, 120);
            this.grDatosTarjeta.TabIndex = 35;
            this.grDatosTarjeta.TabStop = false;
            this.grDatosTarjeta.Text = "Datos Tarjeta";
            // 
            // tarjetaTableAdapter1
            // 
            this.tarjetaTableAdapter1.ClearBeforeFill = true;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 594);
            this.Controls.Add(this.txtCodSeguridad);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantFacturaciones);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grDatosTarjeta);
            this.Name = "Facturar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEASFACTURACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2014DataSet gD1C2014DataSet;
        private System.Windows.Forms.BindingSource lINEASFACTURACIONBindingSource;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.LINEAS_FACTURACIONTableAdapter lINEAS_FACTURACIONTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOPUBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Button btnPagar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.FORMA_PAGOTableAdapter formA_PAGOTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.ITEM_FACTURATableAdapter iteM_FACTURATableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.FACTURATableAdapter facturaTableAdapter1;
        private System.Windows.Forms.Label lblCantFacturaciones;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtCodSeguridad;
        private System.Windows.Forms.GroupBox grDatosTarjeta;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.TARJETATableAdapter tarjetaTableAdapter1;
    }
}