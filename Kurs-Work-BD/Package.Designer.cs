namespace Kurs_Work_BD
{
    partial class Package
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
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectButton1 = new System.Windows.Forms.Button();
            this.SelectButton2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.InsertButton1 = new System.Windows.Forms.Button();
            this.UpdateButton1 = new System.Windows.Forms.Button();
            this.DeleteButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocationBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(107, 378);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(100, 20);
            this.IDBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернуться к авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectButton1
            // 
            this.SelectButton1.Location = new System.Drawing.Point(254, 12);
            this.SelectButton1.Name = "SelectButton1";
            this.SelectButton1.Size = new System.Drawing.Size(111, 23);
            this.SelectButton1.TabIndex = 2;
            this.SelectButton1.Text = "Запись по номеру";
            this.SelectButton1.UseVisualStyleBackColor = true;
            this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
            // 
            // SelectButton2
            // 
            this.SelectButton2.Location = new System.Drawing.Point(254, 51);
            this.SelectButton2.Name = "SelectButton2";
            this.SelectButton2.Size = new System.Drawing.Size(111, 23);
            this.SelectButton2.TabIndex = 3;
            this.SelectButton2.Text = "Показать записи";
            this.SelectButton2.UseVisualStyleBackColor = true;
            this.SelectButton2.Click += new System.EventHandler(this.SelectButton2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 355);
            this.listBox1.TabIndex = 4;
            // 
            // InsertButton1
            // 
            this.InsertButton1.Location = new System.Drawing.Point(254, 93);
            this.InsertButton1.Name = "InsertButton1";
            this.InsertButton1.Size = new System.Drawing.Size(111, 23);
            this.InsertButton1.TabIndex = 5;
            this.InsertButton1.Text = "Добавить запись";
            this.InsertButton1.UseVisualStyleBackColor = true;
            this.InsertButton1.Click += new System.EventHandler(this.InsertButton1_Click);
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.Location = new System.Drawing.Point(254, 135);
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(111, 23);
            this.UpdateButton1.TabIndex = 6;
            this.UpdateButton1.Text = "Редактировать";
            this.UpdateButton1.UseVisualStyleBackColor = true;
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.Location = new System.Drawing.Point(254, 174);
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.Size = new System.Drawing.Size(111, 23);
            this.DeleteButton1.TabIndex = 7;
            this.DeleteButton1.Text = "Удалить запись";
            this.DeleteButton1.UseVisualStyleBackColor = true;
            this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Расположение";
            // 
            // LocationBox2
            // 
            this.LocationBox2.Location = new System.Drawing.Point(107, 413);
            this.LocationBox2.Name = "LocationBox2";
            this.LocationBox2.Size = new System.Drawing.Size(100, 20);
            this.LocationBox2.TabIndex = 10;
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(391, 492);
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
            this.Name = "Package";
            this.Text = "Package";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Package_FormClosing);
            this.Load += new System.EventHandler(this.Package_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SelectButton1;
        private System.Windows.Forms.Button SelectButton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button InsertButton1;
        private System.Windows.Forms.Button UpdateButton1;
        private System.Windows.Forms.Button DeleteButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocationBox2;
    }
}