using System.Diagnostics;
using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private int counter = 0;
        private int loopIndex = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            counter++;
            btnCounter.Text = counter.ToString();
        }

        private void btnUpLow_Click(object sender, EventArgs e)
        {
            btnTwo.Enabled = !btnTwo.Enabled;
            btnOne.Enabled = !btnOne.Enabled;
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            txtCase.Text = txtCase.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            txtCase.Text = txtCase.Text.ToLower();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            string[] words = txtWords.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                btnLoop.Text = words[loopIndex];

                if (loopIndex < words.Length - 1) loopIndex++;
                else loopIndex = 0;
            }
        }

        private void txtWords_TextChanged(object sender, EventArgs e)
        {
            loopIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new("www.everyloop.com")
            {
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void numericChanged_ValueChanged(object sender, EventArgs e)
        {
            lblCounterMax.Text = Math.Max(num1.Value, num2.Value).ToString();
        }

        private void calcUpdate_ValueChanged(object sender, EventArgs e)
        {
            decimal result = calcOp.SelectedItem.ToString() switch
            {
                "+" => calcNum1.Value + calcNum2.Value,
                "-" => calcNum1.Value - calcNum2.Value,
                "/" => calcNum1.Value / calcNum2.Value,
                "*" => calcNum1.Value * calcNum2.Value,
                _ => throw new InvalidOperationException()
            };

            lblCalcSum.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcOp.SelectedIndex = 0;
        }

        private void txtReverse1_TextChanged(object sender, EventArgs e)
        {
            txtReverse2.Text = string.Join("", txtReverse1.Text.Reverse());
        }

        private void txtReverse2_TextChanged(object sender, EventArgs e)
        {
            txtReverse1.Text = string.Join("", txtReverse2.Text.Reverse());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}