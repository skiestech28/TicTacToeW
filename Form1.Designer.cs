namespace TicTacToeGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label labelStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button00 = new Button();
            button01 = new Button();
            button02 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            labelStatus = new Label();
            resetButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button00
            // 
            button00.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button00.Location = new Point(44, 118);
            button00.Name = "button00";
            button00.Size = new Size(86, 70);
            button00.TabIndex = 9;
            button00.UseVisualStyleBackColor = true;
            button00.Click += button_Click;
            // 
            // button01
            // 
            button01.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button01.Location = new Point(136, 118);
            button01.Name = "button01";
            button01.Size = new Size(86, 70);
            button01.TabIndex = 8;
            button01.UseVisualStyleBackColor = true;
            button01.Click += button_Click;
            // 
            // button02
            // 
            button02.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button02.Location = new Point(228, 118);
            button02.Name = "button02";
            button02.Size = new Size(86, 70);
            button02.TabIndex = 7;
            button02.UseVisualStyleBackColor = true;
            button02.Click += button_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(44, 194);
            button10.Name = "button10";
            button10.Size = new Size(86, 70);
            button10.TabIndex = 6;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(136, 194);
            button11.Name = "button11";
            button11.Size = new Size(86, 70);
            button11.TabIndex = 5;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(228, 194);
            button12.Name = "button12";
            button12.Size = new Size(86, 70);
            button12.TabIndex = 4;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.Location = new Point(44, 270);
            button20.Name = "button20";
            button20.Size = new Size(86, 70);
            button20.TabIndex = 3;
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button21.Location = new Point(136, 270);
            button21.Name = "button21";
            button21.Size = new Size(86, 70);
            button21.TabIndex = 2;
            button21.UseVisualStyleBackColor = true;
            button21.Click += button_Click;
            // 
            // button22
            // 
            button22.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button22.Location = new Point(228, 270);
            button22.Name = "button22";
            button22.Size = new Size(86, 70);
            button22.TabIndex = 1;
            button22.UseVisualStyleBackColor = true;
            button22.Click += button_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = SystemColors.ButtonFace;
            labelStatus.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.ForeColor = SystemColors.ActiveCaptionText;
            labelStatus.Location = new Point(232, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(121, 20);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Player X's turn";
            labelStatus.Click += labelStatus_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Lime;
            resetButton.Font = new Font("Ink Free", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(136, 357);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(86, 32);
            resetButton.TabIndex = 10;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(88, 58);
            label1.Name = "label1";
            label1.Size = new Size(192, 39);
            label1.TabIndex = 11;
            label1.Text = "Tic Tac Toe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(365, 414);
            Controls.Add(label1);
            Controls.Add(resetButton);
            Controls.Add(labelStatus);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button02);
            Controls.Add(button01);
            Controls.Add(button00);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button resetButton;
        private Label label1;
    }
}
