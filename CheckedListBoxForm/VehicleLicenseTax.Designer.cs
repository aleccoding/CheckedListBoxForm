
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearButton
            // 
            this.YearButton.AutoSize = true;
            this.YearButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearButton.Location = new System.Drawing.Point(292, 40);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(62, 20);
            this.YearButton.TabIndex = 0;
            this.YearButton.TabStop = true;
            this.YearButton.Text = "全年度";
            this.YearButton.UseVisualStyleBackColor = true;
            this.YearButton.CheckedChanged += new System.EventHandler(this.YearButton_CheckedChanged);
            // 
            // PeriodButton
            // 
            this.PeriodButton.AutoSize = true;
            this.PeriodButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PeriodButton.Location = new System.Drawing.Point(363, 40);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(62, 20);
            this.PeriodButton.TabIndex = 1;
            this.PeriodButton.TabStop = true;
            this.PeriodButton.Text = "依期間";
            this.PeriodButton.UseVisualStyleBackColor = true;
            this.PeriodButton.CheckedChanged += new System.EventHandler(this.PeriodButton_CheckedChanged);
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtime.Location = new System.Drawing.Point(127, 40);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(74, 21);
            this.labtime.TabIndex = 2;
            this.labtime.Text = "使用期間";
            this.labtime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labuse
            // 
            this.labuse.AutoSize = true;
            this.labuse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labuse.Location = new System.Drawing.Point(127, 86);
            this.labuse.Name = "labuse";
            this.labuse.Size = new System.Drawing.Size(42, 21);
            this.labuse.TabIndex = 3;
            this.labuse.Text = "用途";
            // 
            // Typebox
            // 
            this.Typebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Typebox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Typebox.FormattingEnabled = true;
            this.Typebox.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.Typebox.Location = new System.Drawing.Point(292, 82);
            this.Typebox.Name = "Typebox";
            this.Typebox.Size = new System.Drawing.Size(214, 25);
            this.Typebox.TabIndex = 6;
            this.Typebox.SelectedIndexChanged += new System.EventHandler(this.Usebox_SelectedIndexChanged);
            // 
            // Horsepowerbox
            // 
            this.Horsepowerbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Horsepowerbox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Horsepowerbox.FormattingEnabled = true;
            this.Horsepowerbox.Items.AddRange(new object[] {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250  /  12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.Horsepowerbox.Location = new System.Drawing.Point(292, 136);
            this.Horsepowerbox.Name = "Horsepowerbox";
            this.Horsepowerbox.Size = new System.Drawing.Size(214, 25);
            this.Horsepowerbox.TabIndex = 7;
            // 
            // labcc
            // 
            this.labcc.AutoSize = true;
            this.labcc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcc.Location = new System.Drawing.Point(127, 136);
            this.labcc.Name = "labcc";
            this.labcc.Size = new System.Drawing.Size(151, 21);
            this.labcc.TabIndex = 8;
            this.labcc.Text = "汽缸CC數/馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(127, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "試算結果";
            // 
            // labans
            // 
            this.labans.AutoSize = true;
            this.labans.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labans.Location = new System.Drawing.Point(3, 0);
            this.labans.Name = "labans";
            this.labans.Size = new System.Drawing.Size(17, 21);
            this.labans.TabIndex = 10;
            this.labans.Text = "-";
            // 
            // btnCalculater
            // 
            this.btnCalculater.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculater.Location = new System.Drawing.Point(292, 339);
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
            this.btnReset.Location = new System.Drawing.Point(472, 339);
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
            this.labFrom.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFrom.Location = new System.Drawing.Point(431, 42);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(20, 16);
            this.labFrom.TabIndex = 21;
            this.labFrom.Text = "從";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(565, 42);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(20, 16);
            this.labTo.TabIndex = 22;
            this.labTo.Text = "至";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(457, 40);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(102, 23);
            this.dateTimePickerFrom.TabIndex = 23;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 7, 17, 0, 0, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(591, 40);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(102, 23);
            this.dateTimePickerTo.TabIndex = 24;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 7, 17, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labans);
            this.panel1.Location = new System.Drawing.Point(292, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 128);
            this.panel1.TabIndex = 25;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(578, 194);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 128);
            this.vScrollBar1.TabIndex = 26;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // VehicleLicenseTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
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
            this.Name = "VehicleLicenseTax";
            this.Text = "VehicleLicenseTax";
            this.Load += new System.EventHandler(this.VehicleLicenseTax_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}