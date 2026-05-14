namespace Proje
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            filmIdTxt = new TextBox();
            filmAdTxt = new TextBox();
            yonetmenTxt = new TextBox();
            sureTxt = new TextBox();
            puanTxt = new TextBox();
            yapimSirketiTxt = new TextBox();
            kategoriCmb = new ComboBox();
            listButton = new Button();
            kaydetButton = new Button();
            guncelleButton = new Button();
            silButton = new Button();
            dataTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Film ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 0;
            label2.Text = "Film Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 114);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 0;
            label3.Text = "Yönetmen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(98, 159);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 0;
            label4.Text = "Süre (dk)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(136, 205);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 0;
            label5.Text = "Puan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 250);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 0;
            label6.Text = "Yapım Şirketi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(47, 293);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 0;
            label7.Text = "Film Kategorisi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(filmIdTxt);
            panel1.Controls.Add(filmAdTxt);
            panel1.Controls.Add(yonetmenTxt);
            panel1.Controls.Add(sureTxt);
            panel1.Controls.Add(puanTxt);
            panel1.Controls.Add(yapimSirketiTxt);
            panel1.Controls.Add(kategoriCmb);
            panel1.Controls.Add(listButton);
            panel1.Controls.Add(kaydetButton);
            panel1.Controls.Add(guncelleButton);
            panel1.Controls.Add(silButton);
            panel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 488);
            panel1.TabIndex = 1;
            // 
            // filmIdTxt
            // 
            filmIdTxt.BackColor = Color.White;
            filmIdTxt.Location = new Point(235, 14);
            filmIdTxt.Name = "filmIdTxt";
            filmIdTxt.ReadOnly = true;
            filmIdTxt.Size = new Size(344, 34);
            filmIdTxt.TabIndex = 1;
            // 
            // filmAdTxt
            // 
            filmAdTxt.Location = new Point(235, 64);
            filmAdTxt.Name = "filmAdTxt";
            filmAdTxt.Size = new Size(344, 34);
            filmAdTxt.TabIndex = 2;
            // 
            // yonetmenTxt
            // 
            yonetmenTxt.Location = new Point(235, 108);
            yonetmenTxt.Name = "yonetmenTxt";
            yonetmenTxt.Size = new Size(344, 34);
            yonetmenTxt.TabIndex = 3;
            // 
            // sureTxt
            // 
            sureTxt.Location = new Point(235, 153);
            sureTxt.Name = "sureTxt";
            sureTxt.Size = new Size(344, 34);
            sureTxt.TabIndex = 4;
            // 
            // puanTxt
            // 
            puanTxt.Location = new Point(235, 199);
            puanTxt.Name = "puanTxt";
            puanTxt.Size = new Size(344, 34);
            puanTxt.TabIndex = 5;
            // 
            // yapimSirketiTxt
            // 
            yapimSirketiTxt.Location = new Point(235, 244);
            yapimSirketiTxt.Name = "yapimSirketiTxt";
            yapimSirketiTxt.Size = new Size(344, 34);
            yapimSirketiTxt.TabIndex = 6;
            // 
            // kategoriCmb
            // 
            kategoriCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriCmb.FormattingEnabled = true;
            kategoriCmb.Location = new Point(235, 290);
            kategoriCmb.Name = "kategoriCmb";
            kategoriCmb.Size = new Size(344, 36);
            kategoriCmb.TabIndex = 7;
            // 
            // listButton
            // 
            listButton.BackColor = Color.White;
            listButton.CausesValidation = false;
            listButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            listButton.ForeColor = Color.Black;
            listButton.Location = new Point(12, 355);
            listButton.Name = "listButton";
            listButton.Size = new Size(276, 49);
            listButton.TabIndex = 8;
            listButton.Text = "Tüm Kayıtları Listele";
            listButton.UseVisualStyleBackColor = false;
            listButton.Click += listButton_Click;
            // 
            // kaydetButton
            // 
            kaydetButton.BackColor = Color.White;
            kaydetButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            kaydetButton.ForeColor = Color.Black;
            kaydetButton.Location = new Point(303, 355);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(276, 49);
            kaydetButton.TabIndex = 9;
            kaydetButton.Text = "Yeni Kayıt Oluştur ve Kaydet";
            kaydetButton.UseVisualStyleBackColor = false;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // guncelleButton
            // 
            guncelleButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            guncelleButton.ForeColor = Color.Black;
            guncelleButton.Location = new Point(12, 423);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(276, 49);
            guncelleButton.TabIndex = 10;
            guncelleButton.Text = "Güncelle";
            guncelleButton.UseVisualStyleBackColor = true;
            guncelleButton.Click += guncelleButton_Click;
            // 
            // silButton
            // 
            silButton.BackColor = Color.White;
            silButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            silButton.ForeColor = Color.Black;
            silButton.Location = new Point(306, 423);
            silButton.Name = "silButton";
            silButton.Size = new Size(273, 49);
            silButton.TabIndex = 11;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = false;
            silButton.Click += silButton_Click;
            // 
            // dataTable
            // 
            dataTable.AllowUserToOrderColumns = true;
            dataTable.BackgroundColor = Color.DarkRed;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Location = new Point(618, 12);
            dataTable.MultiSelect = false;
            dataTable.Name = "dataTable";
            dataTable.ReadOnly = true;
            dataTable.RowHeadersWidth = 62;
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTable.Size = new Size(1055, 488);
            dataTable.TabIndex = 2;
            dataTable.CellClick += dataTable_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1708, 512);
            Controls.Add(panel1);
            Controls.Add(dataTable);
            Name = "Form1";
            Text = "Film Yönetim Sistemi";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
        }

        private Label label1, label2, label3, label4, label5, label6, label7;
        private Panel panel1;
        private TextBox filmIdTxt, filmAdTxt, yonetmenTxt, sureTxt, puanTxt, yapimSirketiTxt;
        private ComboBox kategoriCmb;
        private Button listButton, kaydetButton, guncelleButton, silButton;
        private DataGridView dataTable;
        private DataGridViewTextBoxColumn colFilmId, colFilmAd, colYonetmen;
        private DataGridViewTextBoxColumn colSure, colPuan, colYapimSirketi, colKategori;
    }
}