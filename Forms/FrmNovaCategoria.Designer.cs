namespace ControleFinanceiro.Forms
{
    partial class FrmNovaCategoria
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
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(110, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(171, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(81, 93);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 10;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 93);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmNovaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 156);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmNovaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Categoria";
            Load += FrmNovaCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
    }
}