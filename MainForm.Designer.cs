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
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWriteMethod = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbReadMethod = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenReceiver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.receiverPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(26, 171);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(242, 79);
            this.txtSend.TabIndex = 0;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(35, 171);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(291, 79);
            this.txtReceived.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(26, 266);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(26, 19);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(90, 21);
            this.comboBoxPorts.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.txtOffset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbWriteMethod);
            this.groupBox1.Controls.Add(this.btnSettings);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SENDER";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(337, 133);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(69, 20);
            this.txtCount.TabIndex = 9;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(337, 97);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(69, 20);
            this.txtOffset.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Methods";
            // 
            // cmbWriteMethod
            // 
            this.cmbWriteMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWriteMethod.FormattingEnabled = true;
            this.cmbWriteMethod.Location = new System.Drawing.Point(77, 117);
            this.cmbWriteMethod.Name = "cmbWriteMethod";
            this.cmbWriteMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbWriteMethod.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(193, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnOpen.Location = new System.Drawing.Point(337, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbReadMethod
            // 
            this.cmbReadMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReadMethod.FormattingEnabled = true;
            this.cmbReadMethod.Location = new System.Drawing.Point(86, 117);
            this.cmbReadMethod.Name = "cmbReadMethod";
            this.cmbReadMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbReadMethod.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenReceiver);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbReadMethod);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.receiverPorts);
            this.groupBox2.Controls.Add(this.txtReceived);
            this.groupBox2.Location = new System.Drawing.Point(480, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 337);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RECEIVER";
            // 
            // btnOpenReceiver
            // 
            this.btnOpenReceiver.Location = new System.Drawing.Point(344, 19);
            this.btnOpenReceiver.Name = "btnOpenReceiver";
            this.btnOpenReceiver.Size = new System.Drawing.Size(75, 23);
            this.btnOpenReceiver.TabIndex = 9;
            this.btnOpenReceiver.Text = "Open";
            this.btnOpenReceiver.UseVisualStyleBackColor = true;
            this.btnOpenReceiver.Click += new System.EventHandler(this.btnOpenReceiver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Methods";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Offset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Count";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial Port Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
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
    }
}

