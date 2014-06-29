namespace FrbaCommerce.Editar_Publicacion
{
    partial class Editar
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
            this.lblAclaracionSubasta = new System.Windows.Forms.Label();
            this.cmbVisibilidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.chkPreguntas = new System.Windows.Forms.CheckBox();
            this.chkRubros = new System.Windows.Forms.CheckedListBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radTipoSubasta = new System.Windows.Forms.RadioButton();
            this.radTipoCompra = new System.Windows.Forms.RadioButton();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.publicacionTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter();
            this.gD1C2014DataSet1 = new FrbaCommerce.GD1C2014DataSet();
            this.rubroTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter();
            this.visibilidadTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.VISIBILIDADTableAdapter();
            this.pub_rubro_TableAdapter = new FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_RUBROTableAdapter();
            this.rubroTableAdapter2 = new FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter();
            this.ofertaTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.OFERTATableAdapter();
            this.compraTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRATableAdapter();
            this.usuarioTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAclaracionSubasta
            // 
            this.lblAclaracionSubasta.AutoSize = true;
            this.lblAclaracionSubasta.Location = new System.Drawing.Point(305, 183);
            this.lblAclaracionSubasta.Name = "lblAclaracionSubasta";
            this.lblAclaracionSubasta.Size = new System.Drawing.Size(207, 13);
            this.lblAclaracionSubasta.TabIndex = 46;
            this.lblAclaracionSubasta.Text = "El lote se venderá completo en la subasta.";
            this.lblAclaracionSubasta.Visible = false;
            // 
            // cmbVisibilidad
            // 
            this.cmbVisibilidad.FormattingEnabled = true;
            this.cmbVisibilidad.Location = new System.Drawing.Point(187, 406);
            this.cmbVisibilidad.Name = "cmbVisibilidad";
            this.cmbVisibilidad.Size = new System.Drawing.Size(170, 21);
            this.cmbVisibilidad.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Visibilidad:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(469, 478);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 23);
            this.btnVolver.TabIndex = 43;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(347, 478);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 23);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(187, 127);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(346, 43);
            this.txtDescripcion.TabIndex = 41;
            this.txtDescripcion.Text = "";
            // 
            // chkPreguntas
            // 
            this.chkPreguntas.AutoSize = true;
            this.chkPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreguntas.Location = new System.Drawing.Point(27, 440);
            this.chkPreguntas.Name = "chkPreguntas";
            this.chkPreguntas.Size = new System.Drawing.Size(182, 20);
            this.chkPreguntas.TabIndex = 40;
            this.chkPreguntas.Text = "Permitir realizar preguntas";
            this.chkPreguntas.UseVisualStyleBackColor = true;
            // 
            // chkRubros
            // 
            this.chkRubros.CheckOnClick = true;
            this.chkRubros.FormattingEnabled = true;
            this.chkRubros.Location = new System.Drawing.Point(187, 255);
            this.chkRubros.Name = "chkRubros";
            this.chkRubros.Size = new System.Drawing.Size(333, 139);
            this.chkRubros.TabIndex = 39;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(187, 217);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 38;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(24, 218);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(125, 16);
            this.lblPrecio.TabIndex = 36;
            this.lblPrecio.Text = "Precio (por unidad):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Rubros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editar publicación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 47;
            // 
            // radTipoSubasta
            // 
            this.radTipoSubasta.AutoSize = true;
            this.radTipoSubasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTipoSubasta.Location = new System.Drawing.Point(187, 92);
            this.radTipoSubasta.Name = "radTipoSubasta";
            this.radTipoSubasta.Size = new System.Drawing.Size(76, 20);
            this.radTipoSubasta.TabIndex = 49;
            this.radTipoSubasta.TabStop = true;
            this.radTipoSubasta.Text = "Subasta";
            this.radTipoSubasta.UseVisualStyleBackColor = false;
            this.radTipoSubasta.CheckedChanged += new System.EventHandler(this.radTipoSubasta_CheckedChanged_1);
            // 
            // radTipoCompra
            // 
            this.radTipoCompra.AutoSize = true;
            this.radTipoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTipoCompra.Location = new System.Drawing.Point(187, 66);
            this.radTipoCompra.Name = "radTipoCompra";
            this.radTipoCompra.Size = new System.Drawing.Size(118, 20);
            this.radTipoCompra.TabIndex = 48;
            this.radTipoCompra.TabStop = true;
            this.radTipoCompra.Text = "Compra directa";
            this.radTipoCompra.UseVisualStyleBackColor = false;
            this.radTipoCompra.CheckedChanged += new System.EventHandler(this.radTipoCompra_CheckedChanged_1);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.Location = new System.Drawing.Point(27, 478);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(278, 23);
            this.btnCambiarEstado.TabIndex = 50;
            this.btnCambiarEstado.Text = "Cambiar a estado:";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(27, 512);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(278, 23);
            this.btnFinalizar.TabIndex = 51;
            this.btnFinalizar.Text = "Finalizar publicación";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // publicacionTableAdapter1
            // 
            this.publicacionTableAdapter1.ClearBeforeFill = true;
            // 
            // gD1C2014DataSet1
            // 
            this.gD1C2014DataSet1.DataSetName = "GD1C2014DataSet";
            this.gD1C2014DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubroTableAdapter1
            // 
            this.rubroTableAdapter1.ClearBeforeFill = true;
            // 
            // visibilidadTableAdapter1
            // 
            this.visibilidadTableAdapter1.ClearBeforeFill = true;
            // 
            // pub_rubro_TableAdapter
            // 
            this.pub_rubro_TableAdapter.ClearBeforeFill = true;
            // 
            // rubroTableAdapter2
            // 
            this.rubroTableAdapter2.ClearBeforeFill = true;
            // 
            // ofertaTableAdapter1
            // 
            this.ofertaTableAdapter1.ClearBeforeFill = true;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(187, 181);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 52;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 547);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.radTipoSubasta);
            this.Controls.Add(this.radTipoCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAclaracionSubasta);
            this.Controls.Add(this.cmbVisibilidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.chkPreguntas);
            this.Controls.Add(this.chkRubros);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Editar";
            this.Text = "Editar Publicacion";
            this.Load += new System.EventHandler(this.editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2014DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAclaracionSubasta;
        private System.Windows.Forms.ComboBox cmbVisibilidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkPreguntas;
        private System.Windows.Forms.CheckedListBox chkRubros;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACIONTableAdapter publicacionTableAdapter1;
        private GD1C2014DataSet gD1C2014DataSet1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radTipoSubasta;
        private System.Windows.Forms.RadioButton radTipoCompra;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter rubroTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.VISIBILIDADTableAdapter visibilidadTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.PUBLICACION_RUBROTableAdapter pub_rubro_TableAdapter;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.RUBROTableAdapter rubroTableAdapter2;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnFinalizar;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.OFERTATableAdapter ofertaTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.COMPRATableAdapter compraTableAdapter1;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.NumericUpDown txtStock;
    }
}