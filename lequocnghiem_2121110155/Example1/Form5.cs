﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{

    public partial class Form5 : Form
    {
        
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        public Form5()
        {
            InitializeComponent();
            bt0.Click += new EventHandler(Button_Click);
            bt1.Click += new EventHandler(Button_Click);
            bt2.Click += new EventHandler(Button_Click);
            bt3.Click += new EventHandler(Button_Click);
            bt4.Click += new EventHandler(Button_Click);
            bt5.Click += new EventHandler(Button_Click);
            bt6.Click += new EventHandler(Button_Click);
            bt7.Click += new EventHandler(Button_Click);
            bt8.Click += new EventHandler(Button_Click);
            bt9.Click += new EventHandler(Button_Click);
            btCong.Click += new EventHandler(Button_Click);
            btTru.Click += new EventHandler(Button_Click);
            btNhan.Click += new EventHandler(Button_Click);
            btChia.Click += new EventHandler(Button_Click);
            btXoa1.Click += new EventHandler(Button_Click);
            btXoatat.Click += new EventHandler(Button_Click);
            btBang.Click += new EventHandler(Button_Click);
            btCham.Click += new EventHandler(Button_Click);
            btMr.Click += new EventHandler(Button_Click);
            btMs.Click += new EventHandler(Button_Click);


            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
         
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        {
                            txtDisplay.Text = (workingMemory + secondValue).ToString();
                            break;
                        }
                    case "-":
                        {
                            txtDisplay.Text = (workingMemory - secondValue).ToString();
                            break;
                        }
                    case "*":
                        {
                            txtDisplay.Text = (workingMemory * secondValue).ToString();
                            break;
                        }
                    case "/":
                        {
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                            break;
                        }
                }
            }
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal/100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = 1/currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory = memory + decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-")
            {
                memory = memory - decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }
            
        }
        
    }
}
