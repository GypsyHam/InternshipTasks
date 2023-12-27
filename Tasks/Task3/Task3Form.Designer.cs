namespace Task3
{
    partial class Task3Form
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
            btnEvaluate = new Button();
            lblResultHeader = new Label();
            txtRawExpression = new TextBox();
            lblExpressionHeader = new Label();
            lblResultValue = new Label();
            lblEvaluatedValue = new Label();
            lblEvaluatedHeader = new Label();
            SuspendLayout();
            // 
            // btnEvaluate
            // 
            btnEvaluate.Location = new Point(15, 116);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(75, 23);
            btnEvaluate.TabIndex = 0;
            btnEvaluate.Text = "Evaluate";
            btnEvaluate.UseVisualStyleBackColor = true;
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // lblResultHeader
            // 
            lblResultHeader.AutoSize = true;
            lblResultHeader.Location = new Point(15, 85);
            lblResultHeader.Name = "lblResultHeader";
            lblResultHeader.Size = new Size(45, 15);
            lblResultHeader.TabIndex = 1;
            lblResultHeader.Text = "Result: ";
            // 
            // txtRawExpression
            // 
            txtRawExpression.Location = new Point(84, 18);
            txtRawExpression.Name = "txtRawExpression";
            txtRawExpression.Size = new Size(459, 23);
            txtRawExpression.TabIndex = 2;
            txtRawExpression.Text = "-56--6";
            txtRawExpression.KeyPress += txtRawExpression_KeyPress;
            // 
            // lblExpressionHeader
            // 
            lblExpressionHeader.AutoSize = true;
            lblExpressionHeader.Location = new Point(15, 21);
            lblExpressionHeader.Name = "lblExpressionHeader";
            lblExpressionHeader.Size = new Size(66, 15);
            lblExpressionHeader.TabIndex = 3;
            lblExpressionHeader.Text = "Expression:";
            // 
            // lblResultValue
            // 
            lblResultValue.AutoSize = true;
            lblResultValue.Location = new Point(84, 85);
            lblResultValue.Name = "lblResultValue";
            lblResultValue.Size = new Size(62, 15);
            lblResultValue.TabIndex = 4;
            lblResultValue.Text = "result here";
            // 
            // lblEvaluatedValue
            // 
            lblEvaluatedValue.AutoSize = true;
            lblEvaluatedValue.Location = new Point(84, 53);
            lblEvaluatedValue.Name = "lblEvaluatedValue";
            lblEvaluatedValue.Size = new Size(62, 15);
            lblEvaluatedValue.TabIndex = 6;
            lblEvaluatedValue.Text = "result here";
            // 
            // lblEvaluatedHeader
            // 
            lblEvaluatedHeader.AutoSize = true;
            lblEvaluatedHeader.Location = new Point(15, 53);
            lblEvaluatedHeader.Name = "lblEvaluatedHeader";
            lblEvaluatedHeader.Size = new Size(61, 15);
            lblEvaluatedHeader.TabIndex = 5;
            lblEvaluatedHeader.Text = "Evaluated:";
            // 
            // Task3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 153);
            Controls.Add(lblEvaluatedValue);
            Controls.Add(lblEvaluatedHeader);
            Controls.Add(lblResultValue);
            Controls.Add(lblExpressionHeader);
            Controls.Add(txtRawExpression);
            Controls.Add(lblResultHeader);
            Controls.Add(btnEvaluate);
            Name = "Task3Form";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvaluate;
        private Label lblResultHeader;
        private TextBox txtRawExpression;
        private Label lblExpressionHeader;
        private Label lblResultValue;
        private Label lblEvaluatedValue;
        private Label lblEvaluatedHeader;
    }
}