namespace WinFormsApp1
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
            CenterButton = new Button();
            SuspendLayout();
            // 
            // CenterButton
            // 
            CenterButton.BackColor = Color.OrangeRed;
            CenterButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            CenterButton.Location = new Point(460, 206);
            CenterButton.Margin = new Padding(3, 2, 3, 2);
            CenterButton.Name = "CenterButton";
            CenterButton.Size = new Size(262, 206);
            CenterButton.TabIndex = 0;
            CenterButton.Text = "złap mnie";
            CenterButton.UseVisualStyleBackColor = false;
            CenterButton.Click += CenterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 618);
            Controls.Add(CenterButton);
            Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CenterButton;
    }
}