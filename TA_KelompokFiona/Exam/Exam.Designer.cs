
namespace TA_KelompokFiona.Exam
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioP = new System.Windows.Forms.Panel();
            this.rC = new System.Windows.Forms.RadioButton();
            this.rB = new System.Windows.Forms.RadioButton();
            this.rA = new System.Windows.Forms.RadioButton();
            this.qT = new System.Windows.Forms.RichTextBox();
            this.noLabel = new System.Windows.Forms.Label();
            this.nB = new System.Windows.Forms.Button();
            this.pB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.radioP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioP);
            this.panel1.Controls.Add(this.qT);
            this.panel1.Controls.Add(this.noLabel);
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 231);
            this.panel1.TabIndex = 0;
            // 
            // radioP
            // 
            this.radioP.Controls.Add(this.rC);
            this.radioP.Controls.Add(this.rB);
            this.radioP.Controls.Add(this.rA);
            this.radioP.Location = new System.Drawing.Point(38, 61);
            this.radioP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioP.Name = "radioP";
            this.radioP.Size = new System.Drawing.Size(332, 167);
            this.radioP.TabIndex = 2;
            // 
            // rC
            // 
            this.rC.AutoSize = true;
            this.rC.Location = new System.Drawing.Point(3, 97);
            this.rC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rC.Name = "rC";
            this.rC.Size = new System.Drawing.Size(85, 17);
            this.rC.TabIndex = 2;
            this.rC.TabStop = true;
            this.rC.Text = "radioButton1";
            this.rC.UseVisualStyleBackColor = true;
            this.rC.CheckedChanged += new System.EventHandler(this.rC_CheckedChanged);
            // 
            // rB
            // 
            this.rB.AutoSize = true;
            this.rB.Location = new System.Drawing.Point(3, 55);
            this.rB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(85, 17);
            this.rB.TabIndex = 1;
            this.rB.TabStop = true;
            this.rB.Text = "radioButton1";
            this.rB.UseVisualStyleBackColor = true;
            this.rB.CheckedChanged += new System.EventHandler(this.rB_CheckedChanged);
            // 
            // rA
            // 
            this.rA.AutoSize = true;
            this.rA.Location = new System.Drawing.Point(3, 13);
            this.rA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rA.Name = "rA";
            this.rA.Size = new System.Drawing.Size(85, 17);
            this.rA.TabIndex = 0;
            this.rA.TabStop = true;
            this.rA.Text = "radioButton1";
            this.rA.UseVisualStyleBackColor = true;
            this.rA.CheckedChanged += new System.EventHandler(this.rA_CheckedChanged);
            // 
            // qT
            // 
            this.qT.Enabled = false;
            this.qT.Location = new System.Drawing.Point(38, 11);
            this.qT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qT.Name = "qT";
            this.qT.ReadOnly = true;
            this.qT.Size = new System.Drawing.Size(231, 45);
            this.qT.TabIndex = 1;
            this.qT.Text = "";
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.Location = new System.Drawing.Point(11, 11);
            this.noLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(22, 13);
            this.noLabel.TabIndex = 0;
            this.noLabel.Text = "10.";
            // 
            // nB
            // 
            this.nB.Location = new System.Drawing.Point(219, 280);
            this.nB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nB.Name = "nB";
            this.nB.Size = new System.Drawing.Size(56, 19);
            this.nB.TabIndex = 1;
            this.nB.Text = "next";
            this.nB.UseVisualStyleBackColor = true;
            this.nB.Click += new System.EventHandler(this.nB_Click);
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(104, 280);
            this.pB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(56, 19);
            this.pB.TabIndex = 2;
            this.pB.Text = "previous";
            this.pB.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(416, 46);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(34, 13);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "00:00";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(417, 203);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.nB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Exam";
            this.Text = "Exam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.radioP.ResumeLayout(false);
            this.radioP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox qT;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.Panel radioP;
        private System.Windows.Forms.RadioButton rC;
        private System.Windows.Forms.RadioButton rB;
        private System.Windows.Forms.RadioButton rA;
        private System.Windows.Forms.Button nB;
        private System.Windows.Forms.Button pB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button submitBtn;
    }
}