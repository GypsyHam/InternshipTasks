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
            SuspendLayout();
            // 
            // btnSubEvent
            // 
            btnSubEvent.Location = new Point(66, 49);
            btnSubEvent.Name = "btnSubEvent";
            btnSubEvent.Size = new Size(55, 23);
            btnSubEvent.TabIndex = 0;
            btnSubEvent.Text = "Sub";
            btnSubEvent.UseVisualStyleBackColor = true;
            // 
            // btnUnSubEvent
            // 
            btnUnSubEvent.Location = new Point(127, 49);
            btnUnSubEvent.Name = "btnUnSubEvent";
            btnUnSubEvent.Size = new Size(55, 23);
            btnUnSubEvent.TabIndex = 1;
            btnUnSubEvent.Text = "Un-Sub";
            btnUnSubEvent.UseVisualStyleBackColor = true;
            // 
            // btnSubEvenCallback
            // 
            btnSubEvenCallback.Location = new Point(250, 49);
            btnSubEvenCallback.Name = "btnSubEvenCallback";
            btnSubEvenCallback.Size = new Size(55, 23);
            btnSubEvenCallback.TabIndex = 2;
            btnSubEvenCallback.Text = "Sub";
            btnSubEvenCallback.UseVisualStyleBackColor = true;
            // 
            // btnUnSubEvenCallback
            // 
            btnUnSubEvenCallback.Location = new Point(311, 49);
            btnUnSubEvenCallback.Name = "btnUnSubEvenCallback";
            btnUnSubEvenCallback.Size = new Size(55, 23);
            btnUnSubEvenCallback.TabIndex = 3;
            btnUnSubEvenCallback.Text = "Un-Sub";
            btnUnSubEvenCallback.UseVisualStyleBackColor = true;
            // 
            // btnSubOddCallback
            // 
            btnSubOddCallback.Location = new Point(434, 49);
            btnSubOddCallback.Name = "btnSubOddCallback";
            btnSubOddCallback.Size = new Size(55, 23);
            btnSubOddCallback.TabIndex = 4;
            btnSubOddCallback.Text = "Sub";
            btnSubOddCallback.UseVisualStyleBackColor = true;
            // 
            // btnUnSubOddCallback
            // 
            btnUnSubOddCallback.Location = new Point(495, 49);
            btnUnSubOddCallback.Name = "btnUnSubOddCallback";
            btnUnSubOddCallback.Size = new Size(55, 23);
            btnUnSubOddCallback.TabIndex = 5;
            btnUnSubOddCallback.Text = "Un-Sub";
            btnUnSubOddCallback.UseVisualStyleBackColor = true;
            btnUnSubOddCallback.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 360);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(216, 78);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(150, 360);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(400, 78);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(150, 360);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
            // 
            // Callback_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "Form1";
            ResumeLayout(false);
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
    }
}
