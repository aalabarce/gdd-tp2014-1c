namespace FrbaCommerce
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPublicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearVisibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVisibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVisibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificiarRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioTableAdapter1 = new FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.publicaciónToolStripMenuItem,
            this.visibilidadToolStripMenuItem,
            this.rubroToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.rolToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.calificarToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // publicaciónToolStripMenuItem
            // 
            this.publicaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarNuevaToolStripMenuItem,
            this.editarPublicaciónToolStripMenuItem});
            this.publicaciónToolStripMenuItem.Name = "publicaciónToolStripMenuItem";
            this.publicaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.publicaciónToolStripMenuItem.Text = "Publicación";
            // 
            // generarNuevaToolStripMenuItem
            // 
            this.generarNuevaToolStripMenuItem.Name = "generarNuevaToolStripMenuItem";
            this.generarNuevaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.generarNuevaToolStripMenuItem.Text = "Generar nueva";
            this.generarNuevaToolStripMenuItem.Click += new System.EventHandler(this.generarNuevaToolStripMenuItem_Click);
            // 
            // editarPublicaciónToolStripMenuItem
            // 
            this.editarPublicaciónToolStripMenuItem.Name = "editarPublicaciónToolStripMenuItem";
            this.editarPublicaciónToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarPublicaciónToolStripMenuItem.Text = "Editar Publicación";
            this.editarPublicaciónToolStripMenuItem.Click += new System.EventHandler(this.editarPublicaciónToolStripMenuItem_Click);
            // 
            // visibilidadToolStripMenuItem
            // 
            this.visibilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearVisibilidadToolStripMenuItem,
            this.modificarVisibilidadToolStripMenuItem,
            this.eliminarVisibilidadToolStripMenuItem});
            this.visibilidadToolStripMenuItem.Name = "visibilidadToolStripMenuItem";
            this.visibilidadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visibilidadToolStripMenuItem.Text = "Visibilidad";
            // 
            // crearVisibilidadToolStripMenuItem
            // 
            this.crearVisibilidadToolStripMenuItem.Name = "crearVisibilidadToolStripMenuItem";
            this.crearVisibilidadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.crearVisibilidadToolStripMenuItem.Text = "Crear Visibilidad";
            this.crearVisibilidadToolStripMenuItem.Click += new System.EventHandler(this.crearVisibilidadToolStripMenuItem_Click);
            // 
            // modificarVisibilidadToolStripMenuItem
            // 
            this.modificarVisibilidadToolStripMenuItem.Name = "modificarVisibilidadToolStripMenuItem";
            this.modificarVisibilidadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modificarVisibilidadToolStripMenuItem.Text = "Modificar Visibilidad";
            this.modificarVisibilidadToolStripMenuItem.Click += new System.EventHandler(this.modificarVisibilidadToolStripMenuItem_Click);
            // 
            // eliminarVisibilidadToolStripMenuItem
            // 
            this.eliminarVisibilidadToolStripMenuItem.Name = "eliminarVisibilidadToolStripMenuItem";
            this.eliminarVisibilidadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.eliminarVisibilidadToolStripMenuItem.Text = "Eliminar Visibilidad";
            this.eliminarVisibilidadToolStripMenuItem.Click += new System.EventHandler(this.eliminarVisibilidadToolStripMenuItem_Click);
            // 
            // rubroToolStripMenuItem
            // 
            this.rubroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRubroToolStripMenuItem,
            this.modificiarRubroToolStripMenuItem,
            this.eliminarRubroToolStripMenuItem});
            this.rubroToolStripMenuItem.Name = "rubroToolStripMenuItem";
            this.rubroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rubroToolStripMenuItem.Text = "Rubro";
            // 
            // crearRubroToolStripMenuItem
            // 
            this.crearRubroToolStripMenuItem.Name = "crearRubroToolStripMenuItem";
            this.crearRubroToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.crearRubroToolStripMenuItem.Text = "Crear Rubro";
            this.crearRubroToolStripMenuItem.Click += new System.EventHandler(this.crearRubroToolStripMenuItem_Click);
            // 
            // modificiarRubroToolStripMenuItem
            // 
            this.modificiarRubroToolStripMenuItem.Name = "modificiarRubroToolStripMenuItem";
            this.modificiarRubroToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modificiarRubroToolStripMenuItem.Text = "Modificiar Rubro";
            this.modificiarRubroToolStripMenuItem.Click += new System.EventHandler(this.modificiarRubroToolStripMenuItem_Click);
            // 
            // eliminarRubroToolStripMenuItem
            // 
            this.eliminarRubroToolStripMenuItem.Name = "eliminarRubroToolStripMenuItem";
            this.eliminarRubroToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.eliminarRubroToolStripMenuItem.Text = "Eliminar Rubro";
            this.eliminarRubroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRubroToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.modificacionToolStripMenuItem,
            this.bajaToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.altaToolStripMenuItem.Text = "Crear Empresa";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificacionToolStripMenuItem.Text = "Modificar Empresa";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bajaToolStripMenuItem.Text = "Eliminar Empresa";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRolToolStripMenuItem,
            this.modificarRolToolStripMenuItem,
            this.eliminarRolToolStripMenuItem});
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            // 
            // crearRolToolStripMenuItem
            // 
            this.crearRolToolStripMenuItem.Name = "crearRolToolStripMenuItem";
            this.crearRolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearRolToolStripMenuItem.Text = "Crear Rol";
            this.crearRolToolStripMenuItem.Click += new System.EventHandler(this.crearRolToolStripMenuItem_Click);
            // 
            // modificarRolToolStripMenuItem
            // 
            this.modificarRolToolStripMenuItem.Name = "modificarRolToolStripMenuItem";
            this.modificarRolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarRolToolStripMenuItem.Text = "Modificar Rol";
            this.modificarRolToolStripMenuItem.Click += new System.EventHandler(this.modificarRolToolStripMenuItem_Click);
            // 
            // eliminarRolToolStripMenuItem
            // 
            this.eliminarRolToolStripMenuItem.Name = "eliminarRolToolStripMenuItem";
            this.eliminarRolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarRolToolStripMenuItem.Text = "Eliminar Rol";
            this.eliminarRolToolStripMenuItem.Click += new System.EventHandler(this.eliminarRolToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // calificarToolStripMenuItem
            // 
            this.calificarToolStripMenuItem.Name = "calificarToolStripMenuItem";
            this.calificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calificarToolStripMenuItem.Text = "Calificar";
            this.calificarToolStripMenuItem.Click += new System.EventHandler(this.calificarToolStripMenuItem_Click);
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Crear Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Frba Commerce";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearVisibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVisibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVisibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificiarRubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRubroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPublicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificarToolStripMenuItem;
        private FrbaCommerce.GD1C2014DataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
    }
}

