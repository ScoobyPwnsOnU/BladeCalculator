using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BladeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                ValOptAtk.ReadOnly = false;
            }
            else
            {
                ValOptAtk.ReadOnly = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                ValSOptAtk.ReadOnly = false;
            }
            else
            {
                ValSOptAtk.ReadOnly = true;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                ValHOptAtk.ReadOnly = false;
            }
            else
            {
                ValHOptAtk.ReadOnly = true;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                ValCDmg.ReadOnly = false;
            }
            else
            {
                ValCDmg.ReadOnly = true;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox5.Checked == true)
            {
                ValSCDmg.ReadOnly = false;
            }
            else
            {
                ValSCDmg.ReadOnly = true;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox6.Checked == true)
            {
                ValHCDmg.ReadOnly = false;
            }
            else
            {
                ValHCDmg.ReadOnly = true;
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked == true)
            {
                ValODef.ReadOnly = false;
            }
            else
            {
                ValODef.ReadOnly = true;
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked == true)
            {
                ValOHP.ReadOnly = false;
            }
            else
            {
                ValOHP.ReadOnly = true;
            }
        }

        private void CurOptAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurSOptAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurHOptAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurCDmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurSCDmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurHCDmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurODef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurOHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValOptAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValSOptAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValHOptAtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValCDmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValSCDmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValHCDmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValODef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ValOHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CurOptAtk_TextChanged(object sender, EventArgs e)
        {
            if(CurOptAtk.Text == "")
            {
                CurOptAtk.Text = "0";
            }
        }

        private void CurSOptAtk_TextChanged(object sender, EventArgs e)
        {
            if (CurSOptAtk.Text == "")
            {
                CurSOptAtk.Text = "0";
            }
        }

        private void CurHOptAtk_TextChanged(object sender, EventArgs e)
        {
            if (CurHOptAtk.Text == "")
            {
                CurHOptAtk.Text = "0";
            }
        }

        private void CurCDmg_TextChanged(object sender, EventArgs e)
        {
            if (CurCDmg.Text == "")
            {
                CurCDmg.Text = "0";
            }
        }

        private void CurSCDmg_TextChanged(object sender, EventArgs e)
        {
            if (CurSCDmg.Text == "")
            {
                CurSCDmg.Text = "0";
            }
        }

        private void CurHCDmg_TextChanged(object sender, EventArgs e)
        {
            if (CurHCDmg.Text == "")
            {
                CurHCDmg.Text = "0";
            }
        }

        private void CurODef_TextChanged(object sender, EventArgs e)
        {
            if (CurODef.Text == "")
            {
                CurODef.Text = "0";
            }
        }

        private void CurOHP_TextChanged(object sender, EventArgs e)
        {
            if (CurOHP.Text == "")
            {
                CurOHP.Text = "0";
            }
        }

        private void ValOptAtk_TextChanged(object sender, EventArgs e)
        {
            if (ValOptAtk.Text == "")
            {
                ValOptAtk.Text = "0";
            }
        }

        private void ValSOptAtk_TextChanged(object sender, EventArgs e)
        {
            if (ValSOptAtk.Text == "")
            {
                ValSOptAtk.Text = "0";
            }
        }

        private void ValHOptAtk_TextChanged(object sender, EventArgs e)
        {
            if (ValHOptAtk.Text == "")
            {
                ValHOptAtk.Text = "0";
            }
        }

        private void ValCDmg_TextChanged(object sender, EventArgs e)
        {
            if (ValCDmg.Text == "")
            {
                ValCDmg.Text = "0";
            }
        }

        private void ValSCDmg_TextChanged(object sender, EventArgs e)
        {
            if (ValSCDmg.Text == "")
            {
                ValSCDmg.Text = "0";
            }
        }

        private void ValHCDmg_TextChanged(object sender, EventArgs e)
        {
            if (ValHCDmg.Text == "")
            {
                ValHCDmg.Text = "0";
            }
        }

        private void ValODef_TextChanged(object sender, EventArgs e)
        {
            if (ValODef.Text == "")
            {
                ValODef.Text = "0";
            }
        }

        private void ValOHP_TextChanged(object sender, EventArgs e)
        {
            if (ValOHP.Text == "")
            {
                ValOHP.Text = "0";
            }
        }

        private void CurOptAtk_Click(object sender, EventArgs e)
        {
            CurOptAtk.SelectAll();
            CurOptAtk.Focus();
        }

        private void CurSOptAtk_Click(object sender, EventArgs e)
        {
            CurSOptAtk.SelectAll();
            CurSOptAtk.Focus();
        }

        private void CurHOptAtk_Click(object sender, EventArgs e)
        {
            CurHOptAtk.SelectAll();
            CurHOptAtk.Focus();
        }

        private void CurCDmg_Click(object sender, EventArgs e)
        {
            CurCDmg.SelectAll();
            CurCDmg.Focus();
        }

        private void CurSCDmg_Click(object sender, EventArgs e)
        {
            CurSCDmg.SelectAll();
            CurSCDmg.Focus();
        }

        private void CurHCDmg_Click(object sender, EventArgs e)
        {
            CurHCDmg.SelectAll();
            CurHCDmg.Focus();
        }

        private void CurODef_Click(object sender, EventArgs e)
        {
            CurODef.SelectAll();
            CurODef.Focus();
        }

        private void CurOHP_Click(object sender, EventArgs e)
        {
            CurOHP.SelectAll();
            CurOHP.Focus();
        }

        private void ValOptAtk_Click(object sender, EventArgs e)
        {
            ValOptAtk.SelectAll();
            ValOptAtk.Focus();
        }

        private void ValSOptAtk_Click(object sender, EventArgs e)
        {
            ValSOptAtk.SelectAll();
            ValSOptAtk.Focus();
        }

        private void ValHOptAtk_Click(object sender, EventArgs e)
        {
            ValHOptAtk.SelectAll();
            ValHOptAtk.Focus();
        }

        private void ValCDmg_Click(object sender, EventArgs e)
        {
            ValCDmg.SelectAll();
            ValCDmg.Focus();
        }

        private void ValSCDmg_Click(object sender, EventArgs e)
        {
            ValSCDmg.SelectAll();
            ValSCDmg.Focus();
        }

        private void ValHCDmg_Click(object sender, EventArgs e)
        {
            ValHCDmg.SelectAll();
            ValHCDmg.Focus();
        }

        private void ValODef_Click(object sender, EventArgs e)
        {
            ValODef.SelectAll();
            ValODef.Focus();
        }

        private void ValOHP_Click(object sender, EventArgs e)
        {
            ValOHP.SelectAll();
            ValOHP.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            float maxValue = 0;
            GainOptAtk.ResetBackColor();
            GainSOptAtk.ResetBackColor();
            GainHOptAtk.ResetBackColor();
            GainCDmg.ResetBackColor();
            GainSCDmg.ResetBackColor();
            GainHCDmg.ResetBackColor();
            GainODef.ResetBackColor();
            GainOHP.ResetBackColor();
            if (CheckBox1.Checked == true)
            {
                if(CurOptAtk.Text != "0")
                {
                    GainOptAtk.Text = Convert.ToString((Single.Parse(ValOptAtk.Text) / Single.Parse(CurOptAtk.Text)) * 100);
                }
                else
                {
                    GainOptAtk.Text = "0";
                }

                if(Single.Parse(GainOptAtk.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainOptAtk.Text);
                }
            }
            else
            {
                GainOptAtk.Text = "0";
            }

            if (CheckBox2.Checked == true)
            {
                if (CurSOptAtk.Text != "0")
                {
                    GainSOptAtk.Text = Convert.ToString((Single.Parse(ValSOptAtk.Text) / Single.Parse(CurSOptAtk.Text)) * 100);
                }
                else
                {
                    GainSOptAtk.Text = "0";
                }

                if (Single.Parse(GainSOptAtk.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainSOptAtk.Text);
                }
            }
            else
            {
                GainSOptAtk.Text = "0";
            }

            if (CheckBox3.Checked == true)
            {
                if (CurHOptAtk.Text != "0")
                {
                    GainHOptAtk.Text = Convert.ToString((Single.Parse(ValHOptAtk.Text) / Single.Parse(CurHOptAtk.Text)) * 100);
                }
                else
                {
                    GainHOptAtk.Text = "0";
                }

                if (Single.Parse(GainHOptAtk.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainHOptAtk.Text);
                }
            }
            else
            {
                GainHOptAtk.Text = "0";
            }

            if (CheckBox4.Checked == true)
            {
                if (CurCDmg.Text != "0")
                {
                    GainCDmg.Text = Convert.ToString((Single.Parse(ValCDmg.Text) / Single.Parse(CurCDmg.Text)) * 100);
                }
                else
                {
                    GainCDmg.Text = "0";
                }

                if (Single.Parse(GainCDmg.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainCDmg.Text);
                }
            }
            else
            {
                GainCDmg.Text = "0";
            }

            if (CheckBox5.Checked == true)
            {
                if (CurSCDmg.Text != "0")
                {
                    GainSCDmg.Text = Convert.ToString((Single.Parse(ValSCDmg.Text) / Single.Parse(CurSCDmg.Text)) * 100);
                }
                else
                {
                    GainSCDmg.Text = "0";
                }

                if (Single.Parse(GainSCDmg.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainSCDmg.Text);
                }
            }
            else
            {
                GainSCDmg.Text = "0";
            }

            if (CheckBox6.Checked == true)
            {
                if (CurHCDmg.Text != "0")
                {
                    GainHCDmg.Text = Convert.ToString((Single.Parse(ValHCDmg.Text) / Single.Parse(CurHCDmg.Text)) * 100);
                }
                else
                {
                    GainHCDmg.Text = "0";
                }

                if (Single.Parse(GainHCDmg.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainHCDmg.Text);
                }
            }
            else
            {
                GainHCDmg.Text = "0";
            }

            if (CheckBox7.Checked == true)
            {
                if (CurODef.Text != "0")
                {
                    GainODef.Text = Convert.ToString((Single.Parse(ValODef.Text) / Single.Parse(CurODef.Text)) * 100);
                }
                else
                {
                    GainODef.Text = "0";
                }

                if (Single.Parse(GainODef.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainODef.Text);
                }
            }
            else
            {
                GainODef.Text = "0";
            }

            if (CheckBox8.Checked == true)
            {
                if (CurOHP.Text != "0")
                {
                    GainOHP.Text = Convert.ToString((Single.Parse(ValOHP.Text) / Single.Parse(CurOHP.Text)) * 100);
                }
                else
                {
                    GainOHP.Text = "0";
                }

                if (Single.Parse(GainOHP.Text) >= maxValue)
                {
                    maxValue = Single.Parse(GainOHP.Text);
                }
            }
            else
            {
                GainOHP.Text = "0";
            }

            if (maxValue != 0)
            {
                if(Single.Parse(GainOptAtk.Text) == maxValue)
                {
                    GainOptAtk.BackColor = Color.Green;
                }
                else
                {
                    GainOptAtk.ResetBackColor();
                }

                if (Single.Parse(GainSOptAtk.Text) == maxValue)
                {
                    GainSOptAtk.BackColor = Color.Green;
                }
                else
                {
                    GainSOptAtk.ResetBackColor();
                }

                if (Single.Parse(GainHOptAtk.Text) == maxValue)
                {
                    GainHOptAtk.BackColor = Color.Green;
                }
                else
                {
                    GainHOptAtk.ResetBackColor();
                }

                if (Single.Parse(GainCDmg.Text) == maxValue)
                {
                    GainCDmg.BackColor = Color.Green;
                }
                else
                {
                    GainCDmg.ResetBackColor();
                }

                if (Single.Parse(GainSCDmg.Text) == maxValue)
                {
                    GainSCDmg.BackColor = Color.Green;
                }
                else
                {
                    GainSCDmg.ResetBackColor();
                }

                if (Single.Parse(GainHCDmg.Text) == maxValue)
                {
                    GainHCDmg.BackColor = Color.Green;
                }
                else
                {
                    GainHCDmg.ResetBackColor();
                }

                if (Single.Parse(GainODef.Text) == maxValue)
                {
                    GainODef.BackColor = Color.Green;
                }
                else
                {
                    GainODef.ResetBackColor();
                }

                if (Single.Parse(GainOHP.Text) == maxValue)
                {
                    GainOHP.BackColor = Color.Green;
                }
                else
                {
                    GainOHP.ResetBackColor();
                }
            }
            else
            {
                GainOptAtk.ResetBackColor();
                GainSOptAtk.ResetBackColor();
                GainHOptAtk.ResetBackColor();
                GainCDmg.ResetBackColor();
                GainSCDmg.ResetBackColor();
                GainHCDmg.ResetBackColor();
                GainODef.ResetBackColor();
                GainOHP.ResetBackColor();
            }
        }
        private void Add1_Click(object sender, EventArgs e)
        {
            CurOptAtk.Text = Convert.ToString(Single.Parse(CurOptAtk.Text) + Single.Parse(ValOptAtk.Text));
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            CurSOptAtk.Text = Convert.ToString(Single.Parse(CurSOptAtk.Text) + Single.Parse(ValSOptAtk.Text));
        }

        private void Add3_Click(object sender, EventArgs e)
        {
            CurHOptAtk.Text = Convert.ToString(Single.Parse(CurHOptAtk.Text) + Single.Parse(ValHOptAtk.Text));
        }

        private void Add4_Click(object sender, EventArgs e)
        {
            CurCDmg.Text = Convert.ToString(Single.Parse(CurCDmg.Text) + Single.Parse(ValCDmg.Text));
        }

        private void Add5_Click(object sender, EventArgs e)
        {
            CurSCDmg.Text = Convert.ToString(Single.Parse(CurSCDmg.Text) + Single.Parse(ValSCDmg.Text));
        }

        private void Add6_Click(object sender, EventArgs e)
        {
            CurHCDmg.Text = Convert.ToString(Single.Parse(CurHCDmg.Text) + Single.Parse(ValHCDmg.Text));
        }

        private void Add7_Click(object sender, EventArgs e)
        {
            CurODef.Text = Convert.ToString(Single.Parse(CurODef.Text) + Single.Parse(ValODef.Text));
        }

        private void Add8_Click(object sender, EventArgs e)
        {
            CurOHP.Text = Convert.ToString(Single.Parse(CurOHP.Text) + Single.Parse(ValOHP.Text));
        }
    }
}
