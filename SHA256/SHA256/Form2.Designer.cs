
namespace SHA256
{
    partial class Form2
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
            this.StartButton = new MetroFramework.Controls.MetroButton();
            this.ConnectButton = new MetroFramework.Controls.MetroButton();
            this.ServerIPtextBox = new MetroFramework.Controls.MetroTextBox();
            this.ServerPortTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ClientPortTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ClıentIPTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(657, 52);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 50);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "START";
            this.StartButton.UseSelectable = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(656, 38);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(119, 51);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseSelectable = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ServerIPtextBox
            // 
            // 
            // 
            // 
            this.ServerIPtextBox.CustomButton.Image = null;
            this.ServerIPtextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.ServerIPtextBox.CustomButton.Name = "";
            this.ServerIPtextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerIPtextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerIPtextBox.CustomButton.TabIndex = 1;
            this.ServerIPtextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerIPtextBox.CustomButton.UseSelectable = true;
            this.ServerIPtextBox.CustomButton.Visible = false;
            this.ServerIPtextBox.Lines = new string[0];
            this.ServerIPtextBox.Location = new System.Drawing.Point(212, 82);
            this.ServerIPtextBox.MaxLength = 32767;
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.PasswordChar = '\0';
            this.ServerIPtextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerIPtextBox.SelectedText = "";
            this.ServerIPtextBox.SelectionLength = 0;
            this.ServerIPtextBox.SelectionStart = 0;
            this.ServerIPtextBox.ShortcutsEnabled = true;
            this.ServerIPtextBox.Size = new System.Drawing.Size(154, 23);
            this.ServerIPtextBox.TabIndex = 6;
            this.ServerIPtextBox.UseSelectable = true;
            this.ServerIPtextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerIPtextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ServerPortTextBox
            // 
            // 
            // 
            // 
            this.ServerPortTextBox.CustomButton.Image = null;
            this.ServerPortTextBox.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.ServerPortTextBox.CustomButton.Name = "";
            this.ServerPortTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerPortTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerPortTextBox.CustomButton.TabIndex = 1;
            this.ServerPortTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerPortTextBox.CustomButton.UseSelectable = true;
            this.ServerPortTextBox.CustomButton.Visible = false;
            this.ServerPortTextBox.Lines = new string[0];
            this.ServerPortTextBox.Location = new System.Drawing.Point(466, 52);
            this.ServerPortTextBox.MaxLength = 32767;
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.PasswordChar = '\0';
            this.ServerPortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerPortTextBox.SelectedText = "";
            this.ServerPortTextBox.SelectionLength = 0;
            this.ServerPortTextBox.SelectionStart = 0;
            this.ServerPortTextBox.ShortcutsEnabled = true;
            this.ServerPortTextBox.Size = new System.Drawing.Size(132, 23);
            this.ServerPortTextBox.TabIndex = 7;
            this.ServerPortTextBox.UseSelectable = true;
            this.ServerPortTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerPortTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClientPortTextBox
            // 
            // 
            // 
            // 
            this.ClientPortTextBox.CustomButton.Image = null;
            this.ClientPortTextBox.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.ClientPortTextBox.CustomButton.Name = "";
            this.ClientPortTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ClientPortTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClientPortTextBox.CustomButton.TabIndex = 1;
            this.ClientPortTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClientPortTextBox.CustomButton.UseSelectable = true;
            this.ClientPortTextBox.CustomButton.Visible = false;
            this.ClientPortTextBox.Lines = new string[0];
            this.ClientPortTextBox.Location = new System.Drawing.Point(465, 40);
            this.ClientPortTextBox.MaxLength = 32767;
            this.ClientPortTextBox.Name = "ClientPortTextBox";
            this.ClientPortTextBox.PasswordChar = '\0';
            this.ClientPortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClientPortTextBox.SelectedText = "";
            this.ClientPortTextBox.SelectionLength = 0;
            this.ClientPortTextBox.SelectionStart = 0;
            this.ClientPortTextBox.ShortcutsEnabled = true;
            this.ClientPortTextBox.Size = new System.Drawing.Size(132, 23);
            this.ClientPortTextBox.TabIndex = 8;
            this.ClientPortTextBox.UseSelectable = true;
            this.ClientPortTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientPortTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClıentIPTextBox
            // 
            // 
            // 
            // 
            this.ClıentIPTextBox.CustomButton.Image = null;
            this.ClıentIPTextBox.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.ClıentIPTextBox.CustomButton.Name = "";
            this.ClıentIPTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ClıentIPTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClıentIPTextBox.CustomButton.TabIndex = 1;
            this.ClıentIPTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClıentIPTextBox.CustomButton.UseSelectable = true;
            this.ClıentIPTextBox.CustomButton.Visible = false;
            this.ClıentIPTextBox.Lines = new string[0];
            this.ClıentIPTextBox.Location = new System.Drawing.Point(225, 215);
            this.ClıentIPTextBox.MaxLength = 32767;
            this.ClıentIPTextBox.Name = "ClıentIPTextBox";
            this.ClıentIPTextBox.PasswordChar = '\0';
            this.ClıentIPTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClıentIPTextBox.SelectedText = "";
            this.ClıentIPTextBox.SelectionLength = 0;
            this.ClıentIPTextBox.SelectionStart = 0;
            this.ClıentIPTextBox.ShortcutsEnabled = true;
            this.ClıentIPTextBox.Size = new System.Drawing.Size(117, 23);
            this.ClıentIPTextBox.TabIndex = 9;
            this.ClıentIPTextBox.UseSelectable = true;
            this.ClıentIPTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClıentIPTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "PORT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "PORT:";
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.Location = new System.Drawing.Point(156, 352);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.Size = new System.Drawing.Size(761, 162);
            this.ChatScreentextBox.TabIndex = 14;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(156, 544);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(583, 67);
            this.MessagetextBox.TabIndex = 15;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SendButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SendButton.Location = new System.Drawing.Point(773, 544);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(122, 67);
            this.SendButton.TabIndex = 16;
            this.SendButton.Text = "SEND";
            this.SendButton.UseSelectable = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerPortTextBox);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(141, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 140);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLİENT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ClientPortTextBox);
            this.groupBox2.Controls.Add(this.ConnectButton);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(142, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 155);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVER";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 634);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ChatScreentextBox);
            this.Controls.Add(this.ClıentIPTextBox);
            this.Controls.Add(this.ServerIPtextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton StartButton;
        private MetroFramework.Controls.MetroButton ConnectButton;
        private MetroFramework.Controls.MetroTextBox ServerIPtextBox;
        private MetroFramework.Controls.MetroTextBox ServerPortTextBox;
        private MetroFramework.Controls.MetroTextBox ClientPortTextBox;
        private MetroFramework.Controls.MetroTextBox ClıentIPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private MetroFramework.Controls.MetroButton SendButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}