namespace MyQuizMaker
{
    partial class GetTests
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.final = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.q_text = new System.Windows.Forms.Label();
            this.AnswerA = new MyQuizMaker.Style.ShapedButton();
            this.AnswerB = new MyQuizMaker.Style.ShapedButton();
            this.AnswerD = new MyQuizMaker.Style.ShapedButton();
            this.AnswerC = new MyQuizMaker.Style.ShapedButton();
            this.restart = new MyQuizMaker.Style.ShapedButton();
            this.TopPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.scoreLbl);
            this.TopPanel.Controls.Add(this.DashboardLabel);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 60);
            this.TopPanel.TabIndex = 7;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.scoreLbl.ForeColor = System.Drawing.Color.Black;
            this.scoreLbl.Location = new System.Drawing.Point(440, 20);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(69, 20);
            this.scoreLbl.TabIndex = 17;
            this.scoreLbl.Text = "Correct: ";
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DashboardLabel.Location = new System.Drawing.Point(60, 13);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(160, 29);
            this.DashboardLabel.TabIndex = 3;
            this.DashboardLabel.Text = "MyQuizMaker";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MyQuizMaker.Properties.Resources.small_logo;
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 2;
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.BackColor = System.Drawing.Color.Transparent;
            this.final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.final.ForeColor = System.Drawing.Color.White;
            this.final.Location = new System.Drawing.Point(46, 24);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(51, 24);
            this.final.TabIndex = 0;
            this.final.Text = "Final";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel5.Controls.Add(this.q_text);
            this.panel5.Controls.Add(this.final);
            this.panel5.Location = new System.Drawing.Point(65, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(699, 77);
            this.panel5.TabIndex = 11;
            // 
            // q_text
            // 
            this.q_text.AutoSize = true;
            this.q_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_text.ForeColor = System.Drawing.Color.White;
            this.q_text.Location = new System.Drawing.Point(46, 24);
            this.q_text.Name = "q_text";
            this.q_text.Size = new System.Drawing.Size(225, 24);
            this.q_text.TabIndex = 0;
            this.q_text.Text = "Question Text Goes Here";
            this.q_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerA
            // 
            this.AnswerA.BackColor = System.Drawing.Color.Transparent;
            this.AnswerA.BorderColor = System.Drawing.Color.Transparent;
            this.AnswerA.BorderWidth = 2;
            this.AnswerA.ButtonShape = MyQuizMaker.Style.ShapedButton.ButtonsShapes.RoundRect;
            this.AnswerA.ButtonText = "AnswerA";
            this.AnswerA.EndColor = System.Drawing.Color.MidnightBlue;
            this.AnswerA.FlatAppearance.BorderSize = 0;
            this.AnswerA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerA.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerA.ForeColor = System.Drawing.Color.GhostWhite;
            this.AnswerA.GradientAngle = 90;
            this.AnswerA.Location = new System.Drawing.Point(65, 190);
            this.AnswerA.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.AnswerA.MouseClickColor2 = System.Drawing.Color.Red;
            this.AnswerA.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.AnswerA.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.ShowButtontext = true;
            this.AnswerA.Size = new System.Drawing.Size(320, 67);
            this.AnswerA.StartColor = System.Drawing.Color.DodgerBlue;
            this.AnswerA.TabIndex = 12;
            this.AnswerA.Text = "AnswerA";
            this.AnswerA.TextLocation_X = 105;
            this.AnswerA.TextLocation_Y = 20;
            this.AnswerA.Transparent1 = 250;
            this.AnswerA.Transparent2 = 250;
            this.AnswerA.UseVisualStyleBackColor = false;
            this.AnswerA.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.BackColor = System.Drawing.Color.Transparent;
            this.AnswerB.BorderColor = System.Drawing.Color.Transparent;
            this.AnswerB.BorderWidth = 2;
            this.AnswerB.ButtonShape = MyQuizMaker.Style.ShapedButton.ButtonsShapes.RoundRect;
            this.AnswerB.ButtonText = "AnswerB";
            this.AnswerB.EndColor = System.Drawing.Color.MidnightBlue;
            this.AnswerB.FlatAppearance.BorderSize = 0;
            this.AnswerB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerB.ForeColor = System.Drawing.Color.GhostWhite;
            this.AnswerB.GradientAngle = 90;
            this.AnswerB.Location = new System.Drawing.Point(444, 190);
            this.AnswerB.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.AnswerB.MouseClickColor2 = System.Drawing.Color.Red;
            this.AnswerB.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.AnswerB.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.ShowButtontext = true;
            this.AnswerB.Size = new System.Drawing.Size(320, 67);
            this.AnswerB.StartColor = System.Drawing.Color.DodgerBlue;
            this.AnswerB.TabIndex = 13;
            this.AnswerB.Text = "AnswerB";
            this.AnswerB.TextLocation_X = 105;
            this.AnswerB.TextLocation_Y = 20;
            this.AnswerB.Transparent1 = 250;
            this.AnswerB.Transparent2 = 250;
            this.AnswerB.UseVisualStyleBackColor = false;
            this.AnswerB.Click += new System.EventHandler(this.AnswerB_Click);
            // 
            // AnswerD
            // 
            this.AnswerD.BackColor = System.Drawing.Color.Transparent;
            this.AnswerD.BorderColor = System.Drawing.Color.Transparent;
            this.AnswerD.BorderWidth = 2;
            this.AnswerD.ButtonShape = MyQuizMaker.Style.ShapedButton.ButtonsShapes.RoundRect;
            this.AnswerD.ButtonText = "AnswerD";
            this.AnswerD.EndColor = System.Drawing.Color.MidnightBlue;
            this.AnswerD.FlatAppearance.BorderSize = 0;
            this.AnswerD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerD.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerD.ForeColor = System.Drawing.Color.GhostWhite;
            this.AnswerD.GradientAngle = 90;
            this.AnswerD.Location = new System.Drawing.Point(444, 291);
            this.AnswerD.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.AnswerD.MouseClickColor2 = System.Drawing.Color.Red;
            this.AnswerD.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.AnswerD.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.ShowButtontext = true;
            this.AnswerD.Size = new System.Drawing.Size(320, 67);
            this.AnswerD.StartColor = System.Drawing.Color.DodgerBlue;
            this.AnswerD.TabIndex = 15;
            this.AnswerD.Text = "AnswerD";
            this.AnswerD.TextLocation_X = 105;
            this.AnswerD.TextLocation_Y = 20;
            this.AnswerD.Transparent1 = 250;
            this.AnswerD.Transparent2 = 250;
            this.AnswerD.UseVisualStyleBackColor = false;
            this.AnswerD.Click += new System.EventHandler(this.AnswerD_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.BackColor = System.Drawing.Color.Transparent;
            this.AnswerC.BorderColor = System.Drawing.Color.Transparent;
            this.AnswerC.BorderWidth = 2;
            this.AnswerC.ButtonShape = MyQuizMaker.Style.ShapedButton.ButtonsShapes.RoundRect;
            this.AnswerC.ButtonText = "AnswerC";
            this.AnswerC.EndColor = System.Drawing.Color.MidnightBlue;
            this.AnswerC.FlatAppearance.BorderSize = 0;
            this.AnswerC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerC.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerC.ForeColor = System.Drawing.Color.GhostWhite;
            this.AnswerC.GradientAngle = 90;
            this.AnswerC.Location = new System.Drawing.Point(65, 291);
            this.AnswerC.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.AnswerC.MouseClickColor2 = System.Drawing.Color.Red;
            this.AnswerC.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.AnswerC.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.ShowButtontext = true;
            this.AnswerC.Size = new System.Drawing.Size(320, 67);
            this.AnswerC.StartColor = System.Drawing.Color.DodgerBlue;
            this.AnswerC.TabIndex = 14;
            this.AnswerC.Text = "AnswerC";
            this.AnswerC.TextLocation_X = 105;
            this.AnswerC.TextLocation_Y = 20;
            this.AnswerC.Transparent1 = 250;
            this.AnswerC.Transparent2 = 250;
            this.AnswerC.UseVisualStyleBackColor = false;
            this.AnswerC.Click += new System.EventHandler(this.AnswerC_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.BorderColor = System.Drawing.Color.Transparent;
            this.restart.BorderWidth = 2;
            this.restart.ButtonShape = MyQuizMaker.Style.ShapedButton.ButtonsShapes.RoundRect;
            this.restart.ButtonText = "Restar Test";
            this.restart.EndColor = System.Drawing.Color.MidnightBlue;
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.ForeColor = System.Drawing.Color.GhostWhite;
            this.restart.GradientAngle = 90;
            this.restart.Location = new System.Drawing.Point(233, 364);
            this.restart.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.restart.MouseClickColor2 = System.Drawing.Color.Red;
            this.restart.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.restart.MouseHoverColor2 = System.Drawing.Color.DarkRed;
            this.restart.Name = "restart";
            this.restart.ShowButtontext = true;
            this.restart.Size = new System.Drawing.Size(320, 67);
            this.restart.StartColor = System.Drawing.Color.Firebrick;
            this.restart.TabIndex = 16;
            this.restart.Text = "restart";
            this.restart.TextLocation_X = 105;
            this.restart.TextLocation_Y = 20;
            this.restart.Transparent1 = 250;
            this.restart.Transparent2 = 250;
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // GetTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.AnswerA);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetTests";
            this.Text = "GetTests";
            this.Load += new System.EventHandler(this.GetTests_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.Label DashboardLabel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label q_text;
        public Style.ShapedButton AnswerA;
        public Style.ShapedButton AnswerB;
        public Style.ShapedButton AnswerD;
        public Style.ShapedButton AnswerC;
        public System.Windows.Forms.Label final;
        public Style.ShapedButton restart;
        public System.Windows.Forms.Label scoreLbl;
    }
}