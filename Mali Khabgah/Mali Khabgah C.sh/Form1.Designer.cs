namespace Mali_Khabgah_C.sh
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            checkboxes = new CheckedListBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            reasons = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            savebox = new ListBox();
            button3 = new Button();
            groupBox4 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "سینا";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "صدرا";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 100);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(78, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "مسعود";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 130);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(67, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "مهدی";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 160);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(67, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "یونس";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 284);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "سیو";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SaveData;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "0";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 7;
            label1.Text = "پول";
            // 
            // checkboxes
            // 
            checkboxes.CheckOnClick = true;
            checkboxes.FormattingEnabled = true;
            checkboxes.Items.AddRange(new object[] { "سینا", "صدرا", "مسعود", "مهدی", "یونس" });
            checkboxes.Location = new Point(20, 98);
            checkboxes.Name = "checkboxes";
            checkboxes.Size = new Size(150, 114);
            checkboxes.Sorted = true;
            checkboxes.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 9;
            label2.Text = "خریدار";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(reasons);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(checkboxes);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 319);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافه";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 215);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 12;
            label3.Text = "دلیل:";
            // 
            // reasons
            // 
            reasons.Location = new Point(20, 238);
            reasons.Name = "reasons";
            reasons.Size = new Size(293, 27);
            reasons.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(176, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(137, 190);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "مصرف کنندگان";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(savebox);
            groupBox3.Location = new Point(337, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 560);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "لیست سیو شده";
            // 
            // button2
            // 
            button2.Location = new Point(16, 525);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // savebox
            // 
            savebox.FormattingEnabled = true;
            savebox.ItemHeight = 20;
            savebox.Location = new Point(16, 28);
            savebox.Name = "savebox";
            savebox.ScrollAlwaysVisible = true;
            savebox.Size = new Size(454, 484);
            savebox.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(12, 543);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "حساب";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox1);
            groupBox4.Location = new Point(813, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(510, 560);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "حساب";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(498, 526);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 584);
            Controls.Add(groupBox4);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "حساب خوابگاه";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private CheckedListBox checkboxes;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox savebox;
        private Button button2;
        private Label label3;
        private TextBox reasons;
        private Button button3;
        private GroupBox groupBox4;
        private RichTextBox richTextBox1;
    }
}