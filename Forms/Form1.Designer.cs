namespace ControleFinanceiro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            button5 = new Button();
            btnCategorias = new Button();
            btnTransações = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            panel7 = new Panel();
            lblWarning = new Label();
            dataGridView1 = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            label8 = new Label();
            pnlReceitas = new Panel();
            lblReceita = new Label();
            label7 = new Label();
            pnlDespesas = new Panel();
            lblDespesa = new Label();
            label5 = new Label();
            panel4 = new Panel();
            lblsaldo = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlReceitas.SuspendLayout();
            pnlDespesas.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 37);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnCategorias);
            panel2.Controls.Add(btnTransações);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 484);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 202, 230);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(2, 48, 71);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 153);
            button5.Name = "button5";
            button5.Size = new Size(194, 51);
            button5.TabIndex = 4;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.Transparent;
            btnCategorias.Dock = DockStyle.Top;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 202, 230);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = Color.FromArgb(2, 48, 71);
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(0, 102);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(194, 51);
            btnCategorias.TabIndex = 3;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += button4_Click_1;
            // 
            // btnTransações
            // 
            btnTransações.Dock = DockStyle.Top;
            btnTransações.FlatAppearance.BorderSize = 0;
            btnTransações.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 202, 230);
            btnTransações.FlatStyle = FlatStyle.Flat;
            btnTransações.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransações.ForeColor = Color.FromArgb(2, 48, 71);
            btnTransações.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransações.Location = new Point(0, 51);
            btnTransações.Name = "btnTransações";
            btnTransações.Size = new Size(194, 51);
            btnTransações.TabIndex = 1;
            btnTransações.Text = "Transações";
            btnTransações.UseVisualStyleBackColor = true;
            btnTransações.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 202, 230);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(2, 48, 71);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(194, 51);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(pnlReceitas);
            panel3.Controls.Add(pnlDespesas);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(194, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(790, 484);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblWarning);
            panel7.Controls.Add(dataGridView1);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(83, 166);
            panel7.Name = "panel7";
            panel7.Size = new Size(563, 194);
            panel7.TabIndex = 7;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.FromArgb(0, 0, 64);
            lblWarning.Location = new Point(160, 68);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(209, 21);
            lblWarning.TabIndex = 8;
            lblWarning.Text = "Você não possui transações...";
            lblWarning.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Valor, Tipo, Categoria, Data, Descricao, id });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(0, 41);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(563, 153);
            dataGridView1.TabIndex = 7;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "valor";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Valor.DefaultCellStyle = dataGridViewCellStyle2;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Data
            // 
            Data.DataPropertyName = "data";
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(10);
            label8.Size = new Size(177, 41);
            label8.TabIndex = 6;
            label8.Text = "Últimas 5 transações:";
            // 
            // pnlReceitas
            // 
            pnlReceitas.BackColor = Color.White;
            pnlReceitas.Controls.Add(lblReceita);
            pnlReceitas.Controls.Add(label7);
            pnlReceitas.Location = new Point(277, 69);
            pnlReceitas.Name = "pnlReceitas";
            pnlReceitas.Size = new Size(162, 66);
            pnlReceitas.TabIndex = 5;
            // 
            // lblReceita
            // 
            lblReceita.Dock = DockStyle.Fill;
            lblReceita.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceita.ForeColor = Color.Green;
            lblReceita.Location = new Point(0, 34);
            lblReceita.Name = "lblReceita";
            lblReceita.Size = new Size(162, 32);
            lblReceita.TabIndex = 2;
            lblReceita.Text = "+ R$100.000.000,00";
            lblReceita.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(10);
            label7.Size = new Size(162, 34);
            label7.TabIndex = 1;
            label7.Text = "Receitas";
            // 
            // pnlDespesas
            // 
            pnlDespesas.BackColor = Color.White;
            pnlDespesas.Controls.Add(lblDespesa);
            pnlDespesas.Controls.Add(label5);
            pnlDespesas.Location = new Point(484, 69);
            pnlDespesas.Name = "pnlDespesas";
            pnlDespesas.Size = new Size(162, 66);
            pnlDespesas.TabIndex = 4;
            // 
            // lblDespesa
            // 
            lblDespesa.Dock = DockStyle.Fill;
            lblDespesa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDespesa.ForeColor = Color.Red;
            lblDespesa.Location = new Point(0, 34);
            lblDespesa.Name = "lblDespesa";
            lblDespesa.Size = new Size(162, 32);
            lblDespesa.TabIndex = 2;
            lblDespesa.Text = "- R$100.000.000,00";
            lblDespesa.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(162, 34);
            label5.TabIndex = 1;
            label5.Text = "Despesas";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblsaldo);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(83, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 66);
            panel4.TabIndex = 3;
            // 
            // lblsaldo
            // 
            lblsaldo.BackColor = Color.White;
            lblsaldo.Dock = DockStyle.Fill;
            lblsaldo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsaldo.ForeColor = Color.FromArgb(0, 0, 64);
            lblsaldo.Location = new Point(0, 34);
            lblsaldo.Name = "lblsaldo";
            lblsaldo.Size = new Size(162, 32);
            lblsaldo.TabIndex = 2;
            lblsaldo.Text = "R$100.000.000,00";
            lblsaldo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(162, 34);
            label2.TabIndex = 1;
            label2.Text = "Saldo Atual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(177, 57);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 521);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle Financeiro";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlReceitas.ResumeLayout(false);
            pnlDespesas.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCategorias;
        private Button btnTransações;
        private Button btnDashboard;
        private Button button5;
        private Panel panel3;
        private Label label1;
        private Panel pnlReceitas;
        private Label lblReceita;
        private Label label7;
        private Panel pnlDespesas;
        private Label lblDespesa;
        private Label label5;
        private Panel panel4;
        private Label lblsaldo;
        private Label label2;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Label label8;
        private Label lblWarning;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn id;
    }
}
