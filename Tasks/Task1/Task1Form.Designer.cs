namespace Task1
{
    partial class Task1Form
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
            this.components = new System.ComponentModel.Container();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStepInterval = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.radTimer = new System.Windows.Forms.RadioButton();
            this.gbxCounterMode = new System.Windows.Forms.GroupBox();
            this.radioWhile = new System.Windows.Forms.RadioButton();
            this.pnlTimerSetup = new System.Windows.Forms.Panel();
            this.pnlTimerCountDown = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.gbxCounterMode.SuspendLayout();
            this.pnlTimerSetup.SuspendLayout();
            this.pnlTimerCountDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(78, 7);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 23);
            this.numDuration.TabIndex = 1;
            this.numDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDuration.ValueChanged += new System.EventHandler(this.numDuration_ValueChanged);
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(78, 55);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 23);
            this.numInterval.TabIndex = 2;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(3, 9);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 15);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration";
            // 
            // lblStepInterval
            // 
            this.lblStepInterval.AutoSize = true;
            this.lblStepInterval.Location = new System.Drawing.Point(3, 57);
            this.lblStepInterval.Name = "lblStepInterval";
            this.lblStepInterval.Size = new System.Drawing.Size(72, 15);
            this.lblStepInterval.TabIndex = 4;
            this.lblStepInterval.Text = "Step Interval";
            // 
            // lblTimeTitle
            // 
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(49, 15);
            this.lblTimeTitle.TabIndex = 5;
            this.lblTimeTitle.Text = "Time (s)";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeValue.Location = new System.Drawing.Point(3, 37);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(65, 37);
            this.lblTimeValue.TabIndex = 6;
            this.lblTimeValue.Text = "10 s";
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Location = new System.Drawing.Point(78, 196);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(75, 23);
            this.btnTimerStart.TabIndex = 7;
            this.btnTimerStart.Text = "Start";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // radTimer
            // 
            this.radTimer.AutoSize = true;
            this.radTimer.Checked = true;
            this.radTimer.Location = new System.Drawing.Point(6, 22);
            this.radTimer.Name = "radTimer";
            this.radTimer.Size = new System.Drawing.Size(55, 19);
            this.radTimer.TabIndex = 8;
            this.radTimer.TabStop = true;
            this.radTimer.Text = "Timer";
            this.radTimer.UseVisualStyleBackColor = true;
            // 
            // gbxCounterMode
            // 
            this.gbxCounterMode.Controls.Add(this.radioWhile);
            this.gbxCounterMode.Controls.Add(this.radTimer);
            this.gbxCounterMode.Location = new System.Drawing.Point(78, 101);
            this.gbxCounterMode.Name = "gbxCounterMode";
            this.gbxCounterMode.Size = new System.Drawing.Size(102, 79);
            this.gbxCounterMode.TabIndex = 9;
            this.gbxCounterMode.TabStop = false;
            this.gbxCounterMode.Text = "Counter Mode";
            // 
            // radioWhile
            // 
            this.radioWhile.AutoSize = true;
            this.radioWhile.Location = new System.Drawing.Point(6, 52);
            this.radioWhile.Name = "radioWhile";
            this.radioWhile.Size = new System.Drawing.Size(55, 19);
            this.radioWhile.TabIndex = 9;
            this.radioWhile.Text = "While";
            this.radioWhile.UseVisualStyleBackColor = true;
            // 
            // pnlTimerSetup
            // 
            this.pnlTimerSetup.Controls.Add(this.lblDuration);
            this.pnlTimerSetup.Controls.Add(this.gbxCounterMode);
            this.pnlTimerSetup.Controls.Add(this.numDuration);
            this.pnlTimerSetup.Controls.Add(this.btnTimerStart);
            this.pnlTimerSetup.Controls.Add(this.numInterval);
            this.pnlTimerSetup.Controls.Add(this.lblStepInterval);
            this.pnlTimerSetup.Location = new System.Drawing.Point(12, 12);
            this.pnlTimerSetup.Name = "pnlTimerSetup";
            this.pnlTimerSetup.Size = new System.Drawing.Size(208, 240);
            this.pnlTimerSetup.TabIndex = 10;
            // 
            // pnlTimerCountDown
            // 
            this.pnlTimerCountDown.Controls.Add(this.lblTimeTitle);
            this.pnlTimerCountDown.Controls.Add(this.lblTimeValue);
            this.pnlTimerCountDown.Location = new System.Drawing.Point(226, 12);
            this.pnlTimerCountDown.Name = "pnlTimerCountDown";
            this.pnlTimerCountDown.Size = new System.Drawing.Size(200, 100);
            this.pnlTimerCountDown.TabIndex = 11;
            // 
            // Task1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 260);
            this.Controls.Add(this.pnlTimerCountDown);
            this.Controls.Add(this.pnlTimerSetup);
            this.Name = "Task1Form";
            this.Text = "Count Down Timer (Task 1)";
            this.Load += new System.EventHandler(this.Task1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.gbxCounterMode.ResumeLayout(false);
            this.gbxCounterMode.PerformLayout();
            this.pnlTimerSetup.ResumeLayout(false);
            this.pnlTimerSetup.PerformLayout();
            this.pnlTimerCountDown.ResumeLayout(false);
            this.pnlTimerCountDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numDuration;
        private NumericUpDown numInterval;
        private Label lblDuration;
        private Label lblStepInterval;
        private Label lblTimeTitle;
        private Label lblTimeValue;
        private Button btnTimerStart;
        private System.Windows.Forms.Timer tmrCountDown;
        private RadioButton radTimer;
        private GroupBox gbxCounterMode;
        private RadioButton radioWhile;
        private Panel pnlTimerSetup;
        private Panel pnlTimerCountDown;
    }
}