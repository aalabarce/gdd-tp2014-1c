namespace FrbaCommerce.Generar_Publicacion
{
    partial class Generar_Publicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radTipoCompra = new System.Windows.Forms.RadioButton();
            this.radTipoSubasta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.chkRubros = new System.Windows.Forms.CheckedListBox();
            this.chkPreguntas = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVisibilidad = new System.Windows.Forms.ComboBox();
            this.rubroTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter();
            this.gD1C2014DataSet1 = new FrbaCommerce.GD1C2014DataSet();
            this.visibilidadTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.VISIBILIDADTableAdapter();
            this.publicacionTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter();
            this.getOrdenadosToolStrip = new System.Windows.Forms.ToolStrip();
            this.getOrdenadosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getOrdenadosToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.getOrdenadosToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblAclaracionSubasta = new System.Windows.Forms.Label();
            this.pub_rubro_TableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_RUBROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).BeginInit();
            this.getOrdenadosToolStrip.SuspendLayout();
            this.getOrdenadosToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar nueva publicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // radTipoCompra
            // 
            this.radTipoCompra.AutoSize = true;
            this.radTipoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTipoCompra.Location = new System.Drawing.Point(198, 57);
            this.radTipoCompra.Name = "radTipoCompra";
            this.radTipoCompra.Size = new System.Drawing.Size(118, 20);
            this.radTipoCompra.TabIndex = 2;
            this.radTipoCompra.TabStop = true;
            this.radTipoCompra.Text = "Compra directa";
            this.radTipoCompra.UseVisualStyleBackColor = false;
            this.radTipoCompra.CheckedChanged += new System.EventHandler(this.radTipoCompra_CheckedChanged);
            // 
            // radTipoSubasta
            // 
            this.radTipoSubasta.AutoSize = true;
            this.radTipoSubasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTipoSubasta.Location = new System.Drawing.Point(198, 83);
            this.radTipoSubasta.Name = "radTipoSubasta";
            this.radTipoSubasta.Size = new System.Drawing.Size(76, 20);
            this.radTipoSubasta.TabIndex = 3;
            this.radTipoSubasta.TabStop = true;
            this.radTipoSubasta.Text = "Subasta";
            this.radTipoSubasta.UseVisualStyleBackColor = false;
            this.radTipoSubasta.CheckedChanged += new System.EventHandler(this.radTipoSubasta_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rubros:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(35, 212);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(125, 16);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio (por unidad):";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(198, 167);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(198, 212);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // chkRubros
            // 
            this.chkRubros.CheckOnClick = true;
            this.chkRubros.FormattingEnabled = true;
            this.chkRubros.Location = new System.Drawing.Point(198, 246);
            this.chkRubros.Name = "chkRubros";
            this.chkRubros.Size = new System.Drawing.Size(333, 139);
            this.chkRubros.TabIndex = 17;
            this.chkRubros.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // chkPreguntas
            // 
            this.chkPreguntas.AutoSize = true;
            this.chkPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreguntas.Location = new System.Drawing.Point(38, 431);
            this.chkPreguntas.Name = "chkPreguntas";
            this.chkPreguntas.Size = new System.Drawing.Size(182, 20);
            this.chkPreguntas.TabIndex = 18;
            this.chkPreguntas.Text = "Permitir realizar preguntas";
            this.chkPreguntas.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(198, 118);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(346, 43);
            this.txtDescripcion.TabIndex = 19;
            this.txtDescripcion.Text = "";
            // 
            // btnBorrador
            // 
            this.btnBorrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrador.Location = new System.Drawing.Point(151, 469);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(147, 23);
            this.btnBorrador.TabIndex = 20;
            this.btnBorrador.Text = "Guardar borrador";
            this.btnBorrador.UseVisualStyleBackColor = true;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Location = new System.Drawing.Point(316, 469);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(95, 23);
            this.btnPublicar.TabIndex = 21;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Visibilidad:";
            // 
            // cmbVisibilidad
            // 
            this.cmbVisibilidad.FormattingEnabled = true;
            this.cmbVisibilidad.Location = new System.Drawing.Point(198, 397);
            this.cmbVisibilidad.Name = "cmbVisibilidad";
            this.cmbVisibilidad.Size = new System.Drawing.Size(170, 21);
            this.cmbVisibilidad.TabIndex = 23;
            this.cmbVisibilidad.SelectedIndexChanged += new System.EventHandler(this.cmbVisibilidad_SelectedIndexChanged);
            // 
            // rubroTableAdapter1
            // 
            this.rubroTableAdapter1.ClearBeforeFill = true;
            // 
            // gD1C2014DataSet1
            // 
            this.gD1C2014DataSet1.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visibilidadTableAdapter1
            // 
            this.visibilidadTableAdapter1.ClearBeforeFill = true;
            // 
            // publicacionTableAdapter1
            // 
            this.publicacionTableAdapter1.ClearBeforeFill = true;
            // 
            // getOrdenadosToolStrip
            // 
            this.getOrdenadosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getOrdenadosToolStripButton});
            this.getOrdenadosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.getOrdenadosToolStrip.Name = "getOrdenadosToolStrip";
            this.getOrdenadosToolStrip.Size = new System.Drawing.Size(566, 25);
            this.getOrdenadosToolStrip.TabIndex = 24;
            this.getOrdenadosToolStrip.Text = "getOrdenadosToolStrip";
            this.getOrdenadosToolStrip.Visible = false;
            // 
            // getOrdenadosToolStripButton
            // 
            this.getOrdenadosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getOrdenadosToolStripButton.Name = "getOrdenadosToolStripButton";
            this.getOrdenadosToolStripButton.Size = new System.Drawing.Size(80, 22);
            this.getOrdenadosToolStripButton.Text = "getOrdenados";
            // 
            // getOrdenadosToolStrip1
            // 
            this.getOrdenadosToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getOrdenadosToolStripButton1});
            this.getOrdenadosToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.getOrdenadosToolStrip1.Name = "getOrdenadosToolStrip1";
            this.getOrdenadosToolStrip1.Size = new System.Drawing.Size(566, 25);
            this.getOrdenadosToolStrip1.TabIndex = 25;
            this.getOrdenadosToolStrip1.Text = "getOrdenadosToolStrip1";
            this.getOrdenadosToolStrip1.Visible = false;
            // 
            // getOrdenadosToolStripButton1
            // 
            this.getOrdenadosToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getOrdenadosToolStripButton1.Name = "getOrdenadosToolStripButton1";
            this.getOrdenadosToolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.getOrdenadosToolStripButton1.Text = "getOrdenados";
            // 
            // lblAclaracionSubasta
            // 
            this.lblAclaracionSubasta.AutoSize = true;
            this.lblAclaracionSubasta.Location = new System.Drawing.Point(316, 174);
            this.lblAclaracionSubasta.Name = "lblAclaracionSubasta";
            this.lblAclaracionSubasta.Size = new System.Drawing.Size(207, 13);
            this.lblAclaracionSubasta.TabIndex = 26;
            this.lblAclaracionSubasta.Text = "El lote se venderá completo en la subasta.";
            this.lblAclaracionSubasta.Visible = false;
            // 
            // pub_rubro_TableAdapter
            // 
            this.pub_rubro_TableAdapter.ClearBeforeFill = true;
            // 
            // Generar_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 512);
            this.Controls.Add(this.lblAclaracionSubasta);
            this.Controls.Add(this.getOrdenadosToolStrip1);
            this.Controls.Add(this.getOrdenadosToolStrip);
            this.Controls.Add(this.cmbVisibilidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnBorrador);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.chkPreguntas);
            this.Controls.Add(this.chkRubros);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radTipoSubasta);
            this.Controls.Add(this.radTipoCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generar_Publicacion";
            this.Text = "Generar publicación";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).EndInit();
            this.getOrdenadosToolStrip.ResumeLayout(false);
            this.getOrdenadosToolStrip.PerformLayout();
            this.getOrdenadosToolStrip1.ResumeLayout(false);
            this.getOrdenadosToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radTipoCompra;
        private System.Windows.Forms.RadioButton radTipoSubasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.CheckedListBox chkRubros;
        private System.Windows.Forms.CheckBox chkPreguntas;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter rubroTableAdapter1;
        private GD1C2014DataSet gD1C2014DataSet1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVisibilidad;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.VISIBILIDADTableAdapter visibilidadTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter publicacionTableAdapter1;
        private System.Windows.Forms.ToolStrip getOrdenadosToolStrip;
        private System.Windows.Forms.ToolStripButton getOrdenadosToolStripButton;
        private System.Windows.Forms.ToolStrip getOrdenadosToolStrip1;
        private System.Windows.Forms.ToolStripButton getOrdenadosToolStripButton1;
        private System.Windows.Forms.Label lblAclaracionSubasta;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_RUBROTableAdapter pub_rubro_TableAdapter;
    }
}