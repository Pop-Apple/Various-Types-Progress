using System;
using System.Windows.Forms;

namespace AppendText_Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e){
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e){
            this.textBox1.Clear();
        }
        private void timer1_Tick(object sender, EventArgs e){
            progressBar1.Increment(1);
            progressBar1.Value.ToString();
            textBox1.AppendText(progressBar1.Value.ToString() + Environment.NewLine);
            bool Demo = progressBar1.Value == 100;
            if (Demo)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                Success();
            }
        }
        private void Success(){
            MessageBox.Show("100% Successfully","AppendText-Progress", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
