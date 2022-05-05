namespace BlakeEastwoodAssgt
{
    partial class testing
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
            this.button1 = new System.Windows.Forms.Button();
            this.OutcomeDisplay = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.P1D1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P1D1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "roll dice array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutcomeDisplay
            // 
            this.OutcomeDisplay.Location = new System.Drawing.Point(419, 5);
            this.OutcomeDisplay.Multiline = true;
            this.OutcomeDisplay.Name = "OutcomeDisplay";
            this.OutcomeDisplay.Size = new System.Drawing.Size(238, 433);
            this.OutcomeDisplay.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "roll player dice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // P1D1
            // 
            this.P1D1.Location = new System.Drawing.Point(312, 131);
            this.P1D1.Name = "P1D1";
            this.P1D1.Size = new System.Drawing.Size(100, 50);
            this.P1D1.TabIndex = 4;
            this.P1D1.TabStop = false;
            this.P1D1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P1D1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OutcomeDisplay);
            this.Controls.Add(this.button1);
            this.Name = "testing";
            this.Text = "testing";
            this.Load += new System.EventHandler(this.testing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1D1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox OutcomeDisplay;
        private Button button2;
        private Button button3;
        private PictureBox P1D1;
    }
}