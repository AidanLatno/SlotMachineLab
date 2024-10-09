namespace SlotMachineLab
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
            slot1 = new PictureBox();
            slot2 = new PictureBox();
            slot3 = new PictureBox();
            exitButton = new Button();
            spinButton = new Button();
            enterAmountLabel = new Label();
            enterAmountBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3).BeginInit();
            SuspendLayout();
            // 
            // slot1
            // 
            slot1.Image = Properties.Resources.Apple;
            slot1.Location = new Point(334, 55);
            slot1.Name = "slot1";
            slot1.Size = new Size(316, 316);
            slot1.SizeMode = PictureBoxSizeMode.Zoom;
            slot1.TabIndex = 0;
            slot1.TabStop = false;
            // 
            // slot2
            // 
            slot2.Image = Properties.Resources.Banana;
            slot2.Location = new Point(766, 55);
            slot2.Name = "slot2";
            slot2.Size = new Size(316, 316);
            slot2.SizeMode = PictureBoxSizeMode.Zoom;
            slot2.TabIndex = 1;
            slot2.TabStop = false;
            // 
            // slot3
            // 
            slot3.Image = Properties.Resources.Cherries;
            slot3.Location = new Point(1241, 55);
            slot3.Name = "slot3";
            slot3.Size = new Size(316, 316);
            slot3.SizeMode = PictureBoxSizeMode.Zoom;
            slot3.TabIndex = 2;
            slot3.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1317, 706);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(151, 64);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // spinButton
            // 
            spinButton.Location = new Point(799, 684);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(224, 86);
            spinButton.TabIndex = 4;
            spinButton.Text = "SPIN!";
            spinButton.UseVisualStyleBackColor = true;
            spinButton.Click += spinButton_Click;
            // 
            // enterAmountLabel
            // 
            enterAmountLabel.AutoSize = true;
            enterAmountLabel.Location = new Point(607, 540);
            enterAmountLabel.Name = "enterAmountLabel";
            enterAmountLabel.Size = new Size(141, 25);
            enterAmountLabel.TabIndex = 5;
            enterAmountLabel.Text = "Enter Amount: $";
            // 
            // enterAmountBox
            // 
            enterAmountBox.Location = new Point(799, 540);
            enterAmountBox.Name = "enterAmountBox";
            enterAmountBox.Size = new Size(243, 31);
            enterAmountBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 860);
            Controls.Add(enterAmountBox);
            Controls.Add(enterAmountLabel);
            Controls.Add(spinButton);
            Controls.Add(exitButton);
            Controls.Add(slot3);
            Controls.Add(slot2);
            Controls.Add(slot1);
            Name = "Form1";
            Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private Button exitButton;
        private Button spinButton;
        private Label enterAmountLabel;
        private TextBox enterAmountBox;
    }
}
