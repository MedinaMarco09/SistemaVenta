

namespace SVPresentation.Formularios
{
    partial class frmCategoria
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
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            btnBuscarLista = new Button();
            txtBuscarLista = new TextBox();
            dgvCategorias = new DataGridView();
            btnNuevoLista = new Button();
            tabNuevo = new TabPage();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbMedidaNuevo = new ComboBox();
            label3 = new Label();
            txbNombreNuevo = new TextBox();
            label2 = new Label();
            tabEditar = new TabPage();
            cbbHabilitado = new ComboBox();
            btnHabilitado = new Label();
            txbNombreEditar = new TextBox();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            cbbMedidaEditar = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(14, 73);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(846, 453);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 1;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnBuscarLista);
            tabLista.Controls.Add(txtBuscarLista);
            tabLista.Controls.Add(dgvCategorias);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Margin = new Padding(3, 4, 3, 4);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3, 4, 3, 4);
            tabLista.Size = new Size(838, 425);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLista
            // 
            btnBuscarLista.Cursor = Cursors.Hand;
            btnBuscarLista.FlatStyle = FlatStyle.Flat;
            btnBuscarLista.Location = new Point(730, 20);
            btnBuscarLista.Margin = new Padding(3, 4, 3, 4);
            btnBuscarLista.Name = "btnBuscarLista";
            btnBuscarLista.Size = new Size(86, 31);
            btnBuscarLista.TabIndex = 3;
            btnBuscarLista.Text = "Buscar";
            btnBuscarLista.UseVisualStyleBackColor = true;
            btnBuscarLista.Click += btnBuscarLista_Click;
            // 
            // txtBuscarLista
            // 
            txtBuscarLista.Location = new Point(507, 20);
            txtBuscarLista.Margin = new Padding(3, 4, 3, 4);
            txtBuscarLista.Name = "txtBuscarLista";
            txtBuscarLista.Size = new Size(215, 27);
            txtBuscarLista.TabIndex = 2;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(18, 59);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(798, 349);
            dgvCategorias.TabIndex = 4;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(18, 20);
            btnNuevoLista.Margin = new Padding(3, 4, 3, 4);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(86, 31);
            btnNuevoLista.TabIndex = 1;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbMedidaNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbNombreNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Margin = new Padding(3, 4, 3, 4);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3, 4, 3, 4);
            tabNuevo.Size = new Size(838, 425);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(731, 360);
            btnGuardarNuevo.Margin = new Padding(3, 4, 3, 4);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(86, 31);
            btnGuardarNuevo.TabIndex = 4;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(18, 360);
            btnVolverNuevo.Margin = new Padding(3, 4, 3, 4);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(86, 31);
            btnVolverNuevo.TabIndex = 5;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbMedidaNuevo
            // 
            cbbMedidaNuevo.BackColor = SystemColors.Window;
            cbbMedidaNuevo.Cursor = Cursors.Hand;
            cbbMedidaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaNuevo.FormattingEnabled = true;
            cbbMedidaNuevo.Location = new Point(18, 125);
            cbbMedidaNuevo.Margin = new Padding(3, 4, 3, 4);
            cbbMedidaNuevo.Name = "cbbMedidaNuevo";
            cbbMedidaNuevo.Size = new Size(812, 28);
            cbbMedidaNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Medida";
            // 
            // txbNombreNuevo
            // 
            txbNombreNuevo.Location = new Point(18, 44);
            txbNombreNuevo.Margin = new Padding(3, 4, 3, 4);
            txbNombreNuevo.Name = "txbNombreNuevo";
            txbNombreNuevo.Size = new Size(812, 27);
            txbNombreNuevo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 20);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(btnHabilitado);
            tabEditar.Controls.Add(txbNombreEditar);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(cbbMedidaEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(label5);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Margin = new Padding(3, 4, 3, 4);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3, 4, 3, 4);
            tabEditar.Size = new Size(838, 425);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.BackColor = SystemColors.Window;
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(18, 205);
            cbbHabilitado.Margin = new Padding(3, 4, 3, 4);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(812, 28);
            cbbHabilitado.TabIndex = 6;
            // 
            // btnHabilitado
            // 
            btnHabilitado.AutoSize = true;
            btnHabilitado.Location = new Point(18, 181);
            btnHabilitado.Name = "btnHabilitado";
            btnHabilitado.Size = new Size(80, 20);
            btnHabilitado.TabIndex = 5;
            btnHabilitado.Text = "Habilitado";
            // 
            // txbNombreEditar
            // 
            txbNombreEditar.Location = new Point(18, 44);
            txbNombreEditar.Margin = new Padding(3, 4, 3, 4);
            txbNombreEditar.Name = "txbNombreEditar";
            txbNombreEditar.Size = new Size(812, 27);
            txbNombreEditar.TabIndex = 2;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(731, 360);
            btnGuardarEditar.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(86, 31);
            btnGuardarEditar.TabIndex = 7;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(18, 360);
            btnVolverEditar.Margin = new Padding(3, 4, 3, 4);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(86, 31);
            btnVolverEditar.TabIndex = 7;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // cbbMedidaEditar
            // 
            cbbMedidaEditar.BackColor = SystemColors.Window;
            cbbMedidaEditar.Cursor = Cursors.Hand;
            cbbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaEditar.FormattingEnabled = true;
            cbbMedidaEditar.Location = new Point(18, 125);
            cbbMedidaEditar.Margin = new Padding(3, 4, 3, 4);
            cbbMedidaEditar.Name = "cbbMedidaEditar";
            cbbMedidaEditar.Size = new Size(812, 28);
            cbbMedidaEditar.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 101);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Medida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 20);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 0;
            label1.Text = "Inventario / Categoria";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 543);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private Label label1;
        private TabPage tabEditar;
        private TextBox txtBuscarLista;
        private Button btnNuevoLista;
        //private DataGridView dataGridView1;
        //private TextBox txtBuscarLista;
        private DataGridView dgvCategorias;
        private Button btnBuscarLista;
        private ComboBox cbbMedidaNuevo;
        private Label label3;
        private TextBox txbNombreNuevo;
        private Label label2;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private ComboBox cbbMedidaEditar;
        private Label label4;
        private Label label5;
        private TextBox txbNombreEditar;
        private ComboBox cbbHabilitado;
        private Label btnHabilitado;
    }
}