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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 55);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 360);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(216, 55);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(150, 360);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(400, 55);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(150, 360);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
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
            // Callback_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
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
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
