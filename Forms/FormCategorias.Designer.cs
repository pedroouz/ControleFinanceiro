namespace ControleFinanceiro
{
    partial class FormCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
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
            label1.Size = new Size(800, 65);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(196, 52);
            button1.Name = "button1";
            button1.Size = new Size(136, 30);
            button1.TabIndex = 1;
            button1.Text = "Nova Categoria";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(78, 129);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(655, 309);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "Nome";
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(348, 52);
            button2.Name = "button2";
            button2.Size = new Size(103, 30);
            button2.TabIndex = 3;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(253, 95);
            label2.Name = "label2";
            label2.Size = new Size(297, 21);
            label2.TabIndex = 4;
            label2.Text = "Voce ainda não criou nenhuma categoria!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(466, 52);
            button3.Name = "button3";
            button3.Size = new Size(103, 30);
            button3.TabIndex = 5;
            button3.Text = "Apagar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(253, 95);
            label3.Name = "label3";
            label3.Size = new Size(289, 21);
            label3.TabIndex = 6;
            label3.Text = "Selecione a categoria que deseja apagar:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCategorias";
            Text = "FormCategorias";
            Load += FormCategorias_Load;
            Shown += FormCategorias_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
    }
}