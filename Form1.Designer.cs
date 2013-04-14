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
            this.wakeRadio = new System.Windows.Forms.RadioButton();
            this.sleepRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // hourBox
            // 
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Location = new System.Drawing.Point(129, 12);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(95, 21);
            this.hourBox.TabIndex = 0;
            this.hourBox.Text = "HOUR";
            // 
            // minuteBox
            // 
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Location = new System.Drawing.Point(225, 12);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(107, 21);
            this.minuteBox.TabIndex = 1;
            this.minuteBox.Text = "MINUTE";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(332, 12);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 34);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate Bedtimes";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // cycleList
            // 
            this.cycleList.Location = new System.Drawing.Point(76, 93);
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
            this.label1.Size = new System.Drawing.Size(0, 7);
            this.label1.TabIndex = 4;
            // 
            // wakeRadio
            // 
            this.wakeRadio.AutoSize = true;
            this.wakeRadio.Location = new System.Drawing.Point(4, 15);
            this.wakeRadio.Name = "wakeRadio";
            this.wakeRadio.Size = new System.Drawing.Size(129, 17);
            this.wakeRadio.TabIndex = 5;
            this.wakeRadio.TabStop = true;
            this.wakeRadio.Text = "I need to wake up at: ";
            this.wakeRadio.UseVisualStyleBackColor = true;
            // 
            // sleepRadio
            // 
            this.sleepRadio.AutoSize = true;
            this.sleepRadio.Location = new System.Drawing.Point(4, 53);
            this.sleepRadio.Name = "sleepRadio";
            this.sleepRadio.Size = new System.Drawing.Size(229, 17);
            this.sleepRadio.TabIndex = 6;
            this.sleepRadio.TabStop = true;
            this.sleepRadio.Text = "If I go to bed now, when should i wake up?";
            this.sleepRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 162);
            this.Controls.Add(this.sleepRadio);
            this.Controls.Add(this.wakeRadio);
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
        private System.Windows.Forms.RadioButton wakeRadio;
        private System.Windows.Forms.RadioButton sleepRadio;
    }
}

