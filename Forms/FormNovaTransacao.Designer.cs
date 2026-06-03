namespace ControleFinanceiro.Forms
{
    partial class FormNovaTransacao
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
            button1 = new Button();
            cboxTipo = new ComboBox();
            cboxCategoria = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mtbData = new MaskedTextBox();
            label5 = new Label();
            txtDescricao = new TextBox();
            button2 = new Button();
            txtValor = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(340, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 1;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cboxTipo
            // 
            cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTipo.FormattingEnabled = true;
            cboxTipo.Items.AddRange(new object[] { "Receita", "Despesa" });
            cboxTipo.Location = new Point(114, 24);
            cboxTipo.Name = "cboxTipo";
            cboxTipo.Size = new Size(121, 23);
            cboxTipo.TabIndex = 3;
            // 
            // cboxCategoria
            // 
            cboxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Items.AddRange(new object[] { "Receita", "DEsoeras" });
            cboxCategoria.Location = new Point(114, 69);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(121, 23);
            cboxCategoria.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 6;
            label3.Text = "Valor: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 154);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 8;
            label4.Text = "Data: ";
            // 
            // mtbData
            // 
            mtbData.BorderStyle = BorderStyle.None;
            mtbData.Location = new Point(114, 159);
            mtbData.Mask = "00/00/0000";
            mtbData.Name = "mtbData";
            mtbData.Size = new Size(61, 16);
            mtbData.TabIndex = 9;
            mtbData.TextAlign = HorizontalAlignment.Center;
            mtbData.ValidatingType = typeof(DateTime);
            mtbData.Click += mtbData_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 192);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 10;
            label5.Text = "Descrição (opcional):";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(193, 194);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(286, 19);
            txtDescricao.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(421, 240);
            button2.Name = "button2";
            button2.Size = new Size(91, 32);
            button2.TabIndex = 12;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(112, 116);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 13;
            txtValor.Enter += txtValor_Enter;
            txtValor.KeyPress += textBox2_KeyPress;
            txtValor.Leave += textBox2_Leave;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(193, 154);
            button3.Name = "button3";
            button3.Size = new Size(75, 24);
            button3.TabIndex = 14;
            button3.Text = "Hoje";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormNovaTransacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 276);
            Controls.Add(button3);
            Controls.Add(txtValor);
            Controls.Add(button2);
            Controls.Add(txtDescricao);
            Controls.Add(label5);
            Controls.Add(mtbData);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboxCategoria);
            Controls.Add(label2);
            Controls.Add(cboxTipo);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormNovaTransacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Transação";
            Load += FormNovaTransacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox cboxTipo;
        private ComboBox cboxCategoria;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtbData;
        private Label label5;
        private TextBox txtDescricao;
        private Button button2;
        private TextBox txtValor;
        private Button button3;
    }
}