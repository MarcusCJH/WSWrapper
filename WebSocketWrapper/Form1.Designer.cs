namespace WebSocketWrapper
{
    partial class WebSocketWrapper
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInstructionUnlock = new System.Windows.Forms.Button();
            this.btnInstructionSearchDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInstructionDirectory = new System.Windows.Forms.TextBox();
            this.btnInstructionLock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxConsoleLog = new System.Windows.Forms.RichTextBox();
            this.gBxInitalize = new System.Windows.Forms.GroupBox();
            this.btnInitalizeDisconnect = new System.Windows.Forms.Button();
            this.btnInitalizeReset = new System.Windows.Forms.Button();
            this.btnInitalizeStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBxInitalize.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInstructionUnlock);
            this.groupBox1.Controls.Add(this.btnInstructionSearchDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxInstructionDirectory);
            this.groupBox1.Controls.Add(this.btnInstructionLock);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // btnInstructionUnlock
            // 
            this.btnInstructionUnlock.Location = new System.Drawing.Point(129, 59);
            this.btnInstructionUnlock.Name = "btnInstructionUnlock";
            this.btnInstructionUnlock.Size = new System.Drawing.Size(159, 23);
            this.btnInstructionUnlock.TabIndex = 4;
            this.btnInstructionUnlock.Text = "Unlock";
            this.btnInstructionUnlock.UseVisualStyleBackColor = true;
            this.btnInstructionUnlock.Click += new System.EventHandler(this.btnInstructionLockUnlock_Click);
            // 
            // btnInstructionSearchDirectory
            // 
            this.btnInstructionSearchDirectory.Location = new System.Drawing.Point(411, 31);
            this.btnInstructionSearchDirectory.Name = "btnInstructionSearchDirectory";
            this.btnInstructionSearchDirectory.Size = new System.Drawing.Size(48, 23);
            this.btnInstructionSearchDirectory.TabIndex = 3;
            this.btnInstructionSearchDirectory.Text = "...";
            this.btnInstructionSearchDirectory.UseVisualStyleBackColor = true;
            this.btnInstructionSearchDirectory.Click += new System.EventHandler(this.btnInstructionSearchDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory Folder";
            // 
            // tbxInstructionDirectory
            // 
            this.tbxInstructionDirectory.Location = new System.Drawing.Point(105, 33);
            this.tbxInstructionDirectory.Name = "tbxInstructionDirectory";
            this.tbxInstructionDirectory.Size = new System.Drawing.Size(293, 20);
            this.tbxInstructionDirectory.TabIndex = 1;
            // 
            // btnInstructionLock
            // 
            this.btnInstructionLock.Location = new System.Drawing.Point(300, 59);
            this.btnInstructionLock.Name = "btnInstructionLock";
            this.btnInstructionLock.Size = new System.Drawing.Size(159, 23);
            this.btnInstructionLock.TabIndex = 0;
            this.btnInstructionLock.Text = "Lock";
            this.btnInstructionLock.UseVisualStyleBackColor = true;
            this.btnInstructionLock.Click += new System.EventHandler(this.btnInstructionLockUnlock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxConsoleLog);
            this.groupBox2.Location = new System.Drawing.Point(13, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console";
            // 
            // tbxConsoleLog
            // 
            this.tbxConsoleLog.Location = new System.Drawing.Point(7, 20);
            this.tbxConsoleLog.Name = "tbxConsoleLog";
            this.tbxConsoleLog.Size = new System.Drawing.Size(451, 299);
            this.tbxConsoleLog.TabIndex = 0;
            this.tbxConsoleLog.Text = "";
            this.tbxConsoleLog.TextChanged += new System.EventHandler(this.tbxConsoleLog_TextChanged);
            // 
            // gBxInitalize
            // 
            this.gBxInitalize.Controls.Add(this.btnInitalizeDisconnect);
            this.gBxInitalize.Controls.Add(this.btnInitalizeReset);
            this.gBxInitalize.Controls.Add(this.btnInitalizeStart);
            this.gBxInitalize.Location = new System.Drawing.Point(13, 464);
            this.gBxInitalize.Name = "gBxInitalize";
            this.gBxInitalize.Size = new System.Drawing.Size(464, 42);
            this.gBxInitalize.TabIndex = 2;
            this.gBxInitalize.TabStop = false;
            this.gBxInitalize.Text = "Initialize";
            // 
            // btnInitalizeDisconnect
            // 
            this.btnInitalizeDisconnect.Location = new System.Drawing.Point(337, 13);
            this.btnInitalizeDisconnect.Name = "btnInitalizeDisconnect";
            this.btnInitalizeDisconnect.Size = new System.Drawing.Size(115, 23);
            this.btnInitalizeDisconnect.TabIndex = 2;
            this.btnInitalizeDisconnect.Text = "Disconnect";
            this.btnInitalizeDisconnect.UseVisualStyleBackColor = true;
            this.btnInitalizeDisconnect.Click += new System.EventHandler(this.buttonLogic_click);
            // 
            // btnInitalizeReset
            // 
            this.btnInitalizeReset.Location = new System.Drawing.Point(172, 13);
            this.btnInitalizeReset.Name = "btnInitalizeReset";
            this.btnInitalizeReset.Size = new System.Drawing.Size(115, 23);
            this.btnInitalizeReset.TabIndex = 1;
            this.btnInitalizeReset.Text = "Reset";
            this.btnInitalizeReset.UseVisualStyleBackColor = true;
            this.btnInitalizeReset.Click += new System.EventHandler(this.buttonLogic_click);
            // 
            // btnInitalizeStart
            // 
            this.btnInitalizeStart.Location = new System.Drawing.Point(9, 13);
            this.btnInitalizeStart.Name = "btnInitalizeStart";
            this.btnInitalizeStart.Size = new System.Drawing.Size(115, 23);
            this.btnInitalizeStart.TabIndex = 0;
            this.btnInitalizeStart.Text = "Start";
            this.btnInitalizeStart.UseVisualStyleBackColor = true;
            this.btnInitalizeStart.Click += new System.EventHandler(this.buttonLogic_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed By : Marcus Chan";
            // 
            // WebSocketWrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBxInitalize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebSocketWrapper";
            this.Text = "WebSocket Wrapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaxiSimulator_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gBxInitalize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInstructionLock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gBxInitalize;
        private System.Windows.Forms.Button btnInitalizeDisconnect;
        private System.Windows.Forms.Button btnInitalizeReset;
        private System.Windows.Forms.Button btnInitalizeStart;
        private System.Windows.Forms.TextBox tbxInstructionDirectory;
        private System.Windows.Forms.Button btnInstructionSearchDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstructionUnlock;
        private System.Windows.Forms.RichTextBox tbxConsoleLog;
        private System.Windows.Forms.Label label2;
    }
}

