namespace Kurs_Work_BD
{
    partial class Judge
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
            this.SolBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SelectButton2 = new System.Windows.Forms.Button();
            this.SelectButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SolBox
            // 
            this.SolBox.Location = new System.Drawing.Point(74, 413);
            this.SolBox.Name = "SolBox";
            this.SolBox.Size = new System.Drawing.Size(100, 20);
            this.SolBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Решение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Номер";
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.Location = new System.Drawing.Point(455, 92);
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(111, 23);
            this.UpdateButton1.TabIndex = 42;
            this.UpdateButton1.Text = "Редактировать";
            this.UpdateButton1.UseVisualStyleBackColor = true;
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 355);
            this.listBox1.TabIndex = 40;
            // 
            // SelectButton2
            // 
            this.SelectButton2.Location = new System.Drawing.Point(455, 52);
            this.SelectButton2.Name = "SelectButton2";
            this.SelectButton2.Size = new System.Drawing.Size(111, 23);
            this.SelectButton2.TabIndex = 39;
            this.SelectButton2.Text = "Показать записи";
            this.SelectButton2.UseVisualStyleBackColor = true;
            this.SelectButton2.Click += new System.EventHandler(this.SelectButton2_Click);
            // 
            // SelectButton1
            // 
            this.SelectButton1.Location = new System.Drawing.Point(455, 13);
            this.SelectButton1.Name = "SelectButton1";
            this.SelectButton1.Size = new System.Drawing.Size(111, 23);
            this.SelectButton1.TabIndex = 38;
            this.SelectButton1.Text = "Запись по номеру";
            this.SelectButton1.UseVisualStyleBackColor = true;
            this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Вернуться к авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(74, 378);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(100, 20);
            this.IDBox1.TabIndex = 36;
            // 
            // Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(578, 491);
            this.Controls.Add(this.SolBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectButton2);
            this.Controls.Add(this.SelectButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBox1);
            this.Name = "Judge";
            this.Text = "Judge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Judge_FormClosing);
            this.Load += new System.EventHandler(this.Judge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SolBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SelectButton2;
        private System.Windows.Forms.Button SelectButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDBox1;
    }
}