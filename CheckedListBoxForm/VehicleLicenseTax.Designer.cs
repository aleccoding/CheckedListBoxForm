
namespace CheckedListBoxForm
{
    partial class VehicleLicenseTax
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
            this.YearButton = new System.Windows.Forms.RadioButton();
            this.PeriodButton = new System.Windows.Forms.RadioButton();
            this.labtime = new System.Windows.Forms.Label();
            this.labuse = new System.Windows.Forms.Label();
            this.Typebox = new System.Windows.Forms.ComboBox();
            this.Horsepowerbox = new System.Windows.Forms.ComboBox();
            this.labcc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labans = new System.Windows.Forms.Label();
            this.btnCalculater = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.labFrom = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // YearButton
            // 
            this.YearButton.AutoSize = true;
            this.YearButton.BackColor = System.Drawing.Color.FloralWhite;
            this.YearButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.YearButton.Location = new System.Drawing.Point(270, 150);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(68, 22);
            this.YearButton.TabIndex = 0;
            this.YearButton.TabStop = true;
            this.YearButton.Text = "全年度";
            this.YearButton.UseVisualStyleBackColor = false;
            this.YearButton.CheckedChanged += new System.EventHandler(this.YearButton_CheckedChanged);
            // 
            // PeriodButton
            // 
            this.PeriodButton.AutoSize = true;
            this.PeriodButton.BackColor = System.Drawing.Color.FloralWhite;
            this.PeriodButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.PeriodButton.Location = new System.Drawing.Point(341, 150);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(68, 22);
            this.PeriodButton.TabIndex = 1;
            this.PeriodButton.TabStop = true;
            this.PeriodButton.Text = "依期間";
            this.PeriodButton.UseVisualStyleBackColor = false;
            this.PeriodButton.CheckedChanged += new System.EventHandler(this.PeriodButton_CheckedChanged);
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.BackColor = System.Drawing.Color.NavajoWhite;
            this.labtime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtime.Location = new System.Drawing.Point(105, 150);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(74, 21);
            this.labtime.TabIndex = 2;
            this.labtime.Text = "使用期間";
            this.labtime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labuse
            // 
            this.labuse.AutoSize = true;
            this.labuse.BackColor = System.Drawing.Color.Khaki;
            this.labuse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labuse.Location = new System.Drawing.Point(105, 196);
            this.labuse.Name = "labuse";
            this.labuse.Size = new System.Drawing.Size(42, 21);
            this.labuse.TabIndex = 3;
            this.labuse.Text = "用途";
            // 
            // Typebox
            // 
            this.Typebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Typebox.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.Typebox.FormattingEnabled = true;
            this.Typebox.IntegralHeight = false;
            this.Typebox.ItemHeight = 22;
            this.Typebox.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.Typebox.Location = new System.Drawing.Point(270, 192);
            this.Typebox.Name = "Typebox";
            this.Typebox.Size = new System.Drawing.Size(312, 30);
            this.Typebox.TabIndex = 6;
            this.Typebox.SelectedIndexChanged += new System.EventHandler(this.Usebox_SelectedIndexChanged);
            // 
            // Horsepowerbox
            // 
            this.Horsepowerbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Horsepowerbox.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.Horsepowerbox.FormattingEnabled = true;
            this.Horsepowerbox.Items.AddRange(new object[] {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250  /  12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.Horsepowerbox.Location = new System.Drawing.Point(270, 237);
            this.Horsepowerbox.Name = "Horsepowerbox";
            this.Horsepowerbox.Size = new System.Drawing.Size(312, 30);
            this.Horsepowerbox.TabIndex = 7;
            // 
            // labcc
            // 
            this.labcc.AutoSize = true;
            this.labcc.BackColor = System.Drawing.Color.NavajoWhite;
            this.labcc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcc.Location = new System.Drawing.Point(105, 241);
            this.labcc.Name = "labcc";
            this.labcc.Size = new System.Drawing.Size(127, 21);
            this.labcc.TabIndex = 8;
            this.labcc.Text = "汽缸CC數 / 馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(105, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "試算結果";
            // 
            // labans
            // 
            this.labans.AutoSize = true;
            this.labans.BackColor = System.Drawing.Color.FloralWhite;
            this.labans.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labans.Location = new System.Drawing.Point(4, 5);
            this.labans.Name = "labans";
            this.labans.Size = new System.Drawing.Size(17, 21);
            this.labans.TabIndex = 10;
            this.labans.Text = "-";
            // 
            // btnCalculater
            // 
            this.btnCalculater.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculater.Location = new System.Drawing.Point(341, 449);
            this.btnCalculater.Name = "btnCalculater";
            this.btnCalculater.Size = new System.Drawing.Size(95, 36);
            this.btnCalculater.TabIndex = 11;
            this.btnCalculater.Text = "確定送出";
            this.btnCalculater.UseVisualStyleBackColor = true;
            this.btnCalculater.Click += new System.EventHandler(this.btnCalculater_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(442, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 36);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.BackColor = System.Drawing.Color.White;
            this.labFrom.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFrom.Location = new System.Drawing.Point(409, 154);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(20, 16);
            this.labFrom.TabIndex = 21;
            this.labFrom.Text = "從";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.BackColor = System.Drawing.Color.White;
            this.labTo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(560, 154);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(20, 16);
            this.labTo.TabIndex = 22;
            this.labTo.Text = "至";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.Location = new System.Drawing.Point(426, 148);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(128, 25);
            this.dateTimePickerFrom.TabIndex = 23;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 7, 17, 0, 0, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Location = new System.Drawing.Point(586, 148);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(124, 25);
            this.dateTimePickerTo.TabIndex = 24;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 7, 17, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.labans);
            this.panel1.Location = new System.Drawing.Point(270, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 145);
            this.panel1.TabIndex = 25;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(336, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 128);
            this.vScrollBar1.TabIndex = 26;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(94, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 45);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(94, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 56);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(94, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 162);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(94, 220);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(170, 56);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(262, 138);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(465, 45);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 45);
            this.label1.TabIndex = 34;
            this.label1.Text = "使用牌照稅應納稅額試算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(92, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "1. 本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(106, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(255, 17);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "使用牌照稅稅額對照表及電動車應納稅額表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(262, 181);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(465, 49);
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(262, 228);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(465, 48);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(262, 273);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(465, 159);
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(91, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "2.";
            // 
            // VehicleLicenseTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labFrom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labcc);
            this.Controls.Add(this.Horsepowerbox);
            this.Controls.Add(this.Typebox);
            this.Controls.Add(this.labuse);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.PeriodButton);
            this.Controls.Add(this.YearButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Name = "VehicleLicenseTax";
            this.Text = "VehicleLicenseTax";
            this.Load += new System.EventHandler(this.VehicleLicenseTax_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton YearButton;
        private System.Windows.Forms.RadioButton PeriodButton;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.Label labuse;
        private System.Windows.Forms.ComboBox Typebox;
        private System.Windows.Forms.ComboBox Horsepowerbox;
        private System.Windows.Forms.Label labcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labans;
        private System.Windows.Forms.Button btnCalculater;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
    }
}