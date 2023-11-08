using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            // check if both boxes are empty
            if (rtbInput1.Text == "" && rtbInput2.Text == "")
            {
                rtbOutput.Text = "please type something in atleast one of the input boxes. \n";
            }
            // check if both boxes are NOT empty, then run the code
            else if (rtbInput1.Text != "" && rtbInput2.Text != "")
            {
                if (rdoCtoF.Checked == true)
                {
                    var hold = float.Parse(rtbInput1.Text);
                    var hold2 = float.Parse(rtbInput2.Text);

                    rtbOutput.Text += (hold * 9 / 5) + 32 + " °F \n";

                    rtbOutput.Text += (hold2 * 9 / 5) + 32 + " °F \n";
                }
                else
                {
                    var hold = float.Parse(rtbInput1.Text);
                    var hold2 = float.Parse(rtbInput2.Text);

                    rtbOutput.Text += (hold - 32) * 5 / 9 + " C° \n";
                    rtbOutput.Text += (hold2 - 32) * 5 / 9 + " C° \n";
                }
            }

            // check if only one of the boxes has a number. i think i can do this easier but idk how
            else if (rtbInput1.Text != "")
            {
                if (rdoCtoF.Checked == true)
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
                if (rdoCtoF.Checked == true)
                {
                    var hold = float.Parse(rtbInput2.Text);

                    rtbOutput.Text += (hold * 9 / 5) + 32 + " °F \n";
                }
                else
                {
                    var hold = float.Parse(rtbInput2.Text);

                    rtbOutput.Text += (hold - 32) * 5 / 9 + " C° \n";
                }
            }
            
            
            /* if (rtbInput1.Text == "" && rtbInput2.Text == "") 
            {
                rtbOutput.Text = "please put a number in atleast one input box. \n";
            }
            else if (rtbInput1.Text != "")
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
             */
        }

        private void moneyFunction(object sender, EventArgs e)
        {
            var input = rtbInput1.Text;
            var input2 = rtbInput2.Text;

            // if cmbmoney's selected item is (this), then do it's appropriate conversion from this (money) to this (money) / currency
            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Yen")
            {
                rtbOutput.Text += float.Parse(input) * 149.77 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen-Dollar")
            {
                rtbOutput.Text += float.Parse(input) * 0.006674 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Euro")
            {
                rtbOutput.Text += float.Parse(input) * 0.93 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Euro-Dollar")
            {
                rtbOutput.Text += float.Parse(input) * 1.07 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Euro-Pound")
            {
                rtbOutput.Text += float.Parse(input) * 0.87 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Pound-Euro")
            {
                rtbOutput.Text += float.Parse(input) * 1.15 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Reais")
            {
                rtbOutput.Text += float.Parse(input) * 4.90 + "\n";
            }
            else
            {
                rtbOutput.Text += float.Parse(input) * 0.20 + "\n";
            }

            // same thingg but for input 2
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

        private void moneyFunction1(object sender, EventArgs e)
        {
            var input = rtbInput1.Text;

            // if cmbmoney's selected item is (this), then do it's appropriate conversion from this (money) to this (money) / currency
            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Yen")
            {
                rtbOutput.Text += float.Parse(input) * 149.77 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen-Dollar")
            {
                rtbOutput.Text += float.Parse(input) * 0.006674 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Euro")
            {
                rtbOutput.Text += float.Parse(input) * 0.93 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Euro-Dollar")
            {
                rtbOutput.Text += float.Parse(input) * 1.07 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Euro-Pound")
            {
                rtbOutput.Text += float.Parse(input) * 0.87 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Pound-Euro")
            {
                rtbOutput.Text += float.Parse(input) * 1.15 + "\n";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar-Reais")
            {
                rtbOutput.Text += float.Parse(input) * 4.90 + "\n";
            }
            else
            {
                rtbOutput.Text += float.Parse(input) * 0.20 + "\n";
            }
        }

        private void moneyFunction2(object sender, EventArgs e)
        {
            var input2 = rtbInput2.Text;

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

        
        private void btnMoney_Click(object sender, EventArgs e)
        {
            // if BOTH input boxes are empty, run this code (the functions for moneyFunction are right above this)
            if (rtbInput1.Text == "" && rtbInput2.Text == "")
            {
                rtbOutput.Text = "please put a number in atleast one of the input boxes. \n\n";
            }
            // if both boxes are NOT empty, run this code
            else if (rtbInput1.Text != "" && rtbInput2.Text != "")
            {
                moneyFunction(sender, e);
            }
            else if (rtbInput1.Text != "")
            {
                moneyFunction1(sender, e);
            }
            else
            {
                moneyFunction2(sender, e);
            }
                    
        }

        private void functionDistance(object sender, EventArgs e)
        {
            if (chkMileToKilo.Checked == false && chkMeterToInch.Checked == false)
            {
                rtbOutput.Text = "please choose atleast one top checkmark. \n";
            }
            else
            {
                if (chkMileToKilo.Checked == true && chkMeterToInch.Checked == true)
                {
                    var input1 = rtbInput1.Text;
                    var input2 = rtbInput2.Text;

                    rtbOutput.Text += "mile to km: " + float.Parse(input1) * 1.60934 + "\n" + "meter to inch: " + float.Parse(input1) * 39.3701 + "\n";
                    rtbOutput.Text += "mile to km: " + float.Parse(input2) * 1.60934 + "\n" + "meter to inch: " + float.Parse(input2) * 39.3701 + "\n";
                }
                else if (chkMileToKilo.Checked == true)
                {
                    var input1 = rtbInput1.Text;
                    var input2 = rtbInput2.Text;

                    rtbOutput.Text += "mile to km:" + float.Parse(input1) * 1.60934 + "\n";
                    rtbOutput.Text += "mile to km:" + float.Parse(input2) * 1.60934 + "\n";
                }
                else
                {
                    var input1 = rtbInput1.Text;
                    var input2 = rtbInput2.Text;

                    rtbOutput.Text += "meter to inch: " + float.Parse(input1) * 39.3701 + "\n";
                    rtbOutput.Text += "meter to inch: " + float.Parse(input2) * 39.3701 + "\n";
                }           
            }
        }

        private void functionDistance1(object sender, EventArgs e)
        {
            if (chkMileToKilo.Checked == false && chkMeterToInch.Checked == false)
            {
                rtbOutput.Text = "please choose atleast one top checkmark. \n";
            }
            else
            {
                if (chkMileToKilo.Checked == true && chkMeterToInch.Checked == true)
                {
                    var input1 = rtbInput1.Text;

                    rtbOutput.Text += "mile to km: " + float.Parse(input1) * 1.60934 + "\n" + "meter to inch: " + float.Parse(input1) * 39.3701 + "\n";
                }
                else if (chkMileToKilo.Checked == true)
                {
                    var input1 = rtbInput1.Text;

                    rtbOutput.Text += "mile to km:" + float.Parse(input1) * 1.60934 + "\n";
                }
                else
                {
                    var input1 = rtbInput1.Text;

                    rtbOutput.Text += "meter to inch: " + float.Parse(input1) * 39.3701 + "\n";
                }
            }
        }

        private void functionDistance2(object sender, EventArgs e)
        {
            if (chkMileToKilo.Checked == false && chkMeterToInch.Checked == false)
            {
                rtbOutput.Text = "please choose atleast one top checkmark. \n";
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

        private void btnDistance_Click(object sender, EventArgs e)
        {
            //if both empty do this
            if (rtbInput1.Text == "" && rtbInput2.Text == "")
            {
                rtbOutput.Text = "please put a number in atleast one of the input boxes. \n\n";
            }
            // if both boxes are NOT empty, run this code (all three functions are once again on top of this)
            else if (rtbInput1.Text != "" && rtbInput2.Text != "")
            {
                functionDistance(sender, e);
            }
            else if (rtbInput1.Text != "")
            {
                functionDistance1(sender, e);
            }
            else
            {
                functionDistance2(sender, e);
            }
        }

        private void functionDistance3(object sender, EventArgs e)
        {
            if (chkKiloToMiles.Checked == false && chkInchToMeter.Checked == false)
            {
                rtbOutput.Text = "please choose atleast one bottom checkmark. \n";
            }
            else
            {
                if (chkKiloToMiles.Checked == true && chkInchToMeter.Checked == true)
                {
                    var input1 = rtbInput1.Text;
                    var input2 = rtbInput2.Text;

                    rtbOutput.Text += "km to mile: " + float.Parse(input1) * 0.621371 + "\n" + "inch to meter: " + float.Parse(input1) * 0.0254 + "\n";
                    rtbOutput.Text += "km to mile: " + float.Parse(input2) * 0.621371 + "\n" + "inch to meter: " + float.Parse(input2) * 0.0254 + "\n";
                }
                else if (chkKiloToMiles.Checked == true)
                {
                    var input1 = rtbInput1.Text;
                    var input2 = rtbInput2.Text;

                    rtbOutput.Text += "km to mile: " + float.Parse(input1) * 0.621371 + "\n";
                    rtbOutput.Text += "km to mile: " + float.Parse(input2) * 0.621371 + "\n";
                }
                else
                {
                    var input1 = rtbInput1.Text;
                    var input2 = rtbInput2.Text;

                    rtbOutput.Text += "inch to meter: " + float.Parse(input1) * 0.0254 + "\n";
                    rtbOutput.Text += "inch to meter: " + float.Parse(input2) * 0.0254 + "\n";
                }
            }
        }

        private void functionDistance4(object sender, EventArgs e)
        {
            if (chkKiloToMiles.Checked == false && chkInchToMeter.Checked == false)
            {
                rtbOutput.Text = "please choose atleast one bottom checkmark. \n";
            }
            else
            {
                if (chkKiloToMiles.Checked == true && chkInchToMeter.Checked == true)
                {
                    var input1 = rtbInput1.Text;

                    rtbOutput.Text += "km to mile: " + float.Parse(input1) * 0.621371 + "\n" + "inch to meter: " + float.Parse(input1) * 0.0254 + "\n";
                }
                else if (chkKiloToMiles.Checked == true)
                {
                    var input1 = rtbInput1.Text;

                    rtbOutput.Text += "km to mile: " + float.Parse(input1) * 0.621371 + "\n";
                }
                else
                {
                    var input1 = rtbInput1.Text;

                    rtbOutput.Text += "inch to meter: " + float.Parse(input1) * 0.0254 + "\n";
                }
            }
        }

        private void functionDistance5(object sender, EventArgs e)
        {
            if (rtbInput2.Text != "")
            {
                if (chkKiloToMiles.Checked == false && chkInchToMeter.Checked == false)
                {
                    rtbOutput.Text = "please choose atleast one bottom checkmark. \n";
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
        }

        private void btnDistance2_Click(object sender, EventArgs e)
        {
            //if both empty do this
            if (rtbInput1.Text == "" && rtbInput2.Text == "")
            {
                rtbOutput.Text = "please put a number in atleast one of the input boxes. \n\n";
            }
            // if both boxes are NOT empty, run this code (all three functions are once again on top of this)
            else if (rtbInput1.Text != "" && rtbInput2.Text != "")
            {
                functionDistance3(sender, e);
            }
            else if (rtbInput1.Text != "")
            {
                functionDistance4(sender, e);
            }
            else
            {
                functionDistance5(sender, e);
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

        private void btnText_Click(object sender, EventArgs e)
        {
            string file = "c:\\Users\\Ryan Oliveira\\source\\repos\\weekofnov6th-ryanhamburger\\WeekOfNov6th\\bin\\test.txt";
            string whatsinthefile = File.ReadAllText(file);
            string[] thingy = whatsinthefile.Split(' ');
            string inputone = rtbInput1.Text + rtbInput2.Text;
            int theotherinput = int.Parse(inputone);

            if (rtbInput2.Text != "")
            {
               for (int i = 0; i < thingy.Length; i += theotherinput)
                {
                    rtbOutput.Text += thingy[i] + " ";
                } 
            }
            else
            {
                rtbOutput.Text = "please type something in input 2. \n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMoneyConverter.SelectedIndex = 0;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string file = "c:\\Users\\Ryan Oliveira\\source\\repos\\weekofnov6th-ryanhamburger\\WeekOfNov6th\\bin\\test.txt";
            string whatsinthefile = File.ReadAllText(file);

            rtbOutput.Text = whatsinthefile;
        }

        private void btnWednesday_Click(object sender, EventArgs e)
        {
            bool done = false;
            string alpha = "a b c d e f g i j k l m n o p q r s t u v w x y z ";
            string[] alphabet = alpha.Split(' ');
            string print = "";

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i].Contains("a"))
                {
                    print = alphabet[i].Replace("a", "A");
                }
                else if (alphabet[i].Contains("e"))
                {
                    print = alphabet[i].Replace("e", "E");
                }
                else if (alphabet[i].Contains("i"))
                {
                    print = alphabet[i].Replace("i", "I");
                }
                else if (alphabet[i].Contains("o"))
                {
                    print = alphabet[i].Replace("o", "O");
                }
                else if (alphabet[i].Contains("u"))
                {
                    print = alphabet[i].Replace("u", "U");
                }
                else
                {
                    print = alphabet[i];
                }
                rtbOutput.Text += print;
            }
            rtbOutput.Text += "\n";


            while (done == false)
            {
                for (int i = alphabet.Length - 1; i >= 0; i--)
                {


                   /* if (i == 4 || i == 9 || i == 14 || i == 19 || i == 24)
                    {
                        rtbOutput.Text += ", ";
                    }
                    if (i == 4 || i == 14 || i == 24)
                    {
                        rtbOutput.Text += alphabet[i].ToUpper();
                    }
                    else
                    {
                        rtbOutput.Text += alphabet[i];
                    } */

                }
                rtbOutput.Text += "\n";
                done = true; 
            }

            /*             for (int i = FirstStrArray.Length-1; i >= 0; i--)
            {
                if (i != FirstStrArray.Length - 1)
                {
                    richBoxOutput.Text += ",";
                }
                richBoxOutput.Text += FirstStrArray[i];
            }
            richBoxOutput.Text += "\n";

            */


            // comma

            /*                 if (i != 0)
                {
                    rtbOutput.Text += ",";
                }

            */

            /* String[] alphabet2 = new string[alphabet.Length + 1];
            rtbOutput.Text += alphabet2; */
        }
    }
}
