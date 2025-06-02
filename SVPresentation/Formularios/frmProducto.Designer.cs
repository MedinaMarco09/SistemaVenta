namespace SVPresentation.Formularios
{
    partial class frmProducto
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
            label1 = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbCategoriaNuevo = new ComboBox();
            label3 = new Label();
            tabEditar = new TabPage();
            label14 = new Label();
            cbbHabilitado = new ComboBox();
            label4 = new Label();
            txbCantidadEditar = new NumericUpDown();
            label5 = new Label();
            txbPrecioVentaEditar = new TextBox();
            label10 = new Label();
            txbPrecioCompraEditar = new TextBox();
            label11 = new Label();
            txbDescripcionEditar = new TextBox();
            cbbCategoriaEditar = new ComboBox();
            label12 = new Label();
            txbCodigoEditar = new TextBox();
            label13 = new Label();
            txbCodigoNuevo = new TextBox();
            tabNuevo = new TabPage();
            label9 = new Label();
            txbCantidadNuevo = new NumericUpDown();
            label8 = new Label();
            txbPrecioVentaNuevo = new TextBox();
            label7 = new Label();
            txbPrecioCompraNuevo = new TextBox();
            label6 = new Label();
            txbDescripcionNuevo = new TextBox();
            label2 = new Label();
            btnBuscarLista = new Button();
            txtBuscarLista = new TextBox();
            dgvProductos = new DataGridView();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 2;
            label1.Text = "Inventario / Producto";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.BackColor = Color.White;
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(914, 450);
            btnGuardarEditar.Margin = new Padding(4, 5, 4, 5);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(107, 38);
            btnGuardarEditar.TabIndex = 14;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = false;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.BackColor = Color.White;
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(23, 450);
            btnVolverEditar.Margin = new Padding(4, 5, 4, 5);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(107, 38);
            btnVolverEditar.TabIndex = 15;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = false;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.BackColor = Color.White;
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(914, 450);
            btnGuardarNuevo.Margin = new Padding(4, 5, 4, 5);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(107, 38);
            btnGuardarNuevo.TabIndex = 12;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = false;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.BackColor = Color.White;
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(23, 450);
            btnVolverNuevo.Margin = new Padding(4, 5, 4, 5);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(107, 38);
            btnVolverNuevo.TabIndex = 13;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = false;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbCategoriaNuevo
            // 
            cbbCategoriaNuevo.BackColor = SystemColors.Window;
            cbbCategoriaNuevo.Cursor = Cursors.Hand;
            cbbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaNuevo.FormattingEnabled = true;
            cbbCategoriaNuevo.Location = new Point(23, 62);
            cbbCategoriaNuevo.Margin = new Padding(4, 5, 4, 5);
            cbbCategoriaNuevo.Name = "cbbCategoriaNuevo";
            cbbCategoriaNuevo.Size = new Size(488, 33);
            cbbCategoriaNuevo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 0;
            label3.Text = "Categoria:";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(label14);
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbCantidadEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(txbPrecioVentaEditar);
            tabEditar.Controls.Add(label10);
            tabEditar.Controls.Add(txbPrecioCompraEditar);
            tabEditar.Controls.Add(label11);
            tabEditar.Controls.Add(txbDescripcionEditar);
            tabEditar.Controls.Add(cbbCategoriaEditar);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(txbCodigoEditar);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Margin = new Padding(4, 5, 4, 5);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(4, 5, 4, 5);
            tabEditar.Size = new Size(1049, 539);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(619, 112);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(94, 25);
            label14.TabIndex = 12;
            label14.Text = "Habilitado";
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.BackColor = SystemColors.Window;
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(619, 142);
            cbbHabilitado.Margin = new Padding(4, 5, 4, 5);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(401, 33);
            cbbHabilitado.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 10;
            label4.Text = "Cantidad:";
            // 
            // txbCantidadEditar
            // 
            txbCantidadEditar.Location = new Point(619, 62);
            txbCantidadEditar.Margin = new Padding(4, 5, 4, 5);
            txbCantidadEditar.Name = "txbCantidadEditar";
            txbCantidadEditar.Size = new Size(403, 31);
            txbCantidadEditar.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 347);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 8;
            label5.Text = "Precio Venta:";
            // 
            // txbPrecioVentaEditar
            // 
            txbPrecioVentaEditar.Location = new Point(23, 377);
            txbPrecioVentaEditar.Margin = new Padding(4, 5, 4, 5);
            txbPrecioVentaEditar.Name = "txbPrecioVentaEditar";
            txbPrecioVentaEditar.Size = new Size(488, 31);
            txbPrecioVentaEditar.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 268);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 6;
            label10.Text = "Precio Compra:";
            // 
            // txbPrecioCompraEditar
            // 
            txbPrecioCompraEditar.Location = new Point(23, 298);
            txbPrecioCompraEditar.Margin = new Padding(4, 5, 4, 5);
            txbPrecioCompraEditar.Name = "txbPrecioCompraEditar";
            txbPrecioCompraEditar.Size = new Size(488, 31);
            txbPrecioCompraEditar.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 190);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(108, 25);
            label11.TabIndex = 4;
            label11.Text = "Descripción:";
            // 
            // txbDescripcionEditar
            // 
            txbDescripcionEditar.Location = new Point(23, 220);
            txbDescripcionEditar.Margin = new Padding(4, 5, 4, 5);
            txbDescripcionEditar.Name = "txbDescripcionEditar";
            txbDescripcionEditar.Size = new Size(488, 31);
            txbDescripcionEditar.TabIndex = 5;
            // 
            // cbbCategoriaEditar
            // 
            cbbCategoriaEditar.BackColor = SystemColors.Window;
            cbbCategoriaEditar.Cursor = Cursors.Hand;
            cbbCategoriaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaEditar.FormattingEnabled = true;
            cbbCategoriaEditar.Location = new Point(23, 62);
            cbbCategoriaEditar.Margin = new Padding(4, 5, 4, 5);
            cbbCategoriaEditar.Name = "cbbCategoriaEditar";
            cbbCategoriaEditar.Size = new Size(488, 33);
            cbbCategoriaEditar.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 32);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(92, 25);
            label12.TabIndex = 0;
            label12.Text = "Categoria:";
            // 
            // txbCodigoEditar
            // 
            txbCodigoEditar.Location = new Point(23, 142);
            txbCodigoEditar.Margin = new Padding(4, 5, 4, 5);
            txbCodigoEditar.Name = "txbCodigoEditar";
            txbCodigoEditar.Size = new Size(488, 31);
            txbCodigoEditar.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 112);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 25);
            label13.TabIndex = 2;
            label13.Text = "Código:";
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(23, 142);
            txbCodigoNuevo.Margin = new Padding(4, 5, 4, 5);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(488, 31);
            txbCodigoNuevo.TabIndex = 3;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txbCantidadNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbPrecioVentaNuevo);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(txbPrecioCompraNuevo);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(txbDescripcionNuevo);
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbCategoriaNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Margin = new Padding(4, 5, 4, 5);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(4, 5, 4, 5);
            tabNuevo.Size = new Size(1049, 539);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(619, 32);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 10;
            label9.Text = "Cantidad:";
            // 
            // txbCantidadNuevo
            // 
            txbCantidadNuevo.Location = new Point(619, 62);
            txbCantidadNuevo.Margin = new Padding(4, 5, 4, 5);
            txbCantidadNuevo.Name = "txbCantidadNuevo";
            txbCantidadNuevo.Size = new Size(403, 31);
            txbCantidadNuevo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 347);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 8;
            label8.Text = "Precio Venta:";
            // 
            // txbPrecioVentaNuevo
            // 
            txbPrecioVentaNuevo.Location = new Point(23, 377);
            txbPrecioVentaNuevo.Margin = new Padding(4, 5, 4, 5);
            txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
            txbPrecioVentaNuevo.Size = new Size(488, 31);
            txbPrecioVentaNuevo.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 268);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 6;
            label7.Text = "Precio Compra:";
            // 
            // txbPrecioCompraNuevo
            // 
            txbPrecioCompraNuevo.Location = new Point(23, 298);
            txbPrecioCompraNuevo.Margin = new Padding(4, 5, 4, 5);
            txbPrecioCompraNuevo.Name = "txbPrecioCompraNuevo";
            txbPrecioCompraNuevo.Size = new Size(488, 31);
            txbPrecioCompraNuevo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 190);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 4;
            label6.Text = "Descripción:";
            // 
            // txbDescripcionNuevo
            // 
            txbDescripcionNuevo.Location = new Point(23, 220);
            txbDescripcionNuevo.Margin = new Padding(4, 5, 4, 5);
            txbDescripcionNuevo.Name = "txbDescripcionNuevo";
            txbDescripcionNuevo.Size = new Size(488, 31);
            txbDescripcionNuevo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "Código:";
            // 
            // btnBuscarLista
            // 
            btnBuscarLista.BackColor = Color.White;
            btnBuscarLista.Cursor = Cursors.Hand;
            btnBuscarLista.FlatStyle = FlatStyle.Flat;
            btnBuscarLista.Location = new Point(913, 25);
            btnBuscarLista.Margin = new Padding(4, 5, 4, 5);
            btnBuscarLista.Name = "btnBuscarLista";
            btnBuscarLista.Size = new Size(107, 38);
            btnBuscarLista.TabIndex = 3;
            btnBuscarLista.Text = "Buscar";
            btnBuscarLista.UseVisualStyleBackColor = false;
            btnBuscarLista.Click += btnBuscarLista_Click;
            // 
            // txtBuscarLista
            // 
            txtBuscarLista.Location = new Point(634, 25);
            txtBuscarLista.Margin = new Padding(4, 5, 4, 5);
            txtBuscarLista.Name = "txtBuscarLista";
            txtBuscarLista.Size = new Size(268, 31);
            txtBuscarLista.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 73);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(997, 437);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.BackColor = Color.White;
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(23, 25);
            btnNuevoLista.Margin = new Padding(4, 5, 4, 5);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(107, 38);
            btnNuevoLista.TabIndex = 1;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = false;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnBuscarLista);
            tabLista.Controls.Add(txtBuscarLista);
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Margin = new Padding(4, 5, 4, 5);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(4, 5, 4, 5);
            tabLista.Size = new Size(1049, 539);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(17, 93);
            tabControlMain.Margin = new Padding(4, 5, 4, 5);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1057, 567);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 3;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 678);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducto";
            Load += frmProducto_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private ComboBox cbbCategoriaNuevo;
        private Label label3;
        private TabPage tabEditar;
        private TextBox txbCodigoNuevo;
        private TabPage tabNuevo;
        private Label label6;
        private TextBox txbDescripcionNuevo;
        private Label label2;
        private Button btnBuscarLista;
        private TextBox txtBuscarLista;
        private DataGridView dgvProductos;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
        private Label label8;
        private TextBox txbPrecioVentaNuevo;
        private Label label7;
        private TextBox txbPrecioCompraNuevo;
        private Label label9;
        private NumericUpDown txbCantidadNuevo;
        private ComboBox cbbHabilitado;
        //private Label label14;
        private Label label4;
        private NumericUpDown txbCantidadEditar;
        private Label label5;
        private TextBox txbPrecioVentaEditar;
        private Label label10;
        private TextBox txbPrecioCompraEditar;
        private Label label11;
        private TextBox txbDescripcionEditar;
        private ComboBox cbbCategoriaEditar;
        private Label label12;
        private TextBox txbCodigoEditar;
        private Label label13;
        private Label label14;
    }
}