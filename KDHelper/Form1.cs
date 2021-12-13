using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void currentKdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                currentKdValueLbl.Text = (killsInput.Value / deathsInput.Value).ToString("0.00");
            }
            catch(DivideByZeroException ex)
            {
                currentKdValueLbl.Text = "Never died";
            }
            catch
            {
                currentKdValueLbl.Text = "Error";
            }
        }

        private void desiredKdBtn_Click(object sender, EventArgs e)
        {
            
            

            if (deathsInput.Value == 0)
            {
                killsNeededValueLbl.Text = "Never died";
            }
            else
            {
                decimal ckd = Math.Round(killsInput.Value / deathsInput.Value, 2);
                decimal dkd = Math.Round(desiredKdInput.Value, 2);

                if (ckd == dkd)
                {
                    killsNeededValueLbl.Text = "Same KD";
                }
                else if (dkd == 0)
                {
                    killsNeededValueLbl.Text = "KD can't be 0";
                }
                else
                {
                    killsNeededLbl.Text = ckd > dkd ? "Deaths needed: " : "Kills needed: ";
                    try
                    {
                        decimal kdn = ckd > dkd ? Math.Ceiling(killsInput.Value / dkd) : Math.Ceiling(deathsInput.Value * desiredKdInput.Value);
                        killsNeededValueLbl.Text = ckd > dkd ? kdn.ToString() + $" (+{kdn-deathsInput.Value})" : kdn.ToString() + $" (+{kdn - killsInput.Value})";
                    }
                    catch
                    {
                        killsNeededValueLbl.Text = "Error";
                    }
                }
            }
        }
    }
}
