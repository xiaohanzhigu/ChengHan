namespace ChengHan
{
    partial class UpdateReader
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
            this.id_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.man_rb = new System.Windows.Forms.RadioButton();
            this.woman_rb = new System.Windows.Forms.RadioButton();
            this.brith_dtp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "阅读编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "日期：";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(216, 47);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(150, 30);
            this.id_tb.TabIndex = 4;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(216, 119);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(150, 30);
            this.name_tb.TabIndex = 5;
            // 
            // man_rb
            // 
            this.man_rb.AutoSize = true;
            this.man_rb.Location = new System.Drawing.Point(218, 205);
            this.man_rb.Name = "man_rb";
            this.man_rb.Size = new System.Drawing.Size(53, 28);
            this.man_rb.TabIndex = 6;
            this.man_rb.TabStop = true;
            this.man_rb.Text = "男";
            this.man_rb.UseVisualStyleBackColor = true;
            // 
            // woman_rb
            // 
            this.woman_rb.AutoSize = true;
            this.woman_rb.Location = new System.Drawing.Point(405, 207);
            this.woman_rb.Name = "woman_rb";
            this.woman_rb.Size = new System.Drawing.Size(53, 28);
            this.woman_rb.TabIndex = 7;
            this.woman_rb.TabStop = true;
            this.woman_rb.Text = "女";
            this.woman_rb.UseVisualStyleBackColor = true;
            // 
            // brith_dtp
            // 
            this.brith_dtp.CustomFormat = "yyyy年MM月dd日";
            this.brith_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.brith_dtp.Location = new System.Drawing.Point(218, 283);
            this.brith_dtp.Name = "brith_dtp";
            this.brith_dtp.Size = new System.Drawing.Size(300, 30);
            this.brith_dtp.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 507);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brith_dtp);
            this.Controls.Add(this.woman_rb);
            this.Controls.Add(this.man_rb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateReader";
            this.Text = "UpdateReader";
            this.Load += new System.EventHandler(this.UpdateReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox id_tb;
        private TextBox name_tb;
        private RadioButton man_rb;
        private RadioButton woman_rb;
        private DateTimePicker brith_dtp;
        private Button button1;
        private Button button2;
    }
}