namespace BaslıkOlusturupEklemek
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
            dataGridView1 = new DataGridView();
            Baslık = new DataGridViewTextBoxColumn();
            Konu = new DataGridViewTextBoxColumn();
            İçerik = new DataGridViewTextBoxColumn();
            BaslıkTextBox = new TextBox();
            LblBaslık = new Label();
            KonuTextBox = new TextBox();
            LblKonu = new Label();
            label3 = new Label();
            icerikRichTextBox1 = new RichTextBox();
            VeriEkleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Baslık, Konu, İçerik });
            dataGridView1.Location = new Point(-3, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(802, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Baslık
            // 
            Baslık.HeaderText = "Baslık";
            Baslık.Name = "Baslık";
            Baslık.Width = 130;
            // 
            // Konu
            // 
            Konu.HeaderText = "Konu";
            Konu.Name = "Konu";
            Konu.Width = 130;
            // 
            // İçerik
            // 
            İçerik.HeaderText = "İçerik";
            İçerik.Name = "İçerik";
            İçerik.Width = 500;
            // 
            // BaslıkTextBox
            // 
            BaslıkTextBox.Location = new Point(-3, 187);
            BaslıkTextBox.Name = "BaslıkTextBox";
            BaslıkTextBox.Size = new Size(802, 23);
            BaslıkTextBox.TabIndex = 1;
            // 
            // LblBaslık
            // 
            LblBaslık.AutoSize = true;
            LblBaslık.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblBaslık.Location = new Point(-3, 169);
            LblBaslık.Name = "LblBaslık";
            LblBaslık.Size = new Size(44, 17);
            LblBaslık.TabIndex = 2;
            LblBaslık.Text = "Baslık";
            // 
            // KonuTextBox
            // 
            KonuTextBox.Location = new Point(-3, 262);
            KonuTextBox.Name = "KonuTextBox";
            KonuTextBox.Size = new Size(802, 23);
            KonuTextBox.TabIndex = 1;
            // 
            // LblKonu
            // 
            LblKonu.AutoSize = true;
            LblKonu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblKonu.Location = new Point(-3, 244);
            LblKonu.Name = "LblKonu";
            LblKonu.Size = new Size(40, 17);
            LblKonu.TabIndex = 2;
            LblKonu.Text = "Konu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(-3, 327);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 2;
            label3.Text = "İcerik";
            // 
            // icerikRichTextBox1
            // 
            icerikRichTextBox1.BorderStyle = BorderStyle.FixedSingle;
            icerikRichTextBox1.Location = new Point(-3, 342);
            icerikRichTextBox1.Name = "icerikRichTextBox1";
            icerikRichTextBox1.Size = new Size(802, 96);
            icerikRichTextBox1.TabIndex = 3;
            icerikRichTextBox1.Text = "";
            // 
            // VeriEkleButton
            // 
            VeriEkleButton.Location = new Point(-3, 441);
            VeriEkleButton.Name = "VeriEkleButton";
            VeriEkleButton.Size = new Size(802, 34);
            VeriEkleButton.TabIndex = 4;
            VeriEkleButton.Text = "Veriyi Ekle";
            VeriEkleButton.UseVisualStyleBackColor = true;
            VeriEkleButton.Click += VeriEkleButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(VeriEkleButton);
            Controls.Add(icerikRichTextBox1);
            Controls.Add(label3);
            Controls.Add(LblKonu);
            Controls.Add(LblBaslık);
            Controls.Add(KonuTextBox);
            Controls.Add(BaslıkTextBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Baslık;
        private DataGridViewTextBoxColumn Konu;
        private DataGridViewTextBoxColumn İçerik;
        private TextBox BaslıkTextBox;
        private Label LblBaslık;
        private TextBox KonuTextBox;
        private Label LblKonu;
        private Label label3;
        private RichTextBox icerikRichTextBox1;
        private Button VeriEkleButton;
    }
}
