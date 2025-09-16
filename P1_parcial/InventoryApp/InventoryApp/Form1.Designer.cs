namespace InventoryApp
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            TxtNome = new TextBox();
            TxtPreco = new TextBox();
            TxtDescricao = new TextBox();
            label3 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(321, 25);
            button1.Name = "button1";
            button1.Size = new Size(66, 69);
            button1.TabIndex = 0;
            button1.Text = "REMOVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(321, 127);
            button2.Name = "button2";
            button2.Size = new Size(66, 69);
            button2.TabIndex = 1;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 134);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(43, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(43, 71);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 4;
            label2.Text = "Preço";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(88, 25);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(88, 25);
            TxtNome.TabIndex = 5;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // TxtPreco
            // 
            TxtPreco.Location = new Point(88, 71);
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(88, 25);
            TxtPreco.TabIndex = 6;
            TxtPreco.TextChanged += TxtPreco_TextChanged;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(95, 115);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(88, 25);
            TxtDescricao.TabIndex = 7;
            TxtDescricao.TextChanged += TxtDescricao_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 8;
            label3.Text = "Descrição";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(410, 403);
            Controls.Add(label3);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtPreco);
            Controls.Add(TxtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox TxtNome;
        private TextBox TxtPreco;
        private TextBox TxtDescricao;
        private Label label3;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
