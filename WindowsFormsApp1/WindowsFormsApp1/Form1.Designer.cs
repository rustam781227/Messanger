namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ServerPorttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.ServerPorttextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServerIPtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVER";
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Location = new System.Drawing.Point(507, 46);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 35);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ServerPorttextBox
            // 
            this.ServerPorttextBox.Location = new System.Drawing.Point(310, 52);
            this.ServerPorttextBox.Name = "ServerPorttextBox";
            this.ServerPorttextBox.Size = new System.Drawing.Size(191, 22);
            this.ServerPorttextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(60, 52);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(191, 22);
            this.ServerIPtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConnectButton);
            this.groupBox2.Controls.Add(this.ClientPorttextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ClientIPtextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(30, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENT";
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.Location = new System.Drawing.Point(507, 46);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(111, 35);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Location = new System.Drawing.Point(310, 52);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(191, 22);
            this.ClientPorttextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT";
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(60, 52);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(191, 22);
            this.ClientIPtextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP";
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatScreentextBox.Location = new System.Drawing.Point(30, 310);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.ReadOnly = true;
            this.ChatScreentextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatScreentextBox.Size = new System.Drawing.Size(648, 218);
            this.ChatScreentextBox.TabIndex = 2;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(30, 547);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(520, 44);
            this.MessagetextBox.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendButton.Location = new System.Drawing.Point(570, 547);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(78, 44);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
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
            // sendFileButton
            // 
            this.sendFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendFileButton.Location = new System.Drawing.Point(671, 547);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(82, 44);
            this.sendFileButton.TabIndex = 5;
            this.sendFileButton.Text = "SEND FILE";
            this.sendFileButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.sendFileButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ChatScreentextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ServerPorttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button SendButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button sendFileButton;
    }
}

