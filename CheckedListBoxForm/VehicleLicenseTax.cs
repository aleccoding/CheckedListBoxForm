using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBoxForm
{
    public partial class VehicleLicenseTax : Form
    {
        private void Init()
        {
            this.Typebox.SelectedIndex = 0;
            this.Horsepowerbox.SelectedIndex = 0;
            this.YearButton.Checked = true;
            this.labFrom.Visible = false;
            this.labTo.Visible = false;
            this.dateTimePickerFrom.Visible = false;
            this.dateTimePickerTo.Visible = false;
            this.labans.Text = "";

        }
        public VehicleLicenseTax()
        {
            InitializeComponent();
        }
        #region Events
        private Point startpoint;
        private void VehicleLicenseTax_Load(object sender, EventArgs e)
        {
            this.Init();
            this.startpoint = this.labans.Location;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Init();
        }
        private decimal GetTaxPerYear() //獲取年繳稅金
        {
            if (this.Typebox.SelectedIndex == -1) return 0;

            int ct_index = this.Horsepowerbox.SelectedIndex;
            string carType = this.Typebox.Text;
            string ccType = this.Horsepowerbox.Text;

            decimal taxperyear = 0;

            switch (carType)
            {
                case "機車":
                    switch (ccType)
                    {
                        case "150~250":
                            taxperyear = 800;
                            break;
                        case "251~500":
                            taxperyear = 1620;
                            break;
                        case "501~600":
                            taxperyear = 2160;
                            break;
                        case "601~1200":
                            taxperyear = 4320;
                            break;
                        case "1201~1800":
                            taxperyear = 7120;
                            break;
                        case "1801或以上":
                            taxperyear = 11230;
                            break;
                    }
                    break;
                case "貨車":
                    switch (ccType)
                    {
                        case "500以下":
                            taxperyear = 900;
                            break;
                        case "501~600":
                            taxperyear = 1080;
                            break;
                        case "601~1200":
                            taxperyear = 1800;
                            break;
                        default:
                            ct_index -= 2;
                            taxperyear = 1800 + 900 * ct_index;
                            break;
                    }
                    break;
                case "大客車":
                    switch (ccType)
                    {
                        case "600以下":
                            taxperyear = 1080;
                            break;
                        case "601~1200":
                            taxperyear = 1800;
                            break;
                        default:
                            ct_index -= 1;
                            taxperyear = 1800 + 900 * ct_index;
                            break;
                    }
                    break;
                case "自用小客車":
                    switch (ccType)
                    {
                        case "500以下":
                            taxperyear = 1620;
                            break;
                        case "501~600":
                            taxperyear = 2160;
                            break;
                        case "601~1200":
                            taxperyear = 4320;
                            break;
                        case "1201~1800":
                            taxperyear = 7120;
                            break;
                        case "1801~2400":
                            taxperyear = 11230;
                            break;
                        case "2401~3000":
                            taxperyear = 15210;
                            break;
                        case "3001~4200":
                            taxperyear = 28220;
                            break;
                        case "4201~5400":
                            taxperyear = 46170;
                            break;
                        case "5401~6600":
                            taxperyear = 69690;
                            break;
                        case "6601~7800":
                            taxperyear = 117000;
                            break;
                        case "7801以上":
                            taxperyear = 151200;
                            break;
                        default:
                            taxperyear = 1620;
                            break;
                    }
                    break;
                case "營業用小客車":
                    switch (ccType)
                    {
                        case "500以下":
                            taxperyear = 900;
                            break;
                        case "501~600":
                            taxperyear = 1260;
                            break;
                        case "601~1200":
                            taxperyear = 2160;
                            break;
                        case "1201~1800":
                            taxperyear = 3060;
                            break;
                        case "1801~2400":
                            taxperyear = 6480;
                            break;
                        case "2401~3000":
                            taxperyear = 9900;
                            break;
                        case "3001~4200":
                            taxperyear = 16380;
                            break;
                        case "4201~5400":
                            taxperyear = 24300;
                            break;
                        case "5401~6600":
                            taxperyear = 33660;
                            break;
                        case "6601~7800":
                            taxperyear = 44460;
                            break;
                        case "7801以上":
                            taxperyear = 56700;
                            break;
                        default:
                            taxperyear = 900;
                            break;
                    }
                    break;
                default:
                    break;
            }
            return taxperyear;
            #region
            //機車
            //貨車
            //大客車
            //自用小客車
            //營業用小客車
            #endregion
        }
        private void YearButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YearButton.Checked)
            {
                this.dateTimePickerFrom.Visible = false;
                this.dateTimePickerTo.Visible = false;
                this.labFrom.Visible = false;
                this.labTo.Visible = false;
            }
        }
        private void PeriodButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PeriodButton.Checked)
            {
                this.dateTimePickerFrom.Visible = true;
                this.dateTimePickerTo.Visible = true;
                this.labFrom.Visible = true;
                this.labTo.Visible = true;
            }
        }
        private void btnCalculater_Click(object sender, EventArgs e)
        {
            DateTime from_date = this.dateTimePickerFrom.Value;
            DateTime to_date = this.dateTimePickerTo.Value;

            if ((to_date - from_date).Days < 0)
            {
                this.dateTimePickerFrom.Value = to_date;
                this.dateTimePickerTo.Value = from_date;
                from_date = this.dateTimePickerFrom.Value;
                to_date = this.dateTimePickerTo.Value;
            }

            if (PeriodButton.Checked)
            {
                int daycnt = (to_date - from_date).Days + 1;
             
                if (from_date.Year == to_date.Year)
                {
                    int Yod = (new DateTime(to_date.Year + 1, 1, 1) - new DateTime(from_date.Year, 1, 1)).Days;
                    this.labans.Text ="貼心小叮嚀!查詢牌照稅天數期間至少一年";
                }
                else
                {
                    int years = to_date.Year - from_date.Year;
                    if (years < 0) years = 0;
                    decimal[] yearlist = new decimal[years + 2];           //頭尾日期多出來的部分
                    for (int i = 0; i < years + 2; i++)
                    {
                        yearlist[i] = from_date.Year + i;
                    }
                    
                    decimal totally = 0;
                    decimal YearofTax = GetTaxPerYear();
                    for (int i = 0; i < yearlist.Length; i++)
                    {
                        decimal Ans;
                        if (i == 0)
                        {
                            decimal DayOfYear = (new DateTime(from_date.Year, 12, 31) - from_date).Days + 1;
                            decimal Yod =  (new DateTime(from_date.Year + 1, 1, 1) - new DateTime(from_date.Year, 1, 1)).Days;
                            Ans = Math.Truncate(YearofTax * (DayOfYear / Yod));
                            totally += Ans;
                            this.labans.Text = $"使用期間: {from_date.ToString("yyyy/MM/dd")} - {from_date.Year}/12/31" +
                                  $"\n計算天數: {DayOfYear}" +
                                  $"\n汽缸CC數/馬力: {this.Horsepowerbox.Text}" +
                                  $"\n用途: {this.Typebox.Text}" +
                                  $"\n計算公式: {GetTaxPerYear()} * {DayOfYear} / {Yod}元" +
                                  $"\n應納稅額: {Ans}元";
                        }
                        else if(i == (yearlist.Length -1))
                        {
                            decimal DayOfYear = (to_date - new DateTime(to_date.Year, 1, 1)).Days + 1;
                            decimal Yod = (new DateTime(to_date.Year + 1, 1, 1) - new DateTime(to_date.Year, 1, 1)).Days;
                            Ans = Math.Truncate(YearofTax * (DayOfYear / Yod));
                            totally += Ans;
                            this.labans.Text += $"\n\n使用期間: {to_date.Year}/1/1 - {to_date.ToString("yyyy/MM/dd")}" +
                                  $"\n計算天數: {DayOfYear}" +
                                  $"\n汽缸CC數/馬力: {this.Horsepowerbox.Text}" +
                                  $"\n用途: {this.Typebox.Text}" +
                                  $"\n計算公式: {GetTaxPerYear()} * {DayOfYear} / {Yod}元" +
                                  $"\n應納稅額: {Ans}元";
                        }
                        else
                        {
                            totally += GetTaxPerYear();
                            int Yod = (new DateTime(to_date.Year + 1, 1, 1) - new DateTime(to_date.Year, 1, 1)).Days;
                            this.labans.Text += $"\n\n使用期間: {from_date.Year + i}/1/1 - {from_date.Year + i}/12/31" +
                                  $"\n計算天數: {Yod}" +
                                  $"\n汽缸CC數/馬力: {this.Horsepowerbox.Text}" +
                                  $"\n用途: {this.Typebox.Text}" +
                                  $"\n計算公式: {GetTaxPerYear()} * {Yod} / {Yod}元" +
                                  $"\n應納稅額: {GetTaxPerYear()}元";
                        }
                    }
                    if (yearlist.Length > 1)
                        this.labans.Text += $"\n\n納稅總額: 共{totally}元";
                }

            }
            else
            {
                int DayOfYear = (new DateTime(to_date.Year + 1, 1, 1) - new DateTime(from_date.Year, 1, 1)).Days;
                this.labans.Text = $"使用期間:{DateTime.Now.ToString("yyyy")}/01/01 -{DateTime.Now.ToString("yyyy")}/12/31" +
                                   $"\n計算天數:{DayOfYear}" +
                                   $"\n汽缸CC數/馬力:{this.Horsepowerbox.Text}" +
                                   $"\n用途:{this.Typebox.Text}" +
                                   $"\n計算公式:{GetTaxPerYear()} * {DayOfYear} / {DayOfYear}元" +
                                   $"\n應納稅額:{GetTaxPerYear()}元";
            }
            this.vScrollBar1.Maximum = this.labans.Text.Length * 4 / 3;
        }

        private void Usebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carType = this.Typebox.Text;
            this.Horsepowerbox.Enabled = true;
            this.Horsepowerbox.Items.Clear();
            switch (carType)
                {
                    case "機車":
                        this.Horsepowerbox.Items.AddRange(new String[] { "150以下", "150~250", "251~500", "501~600", "601~1200", "1201~1800", "1801或以上" });
                        break;
                    case "貨車":
                        this.Horsepowerbox.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400"
                    , "2401~3000", "3001~3600","3601~4200", "4200~4800", "4801~5400", "5401~6000","6001~6600", "6601~7200"
                    , "7201~7800", "7801~8400", "8401~9000", "9001~9600", "9601~10200", "10201以上"});
                        break;
                    case "大客車":
                        this.Horsepowerbox.Items.AddRange(new String[] { "600以下", "601~1200", "1201~1800", "1801~2400"
                    , "2401~3000", "3001~3600","3601~4200", "4200~4800", "4801~5400", "5401~6000","6001~6600", "6601~7200"
                    , "7201~7800", "7801~8400", "8401~9000", "9001~9600", "9601~10200", "10201以上"});
                        break;
                    case "自用小客車":
                        this.Horsepowerbox.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400", "2401~3000"
                    , "3001~4200", "4200~5400", "5401~6600", "6601~7800", "7801以上"});
                        break;
                    case "營業用小客車":
                        this.Horsepowerbox.Items.AddRange(new String[] { "500以下", "501~600", "601~1200", "1201~1800", "1801~2400", "2401~3000"
                    , "3001~4200", "4200~5400", "5401~6600", "6601~7800", "7801以上"});
                        break;
                }
                this.Horsepowerbox.SelectedIndex = 0;
            }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var newponit = new Point(this.labans.Location.X, this.startpoint.Y - this.vScrollBar1.Value);
            this.labans.Location = newponit;
        }
    }
    }


#endregion