namespace SerialPortTest
{
    partial class MainForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.senderPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWriteMethod = new System.Windows.Forms.ComboBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoSenderHex = new System.Windows.Forms.RadioButton();
            this.rdoSenderText = new System.Windows.Forms.RadioButton();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnOpenSender = new System.Windows.Forms.Button();
            this.cmbReadMethod = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEOT = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReceiverSettings = new System.Windows.Forms.Button();
            this.rdoReceiverHex = new System.Windows.Forms.RadioButton();
            this.rdoReceiverText = new System.Windows.Forms.RadioButton();
            this.btnOpenReceiver = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.receiverPorts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSend.Location = new System.Drawing.Point(26, 266);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // senderPorts
            // 
            this.senderPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.senderPorts.FormattingEnabled = true;
            this.senderPorts.Location = new System.Drawing.Point(26, 19);
            this.senderPorts.Name = "senderPorts";
            this.senderPorts.Size = new System.Drawing.Size(90, 21);
            this.senderPorts.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rdoSenderHex);
            this.groupBox1.Controls.Add(this.rdoSenderText);
            this.groupBox1.Controls.Add(this.btnSettings);
            this.groupBox1.Controls.Add(this.btnOpenSender);
            this.groupBox1.Controls.Add(this.senderPorts);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SENDER";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(26, 171);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(393, 86);
            this.txtSend.TabIndex = 17;
            this.txtSend.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbWriteMethod);
            this.groupBox3.Controls.Add(this.txtOffset);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(26, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 91);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Methods";
            // 
            // cmbWriteMethod
            // 
            this.cmbWriteMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWriteMethod.FormattingEnabled = true;
            this.cmbWriteMethod.Location = new System.Drawing.Point(60, 36);
            this.cmbWriteMethod.Name = "cmbWriteMethod";
            this.cmbWriteMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbWriteMethod.TabIndex = 6;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(320, 21);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(69, 20);
            this.txtOffset.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(320, 57);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(69, 20);
            this.txtCount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Offset";
            // 
            // rdoSenderHex
            // 
            this.rdoSenderHex.AutoSize = true;
            this.rdoSenderHex.Location = new System.Drawing.Point(77, 314);
            this.rdoSenderHex.Name = "rdoSenderHex";
            this.rdoSenderHex.Size = new System.Drawing.Size(44, 17);
            this.rdoSenderHex.TabIndex = 15;
            this.rdoSenderHex.TabStop = true;
            this.rdoSenderHex.Text = "Hex";
            this.rdoSenderHex.UseVisualStyleBackColor = true;
            // 
            // rdoSenderText
            // 
            this.rdoSenderText.AutoSize = true;
            this.rdoSenderText.Location = new System.Drawing.Point(16, 314);
            this.rdoSenderText.Name = "rdoSenderText";
            this.rdoSenderText.Size = new System.Drawing.Size(46, 17);
            this.rdoSenderText.TabIndex = 14;
            this.rdoSenderText.TabStop = true;
            this.rdoSenderText.Text = "Text";
            this.rdoSenderText.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettings.Location = new System.Drawing.Point(193, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOpenSender
            // 
            this.btnOpenSender.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnOpenSender.Location = new System.Drawing.Point(337, 19);
            this.btnOpenSender.Name = "btnOpenSender";
            this.btnOpenSender.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSender.TabIndex = 4;
            this.btnOpenSender.Text = "Open";
            this.btnOpenSender.UseVisualStyleBackColor = true;
            this.btnOpenSender.Click += new System.EventHandler(this.btnOpenSender_Click);
            // 
            // cmbReadMethod
            // 
            this.cmbReadMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReadMethod.FormattingEnabled = true;
            this.cmbReadMethod.Location = new System.Drawing.Point(70, 36);
            this.cmbReadMethod.Name = "cmbReadMethod";
            this.cmbReadMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbReadMethod.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEOT);
            this.groupBox2.Controls.Add(this.txtReceived);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnReceiverSettings);
            this.groupBox2.Controls.Add(this.rdoReceiverHex);
            this.groupBox2.Controls.Add(this.rdoReceiverText);
            this.groupBox2.Controls.Add(this.btnOpenReceiver);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.receiverPorts);
            this.groupBox2.Location = new System.Drawing.Point(479, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 349);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RECEIVER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "EOT";
            // 
            // txtEOT
            // 
            this.txtEOT.Location = new System.Drawing.Point(335, 311);
            this.txtEOT.Name = "txtEOT";
            this.txtEOT.Size = new System.Drawing.Size(100, 20);
            this.txtEOT.TabIndex = 14;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(35, 171);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(386, 86);
            this.txtReceived.TabIndex = 13;
            this.txtReceived.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbReadMethod);
            this.groupBox4.Location = new System.Drawing.Point(35, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 91);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Methods";
            // 
            // btnReceiverSettings
            // 
            this.btnReceiverSettings.Location = new System.Drawing.Point(193, 21);
            this.btnReceiverSettings.Name = "btnReceiverSettings";
            this.btnReceiverSettings.Size = new System.Drawing.Size(75, 23);
            this.btnReceiverSettings.TabIndex = 12;
            this.btnReceiverSettings.Text = "Settings";
            this.btnReceiverSettings.UseVisualStyleBackColor = true;
            this.btnReceiverSettings.Click += new System.EventHandler(this.btnReceiverSettings_Click);
            // 
            // rdoReceiverHex
            // 
            this.rdoReceiverHex.AutoSize = true;
            this.rdoReceiverHex.Location = new System.Drawing.Point(100, 314);
            this.rdoReceiverHex.Name = "rdoReceiverHex";
            this.rdoReceiverHex.Size = new System.Drawing.Size(44, 17);
            this.rdoReceiverHex.TabIndex = 11;
            this.rdoReceiverHex.TabStop = true;
            this.rdoReceiverHex.Text = "Hex";
            this.rdoReceiverHex.UseVisualStyleBackColor = true;
            // 
            // rdoReceiverText
            // 
            this.rdoReceiverText.AutoSize = true;
            this.rdoReceiverText.Location = new System.Drawing.Point(25, 314);
            this.rdoReceiverText.Name = "rdoReceiverText";
            this.rdoReceiverText.Size = new System.Drawing.Size(46, 17);
            this.rdoReceiverText.TabIndex = 10;
            this.rdoReceiverText.TabStop = true;
            this.rdoReceiverText.Text = "Text";
            this.rdoReceiverText.UseVisualStyleBackColor = true;
            // 
            // btnOpenReceiver
            // 
            this.btnOpenReceiver.Location = new System.Drawing.Point(346, 21);
            this.btnOpenReceiver.Name = "btnOpenReceiver";
            this.btnOpenReceiver.Size = new System.Drawing.Size(75, 23);
            this.btnOpenReceiver.TabIndex = 9;
            this.btnOpenReceiver.Text = "Open";
            this.btnOpenReceiver.UseVisualStyleBackColor = true;
            this.btnOpenReceiver.Click += new System.EventHandler(this.btnOpenReceiver_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // receiverPorts
            // 
            this.receiverPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receiverPorts.FormattingEnabled = true;
            this.receiverPorts.Location = new System.Drawing.Point(35, 21);
            this.receiverPorts.Name = "receiverPorts";
            this.receiverPorts.Size = new System.Drawing.Size(88, 21);
            this.receiverPorts.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Offset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Count";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox senderPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpenSender;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox receiverPorts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbReadMethod;
        private System.Windows.Forms.ComboBox cmbWriteMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenReceiver;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoSenderHex;
        private System.Windows.Forms.RadioButton rdoSenderText;
        private System.Windows.Forms.RadioButton rdoReceiverHex;
        private System.Windows.Forms.RadioButton rdoReceiverText;
        private System.Windows.Forms.Button btnReceiverSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtSend;
        private System.Windows.Forms.RichTextBox txtReceived;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEOT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

