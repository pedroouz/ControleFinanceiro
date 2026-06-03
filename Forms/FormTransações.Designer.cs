namespace ControleFinanceiro
{
    partial class FormTransações
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(790, 60);
            label1.TabIndex = 0;
            label1.Text = "Transações";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(211, 63);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 1;
            button1.Text = "Nova Transação";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(362, 63);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 3;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Valor, Tipo, Column3, Column4, Column5, id });
            dataGridView1.Location = new Point(87, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(616, 351);
            dataGridView1.TabIndex = 4;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "valor";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Valor.DefaultCellStyle = dataGridViewCellStyle2;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "tipo";
            Tipo.FillWeight = 70F;
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "categoria";
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "data";
            Column4.FillWeight = 80F;
            Column4.HeaderText = "Data";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.DataPropertyName = "descricao";
            Column5.HeaderText = "Descrição";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(475, 63);
            button3.Name = "button3";
            button3.Size = new Size(88, 29);
            button3.TabIndex = 5;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormTransações
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 484);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransações";
            Text = "FormTransações";
            Load += FormTransações_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn id;
    }
}