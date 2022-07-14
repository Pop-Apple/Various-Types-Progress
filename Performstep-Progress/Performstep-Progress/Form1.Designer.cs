namespace Performstep_Progress
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkUse = new System.Windows.Forms.CheckBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(36, 35);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(464, 29);
            this.progressBar.TabIndex = 1;
            // 
            // chkUse
            // 
            this.chkUse.AutoSize = true;
            this.chkUse.Location = new System.Drawing.Point(251, 114);
            this.chkUse.Name = "chkUse";
            this.chkUse.Size = new System.Drawing.Size(125, 22);
            this.chkUse.TabIndex = 2;
            this.chkUse.Text = "Use of timer";
            this.chkUse.UseVisualStyleBackColor = true;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(36, 98);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(191, 52);
            this.btnStep.TabIndex = 3;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 182);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.chkUse);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performstep-Progressbar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkUse;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Timer timer;
    }
}

