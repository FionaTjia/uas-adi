
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
            this.noLabel = new System.Windows.Forms.Label();
            this.qT = new System.Windows.Forms.RichTextBox();
            this.radioP = new System.Windows.Forms.Panel();
            this.rA = new System.Windows.Forms.RadioButton();
            this.rB = new System.Windows.Forms.RadioButton();
            this.rC = new System.Windows.Forms.RadioButton();
            this.nB = new System.Windows.Forms.Button();
            this.pB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.radioP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioP);
            this.panel1.Controls.Add(this.qT);
            this.panel1.Controls.Add(this.noLabel);
            this.panel1.Location = new System.Drawing.Point(24, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 284);
            this.panel1.TabIndex = 0;
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.Location = new System.Drawing.Point(15, 13);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(28, 17);
            this.noLabel.TabIndex = 0;
            this.noLabel.Text = "10.";
            // 
            // qT
            // 
            this.qT.Enabled = false;
            this.qT.Location = new System.Drawing.Point(50, 13);
            this.qT.Name = "qT";
            this.qT.ReadOnly = true;
            this.qT.Size = new System.Drawing.Size(307, 55);
            this.qT.TabIndex = 1;
            this.qT.Text = "";
            // 
            // radioP
            // 
            this.radioP.Controls.Add(this.rC);
            this.radioP.Controls.Add(this.rB);
            this.radioP.Controls.Add(this.rA);
            this.radioP.Location = new System.Drawing.Point(50, 75);
            this.radioP.Name = "radioP";
            this.radioP.Size = new System.Drawing.Size(443, 206);
            this.radioP.TabIndex = 2;
            // 
            // rA
            // 
            this.rA.AutoSize = true;
            this.rA.Location = new System.Drawing.Point(4, 16);
            this.rA.Name = "rA";
            this.rA.Size = new System.Drawing.Size(110, 21);
            this.rA.TabIndex = 0;
            this.rA.TabStop = true;
            this.rA.Text = "radioButton1";
            this.rA.UseVisualStyleBackColor = true;
            // 
            // rB
            // 
            this.rB.AutoSize = true;
            this.rB.Location = new System.Drawing.Point(4, 68);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(110, 21);
            this.rB.TabIndex = 1;
            this.rB.TabStop = true;
            this.rB.Text = "radioButton1";
            this.rB.UseVisualStyleBackColor = true;
            // 
            // rC
            // 
            this.rC.AutoSize = true;
            this.rC.Location = new System.Drawing.Point(4, 119);
            this.rC.Name = "rC";
            this.rC.Size = new System.Drawing.Size(110, 21);
            this.rC.TabIndex = 2;
            this.rC.TabStop = true;
            this.rC.Text = "radioButton1";
            this.rC.UseVisualStyleBackColor = true;
            // 
            // nB
            // 
            this.nB.Location = new System.Drawing.Point(292, 344);
            this.nB.Name = "nB";
            this.nB.Size = new System.Drawing.Size(75, 23);
            this.nB.TabIndex = 1;
            this.nB.Text = "next";
            this.nB.UseVisualStyleBackColor = true;
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(139, 344);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(75, 23);
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
            this.label1.Location = new System.Drawing.Point(552, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(555, 56);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(44, 17);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "00:00";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.nB);
            this.Controls.Add(this.panel1);
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
    }
}