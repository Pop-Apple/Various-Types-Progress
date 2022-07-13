using System;
using System.Windows.Forms;

namespace Simple_Progress
{
    public partial class Form1 : Form
    {
        private const string V = "Processing";

        public Form1(){
            InitializeComponent();
        }
        private void Successfully(){
            MessageBox.Show("100% Successfully", "Simple Progress", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Form1_Load(object sender, EventArgs e){
            this.btnStop.Enabled = false;
            this.progressBar.Maximum = 100;
        }
        private void btnStart_Click(object sender, EventArgs e){
            this.timer.Start();
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e){
            this.timer.Stop();
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }
        private void timer_Tick(object sender, EventArgs e){
            this.progressBar.Increment(1);
            this.progressBar.Value.ToString();
            this.label.Text = "Processing... " + progressBar.Value.ToString() + "%";
            bool Processing = this.progressBar.Value == 100;
            if (Processing){
                timer.Stop();
                Successfully();
                this.progressBar.Value = 0;
                this.label.Text = "Processing... 0%";
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;
            }
        }
    }
}
