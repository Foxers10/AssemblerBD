namespace Kurs_Work_BD
{
    partial class Document
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
            this.LocationBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton1 = new System.Windows.Forms.Button();
            this.UpdateButton1 = new System.Windows.Forms.Button();
            this.InsertButton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SelectButton2 = new System.Windows.Forms.Button();
            this.SelectButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContentBox1 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LocationBox2
            // 
            this.LocationBox2.Location = new System.Drawing.Point(106, 413);
            this.LocationBox2.Name = "LocationBox2";
            this.LocationBox2.Size = new System.Drawing.Size(124, 20);
            this.LocationBox2.TabIndex = 21;
            this.LocationBox2.TextChanged += new System.EventHandler(this.LocationBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Номер";
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.Location = new System.Drawing.Point(253, 174);
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.Size = new System.Drawing.Size(111, 23);
            this.DeleteButton1.TabIndex = 18;
            this.DeleteButton1.Text = "Удалить запись";
            this.DeleteButton1.UseVisualStyleBackColor = true;
            this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton1_Click);
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.Location = new System.Drawing.Point(253, 135);
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(111, 23);
            this.UpdateButton1.TabIndex = 17;
            this.UpdateButton1.Text = "Редактировать";
            this.UpdateButton1.UseVisualStyleBackColor = true;
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // InsertButton1
            // 
            this.InsertButton1.Location = new System.Drawing.Point(253, 93);
            this.InsertButton1.Name = "InsertButton1";
            this.InsertButton1.Size = new System.Drawing.Size(111, 23);
            this.InsertButton1.TabIndex = 16;
            this.InsertButton1.Text = "Добавить запись";
            this.InsertButton1.UseVisualStyleBackColor = true;
            this.InsertButton1.Click += new System.EventHandler(this.InsertButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 355);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SelectButton2
            // 
            this.SelectButton2.Location = new System.Drawing.Point(253, 51);
            this.SelectButton2.Name = "SelectButton2";
            this.SelectButton2.Size = new System.Drawing.Size(111, 23);
            this.SelectButton2.TabIndex = 14;
            this.SelectButton2.Text = "Показать записи";
            this.SelectButton2.UseVisualStyleBackColor = true;
            this.SelectButton2.Click += new System.EventHandler(this.SelectButton2_Click);
            // 
            // SelectButton1
            // 
            this.SelectButton1.Location = new System.Drawing.Point(253, 12);
            this.SelectButton1.Name = "SelectButton1";
            this.SelectButton1.Size = new System.Drawing.Size(111, 23);
            this.SelectButton1.TabIndex = 13;
            this.SelectButton1.Text = "Запись по номеру";
            this.SelectButton1.UseVisualStyleBackColor = true;
            this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Вернуться к авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(106, 378);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(124, 20);
            this.IDBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Содержание";
            // 
            // ContentBox1
            // 
            this.ContentBox1.Location = new System.Drawing.Point(106, 446);
            this.ContentBox1.Name = "ContentBox1";
            this.ContentBox1.Size = new System.Drawing.Size(517, 20);
            this.ContentBox1.TabIndex = 23;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(387, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 329);
            this.listBox2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Номер комплекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Комплекты документов:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 27;
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(635, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ContentBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LocationBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton1);
            this.Controls.Add(this.UpdateButton1);
            this.Controls.Add(this.InsertButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectButton2);
            this.Controls.Add(this.SelectButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBox1);
            this.Name = "Document";
            this.Text = "Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Document_FormClosing);
            this.Load += new System.EventHandler(this.Document_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton1;
        private System.Windows.Forms.Button UpdateButton1;
        private System.Windows.Forms.Button InsertButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SelectButton2;
        private System.Windows.Forms.Button SelectButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContentBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}