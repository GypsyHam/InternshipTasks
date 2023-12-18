namespace CallBack_Task
{
    partial class Callback_Form
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
            btnSubEvent = new Button();
            btnUnSubEvent = new Button();
            btnSubEvenCallback = new Button();
            btnUnSubEvenCallback = new Button();
            btnSubOddCallback = new Button();
            btnUnSubOddCallback = new Button();
            rtxtEvent = new RichTextBox();
            rtxtEvenCallback = new RichTextBox();
            rtxtOddCallback = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTimeToggle = new Button();
            pnlTimerStatus = new Panel();
            SuspendLayout();
            // 
            // btnSubEvent
            // 
            btnSubEvent.Location = new Point(66, 26);
            btnSubEvent.Name = "btnSubEvent";
            btnSubEvent.Size = new Size(55, 23);
            btnSubEvent.TabIndex = 0;
            btnSubEvent.Text = "Sub";
            btnSubEvent.UseVisualStyleBackColor = true;
            btnSubEvent.Click += btnSubEvent_Click;
            // 
            // btnUnSubEvent
            // 
            btnUnSubEvent.Location = new Point(127, 26);
            btnUnSubEvent.Name = "btnUnSubEvent";
            btnUnSubEvent.Size = new Size(55, 23);
            btnUnSubEvent.TabIndex = 1;
            btnUnSubEvent.Text = "Un-Sub";
            btnUnSubEvent.UseVisualStyleBackColor = true;
            btnUnSubEvent.Click += btnUnSubEvent_Click;
            // 
            // btnSubEvenCallback
            // 
            btnSubEvenCallback.Location = new Point(250, 26);
            btnSubEvenCallback.Name = "btnSubEvenCallback";
            btnSubEvenCallback.Size = new Size(55, 23);
            btnSubEvenCallback.TabIndex = 2;
            btnSubEvenCallback.Text = "Sub";
            btnSubEvenCallback.UseVisualStyleBackColor = true;
            // 
            // btnUnSubEvenCallback
            // 
            btnUnSubEvenCallback.Location = new Point(311, 26);
            btnUnSubEvenCallback.Name = "btnUnSubEvenCallback";
            btnUnSubEvenCallback.Size = new Size(55, 23);
            btnUnSubEvenCallback.TabIndex = 3;
            btnUnSubEvenCallback.Text = "Un-Sub";
            btnUnSubEvenCallback.UseVisualStyleBackColor = true;
            // 
            // btnSubOddCallback
            // 
            btnSubOddCallback.Location = new Point(434, 26);
            btnSubOddCallback.Name = "btnSubOddCallback";
            btnSubOddCallback.Size = new Size(55, 23);
            btnSubOddCallback.TabIndex = 4;
            btnSubOddCallback.Text = "Sub";
            btnSubOddCallback.UseVisualStyleBackColor = true;
            // 
            // btnUnSubOddCallback
            // 
            btnUnSubOddCallback.Location = new Point(495, 26);
            btnUnSubOddCallback.Name = "btnUnSubOddCallback";
            btnUnSubOddCallback.Size = new Size(55, 23);
            btnUnSubOddCallback.TabIndex = 5;
            btnUnSubOddCallback.Text = "Un-Sub";
            btnUnSubOddCallback.UseVisualStyleBackColor = true;
            // 
            // rtxtEvent
            // 
            rtxtEvent.Location = new Point(32, 55);
            rtxtEvent.Name = "rtxtEvent";
            rtxtEvent.Size = new Size(150, 360);
            rtxtEvent.TabIndex = 6;
            rtxtEvent.Text = "";
            // 
            // rtxtEvenCallback
            // 
            rtxtEvenCallback.Location = new Point(216, 55);
            rtxtEvenCallback.Name = "rtxtEvenCallback";
            rtxtEvenCallback.Size = new Size(150, 360);
            rtxtEvenCallback.TabIndex = 7;
            rtxtEvenCallback.Text = "";
            // 
            // rtxtOddCallback
            // 
            rtxtOddCallback.Location = new Point(400, 55);
            rtxtOddCallback.Name = "rtxtOddCallback";
            rtxtOddCallback.Size = new Size(150, 360);
            rtxtOddCallback.TabIndex = 8;
            rtxtOddCallback.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "Odd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "Event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 9);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 11;
            label3.Text = "Even";
            // 
            // btnTimeToggle
            // 
            btnTimeToggle.Location = new Point(412, 417);
            btnTimeToggle.Name = "btnTimeToggle";
            btnTimeToggle.Size = new Size(86, 23);
            btnTimeToggle.TabIndex = 12;
            btnTimeToggle.Text = "Time Toggle";
            btnTimeToggle.UseVisualStyleBackColor = true;
            btnTimeToggle.Click += btnTimerToggle_Click;
            // 
            // pnlTimerStatus
            // 
            pnlTimerStatus.BackColor = Color.Red;
            pnlTimerStatus.Location = new Point(504, 421);
            pnlTimerStatus.Name = "pnlTimerStatus";
            pnlTimerStatus.Size = new Size(16, 17);
            pnlTimerStatus.TabIndex = 13;
            // 
            // Callback_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            Controls.Add(pnlTimerStatus);
            Controls.Add(btnTimeToggle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtxtOddCallback);
            Controls.Add(rtxtEvenCallback);
            Controls.Add(rtxtEvent);
            Controls.Add(btnUnSubOddCallback);
            Controls.Add(btnSubOddCallback);
            Controls.Add(btnUnSubEvenCallback);
            Controls.Add(btnSubEvenCallback);
            Controls.Add(btnUnSubEvent);
            Controls.Add(btnSubEvent);
            Name = "Callback_Form";
            Text = "Callback Tester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubEvent;
        private Button btnUnSubEvent;
        private Button btnSubEvenCallback;
        private Button btnUnSubEvenCallback;
        private Button btnSubOddCallback;
        private Button btnUnSubOddCallback;
        private RichTextBox rtxtEvent;
        private RichTextBox rtxtEvenCallback;
        private RichTextBox rtxtOddCallback;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTimeToggle;
        private Panel pnlTimerStatus;
    }
}
