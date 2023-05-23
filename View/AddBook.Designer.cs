namespace ChengHan.View
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pd_dp = new System.Windows.Forms.DateTimePicker();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.author_tb = new System.Windows.Forms.TextBox();
            this.pu_tb = new System.Windows.Forms.TextBox();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.ISBN_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "书名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "作者:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "出版社:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版日期:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "价格:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "ISBN:";
            // 
            // pd_dp
            // 
            this.pd_dp.Location = new System.Drawing.Point(302, 385);
            this.pd_dp.Name = "pd_dp";
            this.pd_dp.Size = new System.Drawing.Size(300, 30);
            this.pd_dp.TabIndex = 7;
            this.pd_dp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(302, 70);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(308, 30);
            this.id_tb.TabIndex = 8;
            this.id_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(302, 161);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(308, 30);
            this.name_tb.TabIndex = 9;
            this.name_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // author_tb
            // 
            this.author_tb.Location = new System.Drawing.Point(302, 238);
            this.author_tb.Name = "author_tb";
            this.author_tb.Size = new System.Drawing.Size(308, 30);
            this.author_tb.TabIndex = 10;
            this.author_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pu_tb
            // 
            this.pu_tb.Location = new System.Drawing.Point(302, 304);
            this.pu_tb.Name = "pu_tb";
            this.pu_tb.Size = new System.Drawing.Size(308, 30);
            this.pu_tb.TabIndex = 11;
            this.pu_tb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // price_tb
            // 
            this.price_tb.Location = new System.Drawing.Point(302, 460);
            this.price_tb.Name = "price_tb";
            this.price_tb.Size = new System.Drawing.Size(308, 30);
            this.price_tb.TabIndex = 12;
            this.price_tb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ISBN_tb
            // 
            this.ISBN_tb.Location = new System.Drawing.Point(302, 557);
            this.ISBN_tb.Name = "ISBN_tb";
            this.ISBN_tb.Size = new System.Drawing.Size(308, 30);
            this.ISBN_tb.TabIndex = 13;
            this.ISBN_tb.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 742);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ISBN_tb);
            this.Controls.Add(this.price_tb);
            this.Controls.Add(this.pu_tb);
            this.Controls.Add(this.author_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.pd_dp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker pd_dp;
        private TextBox id_tb;
        private TextBox name_tb;
        private TextBox author_tb;
        private TextBox pu_tb;
        private TextBox price_tb;
        private TextBox ISBN_tb;
        private Button button1;
        private Button button2;
    }
}