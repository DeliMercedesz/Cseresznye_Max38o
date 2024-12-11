namespace SzabaduloForm
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
            FoglalasButton = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // FoglalasButton
            // 
            FoglalasButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FoglalasButton.BackColor = Color.FromArgb(192, 192, 255);
            FoglalasButton.Location = new Point(12, 406);
            FoglalasButton.Name = "FoglalasButton";
            FoglalasButton.Size = new Size(160, 32);
            FoglalasButton.TabIndex = 0;
            FoglalasButton.Text = "Foglalások";
            FoglalasButton.UseVisualStyleBackColor = false;
            FoglalasButton.Click += FoglalasButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 395);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(FoglalasButton);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button FoglalasButton;
        private Panel panel1;
    }
}