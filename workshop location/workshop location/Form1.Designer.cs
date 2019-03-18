namespace workshop_location
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.classBox1 = new System.Windows.Forms.ListBox();
            this.locationBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workshop/ No of Days /Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location/ Fee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // classBox1
            // 
            this.classBox1.FormattingEnabled = true;
            this.classBox1.ItemHeight = 20;
            this.classBox1.Items.AddRange(new object[] {
            "Intro to C#\t                  5\t         $1,000",
            "Graphic Design Composition\t7\t         $800",
            "Social Media Marketing\t3\t         $1,500",
            "Database Management            5\t         $1,300",
            "How to Manage Teams\t1\t         $500"});
            this.classBox1.Location = new System.Drawing.Point(40, 73);
            this.classBox1.Name = "classBox1";
            this.classBox1.Size = new System.Drawing.Size(423, 104);
            this.classBox1.TabIndex = 5;
            // 
            // locationBox2
            // 
            this.locationBox2.FormattingEnabled = true;
            this.locationBox2.ItemHeight = 20;
            this.locationBox2.Items.AddRange(new object[] {
            "Sweden\t$550",
            "Norway\t$425",
            "Iceland\t$775",
            "Ireland\t$500",
            "England\t$175",
            "Greenland\t$350"});
            this.locationBox2.Location = new System.Drawing.Point(495, 73);
            this.locationBox2.Name = "locationBox2";
            this.locationBox2.Size = new System.Drawing.Size(149, 84);
            this.locationBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locationBox2);
            this.Controls.Add(this.classBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox classBox1;
        private System.Windows.Forms.ListBox locationBox2;
        private System.Windows.Forms.Label label3;
    }
}

