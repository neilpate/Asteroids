namespace Asteroids
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
            this.components = new System.ComponentModel.Container();
            this.View = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopwatchTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(201, 12);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(672, 441);
            this.View.TabIndex = 0;
            this.View.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopwatchTime
            // 
            this.StopwatchTime.AutoSize = true;
            this.StopwatchTime.Location = new System.Drawing.Point(12, 12);
            this.StopwatchTime.Name = "StopwatchTime";
            this.StopwatchTime.Size = new System.Drawing.Size(35, 13);
            this.StopwatchTime.TabIndex = 1;
            this.StopwatchTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 564);
            this.Controls.Add(this.StopwatchTime);
            this.Controls.Add(this.View);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox View;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label StopwatchTime;
    }
}

