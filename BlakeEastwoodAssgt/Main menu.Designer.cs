namespace BlakeEastwoodAssgt
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LDLable = new System.Windows.Forms.Label();
            this.PlayerBox = new System.Windows.Forms.ComboBox();
            this.PlayerLb = new System.Windows.Forms.Label();
            this.AIBox = new System.Windows.Forms.ComboBox();
            this.AILb = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDLable
            // 
            this.LDLable.AutoSize = true;
            this.LDLable.Font = new System.Drawing.Font("Sitka Banner", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LDLable.Location = new System.Drawing.Point(259, 38);
            this.LDLable.Name = "LDLable";
            this.LDLable.Size = new System.Drawing.Size(263, 77);
            this.LDLable.TabIndex = 0;
            this.LDLable.Text = "Liar\'s Dice";
            // 
            // PlayerBox
            // 
            this.PlayerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PlayerBox.Location = new System.Drawing.Point(457, 218);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(146, 23);
            this.PlayerBox.TabIndex = 1;
            this.PlayerBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PlayerLb
            // 
            this.PlayerLb.AutoSize = true;
            this.PlayerLb.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLb.Location = new System.Drawing.Point(457, 191);
            this.PlayerLb.Name = "PlayerLb";
            this.PlayerLb.Size = new System.Drawing.Size(146, 15);
            this.PlayerLb.TabIndex = 2;
            this.PlayerLb.Text = "Choose number of players";
            // 
            // AIBox
            // 
            this.AIBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AIBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AIBox.FormattingEnabled = true;
            this.AIBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AIBox.Location = new System.Drawing.Point(609, 218);
            this.AIBox.Name = "AIBox";
            this.AIBox.Size = new System.Drawing.Size(146, 23);
            this.AIBox.TabIndex = 3;
            this.AIBox.SelectedIndexChanged += new System.EventHandler(this.AIBox_SelectedIndexChanged);
            // 
            // AILb
            // 
            this.AILb.AutoSize = true;
            this.AILb.BackColor = System.Drawing.Color.Transparent;
            this.AILb.Location = new System.Drawing.Point(609, 191);
            this.AILb.Name = "AILb";
            this.AILb.Size = new System.Drawing.Size(120, 15);
            this.AILb.TabIndex = 4;
            this.AILb.Text = "Choose number of AI";
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn.Location = new System.Drawing.Point(106, 315);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(108, 71);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "Play!";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(654, 415);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(275, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "debug/test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.AILb);
            this.Controls.Add(this.AIBox);
            this.Controls.Add(this.PlayerLb);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.LDLable);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LDLable;
        private ComboBox PlayerBox;
        private Label PlayerLb;
        private ComboBox AIBox;
        private Label AILb;
        private Button PlayBtn;
        private Button ExitBtn;
        private Button button1;
    }
}