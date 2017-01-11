namespace BankingSystemSimulation
{
    partial class BankingSystemSimulation
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
            this.label_SFS = new System.Windows.Forms.Label();
            this.label_SSS = new System.Windows.Forms.Label();
            this.textBox_MST3 = new System.Windows.Forms.TextBox();
            this.label_MST3 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.textBox_NOC = new System.Windows.Forms.TextBox();
            this.label_NOC = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_STS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_MST1 = new System.Windows.Forms.TextBox();
            this.label_MST1 = new System.Windows.Forms.Label();
            this.label_MIT = new System.Windows.Forms.Label();
            this.textBox_MIT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_MST2 = new System.Windows.Forms.TextBox();
            this.label_MST2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SFS
            // 
            this.label_SFS.AutoSize = true;
            this.label_SFS.Location = new System.Drawing.Point(7, 16);
            this.label_SFS.Name = "label_SFS";
            this.label_SFS.Size = new System.Drawing.Size(0, 13);
            this.label_SFS.TabIndex = 1;
            // 
            // label_SSS
            // 
            this.label_SSS.AutoSize = true;
            this.label_SSS.Location = new System.Drawing.Point(7, 16);
            this.label_SSS.Name = "label_SSS";
            this.label_SSS.Size = new System.Drawing.Size(0, 13);
            this.label_SSS.TabIndex = 0;
            // 
            // textBox_MST3
            // 
            this.textBox_MST3.Location = new System.Drawing.Point(274, 130);
            this.textBox_MST3.Name = "textBox_MST3";
            this.textBox_MST3.Size = new System.Drawing.Size(236, 20);
            this.textBox_MST3.TabIndex = 4;
            // 
            // label_MST3
            // 
            this.label_MST3.Location = new System.Drawing.Point(110, 130);
            this.label_MST3.Name = "label_MST3";
            this.label_MST3.Size = new System.Drawing.Size(158, 25);
            this.label_MST3.TabIndex = 32;
            this.label_MST3.Text = "Mean Service Time (Server 3) :";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(423, 194);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(87, 27);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(316, 194);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(87, 27);
            this.button_Evaluate.TabIndex = 6;
            this.button_Evaluate.Text = "Evaluate";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // textBox_NOC
            // 
            this.textBox_NOC.Location = new System.Drawing.Point(274, 168);
            this.textBox_NOC.Name = "textBox_NOC";
            this.textBox_NOC.Size = new System.Drawing.Size(236, 20);
            this.textBox_NOC.TabIndex = 5;
            // 
            // label_NOC
            // 
            this.label_NOC.Location = new System.Drawing.Point(110, 168);
            this.label_NOC.Name = "label_NOC";
            this.label_NOC.Size = new System.Drawing.Size(158, 25);
            this.label_NOC.TabIndex = 28;
            this.label_NOC.Text = "Number Of Customers :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_SSS);
            this.groupBox3.Location = new System.Drawing.Point(306, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 172);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report Second Server";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(15, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 348);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label_STS);
            this.groupBox6.Location = new System.Drawing.Point(6, 199);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(294, 143);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Report Third Server";
            // 
            // label_STS
            // 
            this.label_STS.AutoSize = true;
            this.label_STS.Location = new System.Drawing.Point(7, 16);
            this.label_STS.Name = "label_STS";
            this.label_STS.Size = new System.Drawing.Size(0, 13);
            this.label_STS.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_SFS);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 172);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report First Server";
            // 
            // textBox_MST1
            // 
            this.textBox_MST1.Location = new System.Drawing.Point(274, 55);
            this.textBox_MST1.Name = "textBox_MST1";
            this.textBox_MST1.Size = new System.Drawing.Size(236, 20);
            this.textBox_MST1.TabIndex = 2;
            // 
            // label_MST1
            // 
            this.label_MST1.Location = new System.Drawing.Point(110, 55);
            this.label_MST1.Name = "label_MST1";
            this.label_MST1.Size = new System.Drawing.Size(158, 25);
            this.label_MST1.TabIndex = 26;
            this.label_MST1.Text = "Mean Service Time (Server 1) :";
            // 
            // label_MIT
            // 
            this.label_MIT.Location = new System.Drawing.Point(110, 16);
            this.label_MIT.Name = "label_MIT";
            this.label_MIT.Size = new System.Drawing.Size(158, 25);
            this.label_MIT.TabIndex = 24;
            this.label_MIT.Text = "Mean Interarrival Time :";
            // 
            // textBox_MIT
            // 
            this.textBox_MIT.Location = new System.Drawing.Point(274, 16);
            this.textBox_MIT.Name = "textBox_MIT";
            this.textBox_MIT.Size = new System.Drawing.Size(236, 20);
            this.textBox_MIT.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_MST2);
            this.groupBox1.Controls.Add(this.label_MST2);
            this.groupBox1.Controls.Add(this.textBox_MST3);
            this.groupBox1.Controls.Add(this.label_MST3);
            this.groupBox1.Controls.Add(this.button_Clear);
            this.groupBox1.Controls.Add(this.button_Evaluate);
            this.groupBox1.Controls.Add(this.textBox_NOC);
            this.groupBox1.Controls.Add(this.label_NOC);
            this.groupBox1.Controls.Add(this.textBox_MST1);
            this.groupBox1.Controls.Add(this.label_MST1);
            this.groupBox1.Controls.Add(this.textBox_MIT);
            this.groupBox1.Controls.Add(this.label_MIT);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 232);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // textBox_MST2
            // 
            this.textBox_MST2.Location = new System.Drawing.Point(274, 92);
            this.textBox_MST2.Name = "textBox_MST2";
            this.textBox_MST2.Size = new System.Drawing.Size(236, 20);
            this.textBox_MST2.TabIndex = 3;
            // 
            // label_MST2
            // 
            this.label_MST2.Location = new System.Drawing.Point(110, 92);
            this.label_MST2.Name = "label_MST2";
            this.label_MST2.Size = new System.Drawing.Size(158, 25);
            this.label_MST2.TabIndex = 35;
            this.label_MST2.Text = "Mean Service Time (Server 2) :";
            // 
            // BankingSystemSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankingSystemSimulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking System Simulation";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_SFS;
        private System.Windows.Forms.Label label_SSS;
        private System.Windows.Forms.TextBox textBox_MST3;
        private System.Windows.Forms.Label label_MST3;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.TextBox textBox_NOC;
        private System.Windows.Forms.Label label_NOC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label_STS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_MST1;
        private System.Windows.Forms.Label label_MST1;
        private System.Windows.Forms.Label label_MIT;
        private System.Windows.Forms.TextBox textBox_MIT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_MST2;
        private System.Windows.Forms.Label label_MST2;
    }
}

