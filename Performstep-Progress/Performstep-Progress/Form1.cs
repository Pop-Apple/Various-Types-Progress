using System;
using System.Windows.Forms;

namespace Performstep_Progress
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            progressBar.Maximum = 100;
        }
        private void btnStep_Click(object sender, EventArgs e){
            bool Checked = this.chkUse.Checked;
            /*this.progressBar.Value.ToString();
            this.lblProcess.Text = progressBar.Value.ToString();*/
            progressBar.PerformStep();
            if(Checked){
                timer.Start();
            }
            bool Max = this.progressBar.Value == 100;
            if (Max){
                Successfully();
                progressBar.Value = 0;
            }
        }
        private void Successfully(){
            MessageBox.Show("Successfully", "Performstep-Progress", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void timer_Tick(object sender, EventArgs e){
           progressBar.PerformStep();
            bool Max = this.progressBar.Value == 100;
            if(Max){
                timer.Stop();
                Successfully();
                progressBar.Value = 0;
            }
        }
    }
}
