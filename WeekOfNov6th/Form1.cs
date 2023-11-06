using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            if (rtbInput1.Text != "") 
            {
                if (rdoTempConverter1.Checked == true)
                {
                    var hold = float.Parse(rtbInput1.Text);

                    rtbOutput.Text += (hold * 9 / 5) + 32 + " °F \n";
                }
                else
                {
                    var hold = float.Parse(rtbInput1.Text);

                    rtbOutput.Text += (hold - 32) * 5 / 9 + " C° \n";

                }
            }
            else
            {
                rtbOutput.Text = "please put a number in input 1. \n";
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {

            // if input box is NOT empty, run this code
            if (rtbInput2.Text != "")
            {
                var input2 = rtbInput2.Text;

                // if cmbmoney's selected item is (this), then do it's appropriate conversion from this (money) to this (money) / currency
                if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Yen")
                {
                    rtbOutput.Text += float.Parse(input2) * 149.77 + "\n";
                }
                else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen-Dollar")
                {
                    rtbOutput.Text += float.Parse(input2) * 0.006674 + "\n";
                }
                else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Euro")
                {
                    rtbOutput.Text += float.Parse(input2) * 0.93 + "\n";
                }
                else if (cmbMoneyConverter.SelectedItem.ToString() == "Euro-Dollar")
                {
                    rtbOutput.Text += float.Parse(input2) * 1.07 + "\n";
                }
                else if (cmbMoneyConverter.SelectedItem.ToString() == "Euro-Pound")
                {
                    rtbOutput.Text += float.Parse(input2) * 0.87 + "\n";
                }
                else if (cmbMoneyConverter.SelectedItem.ToString() == "Pound-Euro")
                {
                    rtbOutput.Text += float.Parse(input2) * 1.15 + "\n";
                }
                else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Reais")
                {
                    rtbOutput.Text += float.Parse(input2) * 4.90 + "\n";
                }
                else
                {
                    rtbOutput.Text += float.Parse(input2) * 0.20 + "\n";
                }
            }
            //if imbputbox IS empty, paste this
            else
            {
                rtbOutput.Text = "please put a number in input 2";
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            if (rtbInput2.Text != "")
            {
                if (chkMileToKilo.Checked == false && chkMeterToInch.Checked == false)
                {
                    rtbOutput.Text = "please choose atleast one checkmark. \n";
                }
                else
                {
                    if (chkMileToKilo.Checked == true && chkMeterToInch.Checked == true)
                    {
                        var input2 = rtbInput2.Text;

                        rtbOutput.Text += "mile to km: " + float.Parse(input2) * 1.60934 + "\n" + "meter to inch: " + float.Parse(input2) * 39.3701 + "\n";
                    }
                    else if (chkMileToKilo.Checked == true)
                    {
                        var input2 = rtbInput2.Text;

                        rtbOutput.Text += "mile to km:" + float.Parse(input2) * 1.60934 + "\n";
                    }
                    else
                    {
                        var input2 = rtbInput2.Text;

                        rtbOutput.Text += "meter to inch: " + float.Parse(input2) * 39.3701 + "\n";
                    }
                }

                
            }
            else
            {
                rtbOutput.Text = "please put a number in input 2. \n";
            }
        }

        private void btnDistance2_Click(object sender, EventArgs e)
        {
            if (rtbInput2.Text != "")
            {
                if (chkKiloToMiles.Checked == false && chkInchToMeter.Checked == false)
                {
                    rtbOutput.Text += "please choose atleast one checkmark. \n";
                }
                else
                {
                    if (chkKiloToMiles.Checked == true && chkInchToMeter.Checked == true)
                    {
                        var input2 = rtbInput2.Text;

                        rtbOutput.Text += "km to mile: " + float.Parse(input2) * 0.621371 + "\n" + "inch to meter: " + float.Parse(input2) * 0.0254 + "\n";
                    }
                    else if (chkKiloToMiles.Checked == true)
                    {
                        var input2 = rtbInput2.Text;

                        rtbOutput.Text += "km to mile:" + float.Parse(input2) * 0.621371 + "\n";
                    }
                    else
                    {
                        var input2 = rtbInput2.Text;

                        rtbOutput.Text += "inch to meter: " + float.Parse(input2) * 0.0254 + "\n";
                    }
                }   
            }
            else
            {
                rtbOutput.Text = "please put a number in input 2. \n";
            }
        }

        private void rtbInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
        }
    }
}
