using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CbFunc.Items.Add("+");
            CbFunc.Items.Add("-");
            CbFunc.Items.Add("*");
            CbFunc.Items.Add("/");
        }

        private void num1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCaluate_Click(object sender, EventArgs e)
        {
            if (num1txt.Text.Length == 0 || num2txt.Text.Length == 0)//判断输入是否合法，应该检测输入的是否数字或者不允许输入数字以外的字符比较合适。
            {
                MessageBox.Show("请输入数字");//当输入不合法时，弹出信息窗提示不合法
                return;
            }
            switch (CbFunc.Text.ToString())
            {
                case "+":
                    try
                    {
                        double x = double.Parse(num1txt.Text);//获取文本框1中的内容
                        double y = double.Parse(num2txt.Text);//同理
                        resulttxt.Text = (x + y).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "-":
                    try
                    {
                        double x = double.Parse(num1txt.Text);//获取文本框1中的内容
                        double y = double.Parse(num2txt.Text);//同理
                        resulttxt.Text = (x - y).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "*":
                    try
                    {
                        double x = double.Parse(num1txt.Text);//获取文本框1中的内容
                        double y = double.Parse(num2txt.Text);//同理
                        resulttxt.Text = (x * y).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "/":
                    if (int.Parse(num2txt.Text) == 0)
                    {
                        MessageBox.Show("除零错误");
                    }
                    else
                    {
                        try
                        {
                            double x = double.Parse(num1txt.Text);//获取文本框1中的内容
                            double y = double.Parse(num2txt.Text);//同理
                            resulttxt.Text = (x / y).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    }
                    break;
            }
        }
    }
}
