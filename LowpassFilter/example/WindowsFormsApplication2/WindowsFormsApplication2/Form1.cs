using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLowpassFilter;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        LowpassFilter lowpass1 = new LowpassFilter();
        LowpassFilter lowpass2 = new LowpassFilter();
        LowpassFilter lowpass3 = new LowpassFilter();

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            
            firstOrderOutput.Text = lowpass1.firstOrder_lowpassFilter(double.Parse(inputText.Text), 0.6).ToString();
            secondOrderOutput.Text = lowpass2.secondOrder_lowpassFilter(double.Parse(inputText.Text), 0.6).ToString();
            thirdOrderOutput.Text = lowpass3.thirdOrder_lowpassFilter(double.Parse(inputText.Text), 0.6).ToString();
        }
    }
}
