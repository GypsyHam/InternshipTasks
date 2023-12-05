namespace ExceptionsExperiment
{
    partial class Form1
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
            button1 = new Button();
            btnMethodException = new Button();
            btnM2MWithTry = new Button();
            btnWrapMethodInTryCatch = new Button();
            btnLoopM2MWithTryCatch = new Button();
            btnLoopInsideLoopThatCallsMethodCallMethodTry = new Button();
            btnTryCatchFromLoopToMethod = new Button();
            btnTryWithinTry = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 27);
            button1.Name = "button1";
            button1.Size = new Size(241, 23);
            button1.TabIndex = 0;
            button1.Text = "Direct";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDirectException_Click;
            // 
            // btnMethodException
            // 
            btnMethodException.Location = new Point(37, 72);
            btnMethodException.Name = "btnMethodException";
            btnMethodException.Size = new Size(241, 23);
            btnMethodException.TabIndex = 1;
            btnMethodException.Text = "Method";
            btnMethodException.UseVisualStyleBackColor = true;
            btnMethodException.Click += btnMethodException_Click;
            // 
            // btnM2MWithTry
            // 
            btnM2MWithTry.Location = new Point(37, 117);
            btnM2MWithTry.Name = "btnM2MWithTry";
            btnM2MWithTry.Size = new Size(241, 23);
            btnM2MWithTry.TabIndex = 2;
            btnM2MWithTry.Text = "Method Calling Method With TryCatch";
            btnM2MWithTry.UseVisualStyleBackColor = true;
            btnM2MWithTry.Click += btnM2MWithTry_Click;
            // 
            // btnWrapMethodInTryCatch
            // 
            btnWrapMethodInTryCatch.Location = new Point(37, 162);
            btnWrapMethodInTryCatch.Name = "btnWrapMethodInTryCatch";
            btnWrapMethodInTryCatch.Size = new Size(241, 23);
            btnWrapMethodInTryCatch.TabIndex = 3;
            btnWrapMethodInTryCatch.Text = "Wrapping Method In TryCatch";
            btnWrapMethodInTryCatch.UseVisualStyleBackColor = true;
            btnWrapMethodInTryCatch.Click += btnWrapMethodInTryCatch_Click;
            // 
            // btnLoopM2MWithTryCatch
            // 
            btnLoopM2MWithTryCatch.Location = new Point(37, 207);
            btnLoopM2MWithTryCatch.Name = "btnLoopM2MWithTryCatch";
            btnLoopM2MWithTryCatch.Size = new Size(241, 23);
            btnLoopM2MWithTryCatch.TabIndex = 4;
            btnLoopM2MWithTryCatch.Text = "Loop Call Method With Try";
            btnLoopM2MWithTryCatch.UseVisualStyleBackColor = true;
            btnLoopM2MWithTryCatch.Click += btnLoopM2MWithTryCatch_Click;
            // 
            // btnLoopInsideLoopThatCallsMethodCallMethodTry
            // 
            btnLoopInsideLoopThatCallsMethodCallMethodTry.Location = new Point(37, 252);
            btnLoopInsideLoopThatCallsMethodCallMethodTry.Name = "btnLoopInsideLoopThatCallsMethodCallMethodTry";
            btnLoopInsideLoopThatCallsMethodCallMethodTry.Size = new Size(241, 23);
            btnLoopInsideLoopThatCallsMethodCallMethodTry.TabIndex = 5;
            btnLoopInsideLoopThatCallsMethodCallMethodTry.Text = "Loop Inside A Loop Call Method With Try";
            btnLoopInsideLoopThatCallsMethodCallMethodTry.UseVisualStyleBackColor = true;
            btnLoopInsideLoopThatCallsMethodCallMethodTry.Click += btnLoopInsideLoopThatCallsMethodCallMethodTry_Click;
            // 
            // btnTryCatchFromLoopToMethod
            // 
            btnTryCatchFromLoopToMethod.Location = new Point(37, 297);
            btnTryCatchFromLoopToMethod.Name = "btnTryCatchFromLoopToMethod";
            btnTryCatchFromLoopToMethod.Size = new Size(241, 23);
            btnTryCatchFromLoopToMethod.TabIndex = 6;
            btnTryCatchFromLoopToMethod.Text = "Try Catch From Loop To Method";
            btnTryCatchFromLoopToMethod.UseVisualStyleBackColor = true;
            btnTryCatchFromLoopToMethod.Click += btnTryCatchFromLoopToMethod_Click;
            // 
            // btnTryWithinTry
            // 
            btnTryWithinTry.Location = new Point(37, 342);
            btnTryWithinTry.Name = "btnTryWithinTry";
            btnTryWithinTry.Size = new Size(241, 23);
            btnTryWithinTry.TabIndex = 7;
            btnTryWithinTry.Text = "Try Within Try";
            btnTryWithinTry.UseVisualStyleBackColor = true;
            btnTryWithinTry.Click += btnTryWithinTry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTryWithinTry);
            Controls.Add(btnTryCatchFromLoopToMethod);
            Controls.Add(btnLoopInsideLoopThatCallsMethodCallMethodTry);
            Controls.Add(btnLoopM2MWithTryCatch);
            Controls.Add(btnWrapMethodInTryCatch);
            Controls.Add(btnM2MWithTry);
            Controls.Add(btnMethodException);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnMethodException;
        private Button btnM2MWithTry;
        private Button btnWrapMethodInTryCatch;
        private Button btnLoopM2MWithTryCatch;
        private Button btnLoopInsideLoopThatCallsMethodCallMethodTry;
        private Button btnTryCatchFromLoopToMethod;
        private Button btnTryWithinTry;
    }
}
