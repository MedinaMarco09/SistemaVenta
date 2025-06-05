namespace SVPresentation.Formularios
{
    partial class frmUsuario
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
            btnHabilitado = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            cbbHabilitado = new ComboBox();
            tabEditar = new TabPage();
            txbCorreoEditar = new TextBox();
            label4 = new Label();
            txbNombreUsuarioEditar = new TextBox();
            label5 = new Label();
            cbbRolEditar = new ComboBox();
            label8 = new Label();
            txbNombreCompletoEditar = new TextBox();
            label9 = new Label();
            btnBuscar = new Button();
            txbBuscar = new TextBox();
            dgvUsuarios = new DataGridView();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            tabNuevo = new TabPage();
            txbCorreoNuevo = new TextBox();
            label6 = new Label();
            txbNombreUsuarioNuevo = new TextBox();
            label7 = new Label();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbRolNuevo = new ComboBox();
            label3 = new Label();
            txbNombreCompletoNuevo = new TextBox();
            label2 = new Label();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabNuevo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 2;
            label1.Text = "Inventario / Usuario";
            // 
            // btnHabilitado
            // 
            btnHabilitado.AutoSize = true;
            btnHabilitado.Location = new Point(21, 358);
            btnHabilitado.Margin = new Padding(4, 0, 4, 0);
            btnHabilitado.Name = "btnHabilitado";
            btnHabilitado.Size = new Size(94, 25);
            btnHabilitado.TabIndex = 5;
            btnHabilitado.Text = "Habilitado";
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
            btnGuardarEditar.TabIndex = 7;
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
            btnVolverEditar.TabIndex = 7;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = false;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.BackColor = SystemColors.Window;
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(17, 383);
            cbbHabilitado.Margin = new Padding(4, 5, 4, 5);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(1014, 33);
            cbbHabilitado.TabIndex = 6;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(txbCorreoEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbNombreUsuarioEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(cbbRolEditar);
            tabEditar.Controls.Add(label8);
            tabEditar.Controls.Add(txbNombreCompletoEditar);
            tabEditar.Controls.Add(label9);
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(btnHabilitado);
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
            // txbCorreoEditar
            // 
            txbCorreoEditar.Location = new Point(17, 217);
            txbCorreoEditar.Margin = new Padding(4, 5, 4, 5);
            txbCorreoEditar.Name = "txbCorreoEditar";
            txbCorreoEditar.Size = new Size(1014, 31);
            txbCorreoEditar.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 192);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 16;
            label4.Text = "Correo:";
            // 
            // txbNombreUsuarioEditar
            // 
            txbNombreUsuarioEditar.Location = new Point(17, 300);
            txbNombreUsuarioEditar.Margin = new Padding(4, 5, 4, 5);
            txbNombreUsuarioEditar.Name = "txbNombreUsuarioEditar";
            txbNombreUsuarioEditar.Size = new Size(1014, 31);
            txbNombreUsuarioEditar.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 275);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 14;
            label5.Text = "Nombre usuario:";
            // 
            // cbbRolEditar
            // 
            cbbRolEditar.BackColor = SystemColors.Window;
            cbbRolEditar.Cursor = Cursors.Hand;
            cbbRolEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRolEditar.FormattingEnabled = true;
            cbbRolEditar.Location = new Point(17, 50);
            cbbRolEditar.Margin = new Padding(4, 5, 4, 5);
            cbbRolEditar.Name = "cbbRolEditar";
            cbbRolEditar.Size = new Size(1014, 33);
            cbbRolEditar.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 25);
            label8.TabIndex = 12;
            label8.Text = "Rol:";
            // 
            // txbNombreCompletoEditar
            // 
            txbNombreCompletoEditar.Location = new Point(17, 133);
            txbNombreCompletoEditar.Margin = new Padding(4, 5, 4, 5);
            txbNombreCompletoEditar.Name = "txbNombreCompletoEditar";
            txbNombreCompletoEditar.Size = new Size(1014, 31);
            txbNombreCompletoEditar.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 108);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 10;
            label9.Text = "Nombre Completo:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(913, 25);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 38);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(634, 25);
            txbBuscar.Margin = new Padding(4, 5, 4, 5);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(268, 31);
            txbBuscar.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(23, 73);
            dgvUsuarios.Margin = new Padding(4, 5, 4, 5);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(997, 437);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
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
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(dgvUsuarios);
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
            tabControlMain.Location = new Point(17, 95);
            tabControlMain.Margin = new Padding(4, 5, 4, 5);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1057, 567);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 3;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbCorreoNuevo);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(txbNombreUsuarioNuevo);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbRolNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbNombreCompletoNuevo);
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
            // txbCorreoNuevo
            // 
            txbCorreoNuevo.Location = new Point(17, 217);
            txbCorreoNuevo.Margin = new Padding(4, 5, 4, 5);
            txbCorreoNuevo.Name = "txbCorreoNuevo";
            txbCorreoNuevo.Size = new Size(1014, 31);
            txbCorreoNuevo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 192);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 8;
            label6.Text = "Correo:";
            // 
            // txbNombreUsuarioNuevo
            // 
            txbNombreUsuarioNuevo.Location = new Point(17, 300);
            txbNombreUsuarioNuevo.Margin = new Padding(4, 5, 4, 5);
            txbNombreUsuarioNuevo.Name = "txbNombreUsuarioNuevo";
            txbNombreUsuarioNuevo.Size = new Size(1014, 31);
            txbNombreUsuarioNuevo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 275);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 25);
            label7.TabIndex = 6;
            label7.Text = "Nombre usuario:";
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
            btnGuardarNuevo.TabIndex = 4;
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
            btnVolverNuevo.TabIndex = 5;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = false;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbRolNuevo
            // 
            cbbRolNuevo.BackColor = SystemColors.Window;
            cbbRolNuevo.Cursor = Cursors.Hand;
            cbbRolNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRolNuevo.FormattingEnabled = true;
            cbbRolNuevo.Location = new Point(17, 50);
            cbbRolNuevo.Margin = new Padding(4, 5, 4, 5);
            cbbRolNuevo.Name = "cbbRolNuevo";
            cbbRolNuevo.Size = new Size(1014, 33);
            cbbRolNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 2;
            label3.Text = "Rol:";
            // 
            // txbNombreCompletoNuevo
            // 
            txbNombreCompletoNuevo.Location = new Point(17, 133);
            txbNombreCompletoNuevo.Margin = new Padding(4, 5, 4, 5);
            txbNombreCompletoNuevo.Name = "txbNombreCompletoNuevo";
            txbNombreCompletoNuevo.Size = new Size(1014, 31);
            txbNombreCompletoNuevo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo:";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 678);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label btnHabilitado;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private ComboBox cbbHabilitado;
        private TabPage tabEditar;
        private Button btnBuscar;
        private TextBox txbBuscar;
        private DataGridView dgvUsuarios;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
        private TabPage tabNuevo;
        private TextBox txbCorreoNuevo;
        private Label label6;
        private TextBox txbNombreUsuarioNuevo;
        private Label label7;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private ComboBox cbbRolNuevo;
        private Label label3;
        private TextBox txbNombreCompletoNuevo;
        private Label label2;
        private TextBox txbCorreoEditar;
        private Label label4;
        private TextBox txbNombreUsuarioEditar;
        private Label label5;
        private ComboBox cbbRolEditar;
        private Label label8;
        private TextBox txbNombreCompletoEditar;
        private Label label9;
    }
}