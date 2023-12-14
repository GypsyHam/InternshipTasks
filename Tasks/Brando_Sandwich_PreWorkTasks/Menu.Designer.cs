namespace Brando_Sandwich_PreWorkTasks
{
    partial class Menu
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
            btnMenuTask1 = new Button();
            btnMenuTask2 = new Button();
            btnMenuTask3 = new Button();
            btnMenuTask4 = new Button();
            SuspendLayout();
            // 
            // btnMenuTask1
            // 
            btnMenuTask1.Location = new Point(77, 12);
            btnMenuTask1.Name = "btnMenuTask1";
            btnMenuTask1.Size = new Size(75, 23);
            btnMenuTask1.TabIndex = 0;
            btnMenuTask1.Text = "Task 1";
            btnMenuTask1.UseVisualStyleBackColor = true;
            btnMenuTask1.Click += btnMenuTask1_Click;
            // 
            // btnMenuTask2
            // 
            btnMenuTask2.Location = new Point(77, 41);
            btnMenuTask2.Name = "btnMenuTask2";
            btnMenuTask2.Size = new Size(75, 23);
            btnMenuTask2.TabIndex = 1;
            btnMenuTask2.Text = "Task 2";
            btnMenuTask2.UseVisualStyleBackColor = true;
            btnMenuTask2.Click += btnMenuTask2_Click;
            // 
            // btnMenuTask3
            // 
            btnMenuTask3.Location = new Point(77, 70);
            btnMenuTask3.Name = "btnMenuTask3";
            btnMenuTask3.Size = new Size(75, 23);
            btnMenuTask3.TabIndex = 2;
            btnMenuTask3.Text = "Task 3";
            btnMenuTask3.UseVisualStyleBackColor = true;
            btnMenuTask3.Click += btnMenuTask3_Click;
            // 
            // btnMenuTask4
            // 
            btnMenuTask4.Enabled = false;
            btnMenuTask4.Location = new Point(77, 99);
            btnMenuTask4.Name = "btnMenuTask4";
            btnMenuTask4.Size = new Size(75, 23);
            btnMenuTask4.TabIndex = 3;
            btnMenuTask4.Text = "Task 4";
            btnMenuTask4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 131);
            Controls.Add(btnMenuTask4);
            Controls.Add(btnMenuTask3);
            Controls.Add(btnMenuTask2);
            Controls.Add(btnMenuTask1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenuTask1;
        private Button btnMenuTask2;
        private Button btnMenuTask3;
        private Button btnMenuTask4;
    }
}