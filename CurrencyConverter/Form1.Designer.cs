namespace CurrencyConverter
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
            amount = new NumericUpDown();
            startCurrency = new ComboBox();
            endCurrency = new ComboBox();
            arrow = new Label();
            convertButton = new Button();
            result = new Label();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            SuspendLayout();
            // 
            // amount
            // 
            amount.Location = new Point(51, 167);
            amount.Name = "amount";
            amount.Size = new Size(100, 23);
            amount.TabIndex = 0;
            amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // startCurrency
            // 
            startCurrency.FormattingEnabled = true;
            startCurrency.Items.AddRange(new object[] { "EUR", "USD", "JPY", "GBP" });
            startCurrency.Location = new Point(187, 166);
            startCurrency.Name = "startCurrency";
            startCurrency.Size = new Size(121, 23);
            startCurrency.TabIndex = 2;
            // 
            // endCurrency
            // 
            endCurrency.FormattingEnabled = true;
            endCurrency.Items.AddRange(new object[] { "EUR", "USD", "JPY", "GBP" });
            endCurrency.Location = new Point(372, 166);
            endCurrency.Name = "endCurrency";
            endCurrency.Size = new Size(121, 23);
            endCurrency.TabIndex = 3;
            // 
            // arrow
            // 
            arrow.AutoSize = true;
            arrow.Location = new Point(328, 169);
            arrow.Name = "arrow";
            arrow.Size = new Size(25, 15);
            arrow.TabIndex = 4;
            arrow.Text = "-->";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(76, 229);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 6;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += ConvertButton_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(392, 242);
            result.Name = "result";
            result.Size = new Size(27, 15);
            result.TabIndex = 7;
            result.Text = "????";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(542, 312);
            Controls.Add(result);
            Controls.Add(convertButton);
            Controls.Add(arrow);
            Controls.Add(endCurrency);
            Controls.Add(startCurrency);
            Controls.Add(amount);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown amount;
        private ComboBox startCurrency;
        private ComboBox endCurrency;
        private Label arrow;
        private Button convertButton;
        private Label result;
    }
}