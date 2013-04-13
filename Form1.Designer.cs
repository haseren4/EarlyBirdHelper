namespace Early_Bird_Helper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.minuteBox = new System.Windows.Forms.ComboBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.cycleList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourBox
            // 
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Location = new System.Drawing.Point(13, 13);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(95, 21);
            this.hourBox.TabIndex = 0;
            this.hourBox.Text = "---select hour---";
            // 
            // minuteBox
            // 
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Location = new System.Drawing.Point(114, 12);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(107, 21);
            this.minuteBox.TabIndex = 1;
            this.minuteBox.Text = "---select minute---";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(227, 12);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 34);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate Bedtimes";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // cycleList
            // 
            this.cycleList.Location = new System.Drawing.Point(13, 52);
            this.cycleList.Name = "cycleList";
            this.cycleList.Size = new System.Drawing.Size(249, 44);
            this.cycleList.TabIndex = 3;
            this.cycleList.TileSize = new System.Drawing.Size(50, 50);
            this.cycleList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Motorwerk", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 7);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copywrite 2013 Haseren Lanesher Studios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cycleList);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Early Bird Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox minuteBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.ListView cycleList;
        private System.Windows.Forms.Label label1;
    }
}

