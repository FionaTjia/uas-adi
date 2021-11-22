
namespace TA_KelompokFiona.Admin
{
    partial class AdminQuestions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topikCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.questionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_KelompokFionaDataSetQuestion = new TA_KelompokFiona.TA_KelompokFionaDataSetQuestion();
            this.tA_KelompokFionaDataSet = new TA_KelompokFiona.TA_KelompokFionaDataSet();
            this.tAKelompokFionaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new TA_KelompokFiona.TA_KelompokFionaDataSetQuestionTableAdapters.questionsTableAdapter();
            this.topikCountLabel = new System.Windows.Forms.Label();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.richTextBoxQ = new System.Windows.Forms.RichTextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.editLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tA_KelompokFionaDataSetQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tA_KelompokFionaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKelompokFionaDataSetBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topikCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(181, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // topikCol
            // 
            this.topikCol.HeaderText = "Topik";
            this.topikCol.MinimumWidth = 6;
            this.topikCol.Name = "topikCol";
            this.topikCol.ReadOnly = true;
            this.topikCol.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionidDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.topikDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.questionsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(199, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(588, 210);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // questionidDataGridViewTextBoxColumn
            // 
            this.questionidDataGridViewTextBoxColumn.DataPropertyName = "questionid";
            this.questionidDataGridViewTextBoxColumn.HeaderText = "questionid";
            this.questionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionidDataGridViewTextBoxColumn.Name = "questionidDataGridViewTextBoxColumn";
            this.questionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionidDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "a";
            this.aDataGridViewTextBoxColumn.HeaderText = "a";
            this.aDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDataGridViewTextBoxColumn.Width = 125;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "b";
            this.bDataGridViewTextBoxColumn.HeaderText = "b";
            this.bDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDataGridViewTextBoxColumn.Width = 125;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "c";
            this.cDataGridViewTextBoxColumn.HeaderText = "c";
            this.cDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 125;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerDataGridViewTextBoxColumn.Width = 125;
            // 
            // topikDataGridViewTextBoxColumn
            // 
            this.topikDataGridViewTextBoxColumn.DataPropertyName = "topik";
            this.topikDataGridViewTextBoxColumn.HeaderText = "topik";
            this.topikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topikDataGridViewTextBoxColumn.Name = "topikDataGridViewTextBoxColumn";
            this.topikDataGridViewTextBoxColumn.ReadOnly = true;
            this.topikDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "questions";
            this.questionsBindingSource.DataSource = this.tA_KelompokFionaDataSetQuestion;
            // 
            // tA_KelompokFionaDataSetQuestion
            // 
            this.tA_KelompokFionaDataSetQuestion.DataSetName = "TA_KelompokFionaDataSetQuestion";
            this.tA_KelompokFionaDataSetQuestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tA_KelompokFionaDataSet
            // 
            this.tA_KelompokFionaDataSet.DataSetName = "TA_KelompokFionaDataSet";
            this.tA_KelompokFionaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAKelompokFionaDataSetBindingSource
            // 
            this.tAKelompokFionaDataSetBindingSource.DataSource = this.tA_KelompokFionaDataSet;
            this.tAKelompokFionaDataSetBindingSource.Position = 0;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // topikCountLabel
            // 
            this.topikCountLabel.AutoSize = true;
            this.topikCountLabel.Location = new System.Drawing.Point(12, 177);
            this.topikCountLabel.Name = "topikCountLabel";
            this.topikCountLabel.Size = new System.Drawing.Size(46, 17);
            this.topikCountLabel.TabIndex = 2;
            this.topikCountLabel.Text = "label1";
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.AutoSize = true;
            this.questionCountLabel.Location = new System.Drawing.Point(12, 222);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(46, 17);
            this.questionCountLabel.TabIndex = 3;
            this.questionCountLabel.Text = "label1";
            // 
            // richTextBoxQ
            // 
            this.richTextBoxQ.Location = new System.Drawing.Point(16, 298);
            this.richTextBoxQ.Name = "richTextBoxQ";
            this.richTextBoxQ.Size = new System.Drawing.Size(196, 106);
            this.richTextBoxQ.TabIndex = 4;
            this.richTextBoxQ.Text = "";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(302, 298);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(206, 22);
            this.textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(302, 326);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(206, 22);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(302, 354);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(206, 22);
            this.textBoxC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "jawaban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Topik";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(649, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(199, 239);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(46, 17);
            this.editLabel.TabIndex = 17;
            this.editLabel.Text = "label7";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.comboBox1.Location = new System.Drawing.Point(303, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 52);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "python",
            "pengetahuan umum"});
            this.comboBox2.Location = new System.Drawing.Point(539, 318);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // AdminQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.richTextBoxQ);
            this.Controls.Add(this.questionCountLabel);
            this.Controls.Add(this.topikCountLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminQuestions";
            this.Text = "AdminQuestions";
            this.Load += new System.EventHandler(this.AdminQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tA_KelompokFionaDataSetQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tA_KelompokFionaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKelompokFionaDataSetBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn topikCol;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tAKelompokFionaDataSetBindingSource;
        private TA_KelompokFionaDataSet tA_KelompokFionaDataSet;
        private TA_KelompokFionaDataSetQuestion tA_KelompokFionaDataSetQuestion;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private TA_KelompokFionaDataSetQuestionTableAdapters.questionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label topikCountLabel;
        private System.Windows.Forms.Label questionCountLabel;
        private System.Windows.Forms.RichTextBox richTextBoxQ;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}