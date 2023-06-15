
namespace BladeCalculator
{
    partial class Form1
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
            this.CurOptAtk = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CurSOptAtk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurHOptAtk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CurHCDmg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurSCDmg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurCDmg = new System.Windows.Forms.TextBox();
            this.ValHCDmg = new System.Windows.Forms.TextBox();
            this.ValSCDmg = new System.Windows.Forms.TextBox();
            this.ValCDmg = new System.Windows.Forms.TextBox();
            this.ValHOptAtk = new System.Windows.Forms.TextBox();
            this.ValSOptAtk = new System.Windows.Forms.TextBox();
            this.ValOptAtk = new System.Windows.Forms.TextBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.GainHCDmg = new System.Windows.Forms.TextBox();
            this.GainSCDmg = new System.Windows.Forms.TextBox();
            this.GainCDmg = new System.Windows.Forms.TextBox();
            this.GainHOptAtk = new System.Windows.Forms.TextBox();
            this.GainSOptAtk = new System.Windows.Forms.TextBox();
            this.GainOptAtk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GainOHP = new System.Windows.Forms.TextBox();
            this.GainODef = new System.Windows.Forms.TextBox();
            this.CheckBox8 = new System.Windows.Forms.CheckBox();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.ValOHP = new System.Windows.Forms.TextBox();
            this.ValODef = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CurOHP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CurODef = new System.Windows.Forms.TextBox();
            this.Add1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Add2 = new System.Windows.Forms.Button();
            this.Add3 = new System.Windows.Forms.Button();
            this.Add4 = new System.Windows.Forms.Button();
            this.Add5 = new System.Windows.Forms.Button();
            this.Add6 = new System.Windows.Forms.Button();
            this.Add7 = new System.Windows.Forms.Button();
            this.Add8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurOptAtk
            // 
            this.CurOptAtk.Location = new System.Drawing.Point(197, 120);
            this.CurOptAtk.Name = "CurOptAtk";
            this.CurOptAtk.Size = new System.Drawing.Size(100, 20);
            this.CurOptAtk.TabIndex = 0;
            this.CurOptAtk.Text = "0";
            this.CurOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurOptAtk.Click += new System.EventHandler(this.CurOptAtk_Click);
            this.CurOptAtk.TextChanged += new System.EventHandler(this.CurOptAtk_TextChanged);
            this.CurOptAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurOptAtk_KeyPress);
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(15, 329);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(706, 55);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Values";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(421, 123);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blade Idle Option Comparison Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Option Values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Option Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Super Option Attack";
            // 
            // CurSOptAtk
            // 
            this.CurSOptAtk.Location = new System.Drawing.Point(197, 146);
            this.CurSOptAtk.Name = "CurSOptAtk";
            this.CurSOptAtk.Size = new System.Drawing.Size(100, 20);
            this.CurSOptAtk.TabIndex = 7;
            this.CurSOptAtk.Text = "0";
            this.CurSOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurSOptAtk.Click += new System.EventHandler(this.CurSOptAtk_Click);
            this.CurSOptAtk.TextChanged += new System.EventHandler(this.CurSOptAtk_TextChanged);
            this.CurSOptAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurSOptAtk_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hyper Option Attack";
            // 
            // CurHOptAtk
            // 
            this.CurHOptAtk.Location = new System.Drawing.Point(197, 172);
            this.CurHOptAtk.Name = "CurHOptAtk";
            this.CurHOptAtk.Size = new System.Drawing.Size(100, 20);
            this.CurHOptAtk.TabIndex = 9;
            this.CurHOptAtk.Text = "0";
            this.CurHOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurHOptAtk.Click += new System.EventHandler(this.CurHOptAtk_Click);
            this.CurHOptAtk.TextChanged += new System.EventHandler(this.CurHOptAtk_TextChanged);
            this.CurHOptAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurHOptAtk_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hyper Crit Damage";
            // 
            // CurHCDmg
            // 
            this.CurHCDmg.Location = new System.Drawing.Point(197, 250);
            this.CurHCDmg.Name = "CurHCDmg";
            this.CurHCDmg.Size = new System.Drawing.Size(100, 20);
            this.CurHCDmg.TabIndex = 15;
            this.CurHCDmg.Text = "0";
            this.CurHCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurHCDmg.Click += new System.EventHandler(this.CurHCDmg_Click);
            this.CurHCDmg.TextChanged += new System.EventHandler(this.CurHCDmg_TextChanged);
            this.CurHCDmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurHCDmg_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Super Crit Damage";
            // 
            // CurSCDmg
            // 
            this.CurSCDmg.Location = new System.Drawing.Point(197, 224);
            this.CurSCDmg.Name = "CurSCDmg";
            this.CurSCDmg.Size = new System.Drawing.Size(100, 20);
            this.CurSCDmg.TabIndex = 13;
            this.CurSCDmg.Text = "0";
            this.CurSCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurSCDmg.Click += new System.EventHandler(this.CurSCDmg_Click);
            this.CurSCDmg.TextChanged += new System.EventHandler(this.CurSCDmg_TextChanged);
            this.CurSCDmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurSCDmg_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Crit Damage";
            // 
            // CurCDmg
            // 
            this.CurCDmg.Location = new System.Drawing.Point(197, 198);
            this.CurCDmg.Name = "CurCDmg";
            this.CurCDmg.Size = new System.Drawing.Size(100, 20);
            this.CurCDmg.TabIndex = 11;
            this.CurCDmg.Text = "0";
            this.CurCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurCDmg.Click += new System.EventHandler(this.CurCDmg_Click);
            this.CurCDmg.TextChanged += new System.EventHandler(this.CurCDmg_TextChanged);
            this.CurCDmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurCDmg_KeyPress);
            // 
            // ValHCDmg
            // 
            this.ValHCDmg.Location = new System.Drawing.Point(442, 250);
            this.ValHCDmg.Name = "ValHCDmg";
            this.ValHCDmg.ReadOnly = true;
            this.ValHCDmg.Size = new System.Drawing.Size(100, 20);
            this.ValHCDmg.TabIndex = 22;
            this.ValHCDmg.Text = "0";
            this.ValHCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValHCDmg.Click += new System.EventHandler(this.ValHCDmg_Click);
            this.ValHCDmg.TextChanged += new System.EventHandler(this.ValHCDmg_TextChanged);
            this.ValHCDmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValHCDmg_KeyPress);
            // 
            // ValSCDmg
            // 
            this.ValSCDmg.Location = new System.Drawing.Point(442, 224);
            this.ValSCDmg.Name = "ValSCDmg";
            this.ValSCDmg.ReadOnly = true;
            this.ValSCDmg.Size = new System.Drawing.Size(100, 20);
            this.ValSCDmg.TabIndex = 21;
            this.ValSCDmg.Text = "0";
            this.ValSCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValSCDmg.Click += new System.EventHandler(this.ValSCDmg_Click);
            this.ValSCDmg.TextChanged += new System.EventHandler(this.ValSCDmg_TextChanged);
            this.ValSCDmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValSCDmg_KeyPress);
            // 
            // ValCDmg
            // 
            this.ValCDmg.Location = new System.Drawing.Point(442, 198);
            this.ValCDmg.Name = "ValCDmg";
            this.ValCDmg.ReadOnly = true;
            this.ValCDmg.Size = new System.Drawing.Size(100, 20);
            this.ValCDmg.TabIndex = 20;
            this.ValCDmg.Text = "0";
            this.ValCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValCDmg.Click += new System.EventHandler(this.ValCDmg_Click);
            this.ValCDmg.TextChanged += new System.EventHandler(this.ValCDmg_TextChanged);
            this.ValCDmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValCDmg_KeyPress);
            // 
            // ValHOptAtk
            // 
            this.ValHOptAtk.Location = new System.Drawing.Point(442, 172);
            this.ValHOptAtk.Name = "ValHOptAtk";
            this.ValHOptAtk.ReadOnly = true;
            this.ValHOptAtk.Size = new System.Drawing.Size(100, 20);
            this.ValHOptAtk.TabIndex = 19;
            this.ValHOptAtk.Text = "0";
            this.ValHOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValHOptAtk.Click += new System.EventHandler(this.ValHOptAtk_Click);
            this.ValHOptAtk.TextChanged += new System.EventHandler(this.ValHOptAtk_TextChanged);
            this.ValHOptAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValHOptAtk_KeyPress);
            // 
            // ValSOptAtk
            // 
            this.ValSOptAtk.Location = new System.Drawing.Point(442, 146);
            this.ValSOptAtk.Name = "ValSOptAtk";
            this.ValSOptAtk.ReadOnly = true;
            this.ValSOptAtk.Size = new System.Drawing.Size(100, 20);
            this.ValSOptAtk.TabIndex = 18;
            this.ValSOptAtk.Text = "0";
            this.ValSOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValSOptAtk.Click += new System.EventHandler(this.ValSOptAtk_Click);
            this.ValSOptAtk.TextChanged += new System.EventHandler(this.ValSOptAtk_TextChanged);
            this.ValSOptAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValSOptAtk_KeyPress);
            // 
            // ValOptAtk
            // 
            this.ValOptAtk.Location = new System.Drawing.Point(442, 120);
            this.ValOptAtk.Name = "ValOptAtk";
            this.ValOptAtk.ReadOnly = true;
            this.ValOptAtk.Size = new System.Drawing.Size(100, 20);
            this.ValOptAtk.TabIndex = 17;
            this.ValOptAtk.Text = "0";
            this.ValOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValOptAtk.Click += new System.EventHandler(this.ValOptAtk_Click);
            this.ValOptAtk.TextChanged += new System.EventHandler(this.ValOptAtk_TextChanged);
            this.ValOptAtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValOptAtk_KeyPress);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(421, 149);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.CheckBox2.TabIndex = 23;
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(421, 175);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(15, 14);
            this.CheckBox3.TabIndex = 24;
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(421, 253);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(15, 14);
            this.CheckBox6.TabIndex = 27;
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(421, 227);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(15, 14);
            this.CheckBox5.TabIndex = 26;
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(421, 201);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(15, 14);
            this.CheckBox4.TabIndex = 25;
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // GainHCDmg
            // 
            this.GainHCDmg.Location = new System.Drawing.Point(607, 250);
            this.GainHCDmg.Name = "GainHCDmg";
            this.GainHCDmg.ReadOnly = true;
            this.GainHCDmg.Size = new System.Drawing.Size(100, 20);
            this.GainHCDmg.TabIndex = 35;
            this.GainHCDmg.Text = "0";
            this.GainHCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GainSCDmg
            // 
            this.GainSCDmg.Location = new System.Drawing.Point(607, 224);
            this.GainSCDmg.Name = "GainSCDmg";
            this.GainSCDmg.ReadOnly = true;
            this.GainSCDmg.Size = new System.Drawing.Size(100, 20);
            this.GainSCDmg.TabIndex = 34;
            this.GainSCDmg.Text = "0";
            this.GainSCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GainCDmg
            // 
            this.GainCDmg.Location = new System.Drawing.Point(607, 198);
            this.GainCDmg.Name = "GainCDmg";
            this.GainCDmg.ReadOnly = true;
            this.GainCDmg.Size = new System.Drawing.Size(100, 20);
            this.GainCDmg.TabIndex = 33;
            this.GainCDmg.Text = "0";
            this.GainCDmg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GainHOptAtk
            // 
            this.GainHOptAtk.Location = new System.Drawing.Point(607, 172);
            this.GainHOptAtk.Name = "GainHOptAtk";
            this.GainHOptAtk.ReadOnly = true;
            this.GainHOptAtk.Size = new System.Drawing.Size(100, 20);
            this.GainHOptAtk.TabIndex = 32;
            this.GainHOptAtk.Text = "0";
            this.GainHOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GainSOptAtk
            // 
            this.GainSOptAtk.Location = new System.Drawing.Point(607, 146);
            this.GainSOptAtk.Name = "GainSOptAtk";
            this.GainSOptAtk.ReadOnly = true;
            this.GainSOptAtk.Size = new System.Drawing.Size(100, 20);
            this.GainSOptAtk.TabIndex = 31;
            this.GainSOptAtk.Text = "0";
            this.GainSOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GainOptAtk
            // 
            this.GainOptAtk.BackColor = System.Drawing.SystemColors.Control;
            this.GainOptAtk.Location = new System.Drawing.Point(607, 120);
            this.GainOptAtk.Name = "GainOptAtk";
            this.GainOptAtk.ReadOnly = true;
            this.GainOptAtk.Size = new System.Drawing.Size(100, 20);
            this.GainOptAtk.TabIndex = 30;
            this.GainOptAtk.Text = "0";
            this.GainOptAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(569, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Gains Per Option";
            // 
            // GainOHP
            // 
            this.GainOHP.Location = new System.Drawing.Point(607, 302);
            this.GainOHP.Name = "GainOHP";
            this.GainOHP.ReadOnly = true;
            this.GainOHP.Size = new System.Drawing.Size(100, 20);
            this.GainOHP.TabIndex = 50;
            this.GainOHP.Text = "0";
            this.GainOHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GainODef
            // 
            this.GainODef.Location = new System.Drawing.Point(607, 276);
            this.GainODef.Name = "GainODef";
            this.GainODef.ReadOnly = true;
            this.GainODef.Size = new System.Drawing.Size(100, 20);
            this.GainODef.TabIndex = 49;
            this.GainODef.Text = "0";
            this.GainODef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CheckBox8
            // 
            this.CheckBox8.AutoSize = true;
            this.CheckBox8.Location = new System.Drawing.Point(421, 305);
            this.CheckBox8.Name = "CheckBox8";
            this.CheckBox8.Size = new System.Drawing.Size(15, 14);
            this.CheckBox8.TabIndex = 47;
            this.CheckBox8.UseVisualStyleBackColor = true;
            this.CheckBox8.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.Location = new System.Drawing.Point(421, 279);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(15, 14);
            this.CheckBox7.TabIndex = 46;
            this.CheckBox7.UseVisualStyleBackColor = true;
            this.CheckBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // ValOHP
            // 
            this.ValOHP.Location = new System.Drawing.Point(442, 302);
            this.ValOHP.Name = "ValOHP";
            this.ValOHP.ReadOnly = true;
            this.ValOHP.Size = new System.Drawing.Size(100, 20);
            this.ValOHP.TabIndex = 44;
            this.ValOHP.Text = "0";
            this.ValOHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValOHP.Click += new System.EventHandler(this.ValOHP_Click);
            this.ValOHP.TextChanged += new System.EventHandler(this.ValOHP_TextChanged);
            this.ValOHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValOHP_KeyPress);
            // 
            // ValODef
            // 
            this.ValODef.Location = new System.Drawing.Point(442, 276);
            this.ValODef.Name = "ValODef";
            this.ValODef.ReadOnly = true;
            this.ValODef.Size = new System.Drawing.Size(100, 20);
            this.ValODef.TabIndex = 43;
            this.ValODef.Text = "0";
            this.ValODef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValODef.Click += new System.EventHandler(this.ValODef_Click);
            this.ValODef.TextChanged += new System.EventHandler(this.ValODef_TextChanged);
            this.ValODef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValODef_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Option HP";
            // 
            // CurOHP
            // 
            this.CurOHP.Location = new System.Drawing.Point(197, 302);
            this.CurOHP.Name = "CurOHP";
            this.CurOHP.Size = new System.Drawing.Size(100, 20);
            this.CurOHP.TabIndex = 39;
            this.CurOHP.Text = "0";
            this.CurOHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurOHP.Click += new System.EventHandler(this.CurOHP_Click);
            this.CurOHP.TextChanged += new System.EventHandler(this.CurOHP_TextChanged);
            this.CurOHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurOHP_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Option Defense";
            // 
            // CurODef
            // 
            this.CurODef.Location = new System.Drawing.Point(197, 276);
            this.CurODef.Name = "CurODef";
            this.CurODef.Size = new System.Drawing.Size(100, 20);
            this.CurODef.TabIndex = 37;
            this.CurODef.Text = "0";
            this.CurODef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurODef.Click += new System.EventHandler(this.CurODef_Click);
            this.CurODef.TextChanged += new System.EventHandler(this.CurODef_TextChanged);
            this.CurODef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurODef_KeyPress);
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(321, 118);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(75, 23);
            this.Add1.TabIndex = 51;
            this.Add1.Text = "<-";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Add to Total";
            // 
            // Add2
            // 
            this.Add2.Location = new System.Drawing.Point(321, 144);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(75, 23);
            this.Add2.TabIndex = 53;
            this.Add2.Text = "<-";
            this.Add2.UseVisualStyleBackColor = true;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // Add3
            // 
            this.Add3.Location = new System.Drawing.Point(321, 170);
            this.Add3.Name = "Add3";
            this.Add3.Size = new System.Drawing.Size(75, 23);
            this.Add3.TabIndex = 54;
            this.Add3.Text = "<-";
            this.Add3.UseVisualStyleBackColor = true;
            this.Add3.Click += new System.EventHandler(this.Add3_Click);
            // 
            // Add4
            // 
            this.Add4.Location = new System.Drawing.Point(321, 196);
            this.Add4.Name = "Add4";
            this.Add4.Size = new System.Drawing.Size(75, 23);
            this.Add4.TabIndex = 55;
            this.Add4.Text = "<-";
            this.Add4.UseVisualStyleBackColor = true;
            this.Add4.Click += new System.EventHandler(this.Add4_Click);
            // 
            // Add5
            // 
            this.Add5.Location = new System.Drawing.Point(321, 222);
            this.Add5.Name = "Add5";
            this.Add5.Size = new System.Drawing.Size(75, 23);
            this.Add5.TabIndex = 56;
            this.Add5.Text = "<-";
            this.Add5.UseVisualStyleBackColor = true;
            this.Add5.Click += new System.EventHandler(this.Add5_Click);
            // 
            // Add6
            // 
            this.Add6.Location = new System.Drawing.Point(321, 248);
            this.Add6.Name = "Add6";
            this.Add6.Size = new System.Drawing.Size(75, 23);
            this.Add6.TabIndex = 57;
            this.Add6.Text = "<-";
            this.Add6.UseVisualStyleBackColor = true;
            this.Add6.Click += new System.EventHandler(this.Add6_Click);
            // 
            // Add7
            // 
            this.Add7.Location = new System.Drawing.Point(321, 274);
            this.Add7.Name = "Add7";
            this.Add7.Size = new System.Drawing.Size(75, 23);
            this.Add7.TabIndex = 58;
            this.Add7.Text = "<-";
            this.Add7.UseVisualStyleBackColor = true;
            this.Add7.Click += new System.EventHandler(this.Add7_Click);
            // 
            // Add8
            // 
            this.Add8.Location = new System.Drawing.Point(321, 300);
            this.Add8.Name = "Add8";
            this.Add8.Size = new System.Drawing.Size(75, 23);
            this.Add8.TabIndex = 59;
            this.Add8.Text = "<-";
            this.Add8.UseVisualStyleBackColor = true;
            this.Add8.Click += new System.EventHandler(this.Add8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(704, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(704, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(704, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 62;
            this.label16.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(704, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 63;
            this.label17.Text = "%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(704, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 17);
            this.label18.TabIndex = 64;
            this.label18.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(704, 251);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 65;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(704, 277);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 17);
            this.label20.TabIndex = 66;
            this.label20.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(704, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 17);
            this.label21.TabIndex = 67;
            this.label21.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(733, 396);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Add8);
            this.Controls.Add(this.Add7);
            this.Controls.Add(this.Add6);
            this.Controls.Add(this.Add5);
            this.Controls.Add(this.Add4);
            this.Controls.Add(this.Add3);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.GainOHP);
            this.Controls.Add(this.GainODef);
            this.Controls.Add(this.CheckBox8);
            this.Controls.Add(this.CheckBox7);
            this.Controls.Add(this.ValOHP);
            this.Controls.Add(this.ValODef);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CurOHP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CurODef);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GainHCDmg);
            this.Controls.Add(this.GainSCDmg);
            this.Controls.Add(this.GainCDmg);
            this.Controls.Add(this.GainHOptAtk);
            this.Controls.Add(this.GainSOptAtk);
            this.Controls.Add(this.GainOptAtk);
            this.Controls.Add(this.CheckBox6);
            this.Controls.Add(this.CheckBox5);
            this.Controls.Add(this.CheckBox4);
            this.Controls.Add(this.CheckBox3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.ValHCDmg);
            this.Controls.Add(this.ValSCDmg);
            this.Controls.Add(this.ValCDmg);
            this.Controls.Add(this.ValHOptAtk);
            this.Controls.Add(this.ValSOptAtk);
            this.Controls.Add(this.ValOptAtk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurHCDmg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CurSCDmg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CurCDmg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurHOptAtk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurSOptAtk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.CurOptAtk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Blade Idle Option Comparison Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurOptAtk;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CurSOptAtk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CurHOptAtk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CurHCDmg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CurSCDmg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CurCDmg;
        private System.Windows.Forms.TextBox ValHCDmg;
        private System.Windows.Forms.TextBox ValSCDmg;
        private System.Windows.Forms.TextBox ValCDmg;
        private System.Windows.Forms.TextBox ValHOptAtk;
        private System.Windows.Forms.TextBox ValSOptAtk;
        private System.Windows.Forms.TextBox ValOptAtk;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox6;
        private System.Windows.Forms.CheckBox CheckBox5;
        private System.Windows.Forms.CheckBox CheckBox4;
        private System.Windows.Forms.TextBox GainHCDmg;
        private System.Windows.Forms.TextBox GainSCDmg;
        private System.Windows.Forms.TextBox GainCDmg;
        private System.Windows.Forms.TextBox GainHOptAtk;
        private System.Windows.Forms.TextBox GainSOptAtk;
        private System.Windows.Forms.TextBox GainOptAtk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GainOHP;
        private System.Windows.Forms.TextBox GainODef;
        private System.Windows.Forms.CheckBox CheckBox8;
        private System.Windows.Forms.CheckBox CheckBox7;
        private System.Windows.Forms.TextBox ValOHP;
        private System.Windows.Forms.TextBox ValODef;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CurOHP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CurODef;
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Add2;
        private System.Windows.Forms.Button Add3;
        private System.Windows.Forms.Button Add4;
        private System.Windows.Forms.Button Add5;
        private System.Windows.Forms.Button Add6;
        private System.Windows.Forms.Button Add7;
        private System.Windows.Forms.Button Add8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

