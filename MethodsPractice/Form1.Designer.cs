namespace MethodsPractice
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
            labelEnterANumber = new Label();
            textBoxNumberInput = new TextBox();
            buttonCheckNumber = new Button();
            SuspendLayout();
            // 
            // labelEnterANumber
            // 
            labelEnterANumber.AutoSize = true;
            labelEnterANumber.Location = new Point(48, 122);
            labelEnterANumber.Name = "labelEnterANumber";
            labelEnterANumber.Size = new Size(116, 20);
            labelEnterANumber.TabIndex = 0;
            labelEnterANumber.Text = "Enter a Number:";
            // 
            // textBoxNumberInput
            // 
            textBoxNumberInput.Location = new Point(185, 119);
            textBoxNumberInput.Name = "textBoxNumberInput";
            textBoxNumberInput.Size = new Size(125, 27);
            textBoxNumberInput.TabIndex = 1;
            // 
            // buttonCheckNumber
            // 
            buttonCheckNumber.Location = new Point(100, 152);
            buttonCheckNumber.Name = "buttonCheckNumber";
            buttonCheckNumber.Size = new Size(142, 40);
            buttonCheckNumber.TabIndex = 2;
            buttonCheckNumber.Text = "Check Number";
            buttonCheckNumber.UseVisualStyleBackColor = true;
            buttonCheckNumber.Click += buttonCheckNumber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 304);
            Controls.Add(buttonCheckNumber);
            Controls.Add(textBoxNumberInput);
            Controls.Add(labelEnterANumber);
            Name = "Form1";
            Text = "Number Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnterANumber;
        private TextBox textBoxNumberInput;
        private Button buttonCheckNumber;
    }
}
