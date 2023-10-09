namespace Game
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            txtText = new Label();
            progressChecker = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(145, 135);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(495, 96);
            btnStart.TabIndex = 0;
            btnStart.Text = " 시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += start;
            // 
            // txtText
            // 
            txtText.AutoSize = true;
            txtText.Location = new Point(145, 61);
            txtText.Name = "txtText";
            txtText.Size = new Size(243, 32);
            txtText.TabIndex = 1;
            txtText.Text = "텍스트가 표시됩니다.";
            // 
            // progressChecker
            // 
            progressChecker.Enabled = true;
            progressChecker.Tick += progressChecker_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 529);
            Controls.Add(txtText);
            Controls.Add(btnStart);
            Name = "Main";
            Text = "게임";
            TopMost = true;
            Click += progress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label txtText;
        private System.Windows.Forms.Timer progressChecker;
    }
}