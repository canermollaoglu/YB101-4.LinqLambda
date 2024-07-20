namespace LinqLambdaExpression
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lstListe = new ListBox();
            dgwRapor = new DataGridView();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwRapor).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 14);
            button1.Name = "button1";
            button1.Size = new Size(449, 45);
            button1.TabIndex = 0;
            button1.Text = "Çift Sayıları Bul - Linq";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 65);
            button2.Name = "button2";
            button2.Size = new Size(449, 45);
            button2.TabIndex = 0;
            button2.Text = "Çift Sayıları Bul - Lambda";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 116);
            button3.Name = "button3";
            button3.Size = new Size(449, 45);
            button3.TabIndex = 0;
            button3.Text = "Tüm Ürünleri Listeleyiniz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 167);
            button4.Name = "button4";
            button4.Size = new Size(449, 45);
            button4.TabIndex = 0;
            button4.Text = "Ürün Adı, Birim Fiyatı, Kategori Adı";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 218);
            button5.Name = "button5";
            button5.Size = new Size(449, 96);
            button5.TabIndex = 0;
            button5.Text = "20 den fazla ürün satılan siparişleri bulalım";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(13, 320);
            button7.Name = "button7";
            button7.Size = new Size(449, 45);
            button7.TabIndex = 0;
            button7.Text = "1998 den sonra yapılan siparişler";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(13, 371);
            button8.Name = "button8";
            button8.Size = new Size(449, 45);
            button8.TabIndex = 0;
            button8.Text = "Müşterilerin Siparişleri";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 422);
            button9.Name = "button9";
            button9.Size = new Size(449, 45);
            button9.TabIndex = 0;
            button9.Text = "Ürünleri Listele";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(495, 79);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(376, 337);
            lstListe.TabIndex = 1;
            // 
            // dgwRapor
            // 
            dgwRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwRapor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRapor.Location = new Point(13, 483);
            dgwRapor.Name = "dgwRapor";
            dgwRapor.Size = new Size(858, 202);
            dgwRapor.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new Point(495, 12);
            button6.Name = "button6";
            button6.Size = new Size(376, 47);
            button6.TabIndex = 3;
            button6.Text = "Kategori Ürün Sayısı";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 708);
            Controls.Add(button6);
            Controls.Add(dgwRapor);
            Controls.Add(lstListe);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwRapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private ListBox lstListe;
        private DataGridView dgwRapor;
        private Button button6;
    }
}
